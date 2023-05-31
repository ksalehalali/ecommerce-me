using ecommerce_webapi.Models.Domain;
using ecommerce_webapi.Models.DTO;

namespace ecommerce_webapi.Repositories
{
    public interface IProductModelsRepository
    {
        Task<ModelProduct> SaveAsync(ProductModelDto productModel);
        Task<List<ModelProduct>> GetAllAsync();
    }
}
