using ecommerce_webapi.Models.DTO;
using ecommerce_webapi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductModelsController : ControllerBase
    {
        private readonly IProductModelsRepository modelsRepository;

        public ProductModelsController(IProductModelsRepository modelsRepository)
        {
            this.modelsRepository = modelsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var models = await modelsRepository.GetAllAsync();
            if (models == null) { return NotFound(); }
            return Ok(models);
        }
        [HttpPost]
        public async Task<IActionResult> Crate([FromBody]ProductModelDto productModel)
        {
            var model = await modelsRepository.SaveAsync(productModel);

            if (model == null) {return BadRequest(model); }
            return Ok(model);
        }


    }
}
