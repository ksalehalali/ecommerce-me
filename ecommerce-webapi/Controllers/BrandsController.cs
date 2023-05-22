using ecommerce_webapi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandsRepository _brandsRepository;

        public BrandsController(IBrandsRepository brandsRepository)
        {
            this._brandsRepository = brandsRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var brand = await _brandsRepository.GetAllAsync();

            return Ok(brand);
        }
    }
}
