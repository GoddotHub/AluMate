using System;
using System.Drawing;
using System.Windows.Forms;
using AluMate.Models;

namespace AluMate.Views
{
    public partial class ProjectCardControl : UserControl
    {
        public event EventHandler? OpenProjectClicked;
        private readonly ProjectModel _project;
        private Point _originalLocation;

        public ProjectCardControl(ProjectModel project)
        {
            _project = project;
            InitializeComponent();
            BindExecutiveCardData();
            RegisterHoverEffects();
        }

        private void RegisterHoverEffects()
        {
            this.MouseEnter += OnCardMouseEnter;
            this.MouseLeave += OnCardMouseLeave;

            foreach (Control ctrl in this.Controls)
            {
                ctrl.MouseEnter += OnCardMouseEnter;
                ctrl.MouseLeave += OnCardMouseLeave;
            }
        }

        private void OnCardMouseEnter(object? sender, EventArgs e)
        {
            _originalLocation = this.Location;
            this.Location = new Point(this.Location.X, this.Location.Y - 3);
            this.BackColor = Color.FromArgb(38, 38, 38);
        }

        private void OnCardMouseLeave(object? sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                this.Location = new Point(this.Location.X, this.Location.Y + 3);
                this.BackColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void BindExecutiveCardData()
        {
            if (_project == null) return;

            // Hero element
            lblName.Text = string.IsNullOrEmpty(_project.name) ? "UNTITLED PROJECT" : _project.name.ToUpper();

            // Automatic Category Badge / Type Derivation
            lblCategoryType.Text = DeriveProjectCategory(_project.name);

            // Corporate customer name
            lblCustomerName.Text = string.IsNullOrEmpty(_project.customer_name)
                ? $"Customer #{_project.customer_id}"
                : _project.customer_name;

            string statusText = string.IsNullOrEmpty(_project.status) ? "active" : _project.status.ToLower();
            if (statusText == "active")
            {
                lblStatus.Text = "🟢 Active";
                lblStatus.ForeColor = Color.FromArgb(16, 124, 65);
            }
            else
            {
                lblStatus.Text = $"● {char.ToUpper(statusText[0]) + statusText.Substring(1)}";
                lblStatus.ForeColor = Color.FromArgb(216, 59, 1);
            }

            lblCreatedDate.Text = $"Created: {_project.created_at:dd MMM yyyy}";
        }

        private string DeriveProjectCategory(string projectName)
        {
            if (string.IsNullOrEmpty(projectName)) return "🛠 General Project";

            string lower = projectName.ToLower();
            if (lower.Contains("renov") || lower.Contains("office") || lower.Contains("interior"))
                return "🏢 Commercial Interior";
            if (lower.Contains("storefront") || lower.Contains("shop") || lower.Contains("entrance"))
                return "🪟 Storefront System";
            if (lower.Contains("curtain") || lower.Contains("facade") || lower.Contains("wall"))
                return "🏙 Glass Facade";
            if (lower.Contains("window") || lower.Contains("sliding") || lower.Contains("residential"))
                return "🏠 Residential";

            return "⚙️ Aluminum Fabrication";
        }

        private void btnOpen_Click(object? sender, EventArgs e)
        {
            OpenProjectClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}