using System.Net.Http.Json;
using AluMate.Models;

namespace AluMate.Services;

public class ProjectItemService
{
    public async Task<List<ProjectItemResponse>> GetByProjectAsync(
        int projectId)
    {
        return await ApiClient.Client
            .GetFromJsonAsync<List<ProjectItemResponse>>(
                $"project-items/project/{projectId}")
            ?? [];
    }
}