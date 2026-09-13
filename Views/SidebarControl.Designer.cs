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
            pnlSidebar.BackColor = Color.FromArgb(243, 243, 243);
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
            pnlSidebar.Size = new Size(260, 743);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(243, 243, 243);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Controls.Add(pnlDivider);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(260, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblAppName.ForeColor = Color.FromArgb(30, 30, 30);
            lblAppName.Location = new Point(18, 18);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(137, 45);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "AluMate";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(225, 225, 225);
            pnlDivider.Location = new Point(18, 72);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(224, 1);
            pnlDivider.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(220, 235, 252);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 240, 255);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.FromArgb(0, 95, 184);
            btnDashboard.Location = new Point(12, 95);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(12, 0, 0, 0);
            btnDashboard.Size = new Size(236, 38);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "🏠  Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblProjectsSection
            // 
            lblProjectsSection.AutoSize = true;
            lblProjectsSection.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblProjectsSection.ForeColor = Color.FromArgb(110, 110, 110);
            lblProjectsSection.Location = new Point(18, 245);
            lblProjectsSection.Name = "lblProjectsSection";
            lblProjectsSection.Size = new Size(76, 23);
            lblProjectsSection.TabIndex = 2;
            lblProjectsSection.Text = "PROJECTS";
            // 
            // btnProjects
            // 
            btnProjects.BackColor = Color.Transparent;
            btnProjects.Cursor = Cursors.Hand;
            btnProjects.FlatAppearance.BorderSize = 0;
            btnProjects.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
            btnProjects.FlatStyle = FlatStyle.Flat;
            btnProjects.Font = new Font("Segoe UI", 9.5F);
            btnProjects.ForeColor = Color.FromArgb(40, 40, 40);
            btnProjects.Location = new Point(12, 275);
            btnProjects.Name = "btnProjects";
            btnProjects.Padding = new Padding(12, 0, 0, 0);
            btnProjects.Size = new Size(236, 36);
            btnProjects.TabIndex = 3;
            btnProjects.Text = "📁  Projects";
            btnProjects.TextAlign = ContentAlignment.MiddleLeft;
            btnProjects.UseVisualStyleBackColor = false;
            // 
            // btnProjectItems
            // 
            btnProjectItems.BackColor = Color.Transparent;
            btnProjectItems.Cursor = Cursors.Hand;
            btnProjectItems.FlatAppearance.BorderSize = 0;
            btnProjectItems.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
            btnProjectItems.FlatStyle = FlatStyle.Flat;
            btnProjectItems.Font = new Font("Segoe UI", 9.5F);
            btnProjectItems.ForeColor = Color.FromArgb(40, 40, 40);
            btnProjectItems.Location = new Point(12, 315);
            btnProjectItems.Name = "btnProjectItems";
            btnProjectItems.Padding = new Padding(12, 0, 0, 0);
            btnProjectItems.Size = new Size(236, 36);
            btnProjectItems.TabIndex = 4;
            btnProjectItems.Text = "📋  Project Items";
            btnProjectItems.TextAlign = ContentAlignment.MiddleLeft;
            btnProjectItems.UseVisualStyleBackColor = false;
            // 
            // lblCustomersSection
            // 
            lblCustomersSection.AutoSize = true;
            lblCustomersSection.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCustomersSection.ForeColor = Color.FromArgb(110, 110, 110);
            lblCustomersSection.Location = new Point(18, 155);
            lblCustomersSection.Name = "lblCustomersSection";
            lblCustomersSection.Size = new Size(81, 23);
            lblCustomersSection.TabIndex = 5;
            lblCustomersSection.Text = "CLIENTS";
            lblCustomersSection.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.Transparent;
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 9.5F);
            btnCustomers.ForeColor = Color.FromArgb(40, 40, 40);
            btnCustomers.Location = new Point(12, 185);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(12, 0, 0, 0);
            btnCustomers.Size = new Size(236, 36);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "👥  Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            // 
            // lblSalesSection
            // 
            lblSalesSection.AutoSize = true;
            lblSalesSection.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSalesSection.ForeColor = Color.FromArgb(110, 110, 110);
            lblSalesSection.Location = new Point(18, 380);
            lblSalesSection.Name = "lblSalesSection";
            lblSalesSection.Size = new Size(57, 23);
            lblSalesSection.TabIndex = 7;
            lblSalesSection.Text = "SALES";
            // 
            // btnExpenses
            // 
            btnExpenses.BackColor = Color.Transparent;
            btnExpenses.Cursor = Cursors.Hand;
            btnExpenses.FlatAppearance.BorderSize = 0;
            btnExpenses.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.Font = new Font("Segoe UI", 9.5F);
            btnExpenses.ForeColor = Color.FromArgb(40, 40, 40);
            btnExpenses.Location = new Point(12, 410);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Padding = new Padding(12, 0, 0, 0);
            btnExpenses.Size = new Size(236, 36);
            btnExpenses.TabIndex = 8;
            btnExpenses.Text = "💰  Expenses";
            btnExpenses.TextAlign = ContentAlignment.MiddleLeft;
            btnExpenses.UseVisualStyleBackColor = false;
            // 
            // btnQuotations
            // 
            btnQuotations.BackColor = Color.Transparent;
            btnQuotations.Cursor = Cursors.Hand;
            btnQuotations.FlatAppearance.BorderSize = 0;
            btnQuotations.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
            btnQuotations.FlatStyle = FlatStyle.Flat;
            btnQuotations.Font = new Font("Segoe UI", 9.5F);
            btnQuotations.ForeColor = Color.FromArgb(40, 40, 40);
            btnQuotations.Location = new Point(12, 450);
            btnQuotations.Name = "btnQuotations";
            btnQuotations.Padding = new Padding(12, 0, 0, 0);
            btnQuotations.Size = new Size(236, 36);
            btnQuotations.TabIndex = 9;
            btnQuotations.Text = "📊  Quotations";
            btnQuotations.TextAlign = ContentAlignment.MiddleLeft;
            btnQuotations.UseVisualStyleBackColor = false;
            // 
            // lblSettingsSection
            // 
            lblSettingsSection.AutoSize = true;
            lblSettingsSection.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSettingsSection.ForeColor = Color.FromArgb(110, 110, 110);
            lblSettingsSection.Location = new Point(18, 515);
            lblSettingsSection.Name = "lblSettingsSection";
            lblSettingsSection.Size = new Size(88, 23);
            lblSettingsSection.TabIndex = 10;
            lblSettingsSection.Text = "SYSTEM";
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 235, 235);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 9.5F);
            btnSettings.ForeColor = Color.FromArgb(40, 40, 40);
            btnSettings.Location = new Point(12, 545);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(12, 0, 0, 0);
            btnSettings.Size = new Size(236, 36);
            btnSettings.TabIndex = 11;
            btnSettings.Text = "⚙  Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // SidebarControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlSidebar);
            Name = "SidebarControl";
            Size = new Size(260, 743);
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