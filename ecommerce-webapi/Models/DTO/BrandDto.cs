using System.ComponentModel.DataAnnotations;

namespace ecommerce_webapi.Models.DTO
{
    public class BrandDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "has to be a minimum of 3 characters")]
        [MaxLength(100, ErrorMessage = "has to be a maximum of 100 characters")]
        public string Name_AR { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "has to be a minimum of 3 characters")]
        [MaxLength(100, ErrorMessage = "has to be a maximum of 100 characters")]
        public string Name_EN { get; set; }

        public string Image { get; set; }

        public Guid EmployeeId { get; set; }
    }
}
