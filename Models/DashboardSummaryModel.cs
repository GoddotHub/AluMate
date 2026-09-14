namespace AluMate.Models
{
    public class DashboardSummaryModel
    {
        public int total_customers { get; set; }
        public int total_projects { get; set; }
        public int total_quotations { get; set; }
        public int active_projects { get; set; }
        public decimal total_revenue_potential { get; set; }
    }
}