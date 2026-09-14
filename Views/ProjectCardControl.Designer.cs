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
            this.lblCategoryType = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.lblName.Location = new System.Drawing.Point(18, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(264, 35);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "OFFICE RENOVATION";
            // 
            // lblCategoryType
            // 
            this.lblCategoryType.AutoSize = true;
            this.lblCategoryType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCategoryType.ForeColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.lblCategoryType.Location = new System.Drawing.Point(20, 52);
            this.lblCategoryType.Name = "lblCategoryType";
            this.lblCategoryType.Size = new System.Drawing.Size(161, 21);
            this.lblCategoryType.TabIndex = 1;
            this.lblCategoryType.Text = "🏢 Commercial Interior";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.lblCustomerName.Location = new System.Drawing.Point(20, 85);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(260, 25);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "ABC Manufacturing Ltd";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(16, 124, 65);
            this.lblStatus.Location = new System.Drawing.Point(20, 130);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 21);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "🟢 Active";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCreatedDate.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCreatedDate.Location = new System.Drawing.Point(20, 185);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(142, 20);
            this.lblCreatedDate.TabIndex = 4;
            this.lblCreatedDate.Text = "Created: 09 Sept 2026";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(20, 235);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(260, 38);
            this.btnOpen.TabIndex = 5;
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
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCategoryType);
            this.Controls.Add(this.lblName);
            this.Name = "ProjectCardControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategoryType;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Button btnOpen;
    }
}