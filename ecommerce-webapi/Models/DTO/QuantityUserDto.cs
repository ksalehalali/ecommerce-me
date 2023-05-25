using ecommerce_webapi.Models.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce_webapi.Models.DTO
{
    public class QuantityUserDto
    {
        public Guid ProductId { get; set; }
        [Required]
        [Range(0, 1000)]
        public int ItemsCount { get; set; }
        public Guid SizeId { get; set; }
        public Guid ColorId { get; set; }
        public List<ImagesUrlsSaveDto> ImagesUrls { get; set; }
        public Guid? User {  get; set; }
    }
}
