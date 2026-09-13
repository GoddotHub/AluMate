using System;
using System.Net.Http;

namespace AluMate.Services;

public static class ApiClient
{
    public static HttpClient Client { get; } = new()
    {
        BaseAddress = new Uri("http://127.0.0.1:8000/")
    };
}