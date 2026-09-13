namespace AluMate.Views
{
    partial class ProjectCardControl
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblProjectId = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCreatedTitle = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(260, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "OFFICE RENOVATION";
            // 
            // lblProjectId
            // 
            this.lblProjectId.AutoSize = true;
            this.lblProjectId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblProjectId.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.lblProjectId.Location = new System.Drawing.Point(22, 50);
            this.lblProjectId.Name = "lblProjectId";
            this.lblProjectId.Size = new System.Drawing.Size(89, 20);
            this.lblProjectId.TabIndex = 1;
            this.lblProjectId.Text = "Project #001";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblCustomerId.Location = new System.Drawing.Point(20, 95);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(110, 21);
            this.lblCustomerId.TabIndex = 2;
            this.lblCustomerId.Text = "Customer ID: 1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(16, 124, 65);
            this.lblStatus.Location = new System.Drawing.Point(20, 140);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 21);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "🟢 Active";
            // 
            // lblCreatedTitle
            // 
            this.lblCreatedTitle.AutoSize = true;
            this.lblCreatedTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCreatedTitle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCreatedTitle.Location = new System.Drawing.Point(20, 185);
            this.lblCreatedTitle.Name = "lblCreatedTitle";
            this.lblCreatedTitle.Size = new System.Drawing.Size(71, 19);
            this.lblCreatedTitle.TabIndex = 4;
            this.lblCreatedTitle.Text = "CREATED";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCreatedDate.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblCreatedDate.Location = new System.Drawing.Point(20, 205);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(103, 21);
            this.lblCreatedDate.TabIndex = 5;
            this.lblCreatedDate.Text = "09 Sept 2026";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(20, 245);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(260, 35);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open Workspace";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ProjectCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.lblCreatedTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblProjectId);
            this.Controls.Add(this.lblName);
            this.Name = "ProjectCardControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProjectId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCreatedTitle;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Button btnOpen;
    }
}