using System.ComponentModel.DataAnnotations;

namespace ecommerce_webapi.Models.Domain
{
    public class ModelProduct
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "has to be a minimum of 5 characters")]
        [MaxLength(100, ErrorMessage = "has to be a maximum of 100 characters")]
        public string Name { get; set; }
    }
}
