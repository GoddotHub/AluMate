using System.Net.Http.Json;
using AluMate.Models;

namespace AluMate.Services;

public class DashboardService
{
    public async Task<DashboardResponse?> GetDashboardAsync()
    {
        return await ApiClient.Client.GetFromJsonAsync<DashboardResponse>(
            "dashboard/"
        );
    }
}
