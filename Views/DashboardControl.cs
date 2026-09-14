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
    public partial class DashboardControl : UserControl
    {
        private List<ProjectModel> _allProjects = new();
        private static readonly HttpClient _httpClient = new HttpClient { BaseAddress = new Uri("http://127.0.0.1:9434/") };

        public DashboardControl()
        {
            InitializeComponent();
            InitializeQuickActions();
            _ = LoadDashboardCommandCenterDataAsync();
        }

        private void InitializeQuickActions()
        {
            var btnRefresh = this.Controls.Find("btnRefreshDashboard", true).FirstOrDefault() as Button;
            if (btnRefresh != null)
            {
                btnRefresh.Click += async (s, e) => await LoadDashboardCommandCenterDataAsync();
            }
        }

        public async Task LoadDashboardCommandCenterDataAsync()
        {
            try
            {
                var projects = await _httpClient.GetFromJsonAsync<List<ProjectModel>>("projects/");
                if (projects != null)
                {
                    _allProjects = projects;
                    RenderCommandCenter(_allProjects);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load Executive Command Center data: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderCommandCenter(List<ProjectModel> projects)
        {
            RenderHeaderMetrics(projects);
            RenderRevenueSnapshot(projects);
            RenderFeaturedProject(projects);
            RenderActiveProjectsSnapshot(projects);
            RenderBusinessHealth(projects);
            RenderTopActiveCards(projects);
        }

        private void RenderHeaderMetrics(List<ProjectModel> projects)
        {
            var lblTotal = this.Controls.Find("lblTotalProjectsValue", true).FirstOrDefault() as Label;
            if (lblTotal != null) lblTotal.Text = projects.Count.ToString();

            var lblActive = this.Controls.Find("lblActiveProjectsValue", true).FirstOrDefault() as Label;
            if (lblActive != null) lblActive.Text = projects.Count(p => string.Equals(p?.status, "active", StringComparison.OrdinalIgnoreCase)).ToString();

            var lblCompleted = this.Controls.Find("lblCompletedProjectsValue", true).FirstOrDefault() as Label;
            if (lblCompleted != null) lblCompleted.Text = projects.Count(p => string.Equals(p?.status, "completed", StringComparison.OrdinalIgnoreCase)).ToString();
        }

        private void RenderRevenueSnapshot(List<ProjectModel> projects)
        {
            decimal totalQuoted = projects.Sum(p => p?.quoted_price ?? 0);
            var lblQuoted = this.Controls.Find("lblTotalQuotedValue", true).FirstOrDefault() as Label;
            if (lblQuoted != null)
            {
                if (totalQuoted <= 0)
                {
                    lblQuoted.Text = "?0";
                }
                else if (totalQuoted >= 1_000_000)
                {
                    lblQuoted.Text = $"?{totalQuoted / 1_000_000:N2}M";
                }
                else
                {
                    lblQuoted.Text = $"?{totalQuoted:N0}";
                }
            }
        }

        private void RenderFeaturedProject(List<ProjectModel> projects)
        {
            var validProjects = projects.Where(p => p != null).ToList();
            var featuredProj = validProjects.OrderByDescending(p => p.updated_at != default ? p.updated_at : p.created_at).FirstOrDefault();
            if (featuredProj == null) return;

            var lblTitle = this.Controls.Find("lblFeaturedTitle", true).FirstOrDefault() as Label;
            if (lblTitle != null) lblTitle.Text = featuredProj.name;

            var lblCustomer = this.Controls.Find("lblFeaturedCustomer", true).FirstOrDefault() as Label;
            if (lblCustomer != null) lblCustomer.Text = featuredProj.customer_name ?? $"Customer ID: {featuredProj.customer_id}";

            var lblStatus = this.Controls.Find("lblFeaturedStatus", true).FirstOrDefault() as Label;
            if (lblStatus != null)
            {
                string status = featuredProj.status ?? "Active";
                lblStatus.Text = status.ToUpper() switch
                {
                    "ACTIVE" => "?? ACTIVE",
                    "PLANNING" => "?? PLANNING",
                    "DELAYED" => "?? DELAYED",
                    "COMPLETED" => "?? COMPLETED",
                    _ => $"?? {status.ToUpper()}"
                };

                lblStatus.ForeColor = status.ToLower() switch
                {
                    "active" => Color.FromArgb(46, 204, 113),
                    "planning" => Color.FromArgb(241, 196, 15),
                    "delayed" => Color.FromArgb(231, 76, 60),
                    "completed" => Color.FromArgb(52, 152, 219),
                    _ => Color.FromArgb(46, 204, 113)
                };
            }

            var lblDate = this.Controls.Find("lblFeaturedDate", true).FirstOrDefault() as Label;
            if (lblDate != null)
            {
                DateTime targetDt = featuredProj.updated_at != default ? featuredProj.updated_at : (featuredProj.created_at != default ? featuredProj.created_at : DateTime.Now);
                lblDate.Text = $"Created: {targetDt:dd MMM yyyy}";
            }
        }

        private void RenderActiveProjectsSnapshot(List<ProjectModel> projects)
        {
            var gridSnapshot = this.Controls.Find("dgvActiveSnapshot", true).FirstOrDefault() as DataGridView;
            if (gridSnapshot != null)
            {
                gridSnapshot.DataSource = projects.Where(p => p != null).Take(5).Select(p => new
                {
                    ProjectName = p!.name,
                    Customer = p.customer_name ?? $"Customer #{p.customer_id}",
                    Status = p.status,
                    CreatedDate = p.created_at != default ? p.created_at.ToString("dd MMM yyyy") : "N/A"
                }).ToList();

                if (gridSnapshot.Columns["ProjectName"] != null) gridSnapshot.Columns["ProjectName"]!.HeaderText = "Project Name";
                if (gridSnapshot.Columns["Customer"] != null) gridSnapshot.Columns["Customer"]!.HeaderText = "Customer";
                if (gridSnapshot.Columns["Status"] != null) gridSnapshot.Columns["Status"]!.HeaderText = "Status";
                if (gridSnapshot.Columns["CreatedDate"] != null) gridSnapshot.Columns["CreatedDate"]!.HeaderText = "Created Date";
            }
        }

        private void RenderBusinessHealth(List<ProjectModel> projects)
        {
            if (projects == null || !projects.Any()) return;
            int total = projects.Count;
            int active = 0, completed = 0, planning = 0, delayed = 0;

            foreach (var p in projects)
            {
                if (p == null || p.status == null) continue;
                if (string.Equals(p.status, "active", StringComparison.OrdinalIgnoreCase)) active++;
                else if (string.Equals(p.status, "completed", StringComparison.OrdinalIgnoreCase)) completed++;
                else if (string.Equals(p.status, "planning", StringComparison.OrdinalIgnoreCase)) planning++;
                else if (string.Equals(p.status, "delayed", StringComparison.OrdinalIgnoreCase)) delayed++;
            }

            int activePct = total > 0 ? (active * 100) / total : 0;
            int completedPct = total > 0 ? (completed * 100) / total : 0;
            int planningPct = total > 0 ? (planning * 100) / total : 0;
            int delayedPct = total > 0 ? (delayed * 100) / total : 0;

            var lblHealth = this.Controls.Find("lblBusinessHealthLegend", true).FirstOrDefault() as Label;
            if (lblHealth != null)
            {
                lblHealth.Text = $"Project Portfolio Health\n\n" +
                                 $"?? Active: {activePct}%\n" +
                                 $"? Completed: {completedPct}%\n" +
                                 $"?? Planning: {planningPct}%\n" +
                                 $"?? Delayed: {delayedPct}%";
            }
        }

        private void RenderTopActiveCards(List<ProjectModel> projects)
        {
            var panel = this.Controls.Find("pnlTopActiveCards", true).FirstOrDefault() as Panel;
            if (panel == null) return;

            panel.Controls.Clear();
            var topProjects = projects.Where(p => p != null && string.Equals(p.status, "active", StringComparison.OrdinalIgnoreCase)).Take(3).ToList();
            
            int yOffset = 10;
            foreach (var proj in topProjects)
            {
                if (proj == null) continue;
                var card = new Panel
                {
                    Width = panel.Width - 20,
                    Height = 65,
                    Left = 10,
                    Top = yOffset,
                    BackColor = Color.FromArgb(248, 249, 250)
                };

                var lblName = new Label
                {
                    Text = proj.name,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.FromArgb(40, 40, 40),
                    Left = 15,
                    Top = 10,
                    AutoSize = true
                };

                var lblMeta = new Label
                {
                    Text = $"Customer: {proj.customer_name ?? $"#{proj.customer_id}"} | Budget: ?{proj.quoted_price ?? 0:N0}",
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    ForeColor = Color.FromArgb(100, 100, 100),
                    Left = 15,
                    Top = 35,
                    AutoSize = true
                };

                card.Controls.Add(lblName);
                card.Controls.Add(lblMeta);
                panel.Controls.Add(card);

                yOffset += 75;
            }
        }
    }
}
