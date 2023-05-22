using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ecommerce_webapi.Models.Domain
{
    public class Product
    {
   
        public Guid id { get; set; }

        public string Name_AR { get; set; }

        public string Name_EN { get; set; }

        public string? Desc_AR { get; set; }

        public string? Desc_EN { get; set; }

        public string Image { get; set; }

        public double Price { get; set; }

        public double Offer { get; set; }

        public virtual Category? Category { get; set; }
        public Guid? CatID { get; set; }

        public virtual ModelProduct? ModelProduct { get; set; }
        public Guid? ModelID { get; set; }

        public virtual Brand? ProductBrand { get; set; }
        public Guid? BrandID { get; set; }

        public Guid? EmployeeID { get; set; }



        [Display(Name = "Create Date")]
        [DataType(DataType.Date)]
        public DateTime Create_Date { get; set; }

        [Display(Name = "Update Date")]
        [DataType(DataType.Date)]
        public DateTime Update_Date { get; set; }
    }
}
