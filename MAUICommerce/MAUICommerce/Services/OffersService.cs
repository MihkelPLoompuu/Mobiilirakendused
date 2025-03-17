using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Services
{
    public class OffersServices
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public OffersServices(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IEnumerable<Offer>> GetActiveOffersAsync()
        {
            var httpClient = _httpClientFactory.CreateClient(AppConstants.HttpClientName);
            var response = await httpClient.GetAsync("/master/offers");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    return JsonSerializer.Deserialize<IEnumerable<Offer>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                }
            }
            return Enumerable.Empty<Offer>();
        }
    }
}
