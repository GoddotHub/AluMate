using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AluMate.Models;

namespace AluMate.Views
{
    public partial class ProjectsMainViewControl : UserControl
    {
        public event EventHandler<ProjectModel>? ProjectSelected;

        public ProjectsMainViewControl(List<ProjectModel> projects)
        {
            InitializeComponent();
            PopulateProjectGrid(projects);
        }

        public void PopulateProjectGrid(List<ProjectModel> projects)
        {
            flowProjectGrid.Controls.Clear();

            foreach (var proj in projects)
            {
                var card = new ProjectCardControl(proj);
                card.Margin = new Padding(0, 0, 15, 20);
                card.OpenProjectClicked += (s, e) => ProjectSelected?.Invoke(this, proj);
                flowProjectGrid.Controls.Add(card);
            }
        }
    }
}