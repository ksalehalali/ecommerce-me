using ecommerce_webapi.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace ecommerce_webapi.Models.DTO
{
    public class ProductUserReqDto
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
        public Guid? CategoryID { get; set; }

        public virtual ModelProduct? ModelProduct { get; set; }
        public Guid? ModelProductID { get; set; }

        public virtual Brand? Brand { get; set; }
        public Guid? BrandID { get; set; }

        public List<QuantityDto> Quantities { get; set; }



    }
}
