using System;
using System.Drawing;
using System.Windows.Forms;

namespace AluMate.Views;

public partial class SidebarControl : UserControl
{
    private readonly Color HoverColor =
        Color.FromArgb(180, 215, 235);

    private readonly Color NormalColor =
        Color.Transparent;

    // Navigation events
    public event EventHandler? DashboardClicked;
    public event EventHandler? CustomersClicked;
    public event EventHandler? ProjectsClicked;
    public event EventHandler? ProjectItemsClicked;
    public event EventHandler? ExpensesClicked;
    public event EventHandler? QuotationsClicked;
    public event EventHandler? SettingsClicked;

    public SidebarControl()
    {
        InitializeComponent();

        InitializeHoverEffects();
        InitializeNavigationEvents();
    }

    private void InitializeHoverEffects()
    {
        RegisterHover(btnDashboard);
        RegisterHover(btnProjects);
        RegisterHover(btnProjectItems);
        RegisterHover(btnCustomers);
        RegisterHover(btnExpenses);
        RegisterHover(btnQuotations);
        RegisterHover(btnSettings);
    }

    private void RegisterHover(Button button)
    {
        button.MouseEnter += (sender, e) =>
        {
            button.BackColor = HoverColor;
            button.ForeColor = Color.Black;
        };

        button.MouseLeave += (sender, e) =>
        {
            button.BackColor = NormalColor;
            button.ForeColor = Color.Black;
        };
    }

    private void InitializeNavigationEvents()
    {
        btnDashboard.Click += (sender, e) =>
            DashboardClicked?.Invoke(this, EventArgs.Empty);

        btnCustomers.Click += (sender, e) =>
            CustomersClicked?.Invoke(this, EventArgs.Empty);

        btnProjects.Click += (sender, e) =>
            ProjectsClicked?.Invoke(this, EventArgs.Empty);

        btnProjectItems.Click += (sender, e) =>
            ProjectItemsClicked?.Invoke(this, EventArgs.Empty);

        btnExpenses.Click += (sender, e) =>
            ExpensesClicked?.Invoke(this, EventArgs.Empty);

        btnQuotations.Click += (sender, e) =>
            QuotationsClicked?.Invoke(this, EventArgs.Empty);

        btnSettings.Click += (sender, e) =>
            SettingsClicked?.Invoke(this, EventArgs.Empty);
    }
}