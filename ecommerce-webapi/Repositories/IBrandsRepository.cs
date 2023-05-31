using ecommerce_webapi.Models.Domain;
using ecommerce_webapi.Models.DTO;

namespace ecommerce_webapi.Repositories
{
    public interface IBrandsRepository
    {
        Task<List<Brand>> GetAllAsync();
        Task<Brand> CreateAsync(BrandDto brandDto);

    }
}
