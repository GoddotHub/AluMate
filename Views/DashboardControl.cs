using System;
using System.Windows.Forms;

namespace AluMate.Views
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dashboard data refreshed successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}