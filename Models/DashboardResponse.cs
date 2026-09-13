namespace AluMate.Models;

public class DashboardResponse
{
    public int TotalCustomers { get; set; }

    public int TotalProjects { get; set; }

    public int TotalQuotations { get; set; }

    public int ActiveProjects { get; set; }

    public decimal TotalRevenuePotential { get; set; }
}