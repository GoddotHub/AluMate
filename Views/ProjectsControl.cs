using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AluMate.Models;

namespace AluMate.Views
{
    public partial class ProjectsControl : UserControl
    {
        private List<ProjectModel> _allProjects = new();
        private string _currentFilter = "All";

        public ProjectsControl()
        {
            InitializeComponent();
            cmbSortBy.SelectedIndex = 0; // Default to "Recent"
            LoadMockProjects();
        }

        private void LoadMockProjects()
        {
            _allProjects = new List<ProjectModel>
            {
                new ProjectModel { id = 1, name = "Aluminium Factory Expansion", status = "Active", quoted_price = 45000m },
                new ProjectModel { id = 2, name = "Commercial Tower Glass Facade", status = "Active", quoted_price = 120000m },
                new ProjectModel { id = 3, name = "Residential Sliding Windows", status = "Planning", quoted_price = 8500m },
                new ProjectModel { id = 4, name = "Modern Office Partitions", status = "Delayed", quoted_price = 24000m },
                new ProjectModel { id = 5, name = "Retail Storefront Entrance", status = "Completed", quoted_price = 15000m }
            };

            ApplyFilterAndSearch();
        }

        private void ApplyFilterAndSearch()
        {
            string searchQuery = txtSearch.Text.Trim().ToLower();

            var filtered = _allProjects.AsEnumerable();

            // Apply Status Filter
            if (_currentFilter != "All")
            {
                filtered = filtered.Where(p => p.status.Equals(_currentFilter, StringComparison.OrdinalIgnoreCase));
            }

            // Apply Search Filter instantly
            if (!string.IsNullOrEmpty(searchQuery))
            {
                filtered = filtered.Where(p => p.name != null && p.name.ToLower().Contains(searchQuery));
            }

            // Apply Sort
            string selectedSort = cmbSortBy.SelectedItem?.ToString() ?? "Recent";
            filtered = selectedSort switch
            {
                "Progress" => filtered.OrderByDescending(p => p.id), // placeholder sorting logic
                "Deadline" => filtered.OrderBy(p => p.id),
                "Budget" => filtered.OrderByDescending(p => p.quoted_price ?? 0),
                _ => filtered.OrderByDescending(p => p.id) // Recent
            };

            RenderCards(filtered.ToList());
        }

        private void RenderCards(List<ProjectModel> projects)
        {
            flowLayoutPanelCards.SuspendLayout();
            flowLayoutPanelCards.Controls.Clear();

            foreach (var project in projects)
            {
                var card = new ProjectCardControl(project);
                card.OpenProjectClicked += (s, e) =>
                {
                    MessageBox.Show($"Opening project management suite for: {project.name}", "AluMate Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                flowLayoutPanelCards.Controls.Add(card);
            }

            flowLayoutPanelCards.ResumeLayout();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSearch();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return;

            // Reset styles for all filter buttons
            foreach (Control ctrl in pnlFilters.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(240, 240, 240);
                    btn.ForeColor = Color.FromArgb(80, 80, 80);
                    btn.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
                }
            }

            // Highlight active filter pill
            clickedButton.BackColor = Color.FromArgb(220, 235, 252);
            clickedButton.ForeColor = Color.FromArgb(41, 128, 185);
            clickedButton.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);

            _currentFilter = clickedButton.Text;
            ApplyFilterAndSearch();
        }

        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSearch();
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open dialog to create a new fabrication project.", "New Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}