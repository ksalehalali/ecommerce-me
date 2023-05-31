using ecommerce_webapi.API.Data;
using ecommerce_webapi.Models.Domain;
using ecommerce_webapi.Models.DTO;
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

        public async Task<Brand> CreateAsync(BrandDto brandDto)
        {
            //Map to domain
            var brandDomain = new Brand()
            {
                Id = Guid.NewGuid(),
                Name_EN = brandDto.Name_EN,
                Name_AR = brandDto.Name_AR,
                Image = brandDto.Image,
            };

            await dbContext.AddAsync(brandDomain);  
            await dbContext.SaveChangesAsync();

            return brandDomain;
        }

        public async Task<List<Brand>> GetAllAsync()
        {
            var brands = await dbContext.Brands.ToListAsync();

            return brands;
        }
    }
}
