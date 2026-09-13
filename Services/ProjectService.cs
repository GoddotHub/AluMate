using System.Net.Http.Json;
using AluMate.Models;

namespace AluMate.Services;

public class ProjectService
{
    public async Task<ProjectSummaryResponse?> GetSummaryAsync(int projectId)
    {
        return await ApiClient.Client
            .GetFromJsonAsync<ProjectSummaryResponse>(
                $"projects/{projectId}/summary");
    }

    public async Task<ProjectDashboardResponse?> GetDashboardAsync(int projectId)
    {
        return await ApiClient.Client
            .GetFromJsonAsync<ProjectDashboardResponse>(
                $"projects/{projectId}/dashboard");
    }
}