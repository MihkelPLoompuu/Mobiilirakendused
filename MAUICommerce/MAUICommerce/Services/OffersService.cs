using Constants;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Services
{
    public class OffersServices : BaseApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public OffersServices(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
        public async Task<IEnumerable<Offer>> GetActiveOffersAsync()
        {      
            var response = await HttpClient.GetAsync("/master/offers");
            return await HandleApiResponsesAsync<IEnumerable<Offer>>(response, Enumerable.Empty<Offer>());
        }
    }
}
