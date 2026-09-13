using System.Net.Http.Json;
using AluMate.Models;

namespace AluMate.Services;

public class QuotationService
{
    public async Task<List<QuotationResponse>> GetByProjectAsync(
        int projectId)
    {
        return await ApiClient.Client
            .GetFromJsonAsync<List<QuotationResponse>>(
                $"quotations/project/{projectId}")
            ?? [];
    }
}