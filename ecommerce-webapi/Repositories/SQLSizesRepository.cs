using AutoMapper;
using ecommerce_webapi.API.Data;
using ecommerce_webapi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_webapi.Repositories
{
    public class SQLSizesRepository:ISizesRepository
    {
        private readonly ECommerceDBContext _dbContext;

        public SQLSizesRepository(ECommerceDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<Size>> GetAllSizesAsync()
        {
            var regions = await _dbContext.Sizes.ToListAsync();

            //Map domain to dtos
           // var regionsDto = new List<RegionDto>();
            foreach (var region in regions)
            {
                //mapping domain model to dto
                //var regionDto = mapper.Map<RegionDto>(region);
                //regionsDto.Add(regionDto);
            }

            return regions;
        }
    }
}
