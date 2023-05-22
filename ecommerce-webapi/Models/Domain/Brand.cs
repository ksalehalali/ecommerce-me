using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce_webapi.Models.Domain
{
    public class Brand
    {
        public Guid Id { get; set; }

        public string Name_AR { get; set; }

        public string Name_EN { get; set; }

        public string Image { get; set; }

        //[ForeignKey("EmployeeID")]
        //public virtual ApplicationUser? ApplicationEmployee { get; set; }
        //public string? EmployeeID { get; set; }

    }
}
