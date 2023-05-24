using ecommerce_webapi.Models.DTO;

namespace ecommerce_webapi.Repositories
{
    public interface IQuantityRepository
    {
        Task<List<QuantityDto>> GetAll();
        Task<List<QuantityDto>> GetQuantitiesByProductId(Guid productId);

        Task<QuantityDto> GetById(Guid id);
        Task<QuantityDto> Create(QuantityUserDto quantity);
        Task<QuantityDto> Update(Guid id,QuantityDto quantity);
        Task<QuantityDto> Delete(Guid id);
    }
}
