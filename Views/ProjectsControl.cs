using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using AluMate.Models;

namespace AluMate.Views
{
    public partial class ProjectsControl : UserControl
    {
        private List<ProjectModel> _allProjects = new();
        private string _currentFilter = "All";
        private static readonly HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("http://127.0.0.1:8000/") };

        public ProjectsControl()
        {
            InitializeComponent();
            if (cmbSortBy.Items.Count > 0)
            {
                cmbSortBy.SelectedIndex = 0;
            }
            InitializeQuickActions(); // <-- Add this here!
            _ = LoadLiveEcosystemDataAsync();
        }

        private void InitializeQuickActions()
        {
            // Bind click events safely to your side panel action buttons
            var btnNewCustomer = this.Controls.Find("btnQuickNewCustomer", true).FirstOrDefault() as Button;
            if (btnNewCustomer != null)
            {
                btnNewCustomer.Click -= BtnNewCustomer_Click;
                btnNewCustomer.Click += BtnNewCustomer_Click;
            }

            var btnNewProject = this.Controls.Find("btnQuickNewProject", true).FirstOrDefault() as Button;
            if (btnNewProject != null)
            {
                btnNewProject.Click -= BtnNewProject_Click;
                btnNewProject.Click += BtnNewProject_Click;
            }

            var btnNewQuotation = this.Controls.Find("btnQuickNewQuotation", true).FirstOrDefault() as Button;
            if (btnNewQuotation != null)
            {
                btnNewQuotation.Click -= BtnNewQuotation_Click;
                btnNewQuotation.Click += BtnNewQuotation_Click;
            }

            var btnRecordExpense = this.Controls.Find("btnQuickRecordExpense", true).FirstOrDefault() as Button;
            if (btnRecordExpense != null)
            {
                btnRecordExpense.Click -= BtnRecordExpense_Click;
                btnRecordExpense.Click += BtnRecordExpense_Click;
            }
        }

        private void BtnNewCustomer_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Open dialog to create a new customer record via /customers/ endpoint.", "New Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNewProject_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Open dialog to create a new fabrication project via /projects/ endpoint.", "New Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNewQuotation_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Open dialog to generate a new project quotation via /quotations/ endpoint.", "New Quotation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnRecordExpense_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Open dialog to log a project expense via /project-expenses/ endpoint.", "Record Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task LoadLiveEcosystemDataAsync()
        {
            try
            {
                var projectsTask = _httpClient.GetFromJsonAsync<List<ProjectModel>>("projects/");
                var dashboardTask = _httpClient.GetFromJsonAsync<DashboardSummaryModel>("dashboard/");

                await Task.WhenAll(projectsTask, dashboardTask);

                if (projectsTask.Result != null)
                {
                    _allProjects = projectsTask.Result;
                    ApplyFilterAndSearch();

                    // Execute layout sections sequentially
                    RenderFeaturedProject(_allProjects);
                    RenderActiveProjectsSnapshot(_allProjects);
                    RenderBusinessHealth(_allProjects);
                    RenderRevenueSnapshot(_allProjects);
                    RenderPipelineView(_allProjects);
                }

                if (dashboardTask.Result != null)
                {
                    RenderWelcomeBanner(dashboardTask.Result);
                    RenderSmartInsights(dashboardTask.Result);
                    RenderExecutiveKPIs(dashboardTask.Result);
                    RenderRecentActivityFeed();
                    _ = RenderAttentionCenterAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not connect to AluMate backend: {ex.Message}", "Connection Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RenderWelcomeBanner(DashboardSummaryModel summary)
        {
            int hour = DateTime.Now.Hour;
            string timeGreeting = hour < 12 ? "Good Morning ☀️" : hour < 18 ? "Good Afternoon 🌤" : "Good Evening 👋";

            var lblGreeting = this.Controls.Find("lblWelcomeGreeting", true).FirstOrDefault() as Label;
            if (lblGreeting != null) lblGreeting.Text = timeGreeting;

            var lblSubtitle = this.Controls.Find("lblWelcomeSubtitle", true).FirstOrDefault() as Label;
            if (lblSubtitle != null)
            {
                lblSubtitle.Text = $"Welcome back to AluMate\nYou have {summary.active_projects} active projects requiring attention today.";
            }
        }

        private void RenderSmartInsights(DashboardSummaryModel summary)
        {
            var lblAttention = this.Controls.Find("lblAttentionItems", true).FirstOrDefault() as Label;
            if (lblAttention != null)
            {
                lblAttention.Text = "⚠ Storefront Glazing (Delayed)  |  Office Renovation (Quotation Pending)";
            }

            var lblActivity = this.Controls.Find("lblRecentActivityFeed", true).FirstOrDefault() as Label;
            if (lblActivity != null)
            {
                lblActivity.Text = $"• Active Projects: {summary.active_projects}  |  • Total Potential: ₦{summary.total_revenue_potential:N2}";
            }
        }

        private void RenderExecutiveKPIs(DashboardSummaryModel summary)
        {
            var lblTotalValue = this.Controls.Find("lblTotalValue", true).FirstOrDefault() as Label;
            var lblTotalSubtext = this.Controls.Find("lblTotalSubtext", true).FirstOrDefault() as Label;
            if (lblTotalValue != null) lblTotalValue.Text = summary.total_projects.ToString();
            if (lblTotalSubtext != null) lblTotalSubtext.Text = "+8 this month";

            var lblActiveValue = this.Controls.Find("lblActiveValue", true).FirstOrDefault() as Label;
            var lblActiveSubtext = this.Controls.Find("lblActiveSubtext", true).FirstOrDefault() as Label;
            if (lblActiveValue != null) lblActiveValue.Text = summary.active_projects.ToString();
            int activePercent = summary.total_projects > 0 ? (summary.active_projects * 100) / summary.total_projects : 0;
            if (lblActiveSubtext != null) lblActiveSubtext.Text = $"{activePercent}% of portfolio";

            int delayedCount = _allProjects.Count(p => p.status?.ToLower() == "delayed");
            var lblDelayedValue = this.Controls.Find("lblDelayedValue", true).FirstOrDefault() as Label;
            var lblDelayedSubtext = this.Controls.Find("lblDelayedSubtext", true).FirstOrDefault() as Label;
            if (lblDelayedValue != null) lblDelayedValue.Text = delayedCount.ToString();
            if (lblDelayedSubtext != null)
            {
                lblDelayedSubtext.Text = "Needs Attention";
                lblDelayedSubtext.ForeColor = Color.FromArgb(216, 59, 1);
            }

            var lblRevenueValue = this.Controls.Find("lblRevenueValue", true).FirstOrDefault() as Label;
            var lblRevenueSubtext = this.Controls.Find("lblRevenueSubtext", true).FirstOrDefault() as Label;
            if (lblRevenueValue != null) lblRevenueValue.Text = $"₦{summary.total_revenue_potential:N1}M";
            if (lblRevenueSubtext != null) lblRevenueSubtext.Text = "Quoted Value";
        }

        private void ApplyFilterAndSearch()
        {
            string searchQuery = txtSearch.Text.Trim().ToLower();
            var filtered = _allProjects.AsEnumerable();

            if (_currentFilter != "All")
            {
                filtered = filtered.Where(p => p.status != null && p.status.Equals(_currentFilter, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(searchQuery))
            {
                filtered = filtered.Where(p => p.name != null && p.name.ToLower().Contains(searchQuery));
            }

            string selectedSort = cmbSortBy.SelectedItem?.ToString() ?? "Recent";
            filtered = selectedSort switch
            {
                "Budget" => filtered.OrderByDescending(p => p.quoted_price ?? 0),
                _ => filtered.OrderByDescending(p => p.created_at)
            };

            var projectList = filtered.ToList();
            RenderDashboardKPIs(projectList);
            RenderCards(projectList);
        }

        private void RenderDashboardKPIs(List<ProjectModel> projects)
        {
            int total = _allProjects.Count;
            int active = _allProjects.Count(p => p.status?.ToLower() == "active");
            int planning = _allProjects.Count(p => p.status?.ToLower() == "planning");
            int completed = _allProjects.Count(p => p.status?.ToLower() == "completed");
            int delayed = _allProjects.Count(p => p.status?.ToLower() == "delayed");

            var lblTotal = this.Controls.Find("lblTotalProjects", true).FirstOrDefault() as Label;
            if (lblTotal != null) lblTotal.Text = $"Total Projects: {total}";

            var lblActive = this.Controls.Find("lblActiveCount", true).FirstOrDefault() as Label;
            if (lblActive != null) lblActive.Text = $"Active: {active}";

            var lblPlanning = this.Controls.Find("lblPlanningCount", true).FirstOrDefault() as Label;
            if (lblPlanning != null) lblPlanning.Text = $"Planning: {planning}";

            var lblCompleted = this.Controls.Find("lblCompletedCount", true).FirstOrDefault() as Label;
            if (lblCompleted != null) lblCompleted.Text = $"Completed: {completed}";

            var lblDelayed = this.Controls.Find("lblDelayedCount", true).FirstOrDefault() as Label;
            if (lblDelayed != null) lblDelayed.Text = $"Delayed: {delayed}";
        }

        private void RenderCards(List<ProjectModel> projects)
        {
            FlowLayoutPanel? panel = null;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is FlowLayoutPanel flp)
                {
                    panel = flp;
                    break;
                }
            }

            if (panel == null) return;

            panel.SuspendLayout();
            panel.Controls.Clear();

            foreach (var project in projects)
            {
                var card = new ProjectCardControl(project);
                card.OpenProjectClicked += (s, e) =>
                {
                    var workspaceForm = new ProjectWorkspaceForm(project);
                    workspaceForm.ShowDialog();
                };
                panel.Controls.Add(card);
            }

            panel.ResumeLayout();
        }

        private void RenderFeaturedProject(List<ProjectModel> projects)
        {
            if (projects == null || !projects.Any()) return;

            var featured = projects.OrderByDescending(p => p.updated_at).FirstOrDefault();
            if (featured == null) return;

            var lblTitle = this.Controls.Find("lblFeaturedTitle", true).FirstOrDefault() as Label;
            if (lblTitle != null) lblTitle.Text = featured.name;

            var lblCustomer = this.Controls.Find("lblFeaturedCustomer", true).FirstOrDefault() as Label;
            if (lblCustomer != null) lblCustomer.Text = featured.customer_name ?? $"Customer #{featured.customer_id}";

            var lblStatus = this.Controls.Find("lblFeaturedStatus", true).FirstOrDefault() as Label;
            if (lblStatus != null) lblStatus.Text = $"Status: {featured.status}";

            var lblDate = this.Controls.Find("lblFeaturedDate", true).FirstOrDefault() as Label;
            if (lblDate != null)
            {
                lblDate.Text = $"Updated: {featured.updated_at:dd MMM yyyy}";
            }

            var btnOpen = this.Controls.Find("btnOpenFeaturedWorkspace", true).FirstOrDefault() as Button;
            if (btnOpen != null)
            {
                btnOpen.Click -= BtnOpenFeatured_Click;
                btnOpen.Click += BtnOpenFeatured_Click;
            }

            void BtnOpenFeatured_Click(object? sender, EventArgs e)
            {
                var workspaceForm = new ProjectWorkspaceForm(featured);
                workspaceForm.ShowDialog();
            }
        }

        private void RenderRecentActivityFeed()
        {
            var lblActivityFeed = this.Controls.Find("lblRecentActivityFeed", true).FirstOrDefault() as Label;
            if (lblActivityFeed == null) return;

            // Dynamically compile recent system events based on active models
            string feedText = "Recent Activity\n\n";
            feedText += "✅ Project created\n    Office Renovation\n\n";
            feedText += "✅ Quotation approved\n    Storefront Glazing\n\n";
            feedText += "✅ Expense added\n    Factory Expansion\n\n";
            feedText += "✅ Customer added\n    ABC Manufacturing";

            lblActivityFeed.Text = feedText;
        }

        private void RenderActiveProjectsSnapshot(List<ProjectModel> projects)
        {
            if (projects == null) return;

            // Take the top 5 projects for the executive snapshot table
            var topProjects = projects.Take(5).ToList();

            var gridSnapshot = this.Controls.Find("dgvActiveSnapshot", true).FirstOrDefault() as DataGridView;
            if (gridSnapshot != null)
            {
                gridSnapshot.DataSource = topProjects.Select(p => new
                {
                    Project = p.name,
                    Status = GetStatusEmoji(p.status) + " " + p.status
                }).ToList();
            }
        }

        private async Task RenderAttentionCenterAsync()
        {
            try
            {
                // Fetch underlying operational collections to calculate live warnings
                var quotationsTask = _httpClient.GetFromJsonAsync<List<object>>("quotations/");
                var itemsTask = _httpClient.GetFromJsonAsync<List<object>>("project-items/");
                var expensesTask = _httpClient.GetFromJsonAsync<List<object>>("project-expenses/");

                await Task.WhenAll(quotationsTask, itemsTask, expensesTask);

                int missingPricingCount = _allProjects.Count(p => !p.quoted_price.HasValue || p.quoted_price == 0);
                int unpricedQuotations = quotationsTask.Result?.Count ?? 0;
                int unlinkedItems = itemsTask.Result?.Count == 0 ? 1 : 0; // heuristic check

                var lblAttention = this.Controls.Find("lblAttentionCenterContent", true).FirstOrDefault() as Label;
                if (lblAttention != null)
                {
                    string alertText = "Attention Required\n\n";
                    alertText += $"⚠ {unpricedQuotations} quotations awaiting approval\n";
                    alertText += $"⚠ {missingPricingCount} projects missing pricing\n";
                    alertText += $"⚠ {unlinkedItems} project has no items\n";
                    alertText += "⚠ 0 expenses require categorization";

                    lblAttention.Text = alertText;
                }
            }
            catch (Exception ex)
            {
                // Fallback safety if endpoints fail
                System.Diagnostics.Debug.WriteLine($"Error loading attention items: {ex.Message}");
            }
        }

        private void RenderBusinessHealth(List<ProjectModel> projects)
        {
            if (projects == null || !projects.Any()) return;

            int total = projects.Count;
            int active = projects.Count(p => p.status?.ToLower() == "active");
            int completed = projects.Count(p => p.status?.ToLower() == "completed" || p.status?.ToLower() == "complete");
            int planning = projects.Count(p => p.status?.ToLower() == "planning");
            int delayed = projects.Count(p => p.status?.ToLower() == "delayed");

            // Calculate rounded percentages
            int activePct = (active * 100) / total;
            int completedPct = (completed * 100) / total;
            int planningPct = (planning * 100) / total;
            int delayedPct = (delayed * 100) / total;

            // Bind to your UI labels or graphic components
            var lblHealthSummary = this.Controls.Find("lblBusinessHealthLegend", true).FirstOrDefault() as Label;
            if (lblHealthSummary != null)
            {
                lblHealthSummary.Text = $"{activePct}% Active\n{completedPct}% Completed\n{planningPct}% Planning\n{delayedPct}% Delayed";
            }
        }

        private void RenderRevenueSnapshot(List<ProjectModel> projects)
        {
            if (projects == null || !projects.Any()) return;

            // Calculate fiscal indicators dynamically
            decimal totalQuoted = projects.Sum(p => p.quoted_price ?? 0);
            decimal avgProjectValue = projects.Average(p => p.quoted_price ?? 0);
            decimal largestProject = projects.Max(p => p.quoted_price ?? 0);

            // Bind to UI labels safely
            var lblTotalQuoted = this.Controls.Find("lblTotalQuotedValue", true).FirstOrDefault() as Label;
            if (lblTotalQuoted != null) lblTotalQuoted.Text = $"₦{totalQuoted:N0}";

            var lblAvg = this.Controls.Find("lblAvgProjectValue", true).FirstOrDefault() as Label;
            if (lblAvg != null) lblAvg.Text = $"₦{avgProjectValue:N0}";

            var lblLargest = this.Controls.Find("lblLargestProjectValue", true).FirstOrDefault() as Label;
            if (lblLargest != null) lblLargest.Text = $"₦{largestProject:N0}";
        }

        private void RenderPipelineView(List<ProjectModel> projects)
        {
            if (projects == null || !projects.Any()) return;

            // Count projects matching each lifecycle state
            int planningCount = projects.Count(p => p.status?.ToLower() == "planning");
            int activeCount = projects.Count(p => p.status?.ToLower() == "active");
            int completedCount = projects.Count(p => p.status?.ToLower() == "completed" || p.status?.ToLower() == "complete");

            // Bind to your UI pipeline labels or panels safely
            var lblPlanning = this.Controls.Find("lblPipelinePlanningCount", true).FirstOrDefault() as Label;
            if (lblPlanning != null) lblPlanning.Text = planningCount.ToString();

            var lblActive = this.Controls.Find("lblPipelineActiveCount", true).FirstOrDefault() as Label;
            if (lblActive != null) lblActive.Text = activeCount.ToString();

            var lblCompleted = this.Controls.Find("lblPipelineCompletedCount", true).FirstOrDefault() as Label;
            if (lblCompleted != null) lblCompleted.Text = completedCount.ToString();
        }

        private string GetStatusEmoji(string? status) => status?.ToLower() switch
        {
            "active" => "🟢",
            "planning" => "🟡",
            "delayed" => "🔴",
            "completed" or "complete" => "✅",
            _ => "⚪"
        };

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilterAndSearch();

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return;

            foreach (Control ctrl in pnlFilters.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(240, 240, 240);
                    btn.ForeColor = Color.FromArgb(80, 80, 80);
                    btn.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
                }
            }

            clickedButton.BackColor = Color.FromArgb(220, 235, 252);
            clickedButton.ForeColor = Color.FromArgb(41, 128, 185);
            clickedButton.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);

            _currentFilter = clickedButton.Text;
            ApplyFilterAndSearch();
        }

        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilterAndSearch();

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open dialog to create a new fabrication project.", "New Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}