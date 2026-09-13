using System;
using System.Drawing;
using System.Windows.Forms;
using AluMate.Models;

namespace AluMate.Views
{
    public partial class ProjectWorkspaceControl : UserControl
    {
        public event EventHandler? BackClicked;
        private readonly ProjectModel _project;

        public ProjectWorkspaceControl(ProjectModel project)
        {
            _project = project;
            InitializeComponent();
            BindWorkspaceHeader();
        }

        private void BindWorkspaceHeader()
        {
            if (_project != null && !string.IsNullOrEmpty(_project.name))
            {
                lblProjectTitle.Text = _project.name;
            }
        }

        private void TabButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return;

            // Reset tab styles
            foreach (Control ctrl in pnlTabStrip.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.FromArgb(90, 90, 90);
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                }
            }

            // Highlight active Teams-style tab pill
            clickedButton.BackColor = Color.FromArgb(220, 235, 252);
            clickedButton.ForeColor = Color.FromArgb(41, 128, 185);
            clickedButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // Handle tab switching content feedback
            MessageBox.Show($"Loaded workspace section: {clickedButton.Text}", "Teams Workspace", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}