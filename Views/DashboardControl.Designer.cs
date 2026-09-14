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

        private void InitializeComponent()
        {
            pnlKpiTotal = new Panel();
            lblTotalTitle = new Label();
            lblTotalValue = new Label();
            pnlKpiTotalAccent = new Panel();
            pnlKpiActive = new Panel();
            lblActiveTitle = new Label();
            lblActiveValue = new Label();
            pnlKpiActiveAccent = new Panel();
            pnlKpiRevenue = new Panel();
            lblRevenueTitle = new Label();
            lblRevenueValue = new Label();
            pnlKpiRevenueAccent = new Panel();
            pnlKpiDelayed = new Panel();
            lblDelayedTitle = new Label();
            lblDelayedValue = new Label();
            pnlKpiDelayedAccent = new Panel();
            pnlWelcomeBanner = new Panel();
            lblWelcomeGreeting = new Label();
            lblWelcomeSubtitle = new Label();
            pnlFeaturedProject = new Panel();
            lblFeaturedTitle = new Label();
            lblFeaturedCustomer = new Label();
            lblFeaturedStatus = new Label();
            lblFeaturedDate = new Label();
            btnOpenFeaturedWorkspace = new Button();
            pnlAttentionCenter = new Panel();
            lblAttentionCenterContent = new Label();
            pnlActivityFeed = new Panel();
            lblRecentActivityFeed = new Label();
            pnlBusinessHealth = new Panel();
            lblBusinessHealthLegend = new Label();
            pnlActiveSnapshot = new Panel();
            dgvActiveSnapshot = new DataGridView();
            pnlTopActiveCards = new FlowLayoutPanel();
            lblTotalQuotedValue = new Label();
            btnQuickNewCustomer = new Button();
            btnQuickNewProject = new Button();
            btnQuickNewQuotation = new Button();
            btnQuickRecordExpense = new Button();
            pnlKpiTotal.SuspendLayout();
            pnlKpiActive.SuspendLayout();
            pnlKpiRevenue.SuspendLayout();
            pnlKpiDelayed.SuspendLayout();
            pnlWelcomeBanner.SuspendLayout();
            pnlFeaturedProject.SuspendLayout();
            pnlAttentionCenter.SuspendLayout();
            pnlActivityFeed.SuspendLayout();
            pnlBusinessHealth.SuspendLayout();
            pnlActiveSnapshot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActiveSnapshot).BeginInit();
            SuspendLayout();
            // 
            // pnlKpiTotal
            // 
            pnlKpiTotal.BackColor = Color.White;
            pnlKpiTotal.Controls.Add(lblTotalTitle);
            pnlKpiTotal.Controls.Add(lblTotalValue);
            pnlKpiTotal.Controls.Add(pnlKpiTotalAccent);
            pnlKpiTotal.Location = new Point(29, 33);
            pnlKpiTotal.Margin = new Padding(4, 5, 4, 5);
            pnlKpiTotal.Name = "pnlKpiTotal";
            pnlKpiTotal.Size = new Size(321, 125);
            pnlKpiTotal.TabIndex = 0;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalTitle.ForeColor = Color.Gray;
            lblTotalTitle.Location = new Point(21, 20);
            lblTotalTitle.Margin = new Padding(4, 0, 4, 0);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(159, 25);
            lblTotalTitle.TabIndex = 1;
            lblTotalTitle.Text = "TOTAL PROJECTS";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalValue.Location = new Point(21, 53);
            lblTotalValue.Margin = new Padding(4, 0, 4, 0);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(41, 48);
            lblTotalValue.TabIndex = 2;
            lblTotalValue.Text = "0";
            // 
            // pnlKpiTotalAccent
            // 
            pnlKpiTotalAccent.BackColor = Color.FromArgb(0, 120, 212);
            pnlKpiTotalAccent.Location = new Point(0, 0);
            pnlKpiTotalAccent.Margin = new Padding(4, 5, 4, 5);
            pnlKpiTotalAccent.Name = "pnlKpiTotalAccent";
            pnlKpiTotalAccent.Size = new Size(7, 125);
            pnlKpiTotalAccent.TabIndex = 0;
            // 
            // pnlKpiActive
            // 
            pnlKpiActive.BackColor = Color.White;
            pnlKpiActive.Controls.Add(lblActiveTitle);
            pnlKpiActive.Controls.Add(lblActiveValue);
            pnlKpiActive.Controls.Add(pnlKpiActiveAccent);
            pnlKpiActive.Location = new Point(364, 33);
            pnlKpiActive.Margin = new Padding(4, 5, 4, 5);
            pnlKpiActive.Name = "pnlKpiActive";
            pnlKpiActive.Size = new Size(321, 125);
            pnlKpiActive.TabIndex = 1;
            // 
            // lblActiveTitle
            // 
            lblActiveTitle.AutoSize = true;
            lblActiveTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblActiveTitle.ForeColor = Color.Gray;
            lblActiveTitle.Location = new Point(21, 20);
            lblActiveTitle.Margin = new Padding(4, 0, 4, 0);
            lblActiveTitle.Name = "lblActiveTitle";
            lblActiveTitle.Size = new Size(167, 25);
            lblActiveTitle.TabIndex = 1;
            lblActiveTitle.Text = "ACTIVE PROJECTS";
            // 
            // lblActiveValue
            // 
            lblActiveValue.AutoSize = true;
            lblActiveValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblActiveValue.Location = new Point(21, 53);
            lblActiveValue.Margin = new Padding(4, 0, 4, 0);
            lblActiveValue.Name = "lblActiveValue";
            lblActiveValue.Size = new Size(41, 48);
            lblActiveValue.TabIndex = 2;
            lblActiveValue.Text = "0";
            // 
            // pnlKpiActiveAccent
            // 
            pnlKpiActiveAccent.BackColor = Color.FromArgb(16, 124, 65);
            pnlKpiActiveAccent.Location = new Point(0, 0);
            pnlKpiActiveAccent.Margin = new Padding(4, 5, 4, 5);
            pnlKpiActiveAccent.Name = "pnlKpiActiveAccent";
            pnlKpiActiveAccent.Size = new Size(7, 125);
            pnlKpiActiveAccent.TabIndex = 0;
            // 
            // pnlKpiRevenue
            // 
            pnlKpiRevenue.BackColor = Color.White;
            pnlKpiRevenue.Controls.Add(lblRevenueTitle);
            pnlKpiRevenue.Controls.Add(lblRevenueValue);
            pnlKpiRevenue.Controls.Add(pnlKpiRevenueAccent);
            pnlKpiRevenue.Location = new Point(700, 33);
            pnlKpiRevenue.Margin = new Padding(4, 5, 4, 5);
            pnlKpiRevenue.Name = "pnlKpiRevenue";
            pnlKpiRevenue.Size = new Size(321, 125);
            pnlKpiRevenue.TabIndex = 2;
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRevenueTitle.ForeColor = Color.Gray;
            lblRevenueTitle.Location = new Point(21, 20);
            lblRevenueTitle.Margin = new Padding(4, 0, 4, 0);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(196, 25);
            lblRevenueTitle.TabIndex = 1;
            lblRevenueTitle.Text = "REVENUE POTENTIAL";
            // 
            // lblRevenueValue
            // 
            lblRevenueValue.AutoSize = true;
            lblRevenueValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRevenueValue.Location = new Point(21, 53);
            lblRevenueValue.Margin = new Padding(4, 0, 4, 0);
            lblRevenueValue.Name = "lblRevenueValue";
            lblRevenueValue.Size = new Size(131, 48);
            lblRevenueValue.TabIndex = 2;
            lblRevenueValue.Text = "₦0.0M";
            // 
            // pnlKpiRevenueAccent
            // 
            pnlKpiRevenueAccent.BackColor = Color.FromArgb(136, 23, 152);
            pnlKpiRevenueAccent.Location = new Point(0, 0);
            pnlKpiRevenueAccent.Margin = new Padding(4, 5, 4, 5);
            pnlKpiRevenueAccent.Name = "pnlKpiRevenueAccent";
            pnlKpiRevenueAccent.Size = new Size(7, 125);
            pnlKpiRevenueAccent.TabIndex = 0;
            // 
            // pnlKpiDelayed
            // 
            pnlKpiDelayed.BackColor = Color.White;
            pnlKpiDelayed.Controls.Add(lblDelayedTitle);
            pnlKpiDelayed.Controls.Add(lblDelayedValue);
            pnlKpiDelayed.Controls.Add(pnlKpiDelayedAccent);
            pnlKpiDelayed.Location = new Point(1036, 33);
            pnlKpiDelayed.Margin = new Padding(4, 5, 4, 5);
            pnlKpiDelayed.Name = "pnlKpiDelayed";
            pnlKpiDelayed.Size = new Size(350, 125);
            pnlKpiDelayed.TabIndex = 3;
            // 
            // lblDelayedTitle
            // 
            lblDelayedTitle.AutoSize = true;
            lblDelayedTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDelayedTitle.ForeColor = Color.Gray;
            lblDelayedTitle.Location = new Point(21, 20);
            lblDelayedTitle.Margin = new Padding(4, 0, 4, 0);
            lblDelayedTitle.Name = "lblDelayedTitle";
            lblDelayedTitle.Size = new Size(182, 25);
            lblDelayedTitle.TabIndex = 1;
            lblDelayedTitle.Text = "DELAYED PROJECTS";
            // 
            // lblDelayedValue
            // 
            lblDelayedValue.AutoSize = true;
            lblDelayedValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDelayedValue.Location = new Point(21, 53);
            lblDelayedValue.Margin = new Padding(4, 0, 4, 0);
            lblDelayedValue.Name = "lblDelayedValue";
            lblDelayedValue.Size = new Size(41, 48);
            lblDelayedValue.TabIndex = 2;
            lblDelayedValue.Text = "0";
            // 
            // pnlKpiDelayedAccent
            // 
            pnlKpiDelayedAccent.BackColor = Color.FromArgb(245, 247, 250);
            pnlKpiDelayedAccent.Location = new Point(0, 0);
            pnlKpiDelayedAccent.Margin = new Padding(4, 5, 4, 5);
            pnlKpiDelayedAccent.Name = "pnlKpiDelayedAccent";
            pnlKpiDelayedAccent.Size = new Size(7, 125);
            pnlKpiDelayedAccent.TabIndex = 0;
            // 
            // pnlWelcomeBanner
            // 
            pnlWelcomeBanner.BackColor = Color.White;
            pnlWelcomeBanner.Controls.Add(lblWelcomeGreeting);
            pnlWelcomeBanner.Controls.Add(lblWelcomeSubtitle);
            pnlWelcomeBanner.Location = new Point(29, 175);
            pnlWelcomeBanner.Margin = new Padding(4, 5, 4, 5);
            pnlWelcomeBanner.Name = "pnlWelcomeBanner";
            pnlWelcomeBanner.Size = new Size(1357, 117);
            pnlWelcomeBanner.TabIndex = 4;
            // 
            // lblWelcomeGreeting
            // 
            lblWelcomeGreeting.AutoSize = true;
            lblWelcomeGreeting.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcomeGreeting.Location = new Point(21, 20);
            lblWelcomeGreeting.Margin = new Padding(4, 0, 4, 0);
            lblWelcomeGreeting.Name = "lblWelcomeGreeting";
            lblWelcomeGreeting.Size = new Size(257, 38);
            lblWelcomeGreeting.TabIndex = 0;
            lblWelcomeGreeting.Text = "Good Morning ☀️";
            // 
            // lblWelcomeSubtitle
            // 
            lblWelcomeSubtitle.AutoSize = true;
            lblWelcomeSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblWelcomeSubtitle.ForeColor = Color.Gray;
            lblWelcomeSubtitle.Location = new Point(21, 67);
            lblWelcomeSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblWelcomeSubtitle.Name = "lblWelcomeSubtitle";
            lblWelcomeSubtitle.Size = new Size(382, 25);
            lblWelcomeSubtitle.TabIndex = 1;
            lblWelcomeSubtitle.Text = "Loading active projects requiring attention...";
            // 
            // pnlFeaturedProject
            // 
            pnlFeaturedProject.BackColor = Color.White;
            pnlFeaturedProject.Controls.Add(lblFeaturedTitle);
            pnlFeaturedProject.Controls.Add(lblFeaturedCustomer);
            pnlFeaturedProject.Controls.Add(lblFeaturedStatus);
            pnlFeaturedProject.Controls.Add(lblFeaturedDate);
            pnlFeaturedProject.Controls.Add(btnOpenFeaturedWorkspace);
            pnlFeaturedProject.Location = new Point(29, 317);
            pnlFeaturedProject.Margin = new Padding(4, 5, 4, 5);
            pnlFeaturedProject.Name = "pnlFeaturedProject";
            pnlFeaturedProject.Size = new Size(1357, 167);
            pnlFeaturedProject.TabIndex = 5;
            // 
            // lblFeaturedTitle
            // 
            lblFeaturedTitle.AutoSize = true;
            lblFeaturedTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFeaturedTitle.Location = new Point(21, 25);
            lblFeaturedTitle.Margin = new Padding(4, 0, 4, 0);
            lblFeaturedTitle.Name = "lblFeaturedTitle";
            lblFeaturedTitle.Size = new Size(185, 30);
            lblFeaturedTitle.TabIndex = 0;
            lblFeaturedTitle.Text = "Featured Project";
            // 
            // lblFeaturedCustomer
            // 
            lblFeaturedCustomer.AutoSize = true;
            lblFeaturedCustomer.Font = new Font("Segoe UI", 9F);
            lblFeaturedCustomer.ForeColor = Color.DarkSlateGray;
            lblFeaturedCustomer.Location = new Point(21, 70);
            lblFeaturedCustomer.Margin = new Padding(4, 0, 4, 0);
            lblFeaturedCustomer.Name = "lblFeaturedCustomer";
            lblFeaturedCustomer.Size = new Size(105, 25);
            lblFeaturedCustomer.TabIndex = 1;
            lblFeaturedCustomer.Text = "Customer: -";
            // 
            // lblFeaturedStatus
            // 
            lblFeaturedStatus.AutoSize = true;
            lblFeaturedStatus.Font = new Font("Segoe UI", 9F);
            lblFeaturedStatus.Location = new Point(21, 113);
            lblFeaturedStatus.Margin = new Padding(4, 0, 4, 0);
            lblFeaturedStatus.Name = "lblFeaturedStatus";
            lblFeaturedStatus.Size = new Size(76, 25);
            lblFeaturedStatus.TabIndex = 2;
            lblFeaturedStatus.Text = "Status: -";
            // 
            // lblFeaturedDate
            // 
            lblFeaturedDate.AutoSize = true;
            lblFeaturedDate.Font = new Font("Segoe UI", 9F);
            lblFeaturedDate.ForeColor = Color.Gray;
            lblFeaturedDate.Location = new Point(429, 113);
            lblFeaturedDate.Margin = new Padding(4, 0, 4, 0);
            lblFeaturedDate.Name = "lblFeaturedDate";
            lblFeaturedDate.Size = new Size(89, 25);
            lblFeaturedDate.TabIndex = 3;
            lblFeaturedDate.Text = "Created: -";
            // 
            // btnOpenFeaturedWorkspace
            // 
            btnOpenFeaturedWorkspace.BackColor = Color.FromArgb(0, 120, 212);
            btnOpenFeaturedWorkspace.FlatStyle = FlatStyle.Flat;
            btnOpenFeaturedWorkspace.ForeColor = Color.White;
            btnOpenFeaturedWorkspace.Location = new Point(1143, 58);
            btnOpenFeaturedWorkspace.Margin = new Padding(4, 5, 4, 5);
            btnOpenFeaturedWorkspace.Name = "btnOpenFeaturedWorkspace";
            btnOpenFeaturedWorkspace.Size = new Size(186, 53);
            btnOpenFeaturedWorkspace.TabIndex = 4;
            btnOpenFeaturedWorkspace.Text = "Open Workspace";
            btnOpenFeaturedWorkspace.UseVisualStyleBackColor = false;
            // 
            // pnlAttentionCenter
            // 
            pnlAttentionCenter.BackColor = Color.White;
            pnlAttentionCenter.Controls.Add(lblAttentionCenterContent);
            pnlAttentionCenter.Location = new Point(29, 508);
            pnlAttentionCenter.Margin = new Padding(4, 5, 4, 5);
            pnlAttentionCenter.Name = "pnlAttentionCenter";
            pnlAttentionCenter.Size = new Size(664, 300);
            pnlAttentionCenter.TabIndex = 6;
            // 
            // lblAttentionCenterContent
            // 
            lblAttentionCenterContent.Font = new Font("Segoe UI", 9.5F);
            lblAttentionCenterContent.Location = new Point(21, 25);
            lblAttentionCenterContent.Margin = new Padding(4, 0, 4, 0);
            lblAttentionCenterContent.Name = "lblAttentionCenterContent";
            lblAttentionCenterContent.Size = new Size(621, 250);
            lblAttentionCenterContent.TabIndex = 0;
            lblAttentionCenterContent.Text = "Attention Required\n\nAnalyzing operational warnings...";
            // 
            // pnlActivityFeed
            // 
            pnlActivityFeed.BackColor = Color.White;
            pnlActivityFeed.Controls.Add(lblRecentActivityFeed);
            pnlActivityFeed.Location = new Point(721, 508);
            pnlActivityFeed.Margin = new Padding(4, 5, 4, 5);
            pnlActivityFeed.Name = "pnlActivityFeed";
            pnlActivityFeed.Size = new Size(664, 300);
            pnlActivityFeed.TabIndex = 7;
            // 
            // lblRecentActivityFeed
            // 
            lblRecentActivityFeed.Font = new Font("Segoe UI", 9.5F);
            lblRecentActivityFeed.Location = new Point(21, 25);
            lblRecentActivityFeed.Margin = new Padding(4, 0, 4, 0);
            lblRecentActivityFeed.Name = "lblRecentActivityFeed";
            lblRecentActivityFeed.Size = new Size(621, 250);
            lblRecentActivityFeed.TabIndex = 0;
            lblRecentActivityFeed.Text = "Recent Activity\n\nLoading activity stream...";
            // 
            // pnlBusinessHealth
            // 
            pnlBusinessHealth.BackColor = Color.White;
            pnlBusinessHealth.Controls.Add(lblBusinessHealthLegend);
            pnlBusinessHealth.Location = new Point(29, 833);
            pnlBusinessHealth.Margin = new Padding(4, 5, 4, 5);
            pnlBusinessHealth.Name = "pnlBusinessHealth";
            pnlBusinessHealth.Size = new Size(664, 333);
            pnlBusinessHealth.TabIndex = 8;
            // 
            // lblBusinessHealthLegend
            // 
            lblBusinessHealthLegend.Font = new Font("Segoe UI", 9.5F);
            lblBusinessHealthLegend.Location = new Point(21, 25);
            lblBusinessHealthLegend.Margin = new Padding(4, 0, 4, 0);
            lblBusinessHealthLegend.Name = "lblBusinessHealthLegend";
            lblBusinessHealthLegend.Size = new Size(621, 283);
            lblBusinessHealthLegend.TabIndex = 0;
            lblBusinessHealthLegend.Text = "Business Health\n\nCalculating metrics...";
            // 
            // pnlActiveSnapshot
            // 
            pnlActiveSnapshot.BackColor = Color.White;
            pnlActiveSnapshot.Controls.Add(dgvActiveSnapshot);
            pnlActiveSnapshot.Location = new Point(721, 833);
            pnlActiveSnapshot.Margin = new Padding(4, 5, 4, 5);
            pnlActiveSnapshot.Name = "pnlActiveSnapshot";
            pnlActiveSnapshot.Size = new Size(664, 333);
            pnlActiveSnapshot.TabIndex = 9;
            // 
            // dgvActiveSnapshot
            // 
            dgvActiveSnapshot.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActiveSnapshot.BackgroundColor = Color.White;
            dgvActiveSnapshot.BorderStyle = BorderStyle.None;
            dgvActiveSnapshot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActiveSnapshot.Location = new Point(21, 25);
            dgvActiveSnapshot.Margin = new Padding(4, 5, 4, 5);
            dgvActiveSnapshot.Name = "dgvActiveSnapshot";
            dgvActiveSnapshot.RowHeadersWidth = 62;
            dgvActiveSnapshot.Size = new Size(621, 283);
            dgvActiveSnapshot.TabIndex = 0;
            // 
            // pnlTopActiveCards
            // 
            pnlTopActiveCards.Location = new Point(29, 1192);
            pnlTopActiveCards.Margin = new Padding(4, 5, 4, 5);
            pnlTopActiveCards.Name = "pnlTopActiveCards";
            pnlTopActiveCards.Size = new Size(1357, 200);
            pnlTopActiveCards.TabIndex = 10;
            // 
            // lblTotalQuotedValue
            // 
            lblTotalQuotedValue.Location = new Point(0, 0);
            lblTotalQuotedValue.Name = "lblTotalQuotedValue";
            lblTotalQuotedValue.Size = new Size(100, 23);
            lblTotalQuotedValue.TabIndex = 0;
            lblTotalQuotedValue.Visible = false;
            // 
            // btnQuickNewCustomer
            // 
            btnQuickNewCustomer.Location = new Point(0, 0);
            btnQuickNewCustomer.Name = "btnQuickNewCustomer";
            btnQuickNewCustomer.Size = new Size(75, 23);
            btnQuickNewCustomer.TabIndex = 0;
            btnQuickNewCustomer.Visible = false;
            // 
            // btnQuickNewProject
            // 
            btnQuickNewProject.Location = new Point(0, 0);
            btnQuickNewProject.Name = "btnQuickNewProject";
            btnQuickNewProject.Size = new Size(75, 23);
            btnQuickNewProject.TabIndex = 0;
            btnQuickNewProject.Visible = false;
            // 
            // btnQuickNewQuotation
            // 
            btnQuickNewQuotation.Location = new Point(0, 0);
            btnQuickNewQuotation.Name = "btnQuickNewQuotation";
            btnQuickNewQuotation.Size = new Size(75, 23);
            btnQuickNewQuotation.TabIndex = 0;
            btnQuickNewQuotation.Visible = false;
            // 
            // btnQuickRecordExpense
            // 
            btnQuickRecordExpense.Location = new Point(0, 0);
            btnQuickRecordExpense.Name = "btnQuickRecordExpense";
            btnQuickRecordExpense.Size = new Size(75, 23);
            btnQuickRecordExpense.TabIndex = 0;
            btnQuickRecordExpense.Visible = false;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(pnlKpiTotal);
            Controls.Add(pnlKpiActive);
            Controls.Add(pnlKpiRevenue);
            Controls.Add(pnlKpiDelayed);
            Controls.Add(pnlWelcomeBanner);
            Controls.Add(pnlFeaturedProject);
            Controls.Add(pnlAttentionCenter);
            Controls.Add(pnlActivityFeed);
            Controls.Add(pnlBusinessHealth);
            Controls.Add(pnlActiveSnapshot);
            Controls.Add(pnlTopActiveCards);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardControl";
            Size = new Size(1429, 1433);
            pnlKpiTotal.ResumeLayout(false);
            pnlKpiTotal.PerformLayout();
            pnlKpiActive.ResumeLayout(false);
            pnlKpiActive.PerformLayout();
            pnlKpiRevenue.ResumeLayout(false);
            pnlKpiRevenue.PerformLayout();
            pnlKpiDelayed.ResumeLayout(false);
            pnlKpiDelayed.PerformLayout();
            pnlWelcomeBanner.ResumeLayout(false);
            pnlWelcomeBanner.PerformLayout();
            pnlFeaturedProject.ResumeLayout(false);
            pnlFeaturedProject.PerformLayout();
            pnlAttentionCenter.ResumeLayout(false);
            pnlActivityFeed.ResumeLayout(false);
            pnlBusinessHealth.ResumeLayout(false);
            pnlActiveSnapshot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActiveSnapshot).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlKpiTotal;
        private System.Windows.Forms.Panel pnlKpiTotalAccent;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalValue;

        private System.Windows.Forms.Panel pnlKpiActive;
        private System.Windows.Forms.Panel pnlKpiActiveAccent;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Label lblActiveValue;

        private System.Windows.Forms.Panel pnlKpiRevenue;
        private System.Windows.Forms.Panel pnlKpiRevenueAccent;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Label lblRevenueValue;

        private System.Windows.Forms.Panel pnlKpiDelayed;
        private System.Windows.Forms.Panel pnlKpiDelayedAccent;
        private System.Windows.Forms.Label lblDelayedTitle;
        private System.Windows.Forms.Label lblDelayedValue;

        private System.Windows.Forms.Panel pnlWelcomeBanner;
        private System.Windows.Forms.Label lblWelcomeGreeting;
        private System.Windows.Forms.Label lblWelcomeSubtitle;

        private System.Windows.Forms.Panel pnlFeaturedProject;
        private System.Windows.Forms.Label lblFeaturedTitle;
        private System.Windows.Forms.Label lblFeaturedCustomer;
        private System.Windows.Forms.Label lblFeaturedStatus;
        private System.Windows.Forms.Label lblFeaturedDate;
        private System.Windows.Forms.Button btnOpenFeaturedWorkspace;

        private System.Windows.Forms.Panel pnlAttentionCenter;
        private System.Windows.Forms.Label lblAttentionCenterContent;

        private System.Windows.Forms.Panel pnlActivityFeed;
        private System.Windows.Forms.Label lblRecentActivityFeed;

        private System.Windows.Forms.Panel pnlBusinessHealth;
        private System.Windows.Forms.Label lblBusinessHealthLegend;

        private System.Windows.Forms.Panel pnlActiveSnapshot;
        private System.Windows.Forms.DataGridView dgvActiveSnapshot;

        private System.Windows.Forms.FlowLayoutPanel pnlTopActiveCards;

        private System.Windows.Forms.Label lblTotalQuotedValue;

        private System.Windows.Forms.Button btnQuickNewCustomer;
        private System.Windows.Forms.Button btnQuickNewProject;
        private System.Windows.Forms.Button btnQuickNewQuotation;
        private System.Windows.Forms.Button btnQuickRecordExpense;
    }
}