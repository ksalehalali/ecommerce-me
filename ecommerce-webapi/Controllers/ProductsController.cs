using ecommerce_webapi.API.CustomActionFilters;
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
        public async Task<IActionResult> GetAllProducts([FromQuery]string? filterOn, [FromQuery]string? filterQuery )
        {
            var products =await productsRepository.GetProductsAsync(filterOn,filterQuery);
            return Ok(products);
        }
        [HttpGet]
        [Route("id:Guid")]
        public async Task<IActionResult> GetProductById([FromQuery]Guid id)
        {
            var product =await productsRepository.GetProductByIdAsync(id);
            if (product == null) { return NotFound(); }
            return Ok(product);
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> CreateProduct([FromBody]ProductSaveDto productSaveDto)
        {
            var product = await productsRepository.AddProductAsync(productSaveDto);

            return Ok(product);
        }
        [HttpPut]
        [Route("id:Guid")]
        [ValidateModel]

        public async Task<IActionResult> UpdateProduct([FromQuery]Guid id, [FromBody]ProductUpdateReqDto productUpdateReqDto)
        {
            var product = await productsRepository.UpdateProductAsync(id,productUpdateReqDto);
            if (product == null) { return NotFound("Product not exist"); };
            return Ok(product);
        }

        [HttpDelete]
        [Route("id:Guid")]

        public async Task<IActionResult> DeleteProduct([FromQuery]Guid id)
        {
            var product = await productsRepository.DeleteProductAsync(id);
            if (product == null) { return NotFound("Not exist"); };
            return Ok(product);
        }
    }
}
