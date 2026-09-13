namespace AluMate.Views
{
    partial class ProjectOverviewControl
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
            this.pnlKpiRow = new System.Windows.Forms.FlowLayoutPanel();
            this.cardHealth = new System.Windows.Forms.Panel();
            this.lblHealthValue = new System.Windows.Forms.Label();
            this.lblHealthTitle = new System.Windows.Forms.Label();
            this.cardProgress = new System.Windows.Forms.Panel();
            this.lblProgressValue = new System.Windows.Forms.Label();
            this.lblProgressTitle = new System.Windows.Forms.Label();
            this.cardBudget = new System.Windows.Forms.Panel();
            this.lblBudgetValue = new System.Windows.Forms.Label();
            this.lblBudgetTitle = new System.Windows.Forms.Label();
            this.cardTime = new System.Windows.Forms.Panel();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblTimeTitle = new System.Windows.Forms.Label();
            this.cardRisk = new System.Windows.Forms.Panel();
            this.lblRiskValue = new System.Windows.Forms.Label();
            this.lblRiskTitle = new System.Windows.Forms.Label();
            this.pnlChartsRow = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlChartLeft = new System.Windows.Forms.Panel();
            this.lblChartLeftTitle = new System.Windows.Forms.Label();
            this.pnlChartRight = new System.Windows.Forms.Panel();
            this.lblChartRightTitle = new System.Windows.Forms.Label();
            this.pnlKpiRow.SuspendLayout();
            this.cardHealth.SuspendLayout();
            this.cardProgress.SuspendLayout();
            this.cardBudget.SuspendLayout();
            this.cardTime.SuspendLayout();
            this.cardRisk.SuspendLayout();
            this.pnlChartsRow.SuspendLayout();
            this.pnlChartLeft.SuspendLayout();
            this.pnlChartRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKpiRow
            // 
            this.pnlKpiRow.Controls.Add(this.cardHealth);
            this.pnlKpiRow.Controls.Add(this.cardProgress);
            this.pnlKpiRow.Controls.Add(this.cardBudget);
            this.pnlKpiRow.Controls.Add(this.cardTime);
            this.pnlKpiRow.Controls.Add(this.cardRisk);
            this.pnlKpiRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpiRow.Location = new System.Drawing.Point(0, 0);
            this.pnlKpiRow.Name = "pnlKpiRow";
            this.pnlKpiRow.Size = new System.Drawing.Size(960, 105);
            this.pnlKpiRow.TabIndex = 0;
            // 
            // cardHealth
            // 
            this.cardHealth.BackColor = System.Drawing.Color.White;
            this.cardHealth.Controls.Add(this.lblHealthValue);
            this.cardHealth.Controls.Add(this.lblHealthTitle);
            this.cardHealth.Location = new System.Drawing.Point(3, 3);
            this.cardHealth.Name = "cardHealth";
            this.cardHealth.Size = new System.Drawing.Size(182, 90);
            this.cardHealth.TabIndex = 0;
            // 
            // lblHealthValue
            // 
            this.lblHealthValue.AutoSize = true;
            this.lblHealthValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHealthValue.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblHealthValue.Location = new System.Drawing.Point(15, 12);
            this.lblHealthValue.Name = "lblHealthValue";
            this.lblHealthValue.Size = new System.Drawing.Size(68, 41);
            this.lblHealthValue.TabIndex = 1;
            this.lblHealthValue.Text = "94%";
            // 
            // lblHealthTitle
            // 
            this.lblHealthTitle.AutoSize = true;
            this.lblHealthTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblHealthTitle.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.lblHealthTitle.Location = new System.Drawing.Point(15, 55);
            this.lblHealthTitle.Name = "lblHealthTitle";
            this.lblHealthTitle.Size = new System.Drawing.Size(117, 20);
            this.lblHealthTitle.TabIndex = 0;
            this.lblHealthTitle.Text = "PROJECT HEALTH";
            // 
            // cardProgress
            // 
            this.cardProgress.BackColor = System.Drawing.Color.White;
            this.cardProgress.Controls.Add(this.lblProgressValue);
            this.cardProgress.Controls.Add(this.lblProgressTitle);
            this.cardProgress.Location = new System.Drawing.Point(191, 3);
            this.cardProgress.Name = "cardProgress";
            this.cardProgress.Size = new System.Drawing.Size(182, 90);
            this.cardProgress.TabIndex = 1;
            // 
            // lblProgressValue
            // 
            this.lblProgressValue.AutoSize = true;
            this.lblProgressValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblProgressValue.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblProgressValue.Location = new System.Drawing.Point(15, 12);
            this.lblProgressValue.Name = "lblProgressValue";
            this.lblProgressValue.Size = new System.Drawing.Size(68, 41);
            this.lblProgressValue.TabIndex = 1;
            this.lblProgressValue.Text = "82%";
            // 
            // lblProgressTitle
            // 
            this.lblProgressTitle.AutoSize = true;
            this.lblProgressTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblProgressTitle.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.lblProgressTitle.Location = new System.Drawing.Point(15, 55);
            this.lblProgressTitle.Name = "lblProgressTitle";
            this.lblProgressTitle.Size = new System.Drawing.Size(83, 20);
            this.lblProgressTitle.TabIndex = 0;
            this.lblProgressTitle.Text = "PROGRESS";
            // 
            // cardBudget
            // 
            this.cardBudget.BackColor = System.Drawing.Color.White;
            this.cardBudget.Controls.Add(this.lblBudgetValue);
            this.cardBudget.Controls.Add(this.lblBudgetTitle);
            this.cardBudget.Location = new System.Drawing.Point(379, 3);
            this.cardBudget.Name = "cardBudget";
            this.cardBudget.Size = new System.Drawing.Size(182, 90);
            this.cardBudget.TabIndex = 2;
            // 
            // lblBudgetValue
            // 
            this.lblBudgetValue.AutoSize = true;
            this.lblBudgetValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBudgetValue.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblBudgetValue.Location = new System.Drawing.Point(15, 12);
            this.lblBudgetValue.Name = "lblBudgetValue";
            this.lblBudgetValue.Size = new System.Drawing.Size(68, 41);
            this.lblBudgetValue.TabIndex = 1;
            this.lblBudgetValue.Text = "73%";
            // 
            // lblBudgetTitle
            // 
            this.lblBudgetTitle.AutoSize = true;
            this.lblBudgetTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblBudgetTitle.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.lblBudgetTitle.Location = new System.Drawing.Point(15, 55);
            this.lblBudgetTitle.Name = "lblBudgetTitle";
            this.lblBudgetTitle.Size = new System.Drawing.Size(107, 20);
            this.lblBudgetTitle.TabIndex = 0;
            this.lblBudgetTitle.Text = "BUDGET USED";
            // 
            // cardTime
            // 
            this.cardTime.BackColor = System.Drawing.Color.White;
            this.cardTime.Controls.Add(this.lblTimeValue);
            this.cardTime.Controls.Add(this.lblTimeTitle);
            this.cardTime.Location = new System.Drawing.Point(567, 3);
            this.cardTime.Name = "cardTime";
            this.cardTime.Size = new System.Drawing.Size(182, 90);
            this.cardTime.TabIndex = 3;
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTimeValue.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblTimeValue.Location = new System.Drawing.Point(15, 12);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(88, 41);
            this.lblTimeValue.TabIndex = 1;
            this.lblTimeValue.Text = "48 d";
            // 
            // lblTimeTitle
            // 
            this.lblTimeTitle.AutoSize = true;
            this.lblTimeTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTimeTitle.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.lblTimeTitle.Location = new System.Drawing.Point(15, 55);
            this.lblTimeTitle.Name = "lblTimeTitle";
            this.lblTimeTitle.Size = new System.Drawing.Size(130, 20);
            this.lblTimeTitle.TabIndex = 0;
            this.lblTimeTitle.Text = "TIME REMAINING";
            // 
            // cardRisk
            // 
            this.cardRisk.BackColor = System.Drawing.Color.White;
            this.cardRisk.Controls.Add(this.lblRiskValue);
            this.cardRisk.Controls.Add(this.lblRiskTitle);
            this.cardRisk.Location = new System.Drawing.Point(755, 3);
            this.cardRisk.Name = "cardRisk";
            this.cardRisk.Size = new System.Drawing.Size(185, 90);
            this.cardRisk.TabIndex = 4;
            // 
            // lblRiskValue
            // 
            this.lblRiskValue.AutoSize = true;
            this.lblRiskValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRiskValue.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblRiskValue.Location = new System.Drawing.Point(15, 12);
            this.lblRiskValue.Name = "lblRiskValue";
            this.lblRiskValue.Size = new System.Drawing.Size(76, 41);
            this.lblRiskValue.TabIndex = 1;
            this.lblRiskValue.Text = "Low";
            // 
            // lblRiskTitle
            // 
            this.lblRiskTitle.AutoSize = true;
            this.lblRiskTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRiskTitle.ForeColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.lblRiskTitle.Location = new System.Drawing.Point(15, 55);
            this.lblRiskTitle.Name = "lblRiskTitle";
            this.lblRiskTitle.Size = new System.Drawing.Size(91, 20);
            this.lblRiskTitle.TabIndex = 0;
            this.lblRiskTitle.Text = "RISK LEVEL";
            // 
            // pnlChartsRow
            // 
            this.pnlChartsRow.Controls.Add(this.pnlChartLeft);
            this.pnlChartsRow.Controls.Add(this.pnlChartRight);
            this.pnlChartsRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartsRow.Location = new System.Drawing.Point(0, 105);
            this.pnlChartsRow.Name = "pnlChartsRow";
            this.pnlChartsRow.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.pnlChartsRow.Size = new System.Drawing.Size(960, 315);
            this.pnlChartsRow.TabIndex = 1;
            // 
            // pnlChartLeft
            // 
            this.pnlChartLeft.BackColor = System.Drawing.Color.White;
            this.pnlChartLeft.Controls.Add(this.lblChartLeftTitle);
            this.pnlChartLeft.Location = new System.Drawing.Point(3, 18);
            this.pnlChartLeft.Name = "pnlChartLeft";
            this.pnlChartLeft.Size = new System.Drawing.Size(470, 280);
            this.pnlChartLeft.TabIndex = 0;
            // 
            // lblChartLeftTitle
            // 
            this.lblChartLeftTitle.AutoSize = true;
            this.lblChartLeftTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChartLeftTitle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblChartLeftTitle.Location = new System.Drawing.Point(20, 20);
            this.lblChartLeftTitle.Name = "lblChartLeftTitle";
            this.lblChartLeftTitle.Size = new System.Drawing.Size(217, 25);
            this.lblChartLeftTitle.TabIndex = 0;
            this.lblChartLeftTitle.Text = "Task Completion Trends";
            // 
            // pnlChartRight
            // 
            this.pnlChartRight.BackColor = System.Drawing.Color.White;
            this.pnlChartRight.Controls.Add(this.lblChartRightTitle);
            this.pnlChartRight.Location = new System.Drawing.Point(479, 18);
            this.pnlChartRight.Name = "pnlChartRight";
            this.pnlChartRight.Size = new System.Drawing.Size(470, 280);
            this.pnlChartRight.TabIndex = 1;
            // 
            // lblChartRightTitle
            // 
            this.lblChartRightTitle.AutoSize = true;
            this.lblChartRightTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChartRightTitle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblChartRightTitle.Location = new System.Drawing.Point(20, 20);
            this.lblChartRightTitle.Name = "lblChartRightTitle";
            this.lblChartRightTitle.Size = new System.Drawing.Size(201, 25);
            this.lblChartRightTitle.TabIndex = 0;
            this.lblChartRightTitle.Text = "Budget vs Actual Cost";
            // 
            // ProjectOverviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.pnlChartsRow);
            this.Controls.Add(this.pnlKpiRow);
            this.Name = "ProjectOverviewControl";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(960, 420);
            this.pnlKpiRow.ResumeLayout(false);
            this.cardHealth.ResumeLayout(false);
            this.cardHealth.PerformLayout();
            this.cardProgress.ResumeLayout(false);
            this.cardProgress.PerformLayout();
            this.cardBudget.ResumeLayout(false);
            this.cardBudget.PerformLayout();
            this.cardTime.ResumeLayout(false);
            this.cardTime.PerformLayout();
            this.cardRisk.ResumeLayout(false);
            this.cardRisk.PerformLayout();
            this.pnlChartsRow.ResumeLayout(false);
            this.pnlChartLeft.ResumeLayout(false);
            this.pnlChartLeft.PerformLayout();
            this.pnlChartRight.ResumeLayout(false);
            this.pnlChartRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlKpiRow;
        private System.Windows.Forms.Panel cardHealth;
        private System.Windows.Forms.Label lblHealthValue;
        private System.Windows.Forms.Label lblHealthTitle;
        private System.Windows.Forms.Panel cardProgress;
        private System.Windows.Forms.Label lblProgressValue;
        private System.Windows.Forms.Label lblProgressTitle;
        private System.Windows.Forms.Panel cardBudget;
        private System.Windows.Forms.Label lblBudgetValue;
        private System.Windows.Forms.Label lblBudgetTitle;
        private System.Windows.Forms.Panel cardTime;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblTimeTitle;
        private System.Windows.Forms.Panel cardRisk;
        private System.Windows.Forms.Label lblRiskValue;
        private System.Windows.Forms.Label lblRiskTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlChartsRow;
        private System.Windows.Forms.Panel pnlChartLeft;
        private System.Windows.Forms.Label lblChartLeftTitle;
        private System.Windows.Forms.Panel pnlChartRight;
        private System.Windows.Forms.Label lblChartRightTitle;
    }
}