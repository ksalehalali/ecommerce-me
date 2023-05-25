using ecommerce_webapi.Models.DTO;

namespace ecommerce_webapi.Repositories
{
    public interface IProductsRepository
    {
        Task<List<ProductUserReqDto>> GetProductsAsync(string? filterOn =null, string? filterQuery =null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000);
        Task<ProductUserReqDto> GetProductByIdAsync(Guid id);
        Task<ProductUserReqDto> AddProductAsync(ProductSaveDto productSaveDto);
        Task<ProductUserReqDto> UpdateProductAsync(Guid ID, ProductUpdateReqDto productUpdateReq);
        Task<ProductUserReqDto> DeleteProductAsync(Guid ID);

    }
}
