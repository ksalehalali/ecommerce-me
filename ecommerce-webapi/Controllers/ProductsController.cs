using ecommerce_webapi.Models.DTO;
using ecommerce_webapi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = productsRepository.GetProductsAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody]ProductSaveDto productSaveDto)
        {
            var product = await productsRepository.AddProductAsync(productSaveDto);

            return Ok(product);
        }
    }
}
