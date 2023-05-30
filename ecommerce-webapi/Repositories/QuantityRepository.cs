using AutoMapper;
using ecommerce_webapi.API.Data;
using ecommerce_webapi.Models.Domain;
using ecommerce_webapi.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_webapi.Repositories
{
    public class QuantityRepository : IQuantityRepository
    {
        private readonly IMapper mapper;
        private readonly ECommerceDBContext dbContext;

        public QuantityRepository(IMapper mapper,ECommerceDBContext dbContext)
        {
            this.mapper = mapper;
            this.dbContext = dbContext;
        }
        public async Task<QuantityDto> Create(QuantityUserDto quantity)
        {

            //  var domainQuantity = mapper.Map<Quantity>(quantity);
            var size = await dbContext.Sizes.FirstOrDefaultAsync(x => x.Id == quantity.SizeId);
            var color = await dbContext.Colors.FirstOrDefaultAsync(x => x.Id == quantity.ColorId);

            var domainQuantity = new Quantity()
            {
                Id = Guid.NewGuid(),
                ProductId = quantity.ProductId,
                SizeId = quantity.SizeId,
                ColorId = quantity.ColorId,
                ItemsCount = quantity.ItemsCount,
                AddedDate = DateTime.Now,          
                Size=size,
                Color=color,
                User = quantity.User
            };

            var imagesQList = new List<ImagesUrls>();

            foreach (var item in quantity.ImagesUrls)
            {
                imagesQList.Add(
                    new ImagesUrls
                    {
                        Id= Guid.NewGuid(),
                        Url = item.Url,
                        QuantityId= domainQuantity.Id
                    }
                );
            }

            foreach (var item in imagesQList)
            {
                await dbContext.imagesUrls.AddAsync(item);
            }

            await dbContext.AddAsync(domainQuantity);
            await dbContext.SaveChangesAsync();

            //convert dto user to dto
            var quantityDto = mapper.Map<QuantityDto>(quantity);
            quantityDto.Size = await dbContext.Sizes.FirstOrDefaultAsync(x => x.Id == quantity.SizeId);
            quantityDto.Color = await dbContext.Colors.FirstOrDefaultAsync(x => x.Id == quantity.ColorId);
            return quantityDto;
        }

        public async Task<QuantityDto> Delete(Guid id)
        {
           var quantity = await dbContext.Quantities.FirstOrDefaultAsync(q => q.Id == id);
            if (quantity != null) { return null; }
             dbContext.Quantities.Remove(quantity);

            await dbContext.SaveChangesAsync();
            return mapper.Map<QuantityDto>(quantity);
        }

        public async Task<List<QuantityDto>> GetAll()
        {
            var quantity = await dbContext.Quantities.Include("Size").Include("Color").ToListAsync();
          //  var imagesUrls = await dbContext
            var quantityDto = new List<QuantityDto>();
            foreach (var item in quantity)
            {
              quantityDto.Add(new QuantityDto
              {
                  Id = item.Id,
                  ProductId = item.ProductId,
                  SizeId = item.SizeId,
                  ColorId = item.ColorId,
                  ItemsCount = item.ItemsCount,
                  Size = item.Size,
                  Color = item.Color,
                  ImagesUrls = await dbContext.imagesUrls.Where(x => x.QuantityId==item.Id).ToListAsync(),
                 
              });
            }
            return quantityDto; 
        }

        public Task<QuantityDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<QuantityDto>> GetQuantitiesByProductId(Guid productId)
        {
           var quantities = await dbContext.Quantities.Where(x =>x.ProductId == productId).Include("Size").Include("Color").ToListAsync();

            var quantityDto = new List<QuantityDto>();
            foreach (var item in quantities)
            {
                quantityDto.Add(new QuantityDto
                {
                    Id = item.Id,
                    ProductId = item.ProductId,
                    SizeId = item.SizeId,
                    ColorId = item.ColorId,
                    ItemsCount = item.ItemsCount,
                    Size = item.Size,
                    Color = item.Color,
                    ImagesUrls = await dbContext.imagesUrls.Where(x => x.QuantityId == item.Id).ToListAsync(),

                });
            }

            return mapper.Map<List<QuantityDto>>(quantityDto);
        }

        public Task<QuantityDto> Update(Guid id, QuantityDto quantity)
        {
            throw new NotImplementedException();
        }
    }
}
