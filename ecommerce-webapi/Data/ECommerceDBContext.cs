
using ecommerce_webapi.Models.Domain;
using ecommerce_webapi.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_webapi.API.Data
{
    public class ECommerceDBContext: DbContext
    {
        public ECommerceDBContext(DbContextOptions<ECommerceDBContext> dbContextOptions):base(dbContextOptions) 
        {
            
        }

        public DbSet<Category> Categories  { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<ModelProduct> ModelsProduct { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Quantity> Quantities { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ImagesUrls> imagesUrls { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed data for difficulties

            var categories  =new List<Category>()
            {
                new Category()
                {
                    Id=Guid.Parse("772da223-096e-4dfd-b900-95e22c3de191"),
                    Name_EN="Mobile",
                      Name_AR="الموبايل",
                    ImageUrl="aaaa"
                },
                 new Category()
                {
                    Id=Guid.Parse("10e405c3-a390-4094-be7c-91a565fd1829"),
                    Name_EN="Women's Clothing",
                      Name_AR="ألبسة نسائية",
                    ImageUrl="aaaa"
                },
                  new Category()
                {
                    Id=Guid.Parse("a8c77684-72f2-4e75-9d36-7c96451f03bb"),
                    Name_EN="Men's shoes",
                    Name_AR="احذية رجالية",
                    ImageUrl="aaaa"
                }
            };

            //seed difficualties to database
            modelBuilder.Entity<Category>().HasData(categories);


            // seed data for regions

            var brands = new List<Brand>()
            {
                new Brand()
                {
                    Id=Guid.Parse("51257a5e-ecdb-4935-a2f7-750b0bafe5a7") ,
                    Name_EN= "Apple",
                   Name_AR="ابل",
                    Image= "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.seiu1000.org%2Fpost%2Fimage-dimensions&psig=AOvVaw0INXBPxzDdt40oc8apK8LH&ust=1683634630836000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCIim5vPZ5f4CFQAAAAAdAAAAABAE",
                },

                     new Brand()
                {
                    Id=Guid.Parse("9d3e3322-a82a-4c53-be47-70ba4d1f56d5") ,
                    Name_EN= "Samsung",
                   Name_AR="سامسونج",
                    Image= "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.seiu1000.org%2Fpost%2Fimage-dimensions&psig=AOvVaw0INXBPxzDdt40oc8apK8LH&ust=1683634630836000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCIim5vPZ5f4CFQAAAAAdAAAAABAE",
                },
            };

            modelBuilder.Entity<Brand>().HasData(brands);

        }
    }
}
