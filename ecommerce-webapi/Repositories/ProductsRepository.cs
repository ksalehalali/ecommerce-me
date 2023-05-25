using AutoMapper;
using ecommerce_webapi.API.Data;
using ecommerce_webapi.Migrations;
using ecommerce_webapi.Models.Domain;
using ecommerce_webapi.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace ecommerce_webapi.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ECommerceDBContext _dbContext;
        private readonly IMapper mapper;

        public ProductsRepository(ECommerceDBContext dbContext,IMapper mapper)
        {
            this._dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<ProductUserReqDto> AddProductAsync(ProductSaveDto productSaveDto)
        {
            var productModel = await _dbContext.ModelsProduct.FirstOrDefaultAsync(x => x.Id == productSaveDto.ModelProductID);
            var productBrand = await _dbContext.Brands.FirstOrDefaultAsync(x => x.Id == productSaveDto.BrandID);
            var productCat = await _dbContext.Categories.FirstOrDefaultAsync(x => x.Id == productSaveDto.CategoryID);

            //Map AddDto To model
            // var productDomainModel = mapper.Map<Product>(productUserReqDto);
            var productDomainModel = new Product()
            {
                Name_EN = productSaveDto.Name_EN,
                Name_AR = productSaveDto.Name_AR,
                Image= productSaveDto.ImageUrl,
                Desc_AR = productSaveDto.Desc_AR,
                Desc_EN = productSaveDto.Desc_EN,
                CategoryID= productSaveDto.CategoryID,
                BrandID= productSaveDto.BrandID,
                Create_Date=DateTime.Now,
                Price= productSaveDto.Price,
                ModelProduct = productModel,
                Brand = productBrand,
                Category = productCat,
                Offer = productSaveDto.Offer,
                ModelProductID = productSaveDto.ModelProductID,
                

            };
             //use domain model to create product
             await _dbContext.Products.AddAsync(productDomainModel);
            await _dbContext.SaveChangesAsync();

            //mapping domain model to dto
             var productDto = mapper.Map<ProductUserReqDto>(productDomainModel);
            
            return productDto;
        }


        public async Task<ProductUserReqDto> GetProductByIdAsync(Guid id)
        {

            var product = await _dbContext.Products.Include("Brand").Include("ModelProduct").Include("Category").SingleOrDefaultAsync(x => x.id == id);
            if (product == null)
            {
                return null;
            }

            var productDto = mapper.Map<ProductUserReqDto>(product);
            var productQuantites = await _dbContext.Quantities.Where(x => x.ProductId == product.id).Include("Color").Include("Size").ToListAsync();
            var productQuantityDto = mapper.Map<List<QuantityDto>>(productQuantites);
            foreach (var quantite in productQuantityDto)
            {
                var quantityImages = await _dbContext.imagesUrls.Where(x => x.QuantityId == quantite.Id).ToListAsync();
                quantite.ImagesUrls = quantityImages;
            }
            productDto.Quantities = productQuantityDto;

            return productDto;

        }

        public async Task<List<ProductUserReqDto>> GetProductsAsync( string? filterOn, string? filterQuery,
            string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000)
        {
            var products=  _dbContext.Products.Include("Brand").Include("ModelProduct").Include("Category").AsQueryable();

           

            //filtering
            if (string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
            {
                bool isArabic = ContainsArabicCharacters(filterQuery);
                bool isEnglish = ContainsEnglishCharacters(filterQuery);
                if (isArabic)
                {
                    if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                    {
                        products = products.Where(x => x.Name_AR.Contains(filterQuery));
                    }
                }
                else
                {
                    if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                    {
                        products = products.Where(x => x.Name_EN.Contains(filterQuery));
                    }

                }
            }

            //Sorting
            if (string.IsNullOrWhiteSpace(sortBy) == false)
            {
                if (sortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    products = isAscending ? products.OrderBy(x => x.Name_EN) : products.OrderByDescending(x => x.Name_EN);
                }
                else if (sortBy.Equals("Price", StringComparison.OrdinalIgnoreCase))
                {
                    products = isAscending ? products.OrderBy(x => x.Price) : products.OrderByDescending(x => x.Price);
                }
            }

           

            //mapping domain model to dto
            var productsDto = mapper.Map<List<ProductUserReqDto>>(products);
            //Pagination
            var skipResults = (pageNumber - 1) * pageSize;

           productsDto =   productsDto.Skip(skipResults).Take(pageSize).ToList();


            foreach (var product in productsDto)
            {
                var productQuantites = await _dbContext.Quantities.Where(x => x.ProductId == product.id).Include("Color").Include("Size").ToListAsync();
                var productQuantityDto = mapper.Map<List<QuantityDto>>(productQuantites);
                foreach (var quantite in productQuantityDto)
                {
                    var quantityImages = await _dbContext.imagesUrls.Where(x => x.QuantityId ==quantite.Id).ToListAsync();
                    quantite.ImagesUrls = quantityImages;
                }
                product.Quantities = productQuantityDto;

            }

            //convert from model to dto
       

            return productsDto;

        }


        //check lang
        static bool ContainsArabicCharacters(string input)
        {
            foreach (char c in input)
            {
                // Check if the character falls within the Arabic Unicode range
                if (c >= 0x0600 && c <= 0x06FF)
                {
                    return true;
                }
            }

            return false;
        }

        static bool ContainsEnglishCharacters(string input)
        {
            foreach (char c in input)
            {
                // Check if the character falls within the English Unicode range
                if ((c >= 0x0041 && c <= 0x005A) || (c >= 0x0061 && c <= 0x007A))
                {
                    return true;
                }
            }

            return false;
        }

        public async Task<ProductUserReqDto> UpdateProductAsync(Guid ID, ProductUpdateReqDto productUpdateReqDto)
        {
            var product = await _dbContext.Products.SingleOrDefaultAsync(x => x.id == ID);
            if (product == null) { return null; }

            product.Name_EN = productUpdateReqDto.Name_EN;
                product.Name_AR = productUpdateReqDto.Name_AR;
            product.Image = productUpdateReqDto.Image;
                product.Desc_AR = productUpdateReqDto.Desc_AR;
                product.Desc_EN = productUpdateReqDto.Desc_EN;
                product.CategoryID = productUpdateReqDto.CatID;
                product.BrandID = productUpdateReqDto.BrandID;
            product.Update_Date = DateTime.Now;
                product.Price = productUpdateReqDto.Price;
               product.Offer = productUpdateReqDto.Offer;
            product.ModelProductID = productUpdateReqDto.ModelID;

            await _dbContext.SaveChangesAsync();

            return mapper.Map<ProductUserReqDto>(product);
        }


        public async Task<ProductUserReqDto> DeleteProductAsync(Guid ID)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.id == ID);
            if (product == null) { return null; }
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
            return mapper.Map<ProductUserReqDto>(product);
        }
    }
}
