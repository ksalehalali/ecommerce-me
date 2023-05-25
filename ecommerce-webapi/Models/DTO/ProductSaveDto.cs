using ecommerce_webapi.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace ecommerce_webapi.Models.DTO
{
    public class ProductSaveDto
    {
        [Required]
        [MinLength(5,ErrorMessage ="has to be a minimum of 5 characters")]
        [MaxLength(40,ErrorMessage = "has to be a maximum of 40 characters")]
        public string Name_AR { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "has to be a minimum of 5 characters")]
        [MaxLength(40, ErrorMessage = "has to be a maximum of 40 characters")]
        public string Name_EN { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "has to be a minimum of 5 characters")]
        [MaxLength(100, ErrorMessage = "has to be a maximum of 100 characters")]
        public string Desc_AR { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "has to be a minimum of 5 characters")]
        [MaxLength(100, ErrorMessage = "has to be a maximum of 100 characters")]
        public string Desc_EN { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]

        public double Price { get; set; }
        [Required]
        public double Offer { get; set; }
        [Required]

        public Guid CategoryID { get; set; }
        [Required]

        public Guid ModelProductID { get; set; }
        [Required]

        public Guid? BrandID { get; set; }

        public Guid? UserAdded { get; set; }

    }
}
