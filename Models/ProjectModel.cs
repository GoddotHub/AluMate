namespace AluMate.Models
{
    public class ProjectModel
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public string? customer_name { get; set; } // Add this for company names
        public string name { get; set; } = string.Empty;
        public string? description { get; set; }
        public string? location { get; set; }
        public string status { get; set; } = string.Empty;
        public decimal? quoted_price { get; set; } // Add this to fix the C# build errors
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}