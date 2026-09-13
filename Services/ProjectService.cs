using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AluMate.Models;

namespace AluMate.Services
{
    public class ProjectService
    {
        // Use a shared or unified client configuration pointing to the backend
        private readonly HttpClient _client = ApiClient.Client ?? new HttpClient { BaseAddress = new Uri("http://127.0.0.1:8000/") };

        public async Task<List<ProjectModel>> GetProjectsAsync()
        {
            try
            {
                return await _client.GetFromJsonAsync<List<ProjectModel>>("projects") ?? new List<ProjectModel>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading projects: {ex.Message}");
                return new List<ProjectModel>();
            }
        }

        public async Task<ProjectSummaryResponse?> GetSummaryAsync(int projectId)
        {
            try
            {
                return await _client.GetFromJsonAsync<ProjectSummaryResponse>($"projects/{projectId}/summary");
            }
            catch
            {
                return null;
            }
        }

        public async Task<ProjectDashboardResponse?> GetDashboardAsync(int projectId)
        {
            try
            {
                return await _client.GetFromJsonAsync<ProjectDashboardResponse>($"projects/{projectId}/dashboard");
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<ProjectProgressResponse>> GetProgressAsync(int projectId)
        {
            try
            {
                return await _client.GetFromJsonAsync<List<ProjectProgressResponse>>($"projects/{projectId}/progress") ?? new List<ProjectProgressResponse>();
            }
            catch
            {
                return new List<ProjectProgressResponse>();
            }
        }

        public async Task<bool> AddProgressAsync(int projectId, ProjectProgressCreateRequest request)
        {
            try
            {
                var response = await _client.PostAsJsonAsync($"projects/{projectId}/progress", request);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}