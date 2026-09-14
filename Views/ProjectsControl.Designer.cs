namespace AluMate.Views
{
    partial class ProjectsControl
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFilterAll = new System.Windows.Forms.Button();
            this.btnFilterActive = new System.Windows.Forms.Button();
            this.btnFilterPlanning = new System.Windows.Forms.Button();
            this.btnFilterCompleted = new System.Windows.Forms.Button();
            this.btnFilterDelayed = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.cmbSortBy);
            this.pnlHeader.Controls.Add(this.lblSortBy);
            this.pnlHeader.Controls.Add(this.pnlFilters);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.btnNewProject);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 120);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 12);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(225, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Dashboard";
            // 
            // btnNewProject
            // 
            this.btnNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewProject.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnNewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewProject.FlatAppearance.BorderSize = 0;
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.ForeColor = System.Drawing.Color.White;
            this.btnNewProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewProject.Location = new System.Drawing.Point(830, 15);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(150, 35);
            this.btnNewProject.TabIndex = 1;
            this.btnNewProject.Text = "+ New Project";
            this.btnNewProject.UseVisualStyleBackColor = false;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(20, 68);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.btnFilterAll);
            this.pnlFilters.Controls.Add(this.btnFilterActive);
            this.pnlFilters.Controls.Add(this.btnFilterPlanning);
            this.pnlFilters.Controls.Add(this.btnFilterCompleted);
            this.pnlFilters.Controls.Add(this.btnFilterDelayed);
            this.pnlFilters.Location = new System.Drawing.Point(290, 65);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(400, 40);
            this.pnlFilters.TabIndex = 3;
            // 
            // btnFilterAll
            // 
            this.btnFilterAll.BackColor = System.Drawing.Color.FromArgb(220, 235, 252);
            this.btnFilterAll.FlatAppearance.BorderSize = 0;
            this.btnFilterAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterAll.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnFilterAll.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnFilterAll.Location = new System.Drawing.Point(3, 3);
            this.btnFilterAll.Name = "btnFilterAll";
            this.btnFilterAll.Size = new System.Drawing.Size(65, 30);
            this.btnFilterAll.TabIndex = 0;
            this.btnFilterAll.Text = "All";
            this.btnFilterAll.UseVisualStyleBackColor = false;
            this.btnFilterAll.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // btnFilterActive
            // 
            this.btnFilterActive.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnFilterActive.FlatAppearance.BorderSize = 0;
            this.btnFilterActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterActive.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnFilterActive.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnFilterActive.Location = new System.Drawing.Point(74, 3);
            this.btnFilterActive.Name = "btnFilterActive";
            this.btnFilterActive.Size = new System.Drawing.Size(75, 30);
            this.btnFilterActive.TabIndex = 1;
            this.btnFilterActive.Text = "Active";
            this.btnFilterActive.UseVisualStyleBackColor = false;
            this.btnFilterActive.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // btnFilterPlanning
            // 
            this.btnFilterPlanning.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnFilterPlanning.FlatAppearance.BorderSize = 0;
            this.btnFilterPlanning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterPlanning.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnFilterPlanning.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnFilterPlanning.Location = new System.Drawing.Point(155, 3);
            this.btnFilterPlanning.Name = "btnFilterPlanning";
            this.btnFilterPlanning.Size = new System.Drawing.Size(85, 30);
            this.btnFilterPlanning.TabIndex = 2;
            this.btnFilterPlanning.Text = "Planning";
            this.btnFilterPlanning.UseVisualStyleBackColor = false;
            this.btnFilterPlanning.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // btnFilterCompleted
            // 
            this.btnFilterCompleted.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnFilterCompleted.FlatAppearance.BorderSize = 0;
            this.btnFilterCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterCompleted.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnFilterCompleted.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnFilterCompleted.Location = new System.Drawing.Point(246, 3);
            this.btnFilterCompleted.Name = "btnFilterCompleted";
            this.btnFilterCompleted.Size = new System.Drawing.Size(95, 30);
            this.btnFilterCompleted.TabIndex = 3;
            this.btnFilterCompleted.Text = "Completed";
            this.btnFilterCompleted.UseVisualStyleBackColor = false;
            this.btnFilterCompleted.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // btnFilterDelayed
            // 
            this.btnFilterDelayed.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnFilterDelayed.FlatAppearance.BorderSize = 0;
            this.btnFilterDelayed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterDelayed.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnFilterDelayed.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnFilterDelayed.Location = new System.Drawing.Point(3, 39);
            this.btnFilterDelayed.Name = "btnFilterDelayed";
            this.btnFilterDelayed.Size = new System.Drawing.Size(80, 30);
            this.btnFilterDelayed.TabIndex = 4;
            this.btnFilterDelayed.Text = "Delayed";
            this.btnFilterDelayed.UseVisualStyleBackColor = false;
            this.btnFilterDelayed.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // lblSortBy
            // 
            this.lblSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSortBy.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblSortBy.Location = new System.Drawing.Point(720, 71);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(65, 20);
            this.lblSortBy.TabIndex = 4;
            this.lblSortBy.Text = "Sort By:";
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortBy.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Items.AddRange(new object[] {
            "Recent",
            "Progress",
            "Deadline",
            "Budget"});
            this.cmbSortBy.Location = new System.Drawing.Point(791, 68);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(190, 29);
            this.cmbSortBy.TabIndex = 5;
            this.cmbSortBy.SelectedIndexChanged += new System.EventHandler(this.cmbSortBy_SelectedIndexChanged);
            // 
            // flowLayoutPanelCards
            // 
            this.flowLayoutPanelCards.AutoScroll = true;
            this.flowLayoutPanelCards.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.flowLayoutPanelCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(0, 120);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(1000, 530);
            this.flowLayoutPanelCards.TabIndex = 1;
            // 
            // ProjectsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.Add(this.flowLayoutPanelCards);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ProjectsControl";
            this.Size = new System.Drawing.Size(1000, 650);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel pnlFilters;
        private System.Windows.Forms.Button btnFilterAll;
        private System.Windows.Forms.Button btnFilterActive;
        private System.Windows.Forms.Button btnFilterPlanning;
        private System.Windows.Forms.Button btnFilterCompleted;
        private System.Windows.Forms.Button btnFilterDelayed;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
    }
}