namespace ecommerce_webapi.Models.Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name_AR { get; set; }
        public string Name_EN { get; set; }

        public string ImageUrl { get; set; }

    }
}
