using MAUICommerce.Shared.Dtos;
using Models;

namespace Services
{
    public class ProductsServices : BaseApiService
    {
        public ProductsServices(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
        public async Task<IEnumerable<ProductDto>> GetPopularProductsAsync()
        {
            var response = await HttpClient.GetAsync("/popular-products");
            return await HandleApiResponsesAsync(response, Enumerable.Empty<ProductDto>());
        }
    }
}
