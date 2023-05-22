using ecommerce_webapi.Models.DTO;

namespace ecommerce_webapi.Repositories
{
    public interface IProductsRepository
    {
        Task<List<ProductUserReqDto>> GetProductsAsync();
        Task<ProductUserReqDto> AddProductAsync(ProductSaveDto productSaveDto);
    }
}
