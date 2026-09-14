using System.Windows.Forms;
using AluMate.Models;

namespace AluMate.Views
{
    public partial class ProjectWorkspaceForm : Form
    {
        private readonly ProjectModel _project;

        public ProjectWorkspaceForm(ProjectModel project)
        {
            _project = project;
            InitializeComponent();
            SetupWorkspaceLayout();
        }

        private void SetupWorkspaceLayout()
        {
            this.Text = $"AluMate Workspace - {_project.name}";

            var lblName = this.Controls.Find("lblHeaderProjectName", true).FirstOrDefault() as Label;
            if (lblName != null) lblName.Text = _project.name.ToUpper();

            var lblCustomer = this.Controls.Find("lblHeaderCustomerName", true).FirstOrDefault() as Label;
            if (lblCustomer != null) lblCustomer.Text = _project.customer_name ?? $"Customer #{_project.customer_id}";
        }
        // Tab navigation handlers for: Overview, Items, Quotations, Expenses, Documents, Timeline, Analytics
    }
}