namespace AluMate.Views
{
    partial class ProjectWorkspaceControl
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
            this.pnlWorkspaceHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.pnlTabStrip = new System.Windows.Forms.Panel();
            this.btnTabOverview = new System.Windows.Forms.Button();
            this.btnTabTimeline = new System.Windows.Forms.Button();
            this.btnTabTasks = new System.Windows.Forms.Button();
            this.btnTabDocuments = new System.Windows.Forms.Button();
            this.btnTabBudget = new System.Windows.Forms.Button();
            this.btnTabTeam = new System.Windows.Forms.Button();
            this.btnTabAnalytics = new System.Windows.Forms.Button();
            this.pnlWorkspaceContent = new System.Windows.Forms.Panel();
            this.pnlWorkspaceHeader.SuspendLayout();
            this.pnlTabStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkspaceHeader
            // 
            this.pnlWorkspaceHeader.BackColor = System.Drawing.Color.White;
            this.pnlWorkspaceHeader.Controls.Add(this.btnBack);
            this.pnlWorkspaceHeader.Controls.Add(this.lblProjectTitle);
            this.pnlWorkspaceHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWorkspaceHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlWorkspaceHeader.Name = "pnlWorkspaceHeader";
            this.pnlWorkspaceHeader.Size = new System.Drawing.Size(1000, 70);
            this.pnlWorkspaceHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnBack.Location = new System.Drawing.Point(20, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblProjectTitle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblProjectTitle.Location = new System.Drawing.Point(115, 16);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(374, 37);
            this.lblProjectTitle.TabIndex = 1;
            this.lblProjectTitle.Text = "Aluminium Factory Expansion";
            // 
            // pnlTabStrip
            // 
            this.pnlTabStrip.BackColor = System.Drawing.Color.White;
            this.pnlTabStrip.Controls.Add(this.btnTabOverview);
            this.pnlTabStrip.Controls.Add(this.btnTabTimeline);
            this.pnlTabStrip.Controls.Add(this.btnTabTasks);
            this.pnlTabStrip.Controls.Add(this.btnTabDocuments);
            this.pnlTabStrip.Controls.Add(this.btnTabBudget);
            this.pnlTabStrip.Controls.Add(this.btnTabTeam);
            this.pnlTabStrip.Controls.Add(this.btnTabAnalytics);
            this.pnlTabStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabStrip.Location = new System.Drawing.Point(0, 70);
            this.pnlTabStrip.Name = "pnlTabStrip";
            this.pnlTabStrip.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.pnlTabStrip.Size = new System.Drawing.Size(1000, 50);
            this.pnlTabStrip.TabIndex = 1;
            // 
            // btnTabOverview
            // 
            this.btnTabOverview.BackColor = System.Drawing.Color.FromArgb(220, 235, 252);
            this.btnTabOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabOverview.FlatAppearance.BorderSize = 0;
            this.btnTabOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabOverview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabOverview.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnTabOverview.Location = new System.Drawing.Point(20, 8);
            this.btnTabOverview.Name = "btnTabOverview";
            this.btnTabOverview.Size = new System.Drawing.Size(100, 32);
            this.btnTabOverview.TabIndex = 0;
            this.btnTabOverview.Text = "Overview";
            this.btnTabOverview.UseVisualStyleBackColor = false;
            this.btnTabOverview.Click += new System.EventHandler(this.TabButton_Click);
            // 
            // btnTabTimeline
            // 
            this.btnTabTimeline.BackColor = System.Drawing.Color.Transparent;
            this.btnTabTimeline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabTimeline.FlatAppearance.BorderSize = 0;
            this.btnTabTimeline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabTimeline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTabTimeline.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnTabTimeline.Location = new System.Drawing.Point(126, 8);
            this.btnTabTimeline.Name = "btnTabTimeline";
            this.btnTabTimeline.Size = new System.Drawing.Size(100, 32);
            this.btnTabTimeline.TabIndex = 1;
            this.btnTabTimeline.Text = "Timeline";
            this.btnTabTimeline.UseVisualStyleBackColor = true;
            this.btnTabTimeline.Click += new System.EventHandler(this.TabButton_Click);
            // 
            // btnTabTasks
            // 
            this.btnTabTasks.BackColor = System.Drawing.Color.Transparent;
            this.btnTabTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabTasks.FlatAppearance.BorderSize = 0;
            this.btnTabTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabTasks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTabTasks.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnTabTasks.Location = new System.Drawing.Point(232, 8);
            this.btnTabTasks.Name = "btnTabTasks";
            this.btnTabTasks.Size = new System.Drawing.Size(100, 32);
            this.btnTabTasks.TabIndex = 2;
            this.btnTabTasks.Text = "Tasks";
            this.btnTabTasks.UseVisualStyleBackColor = true;
            this.btnTabTasks.Click += new System.EventHandler(this.TabButton_Click);
            // 
            // btnTabDocuments
            // 
            this.btnTabDocuments.BackColor = System.Drawing.Color.Transparent;
            this.btnTabDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabDocuments.FlatAppearance.BorderSize = 0;
            this.btnTabDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabDocuments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTabDocuments.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnTabDocuments.Location = new System.Drawing.Point(338, 8);
            this.btnTabDocuments.Name = "btnTabDocuments";
            this.btnTabDocuments.Size = new System.Drawing.Size(110, 32);
            this.btnTabDocuments.TabIndex = 3;
            this.btnTabDocuments.Text = "Documents";
            this.btnTabDocuments.UseVisualStyleBackColor = true;
            this.btnTabDocuments.Click += new System.EventHandler(this.TabButton_Click);
            // 
            // btnTabBudget
            // 
            this.btnTabBudget.BackColor = System.Drawing.Color.Transparent;
            this.btnTabBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabBudget.FlatAppearance.BorderSize = 0;
            this.btnTabBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabBudget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTabBudget.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnTabBudget.Location = new System.Drawing.Point(454, 8);
            this.btnTabBudget.Name = "btnTabBudget";
            this.btnTabBudget.Size = new System.Drawing.Size(100, 32);
            this.btnTabBudget.TabIndex = 4;
            this.btnTabBudget.Text = "Budget";
            this.btnTabBudget.UseVisualStyleBackColor = true;
            this.btnTabBudget.Click += new System.EventHandler(this.TabButton_Click);
            // 
            // btnTabTeam
            // 
            this.btnTabTeam.BackColor = System.Drawing.Color.Transparent;
            this.btnTabTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabTeam.FlatAppearance.BorderSize = 0;
            this.btnTabTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTabTeam.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnTabTeam.Location = new System.Drawing.Point(560, 8);
            this.btnTabTeam.Name = "btnTabTeam";
            this.btnTabTeam.Size = new System.Drawing.Size(100, 32);
            this.btnTabTeam.TabIndex = 5;
            this.btnTabTeam.Text = "Team";
            this.btnTabTeam.UseVisualStyleBackColor = true;
            this.btnTabTeam.Click += new System.EventHandler(this.TabButton_Click);
            // 
            // btnTabAnalytics
            // 
            this.btnTabAnalytics.BackColor = System.Drawing.Color.Transparent;
            this.btnTabAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabAnalytics.FlatAppearance.BorderSize = 0;
            this.btnTabAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabAnalytics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTabAnalytics.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.btnTabAnalytics.Location = new System.Drawing.Point(666, 8);
            this.btnTabAnalytics.Name = "btnTabAnalytics";
            this.btnTabAnalytics.Size = new System.Drawing.Size(100, 32);
            this.btnTabAnalytics.TabIndex = 6;
            this.btnTabAnalytics.Text = "Analytics";
            this.btnTabAnalytics.UseVisualStyleBackColor = true;
            this.btnTabAnalytics.Click += new System.EventHandler(this.TabButton_Click);
            // 
            // pnlWorkspaceContent
            // 
            this.pnlWorkspaceContent.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlWorkspaceContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkspaceContent.Location = new System.Drawing.Point(0, 120);
            this.pnlWorkspaceContent.Name = "pnlWorkspaceContent";
            this.pnlWorkspaceContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlWorkspaceContent.Size = new System.Drawing.Size(1000, 530);
            this.pnlWorkspaceContent.TabIndex = 2;
            // 
            // ProjectWorkspaceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.pnlWorkspaceContent);
            this.Controls.Add(this.pnlTabStrip);
            this.Controls.Add(this.pnlWorkspaceHeader);
            this.Name = "ProjectWorkspaceControl";
            this.Size = new System.Drawing.Size(1000, 650);
            this.pnlWorkspaceHeader.ResumeLayout(false);
            this.pnlWorkspaceHeader.PerformLayout();
            this.pnlTabStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWorkspaceHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Panel pnlTabStrip;
        private System.Windows.Forms.Button btnTabOverview;
        private System.Windows.Forms.Button btnTabTimeline;
        private System.Windows.Forms.Button btnTabTasks;
        private System.Windows.Forms.Button btnTabDocuments;
        private System.Windows.Forms.Button btnTabBudget;
        private System.Windows.Forms.Button btnTabTeam;
        private System.Windows.Forms.Button btnTabAnalytics;
        private System.Windows.Forms.Panel pnlWorkspaceContent;
    }
}