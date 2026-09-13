using System;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluMate.Views
{
    public partial class ProjectsControl : UserControl
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("http://127.0.0.1:8000") };

        public ProjectsControl()
        {
            InitializeComponent();
            ConfigureGridStyling();
            _ = LoadProjectsDataAsync();
        }

        private void ConfigureGridStyling()
        {
            dataGridViewProjects.BorderStyle = BorderStyle.None;
            dataGridViewProjects.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewProjects.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewProjects.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewProjects.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewProjects.BackgroundColor = Color.White;
            dataGridViewProjects.EnableHeadersVisualStyles = false;
            dataGridViewProjects.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewProjects.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewProjects.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewProjects.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task LoadProjectsDataAsync()
        {
            try
            {
                // Calls your backend projects endpoint
                HttpResponseMessage response = await client.GetAsync("/projects/");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    // Bind data or parse into your DataGridView rows here
                }
            }
            catch (Exception)
            {
                // Fallback mock rows for visual preview if API is offline
                dataGridViewProjects.Rows.Clear();
                dataGridViewProjects.Rows.Add("1", "Commercial High-Rise Windows", "Active");
                dataGridViewProjects.Rows.Add("2", "Aluminium Storefront Retrofit", "Pending");
            }
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open New Project dialog.", "AluMate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}