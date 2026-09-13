namespace AluMate.Views
{
    partial class SidebarControl
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;
        private Panel pnlDivider;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            pnlHeader = new Panel();
            lblAppName = new Label();
            pnlDivider = new Panel();
            btnDashboard = new Button();
            lblProjectsSection = new Label();
            btnProjects = new Button();
            btnProjectItems = new Button();
            lblCustomersSection = new Label();
            btnCustomers = new Button();
            lblSalesSection = new Label();
            btnExpenses = new Button();
            btnQuotations = new Button();
            lblSettingsSection = new Label();
            btnSettings = new Button();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(188, 220, 240);
            pnlSidebar.Controls.Add(pnlHeader);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblProjectsSection);
            pnlSidebar.Controls.Add(btnProjects);
            pnlSidebar.Controls.Add(btnProjectItems);
            pnlSidebar.Controls.Add(lblCustomersSection);
            pnlSidebar.Controls.Add(btnCustomers);
            pnlSidebar.Controls.Add(lblSalesSection);
            pnlSidebar.Controls.Add(btnExpenses);
            pnlSidebar.Controls.Add(btnQuotations);
            pnlSidebar.Controls.Add(lblSettingsSection);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(280, 743);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(188, 220, 240);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Controls.Add(pnlDivider);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(280, 95);
            pnlHeader.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAppName.Location = new Point(20, 20);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(163, 48);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "AluMate";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(130, 160, 180);
            pnlDivider.Location = new Point(20, 75);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(240, 1);
            pnlDivider.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.SteelBlue;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(20, 125);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(230, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblProjectsSection
            // 
            lblProjectsSection.AutoSize = true;
            lblProjectsSection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProjectsSection.ForeColor = Color.DimGray;
            lblProjectsSection.Location = new Point(20, 310);
            lblProjectsSection.Name = "lblProjectsSection";
            lblProjectsSection.Size = new Size(80, 25);
            lblProjectsSection.TabIndex = 2;
            lblProjectsSection.Text = "Projects";
            // 
            // btnProjects
            // 
            btnProjects.BackColor = Color.Transparent;
            btnProjects.Cursor = Cursors.Hand;
            btnProjects.FlatAppearance.BorderSize = 0;
            btnProjects.FlatStyle = FlatStyle.Flat;
            btnProjects.ForeColor = Color.Black;
            btnProjects.Location = new Point(30, 345);
            btnProjects.Name = "btnProjects";
            btnProjects.Padding = new Padding(15, 0, 0, 0);
            btnProjects.Size = new Size(230, 35);
            btnProjects.TabIndex = 3;
            btnProjects.Text = "Projects";
            btnProjects.TextAlign = ContentAlignment.MiddleLeft;
            btnProjects.UseVisualStyleBackColor = false;
            // 
            // btnProjectItems
            // 
            btnProjectItems.BackColor = Color.Transparent;
            btnProjectItems.Cursor = Cursors.Hand;
            btnProjectItems.FlatAppearance.BorderSize = 0;
            btnProjectItems.FlatStyle = FlatStyle.Flat;
            btnProjectItems.ForeColor = Color.Black;
            btnProjectItems.Location = new Point(30, 385);
            btnProjectItems.Name = "btnProjectItems";
            btnProjectItems.Padding = new Padding(15, 0, 0, 0);
            btnProjectItems.Size = new Size(230, 35);
            btnProjectItems.TabIndex = 4;
            btnProjectItems.Text = "Project Items";
            btnProjectItems.TextAlign = ContentAlignment.MiddleLeft;
            btnProjectItems.UseVisualStyleBackColor = false;
            // 
            // lblCustomersSection
            // 
            lblCustomersSection.AutoSize = true;
            lblCustomersSection.FlatStyle = FlatStyle.Flat;
            lblCustomersSection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomersSection.ForeColor = Color.DimGray;
            lblCustomersSection.Location = new Point(20, 200);
            lblCustomersSection.Name = "lblCustomersSection";
            lblCustomersSection.Size = new Size(101, 25);
            lblCustomersSection.TabIndex = 5;
            lblCustomersSection.Text = "Customers";
            lblCustomersSection.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.Transparent;
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.ForeColor = Color.Black;
            btnCustomers.Location = new Point(30, 235);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(15, 0, 0, 0);
            btnCustomers.Size = new Size(230, 35);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // lblSalesSection
            // 
            lblSalesSection.AutoSize = true;
            lblSalesSection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSalesSection.ForeColor = Color.DimGray;
            lblSalesSection.Location = new Point(20, 475);
            lblSalesSection.Name = "lblSalesSection";
            lblSalesSection.Size = new Size(55, 25);
            lblSalesSection.TabIndex = 7;
            lblSalesSection.Text = "Sales";
            // 
            // btnExpenses
            // 
            btnExpenses.BackColor = Color.Transparent;
            btnExpenses.Cursor = Cursors.Hand;
            btnExpenses.FlatAppearance.BorderSize = 0;
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.ForeColor = Color.Black;
            btnExpenses.Location = new Point(30, 425);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Padding = new Padding(15, 0, 0, 0);
            btnExpenses.Size = new Size(230, 35);
            btnExpenses.TabIndex = 8;
            btnExpenses.Text = "Expenses";
            btnExpenses.TextAlign = ContentAlignment.MiddleLeft;
            btnExpenses.UseVisualStyleBackColor = false;
            // 
            // btnQuotations
            // 
            btnQuotations.BackColor = Color.Transparent;
            btnQuotations.Cursor = Cursors.Hand;
            btnQuotations.FlatAppearance.BorderSize = 0;
            btnQuotations.FlatStyle = FlatStyle.Flat;
            btnQuotations.ForeColor = Color.Black;
            btnQuotations.Location = new Point(30, 510);
            btnQuotations.Name = "btnQuotations";
            btnQuotations.Padding = new Padding(15, 0, 0, 0);
            btnQuotations.Size = new Size(230, 35);
            btnQuotations.TabIndex = 9;
            btnQuotations.Text = "Quotations";
            btnQuotations.TextAlign = ContentAlignment.MiddleLeft;
            btnQuotations.UseVisualStyleBackColor = false;
            // 
            // lblSettingsSection
            // 
            lblSettingsSection.AutoSize = true;
            lblSettingsSection.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSettingsSection.ForeColor = Color.DimGray;
            lblSettingsSection.Location = new Point(20, 610);
            lblSettingsSection.Name = "lblSettingsSection";
            lblSettingsSection.Size = new Size(81, 25);
            lblSettingsSection.TabIndex = 10;
            lblSettingsSection.Text = "Settings";
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.Black;
            btnSettings.Location = new Point(30, 645);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(15, 0, 0, 0);
            btnSettings.Size = new Size(230, 35);
            btnSettings.TabIndex = 11;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // SidebarControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSidebar);
            Name = "SidebarControl";
            Size = new Size(371, 743);
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;

        private Label lblAppName;

        private Button btnDashboard;

        private Label lblProjectsSection;
        private Button btnProjects;
        private Button btnProjectItems;

        private Label lblCustomersSection;
        private Button btnCustomers;

        private Label lblSalesSection;
        private Button btnExpenses;
        private Button btnQuotations;
        private Label lblSettingsSection;
        private Button btnSettings;
    }
}