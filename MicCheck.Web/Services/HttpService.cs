using MicCheck.Shared.Models;
using MicCheck.Web.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MicCheck.Web.Services
{
    public class HttpService : IHttpService
    {
        private HttpClient _httpClient;

        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        public HttpService(HttpClient httpClient, NavigationManager navigationManager, ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
            _navigationManager = navigationManager;
            _httpClient = httpClient;
        }

        public async Task<T> Get<T>(string url)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
            return await sendRequest<T>(request);
        }

        public async Task<T> Post<T>(string url, object value)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return await sendRequest<T>(request);
        }

        private async Task<T> sendRequest<T>(HttpRequestMessage request)
        {
            // add jwt auth header if user is logged in and request is to the api url
            AuthenticationTokenUserModel user = await _localStorageService.GetItem<AuthenticationTokenUserModel>("user");
            bool isApiUrl = !request.RequestUri.IsAbsoluteUri;
            if (user != null && isApiUrl)
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", user.Token);

            using HttpResponseMessage response = await _httpClient.SendAsync(request);

            // auto logout on 401 response
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                _navigationManager.NavigateTo("logout");
                return default;
            }

            // throw exception on error response
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
                throw new Exception(error["message"]);
            }

            return await response.Content.ReadFromJsonAsync<T>();
        }

    }
}
