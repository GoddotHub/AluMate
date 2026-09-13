namespace AluMate.Models
{
    public class ProjectProgressResponse
    {
        public int id { get; set; }
        public int project_id { get; set; }
        public string milestone_name { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public int completion_percentage { get; set; }
        public string notes { get; set; } = string.Empty;
        public string updated_at { get; set; } = string.Empty;
    }

    public class ProjectProgressCreateRequest
    {
        public string milestone_name { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public int completion_percentage { get; set; }
        public string notes { get; set; } = string.Empty;
    }
}