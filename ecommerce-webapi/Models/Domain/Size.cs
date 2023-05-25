using System.ComponentModel.DataAnnotations;

namespace ecommerce_webapi.Models.Domain
{
    public class Size
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "has to be a minimum of 2 characters")]
        [MaxLength(20, ErrorMessage = "has to be a maximum of 20 characters")]
        public string Name { get; set; }
    }
}
