using ecommerce_webapi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SizesController : ControllerBase
    {
        private readonly ISizesRepository _sizesRepository;

        public SizesController(ISizesRepository sizesRepository)
        {
            this._sizesRepository = sizesRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //
            var sizes = await _sizesRepository.GetAllSizesAsync();
            if (sizes == null) { }

            return Ok(sizes);
        }
    }
}
