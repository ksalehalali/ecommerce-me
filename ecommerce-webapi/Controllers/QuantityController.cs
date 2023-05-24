using ecommerce_webapi.Models.DTO;
using ecommerce_webapi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuantityController : ControllerBase
    {
        private readonly IQuantityRepository quantityRepository;

        public QuantityController(IQuantityRepository quantityRepository)
        {
            this.quantityRepository = quantityRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var quantities = await quantityRepository.GetAll();
            return Ok(quantities);
        }

        [HttpPost]
        public async Task<IActionResult> Create(QuantityUserDto quantity)
        {

            var quantityDto = await quantityRepository.Create(quantity);
            if (quantityDto == null) { return BadRequest(); }
            return Ok(quantityDto);

        }
    }
}
