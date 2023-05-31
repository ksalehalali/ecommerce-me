using ecommerce_webapi.API.Data;
using ecommerce_webapi.Models.Domain;
using ecommerce_webapi.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_webapi.Repositories
{
    public class ProductModelsRepository : IProductModelsRepository
    {
        private readonly ECommerceDBContext dbContext;

        public ProductModelsRepository(ECommerceDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<ModelProduct>> GetAllAsync()
        {
            var models = await dbContext.ModelsProduct.ToListAsync();
            return models;
        }

        public async Task<ModelProduct> SaveAsync(ProductModelDto productModel)
        {
            var modelDomain = new ModelProduct()
            {
                Id = Guid.NewGuid(),
                Name = productModel.Name,
            };
            await dbContext.ModelsProduct.AddAsync(modelDomain);
            await dbContext.SaveChangesAsync();
            return modelDomain;
            
        }
    }
}
