using System.ComponentModel.DataAnnotations;

namespace ecommerce_webapi.Models.DTO
{
    public class ProductModelDto
    {
        [Required]
        [MinLength(2, ErrorMessage = "has to be a minimum of 5 characters")]
        [MaxLength(100, ErrorMessage = "has to be a maximum of 100 characters")]
        public string Name { get; set; }
    }
}
