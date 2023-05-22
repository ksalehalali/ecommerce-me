using ecommerce_webapi.API.Data;
using ecommerce_webapi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_webapi.Repositories
{
    public class BrandRepository : IBrandsRepository
    {
        private readonly ECommerceDBContext dbContext;

        public BrandRepository(ECommerceDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<Brand>> GetAllAsync()
        {
            var brands = await dbContext.Brands.ToListAsync();

            return brands;
        }
    }
}
