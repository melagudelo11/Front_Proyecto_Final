using Microsoft.Extensions.Options;
using VirtualWaiter.Application.Data.Common;
using VirtualWaiter.Application.Data.DTO;

namespace VirtualWaiter.Application.Services.Product
{
    public class ProductServices : IProductServices
    {
        readonly HttpClient _httpClient;
        readonly AppSettings _appSettings;

        public ProductServices(HttpClient httpClient, IOptions<AppSettings> appsetting)
        {

            _appSettings = appsetting.Value;
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(_appSettings.BaseUrl);
        }

        public async Task<bool> Delete(int id)
        {
            BaseServices<bool, int> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Delete(id, _appSettings.DeleteProductAddress);
        }

        public async Task<ProductRequestDTO> GetProductBydId(string id)
        {
            BaseServices<ProductRequestDTO, string> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Get(id, _appSettings.GetProductByIdAddress);
        }

        public async Task<IEnumerable<ProductResponseDTO>> GetProducts()
        {
            BaseServices<IEnumerable<ProductResponseDTO>, string> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Get(string.Empty, _appSettings.GetProductAddress);
        }

        public async Task<bool> Save(ProductRqCreate product)
        {

            BaseServices<bool, ProductRqCreate> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Post(product, _appSettings.PostProductAddress);

        }

        public async Task<bool> Update(ProductRequestDTO product)
        {
            BaseServices<bool, ProductRequestDTO> baseServices = new(_httpClient, _appSettings);
            return await baseServices.Put(product, _appSettings.UpdateProductAddress);
        }
    }
}
