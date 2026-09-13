using System.Net.Http.Json;
using AluMate.Models;

namespace AluMate.Services;

public class CustomerService
{
    public async Task<List<CustomerResponse>> GetCustomersAsync()
    {
        return await ApiClient.Client
            .GetFromJsonAsync<List<CustomerResponse>>(
                "customers/")
            ?? [];
    }
}