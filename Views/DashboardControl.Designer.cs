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
            this.pnlKpiContainer = new System.Windows.Forms.Panel();
            this.cardTotal = new System.Windows.Forms.Panel();
            this.accentTotal = new System.Windows.Forms.Panel();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.cardActive = new System.Windows.Forms.Panel();
            this.accentActive = new System.Windows.Forms.Panel();
            this.lblActiveValue = new System.Windows.Forms.Label();
            this.lblActiveTitle = new System.Windows.Forms.Label();
            this.cardSuccess = new System.Windows.Forms.Panel();
            this.accentSuccess = new System.Windows.Forms.Panel();
            this.lblSuccessValue = new System.Windows.Forms.Label();
            this.lblSuccessTitle = new System.Windows.Forms.Label();
            this.cardDelayed = new System.Windows.Forms.Panel();
            this.accentDelayed = new System.Windows.Forms.Panel();
            this.lblDelayedValue = new System.Windows.Forms.Label();
            this.lblDelayedTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlKpiContainer.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.cardActive.SuspendLayout();
            this.cardSuccess.SuspendLayout();
            this.cardDelayed.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKpiContainer
            // 
            this.pnlKpiContainer.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlKpiContainer.Controls.Add(this.cardDelayed);
            this.pnlKpiContainer.Controls.Add(this.cardSuccess);
            this.pnlKpiContainer.Controls.Add(this.cardActive);
            this.pnlKpiContainer.Controls.Add(this.cardTotal);
            this.pnlKpiContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpiContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlKpiContainer.Name = "pnlKpiContainer";
            this.pnlKpiContainer.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.pnlKpiContainer.Size = new System.Drawing.Size(1000, 110);
            this.pnlKpiContainer.TabIndex = 0;
            // 
            // cardTotal
            // 
            this.cardTotal.BackColor = System.Drawing.Color.White;
            this.cardTotal.Controls.Add(this.lblTotalTitle);
            this.cardTotal.Controls.Add(this.lblTotalValue);
            this.cardTotal.Controls.Add(this.accentTotal);
            this.cardTotal.Location = new System.Drawing.Point(20, 15);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.Size = new System.Drawing.Size(210, 80);
            this.cardTotal.TabIndex = 0;
            // 
            // accentTotal
            // 
            this.accentTotal.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.accentTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentTotal.Location = new System.Drawing.Point(0, 0);
            this.accentTotal.Name = "accentTotal";
            this.accentTotal.Size = new System.Drawing.Size(5, 80);
            this.accentTotal.TabIndex = 0;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblTotalValue.Location = new System.Drawing.Point(20, 10);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(64, 46);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "124";
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.lblTotalTitle.Location = new System.Drawing.Point(20, 50);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(117, 20);
            this.lblTotalTitle.TabIndex = 2;
            this.lblTotalTitle.Text = "TOTAL PROJECTS";
            // 
            // cardActive
            // 
            this.cardActive.BackColor = System.Drawing.Color.White;
            this.cardActive.Controls.Add(this.lblActiveTitle);
            this.cardActive.Controls.Add(this.lblActiveValue);
            this.cardActive.Controls.Add(this.accentActive);
            this.cardActive.Location = new System.Drawing.Point(250, 15);
            this.cardActive.Name = "cardActive";
            this.cardActive.Size = new System.Drawing.Size(210, 80);
            this.cardActive.TabIndex = 1;
            // 
            // accentActive
            // 
            this.accentActive.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.accentActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentActive.Location = new System.Drawing.Point(0, 0);
            this.accentActive.Name = "accentActive";
            this.accentActive.Size = new System.Drawing.Size(5, 80);
            this.accentActive.TabIndex = 0;
            // 
            // lblActiveValue
            // 
            this.lblActiveValue.AutoSize = true;
            this.lblActiveValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblActiveValue.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblActiveValue.Location = new System.Drawing.Point(20, 10);
            this.lblActiveValue.Name = "lblActiveValue";
            this.lblActiveValue.Size = new System.Drawing.Size(48, 46);
            this.lblActiveValue.TabIndex = 1;
            this.lblActiveValue.Text = "85";
            // 
            // lblActiveTitle
            // 
            this.lblActiveTitle.AutoSize = true;
            this.lblActiveTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblActiveTitle.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.lblActiveTitle.Location = new System.Drawing.Point(20, 50);
            this.lblActiveTitle.Name = "lblActiveTitle";
            this.lblActiveTitle.Size = new System.Drawing.Size(126, 20);
            this.lblActiveTitle.TabIndex = 2;
            this.lblActiveTitle.Text = "ACTIVE PROJECTS";
            // 
            // cardSuccess
            // 
            this.cardSuccess.BackColor = System.Drawing.Color.White;
            this.cardSuccess.Controls.Add(this.lblSuccessTitle);
            this.cardSuccess.Controls.Add(this.lblSuccessValue);
            this.cardSuccess.Controls.Add(this.accentSuccess);
            this.cardSuccess.Location = new System.Drawing.Point(480, 15);
            this.cardSuccess.Name = "cardSuccess";
            this.cardSuccess.Size = new System.Drawing.Size(210, 80);
            this.cardSuccess.TabIndex = 2;
            // 
            // accentSuccess
            // 
            this.accentSuccess.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.accentSuccess.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentSuccess.Location = new System.Drawing.Point(0, 0);
            this.accentSuccess.Name = "accentSuccess";
            this.accentSuccess.Size = new System.Drawing.Size(5, 80);
            this.accentSuccess.TabIndex = 0;
            // 
            // lblSuccessValue
            // 
            this.lblSuccessValue.AutoSize = true;
            this.lblSuccessValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSuccessValue.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblSuccessValue.Location = new System.Drawing.Point(20, 10);
            this.lblSuccessValue.Name = "lblSuccessValue";
            this.lblSuccessValue.Size = new System.Drawing.Size(65, 46);
            this.lblSuccessValue.TabIndex = 1;
            this.lblSuccessValue.Text = "92%";
            // 
            // lblSuccessTitle
            // 
            this.lblSuccessTitle.AutoSize = true;
            this.lblSuccessTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSuccessTitle.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.lblSuccessTitle.Location = new System.Drawing.Point(20, 50);
            this.lblSuccessTitle.Name = "lblSuccessTitle";
            this.lblSuccessTitle.Size = new System.Drawing.Size(109, 20);
            this.lblSuccessTitle.TabIndex = 2;
            this.lblSuccessTitle.Text = "SUCCESS RATE";
            // 
            // cardDelayed
            // 
            this.cardDelayed.BackColor = System.Drawing.Color.White;
            this.cardDelayed.Controls.Add(this.lblDelayedTitle);
            this.cardDelayed.Controls.Add(this.lblDelayedValue);
            this.cardDelayed.Controls.Add(this.accentDelayed);
            this.cardDelayed.Location = new System.Drawing.Point(710, 15);
            this.cardDelayed.Name = "cardDelayed";
            this.cardDelayed.Size = new System.Drawing.Size(210, 80);
            this.cardDelayed.TabIndex = 3;
            // 
            // accentDelayed
            // 
            this.accentDelayed.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.accentDelayed.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentDelayed.Location = new System.Drawing.Point(0, 0);
            this.accentDelayed.Name = "accentDelayed";
            this.accentDelayed.Size = new System.Drawing.Size(5, 80);
            this.accentDelayed.TabIndex = 0;
            // 
            // lblDelayedValue
            // 
            this.lblDelayedValue.AutoSize = true;
            this.lblDelayedValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDelayedValue.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblDelayedValue.Location = new System.Drawing.Point(20, 10);
            this.lblDelayedValue.Name = "lblDelayedValue";
            this.lblDelayedValue.Size = new System.Drawing.Size(48, 46);
            this.lblDelayedValue.TabIndex = 1;
            this.lblDelayedValue.Text = "12";
            // 
            // lblDelayedTitle
            // 
            this.lblDelayedTitle.AutoSize = true;
            this.lblDelayedTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDelayedTitle.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.lblDelayedTitle.Location = new System.Drawing.Point(20, 50);
            this.lblDelayedTitle.Name = "lblDelayedTitle";
            this.lblDelayedTitle.Size = new System.Drawing.Size(141, 20);
            this.lblDelayedTitle.TabIndex = 2;
            this.lblDelayedTitle.Text = "DELAYED PROJECTS";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(840, 130);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.pnlKpiContainer);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1000, 650);
            this.pnlKpiContainer.ResumeLayout(false);
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.cardActive.ResumeLayout(false);
            this.cardActive.PerformLayout();
            this.cardSuccess.ResumeLayout(false);
            this.cardSuccess.PerformLayout();
            this.cardDelayed.ResumeLayout(false);
            this.cardDelayed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKpiContainer;
        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Panel accentTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Panel cardActive;
        private System.Windows.Forms.Panel accentActive;
        private System.Windows.Forms.Label lblActiveValue;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Panel cardSuccess;
        private System.Windows.Forms.Panel accentSuccess;
        private System.Windows.Forms.Label lblSuccessValue;
        private System.Windows.Forms.Label lblSuccessTitle;
        private System.Windows.Forms.Panel cardDelayed;
        private System.Windows.Forms.Panel accentDelayed;
        private System.Windows.Forms.Label lblDelayedValue;
        private System.Windows.Forms.Label lblDelayedTitle;
        private System.Windows.Forms.Button btnRefresh;
    }
}