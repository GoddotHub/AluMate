namespace AluMate.Views
{
    partial class ProjectsMainViewControl
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
            this.pnlTopStats = new System.Windows.Forms.Panel();
            this.lblStatsTitle = new System.Windows.Forms.Label();
            this.pnlFilterBar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFilterAll = new System.Windows.Forms.Button();
            this.btnFilterActive = new System.Windows.Forms.Button();
            this.btnFilterDelayed = new System.Windows.Forms.Button();
            this.flowProjectGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopStats.SuspendLayout();
            this.pnlFilterBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopStats
            // 
            this.pnlTopStats.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlTopStats.Controls.Add(this.lblStatsTitle);
            this.pnlTopStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopStats.Location = new System.Drawing.Point(20, 20);
            this.pnlTopStats.Name = "pnlTopStats";
            this.pnlTopStats.Size = new System.Drawing.Size(1020, 90);
            this.pnlTopStats.TabIndex = 0;
            // 
            // lblStatsTitle
            // 
            this.lblStatsTitle.AutoSize = true;
            this.lblStatsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatsTitle.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.lblStatsTitle.Location = new System.Drawing.Point(20, 15);
            this.lblStatsTitle.Name = "lblStatsTitle";
            this.lblStatsTitle.Size = new System.Drawing.Size(206, 28);
            this.lblStatsTitle.TabIndex = 0;
            this.lblStatsTitle.Text = "Dashboard Statistics";
            // 
            // pnlFilterBar
            // 
            this.pnlFilterBar.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.pnlFilterBar.Controls.Add(this.txtSearch);
            this.pnlFilterBar.Controls.Add(this.btnFilterAll);
            this.pnlFilterBar.Controls.Add(this.btnFilterActive);
            this.pnlFilterBar.Controls.Add(this.btnFilterDelayed);
            this.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterBar.Location = new System.Drawing.Point(20, 110);
            this.pnlFilterBar.Name = "pnlFilterBar";
            this.pnlFilterBar.Size = new System.Drawing.Size(1020, 70);
            this.pnlFilterBar.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.txtSearch.Location = new System.Drawing.Point(20, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "🔍 Search projects...";
            // 
            // btnFilterAll
            // 
            this.btnFilterAll.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnFilterAll.FlatAppearance.BorderSize = 0;
            this.btnFilterAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterAll.ForeColor = System.Drawing.Color.White;
            this.btnFilterAll.Location = new System.Drawing.Point(340, 18);
            this.btnFilterAll.Name = "btnFilterAll";
            this.btnFilterAll.Size = new System.Drawing.Size(90, 30);
            this.btnFilterAll.TabIndex = 1;
            this.btnFilterAll.Text = "All (6)";
            this.btnFilterAll.UseVisualStyleBackColor = false;
            // 
            // btnFilterActive
            // 
            this.btnFilterActive.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnFilterActive.FlatAppearance.BorderSize = 0;
            this.btnFilterActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterActive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilterActive.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.btnFilterActive.Location = new System.Drawing.Point(440, 18);
            this.btnFilterActive.Name = "btnFilterActive";
            this.btnFilterActive.Size = new System.Drawing.Size(100, 30);
            this.btnFilterActive.TabIndex = 2;
            this.btnFilterActive.Text = "Active (5)";
            this.btnFilterActive.UseVisualStyleBackColor = false;
            // 
            // btnFilterDelayed
            // 
            this.btnFilterDelayed.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.btnFilterDelayed.FlatAppearance.BorderSize = 0;
            this.btnFilterDelayed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterDelayed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilterDelayed.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.btnFilterDelayed.Location = new System.Drawing.Point(550, 18);
            this.btnFilterDelayed.Name = "btnFilterDelayed";
            this.btnFilterDelayed.Size = new System.Drawing.Size(110, 30);
            this.btnFilterDelayed.TabIndex = 3;
            this.btnFilterDelayed.Text = "At Risk (1)";
            this.btnFilterDelayed.UseVisualStyleBackColor = false;
            // 
            // flowProjectGrid
            // 
            this.flowProjectGrid.AutoScroll = true;
            this.flowProjectGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowProjectGrid.Location = new System.Drawing.Point(20, 180);
            this.flowProjectGrid.Name = "flowProjectGrid";
            this.flowProjectGrid.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowProjectGrid.Size = new System.Drawing.Size(1020, 500);
            this.flowProjectGrid.TabIndex = 2;
            // 
            // ProjectsMainViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.Controls.Add(this.flowProjectGrid);
            this.Controls.Add(this.pnlFilterBar);
            this.Controls.Add(this.pnlTopStats);
            this.Name = "ProjectsMainViewControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1060, 700);
            this.pnlTopStats.ResumeLayout(false);
            this.pnlTopStats.PerformLayout();
            this.pnlFilterBar.ResumeLayout(false);
            this.pnlFilterBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopStats;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.Panel pnlFilterBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFilterAll;
        private System.Windows.Forms.Button btnFilterActive;
        private System.Windows.Forms.Button btnFilterDelayed;
        private System.Windows.Forms.FlowLayoutPanel flowProjectGrid;
    }
}