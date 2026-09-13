namespace AluMate.Views
{
    partial class DashboardControl
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cardsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cardProjects = new System.Windows.Forms.Panel();
            this.lblProjectsTitle = new System.Windows.Forms.Label();
            this.lblProjectsVal = new System.Windows.Forms.Label();
            this.cardActive = new System.Windows.Forms.Panel();
            this.lblActiveTitle = new System.Windows.Forms.Label();
            this.lblActiveVal = new System.Windows.Forms.Label();
            this.cardQuotations = new System.Windows.Forms.Panel();
            this.lblQuotationsTitle = new System.Windows.Forms.Label();
            this.lblQuotationsVal = new System.Windows.Forms.Label();
            this.cardCustomers = new System.Windows.Forms.Panel();
            this.lblCustomersTitle = new System.Windows.Forms.Label();
            this.lblCustomersVal = new System.Windows.Forms.Label();
            this.cardRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.lblRevenueVal = new System.Windows.Forms.Label();
            this.cardsPanel.SuspendLayout();
            this.cardProjects.SuspendLayout();
            this.cardActive.SuspendLayout();
            this.cardQuotations.SuspendLayout();
            this.cardCustomers.SuspendLayout();
            this.cardRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard Overview";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(850, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cardsPanel
            // 
            this.cardsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardsPanel.Controls.Add(this.cardProjects);
            this.cardsPanel.Controls.Add(this.cardActive);
            this.cardsPanel.Controls.Add(this.cardQuotations);
            this.cardsPanel.Controls.Add(this.cardCustomers);
            this.cardsPanel.Controls.Add(this.cardRevenue);
            this.cardsPanel.Location = new System.Drawing.Point(30, 90);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(940, 330);
            this.cardsPanel.TabIndex = 2;
            // 
            // cardProjects
            // 
            this.cardProjects.BackColor = System.Drawing.Color.White;
            this.cardProjects.Controls.Add(this.lblProjectsTitle);
            this.cardProjects.Controls.Add(this.lblProjectsVal);
            this.cardProjects.Location = new System.Drawing.Point(0, 0);
            this.cardProjects.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.cardProjects.Name = "cardProjects";
            this.cardProjects.Size = new System.Drawing.Size(290, 130);
            this.cardProjects.TabIndex = 0;
            // 
            // lblProjectsTitle
            // 
            this.lblProjectsTitle.AutoSize = true;
            this.lblProjectsTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblProjectsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblProjectsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblProjectsTitle.Name = "lblProjectsTitle";
            this.lblProjectsTitle.Size = new System.Drawing.Size(125, 25);
            this.lblProjectsTitle.TabIndex = 0;
            this.lblProjectsTitle.Text = "Total Projects";
            // 
            // lblProjectsVal
            // 
            this.lblProjectsVal.AutoSize = true;
            this.lblProjectsVal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblProjectsVal.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblProjectsVal.Location = new System.Drawing.Point(20, 55);
            this.lblProjectsVal.Name = "lblProjectsVal";
            this.lblProjectsVal.Size = new System.Drawing.Size(73, 54);
            this.lblProjectsVal.TabIndex = 1;
            this.lblProjectsVal.Text = "---";
            // 
            // cardActive
            // 
            this.cardActive.BackColor = System.Drawing.Color.White;
            this.cardActive.Controls.Add(this.lblActiveTitle);
            this.cardActive.Controls.Add(this.lblActiveVal);
            this.cardActive.Location = new System.Drawing.Point(310, 0);
            this.cardActive.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.cardActive.Name = "cardActive";
            this.cardActive.Size = new System.Drawing.Size(290, 130);
            this.cardActive.TabIndex = 1;
            // 
            // lblActiveTitle
            // 
            this.lblActiveTitle.AutoSize = true;
            this.lblActiveTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblActiveTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblActiveTitle.Location = new System.Drawing.Point(20, 20);
            this.lblActiveTitle.Name = "lblActiveTitle";
            this.lblActiveTitle.Size = new System.Drawing.Size(133, 25);
            this.lblActiveTitle.TabIndex = 0;
            this.lblActiveTitle.Text = "Active Projects";
            // 
            // lblActiveVal
            // 
            this.lblActiveVal.AutoSize = true;
            this.lblActiveVal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblActiveVal.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblActiveVal.Location = new System.Drawing.Point(20, 55);
            this.lblActiveVal.Name = "lblActiveVal";
            this.lblActiveVal.Size = new System.Drawing.Size(73, 54);
            this.lblActiveVal.TabIndex = 1;
            this.lblActiveVal.Text = "---";
            // 
            // cardQuotations
            // 
            this.cardQuotations.BackColor = System.Drawing.Color.White;
            this.cardQuotations.Controls.Add(this.lblQuotationsTitle);
            this.cardQuotations.Controls.Add(this.lblQuotationsVal);
            this.cardQuotations.Location = new System.Drawing.Point(620, 0);
            this.cardQuotations.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.cardQuotations.Name = "cardQuotations";
            this.cardQuotations.Size = new System.Drawing.Size(290, 130);
            this.cardQuotations.TabIndex = 2;
            // 
            // lblQuotationsTitle
            // 
            this.lblQuotationsTitle.AutoSize = true;
            this.lblQuotationsTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblQuotationsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblQuotationsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblQuotationsTitle.Name = "lblQuotationsTitle";
            this.lblQuotationsTitle.Size = new System.Drawing.Size(155, 25);
            this.lblQuotationsTitle.TabIndex = 0;
            this.lblQuotationsTitle.Text = "Total Quotations";
            // 
            // lblQuotationsVal
            // 
            this.lblQuotationsVal.AutoSize = true;
            this.lblQuotationsVal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblQuotationsVal.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblQuotationsVal.Location = new System.Drawing.Point(20, 55);
            this.lblQuotationsVal.Name = "lblQuotationsVal";
            this.lblQuotationsVal.Size = new System.Drawing.Size(73, 54);
            this.lblQuotationsVal.TabIndex = 1;
            this.lblQuotationsVal.Text = "---";
            // 
            // cardCustomers
            // 
            this.cardCustomers.BackColor = System.Drawing.Color.White;
            this.cardCustomers.Controls.Add(this.lblCustomersTitle);
            this.cardCustomers.Controls.Add(this.lblCustomersVal);
            this.cardCustomers.Location = new System.Drawing.Point(0, 150);
            this.cardCustomers.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.cardCustomers.Name = "cardCustomers";
            this.cardCustomers.Size = new System.Drawing.Size(290, 130);
            this.cardCustomers.TabIndex = 3;
            // 
            // lblCustomersTitle
            // 
            this.lblCustomersTitle.AutoSize = true;
            this.lblCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCustomersTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblCustomersTitle.Location = new System.Drawing.Point(20, 20);
            this.lblCustomersTitle.Name = "lblCustomersTitle";
            this.lblCustomersTitle.Size = new System.Drawing.Size(142, 25);
            this.lblCustomersTitle.TabIndex = 0;
            this.lblCustomersTitle.Text = "Total Customers";
            // 
            // lblCustomersVal
            // 
            this.lblCustomersVal.AutoSize = true;
            this.lblCustomersVal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCustomersVal.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblCustomersVal.Location = new System.Drawing.Point(20, 55);
            this.lblCustomersVal.Name = "lblCustomersVal";
            this.lblCustomersVal.Size = new System.Drawing.Size(73, 54);
            this.lblCustomersVal.TabIndex = 1;
            this.lblCustomersVal.Text = "---";
            // 
            // cardRevenue
            // 
            this.cardRevenue.BackColor = System.Drawing.Color.White;
            this.cardRevenue.Controls.Add(this.lblRevenueTitle);
            this.cardRevenue.Controls.Add(this.lblRevenueVal);
            this.cardRevenue.Location = new System.Drawing.Point(310, 150);
            this.cardRevenue.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.Size = new System.Drawing.Size(290, 130);
            this.cardRevenue.TabIndex = 4;
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblRevenueTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(165, 25);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "Revenue Potential";
            // 
            // lblRevenueVal
            // 
            this.lblRevenueVal.AutoSize = true;
            this.lblRevenueVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblRevenueVal.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblRevenueVal.Location = new System.Drawing.Point(20, 55);
            this.lblRevenueVal.Name = "lblRevenueVal";
            this.lblRevenueVal.Size = new System.Drawing.Size(76, 46);
            this.lblRevenueVal.TabIndex = 1;
            this.lblRevenueVal.Text = "---";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.cardsPanel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTitle);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1000, 650);
            this.cardsPanel.ResumeLayout(false);
            this.cardProjects.ResumeLayout(false);
            this.cardProjects.PerformLayout();
            this.cardActive.ResumeLayout(false);
            this.cardActive.PerformLayout();
            this.cardQuotations.ResumeLayout(false);
            this.cardQuotations.PerformLayout();
            this.cardCustomers.ResumeLayout(false);
            this.cardCustomers.PerformLayout();
            this.cardRevenue.ResumeLayout(false);
            this.cardRevenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel cardsPanel;
        private System.Windows.Forms.Panel cardProjects;
        private System.Windows.Forms.Label lblProjectsTitle;
        private System.Windows.Forms.Label lblProjectsVal;
        private System.Windows.Forms.Panel cardActive;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Label lblActiveVal;
        private System.Windows.Forms.Panel cardQuotations;
        private System.Windows.Forms.Label lblQuotationsTitle;
        private System.Windows.Forms.Label lblQuotationsVal;
        private System.Windows.Forms.Panel cardCustomers;
        private System.Windows.Forms.Label lblCustomersTitle;
        private System.Windows.Forms.Label lblCustomersVal;
        private System.Windows.Forms.Panel cardRevenue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Label lblRevenueVal;
    }
}