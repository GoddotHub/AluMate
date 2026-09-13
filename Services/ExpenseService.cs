using System.Net.Http.Json;
using AluMate.Models;

namespace AluMate.Services;

public class ProjectExpenseService
{
    public async Task<List<ProjectExpenseResponse>> GetByProjectAsync(
        int projectId)
    {
        return await ApiClient.Client
            .GetFromJsonAsync<List<ProjectExpenseResponse>>(
                $"project-expenses/project/{projectId}")
            ?? [];
    }
}