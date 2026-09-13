using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AluMate.Views;

namespace AluMate
{
    public partial class MainForm : Form
    {
        private Dictionary<string, UserControl> viewCache = new Dictionary<string, UserControl>();

        public MainForm()
        {
            InitializeComponent();

            sidebarControl1.DashboardClicked += (s, e) => SwitchView("Dashboard", new DashboardControl());
            sidebarControl1.ProjectsClicked += (s, e) => SwitchView("Projects", new ProjectsControl());
            sidebarControl1.ProjectItemsClicked += (s, e) => SwitchView("Project Items", new ProjectItemsControl());
            sidebarControl1.CustomersClicked += (s, e) => SwitchView("Customers", new CustomersControl());
            sidebarControl1.ExpensesClicked += (s, e) => SwitchView("Expenses", new ExpensesControl());
            sidebarControl1.QuotationsClicked += (s, e) => SwitchView("Quotations", new QuotationsControl());
            sidebarControl1.SettingsClicked += (s, e) => SwitchView("Settings", new SettingsControl());

            // Set Dashboard as the default startup view
            SwitchView("Dashboard", new DashboardControl());
        }

        private void SwitchView(string viewName, UserControl controlToLoad)
        {
            panelContent.Controls.Clear();

            if (!viewCache.ContainsKey(viewName))
            {
                viewCache[viewName] = controlToLoad;
            }

            var activeControl = viewCache[viewName];
            activeControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(activeControl);
            activeControl.BringToFront();
        }
    }
}