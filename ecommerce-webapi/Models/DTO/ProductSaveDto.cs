using ecommerce_webapi.Models.Domain;

namespace ecommerce_webapi.Models.DTO
{
    public class ProductSaveDto
    {
        public string Name_AR { get; set; }

        public string Name_EN { get; set; }

        public string? Desc_AR { get; set; }

        public string? Desc_EN { get; set; }

        public string ImageUrl { get; set; }

        public double Price { get; set; }

        public double Offer { get; set; }

        public Guid? CatID { get; set; }

        public Guid? ModelID { get; set; }

        public Guid? BrandID { get; set; }
        public Guid? UserAdded { get; set; }

    }
}
