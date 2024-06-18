using VirtualWaiter.Application.Data.DTO;

namespace VirtualWaiter.Application.Services.Product
{
    public interface IProductServices
    {
        public Task<IEnumerable<ProductResponseDTO>> GetProducts();
        public Task<bool> Save(ProductRqCreate product);
        public Task<ProductRequestDTO> GetProductBydId(string id);
        public Task<bool> Update(ProductRequestDTO product);
        public Task<bool> Delete(int id);
    }
}
