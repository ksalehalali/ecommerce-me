using ecommerce_webapi.Models.Domain;

namespace ecommerce_webapi.Repositories
{
    public interface IBrandsRepository
    {
        Task<List<Brand>> GetAllAsync();

    }
}
