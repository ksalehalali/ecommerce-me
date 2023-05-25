using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce_webapi.Models.Domain
{
    public class Brand
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "has to be a minimum of 5 characters")]
        [MaxLength(100, ErrorMessage = "has to be a maximum of 100 characters")]
        public string Name_AR { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "has to be a minimum of 5 characters")]
        [MaxLength(100, ErrorMessage = "has to be a maximum of 100 characters")]
        public string Name_EN { get; set; }

        public string Image { get; set; }

        //[ForeignKey("EmployeeID")]
        //public virtual ApplicationUser? ApplicationEmployee { get; set; }
        //public string? EmployeeID { get; set; }

    }
}
