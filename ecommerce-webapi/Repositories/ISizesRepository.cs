using ecommerce_webapi.Models.Domain;

namespace ecommerce_webapi.Repositories
{
    public interface ISizesRepository
    {
        Task<List<Size>> GetAllSizesAsync();
    }
}
