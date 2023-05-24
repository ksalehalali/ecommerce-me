using ecommerce_webapi.Models.DTO;

namespace ecommerce_webapi.Repositories
{
    public interface IProductsRepository
    {
        Task<List<ProductUserReqDto>> GetProductsAsync();
        Task<ProductUserReqDto> GetProductByIdAsync(Guid id);
        Task<ProductUserReqDto> AddProductAsync(ProductSaveDto productSaveDto);
        Task<ProductUserReqDto> UpdateProductAsync(Guid ID, ProductUpdateReqDto productUpdateReq);
        Task<ProductUserReqDto> DeleteProductAsync(Guid ID);

    }
}
