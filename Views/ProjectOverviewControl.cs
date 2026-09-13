using System.Windows.Forms;
using AluMate.Models;

namespace AluMate.Views
{
    public partial class ProjectOverviewControl : UserControl
    {
        private readonly ProjectModel _project;

        public ProjectOverviewControl(ProjectModel project)
        {
            _project = project;
            InitializeComponent();
        }
    }
}