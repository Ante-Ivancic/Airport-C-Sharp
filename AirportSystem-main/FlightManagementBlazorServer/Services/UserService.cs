﻿using DomainModel.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Services
{
    public class UserService
    {
        private readonly string BaseApiUrl = "https://localhost:44334/api/User";
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>(BaseApiUrl);
        }
        public async Task AddUserAsync(User user)
        {
            var httpPostRequest = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            httpPostRequest.Content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8,
            "application/json");
            await _httpClient.SendAsync(httpPostRequest);
        }

    }
}
