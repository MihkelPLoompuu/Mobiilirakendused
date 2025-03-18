using Constants;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Services
{
    public class BaseApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BaseApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        protected JsonSerializerOptions DefualtSerializerOptions = new ()
        {
            PropertyNameCaseInsensitive = true
        };

        protected HttpClient HttpClient => _httpClientFactory.CreateClient(AppConstants.HttpClientName);

        protected TData Deserialize<TData>(string jsonData) =>
            JsonSerializer.Deserialize<TData>(jsonData, DefualtSerializerOptions);

        protected async Task<TData> HandleApiResponsesAsync<TData>(HttpResponseMessage response, TData defualtValue)
        {
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    return JsonSerializer.Deserialize<TData>(content, DefualtSerializerOptions);
                }
            }
            return defualtValue;
        }
    }
}
