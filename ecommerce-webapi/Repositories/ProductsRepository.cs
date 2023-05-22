using AutoMapper;
using ecommerce_webapi.API.Data;
using ecommerce_webapi.Models.Domain;
using ecommerce_webapi.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_webapi.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ECommerceDBContext _dbContext;
        //private readonly IMapper mapper;

        public ProductsRepository(ECommerceDBContext dbContext)
        {
            this._dbContext = dbContext;
           // this.mapper = mapper;
        }
        public async Task<ProductUserReqDto> AddProductAsync(ProductSaveDto productSaveDto)
        {
            var productModel = await _dbContext.ModelsProduct.FirstOrDefaultAsync(x => x.Id == productSaveDto.ModelID);
            var productBrand = await _dbContext.Brands.FirstOrDefaultAsync(x => x.Id == productSaveDto.BrandID);
            var productCat = await _dbContext.Categories.FirstOrDefaultAsync(x => x.Id == productSaveDto.CatID);

            //Map AddDto To model
            // var productDomainModel = mapper.Map<Product>(productUserReqDto);
            var productDomainModel = new Product()
            {
                Name_EN = productSaveDto.Name_EN,
                Name_AR = productSaveDto.Name_AR,
                Image= productSaveDto.ImageUrl,
                Desc_AR = productSaveDto.Desc_AR,
                Desc_EN = productSaveDto.Desc_EN,
                CatID= productSaveDto.CatID,
                BrandID= productSaveDto.BrandID,
                Create_Date=DateTime.Now,
                Price= productSaveDto.Price,
                ModelProduct = productModel,
                ProductBrand = productBrand,
                Category = productCat

            };
             //use domain model to create product
             await _dbContext.Products.AddAsync(productDomainModel);
            await _dbContext.SaveChangesAsync();

            //mapping domain model to dto
            // var productDto = mapper.Map<ProductUserReqDto>(productDomainModel);
            var productDto = new ProductUserReqDto()
            {
                Name_EN = productSaveDto.Name_EN,
                Name_AR = productSaveDto.Name_AR,
                Image = productSaveDto.ImageUrl,
                Desc_AR = productSaveDto.Desc_AR,
                Desc_EN = productSaveDto.Desc_EN,
                CatID = productSaveDto.CatID,
                BrandID = productSaveDto.BrandID,
                Price = productSaveDto.Price,
            };
            return productDto;
        }

        public Task<List<ProductUserReqDto>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

     
    }
}
