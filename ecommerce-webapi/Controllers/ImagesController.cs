using ecommerce_webapi.Models.Domain;
using ecommerce_webapi.Models.DTO;
using ecommerce_webapi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ecommerce_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository imageRepository;

        public ImagesController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }

        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload([FromForm]ImageUploadReqDto request)
        {
            ValidateFileUpload(request);
            if (ModelState.IsValid)
            {
                //convert DTO to domain model
                var imageDomainModel = new Image
                {
                    File = request.File,
                    FileExtention = Path.GetExtension(request.File.FileName),
                    FileSizeInBytes = request.File.Length,
                    Name = request.FileName,
                    Description = request.FileDescription,
                };

                // user repo upload
                await imageRepository.Upload(imageDomainModel);

                return Ok(imageDomainModel);

            }

            return BadRequest(ModelState);
        }

        private void ValidateFileUpload(ImageUploadReqDto request)
        {
            var allowedExtintions = new string[] { ".jpg", ".jpeg", ".png" };

            if(!allowedExtintions.Contains(Path.GetExtension(request.File.FileName))) {
                ModelState.AddModelError("file", "Unsupported file extention");
            }

            if(request.File.Length > 10485760) {
                ModelState.AddModelError("file", "file size more than 10MB");
            }


        }
    }
}
