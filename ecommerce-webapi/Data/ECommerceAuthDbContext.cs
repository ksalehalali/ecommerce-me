using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_webapi.API.Data
{
    public class ECommerceAuthDbContext:IdentityDbContext
    {
        public ECommerceAuthDbContext(DbContextOptions<ECommerceAuthDbContext> options) :base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "011a681d-feb1-42a6-81ff-6bf39079b95a";
            var writerRoleId = "fb593a65-4c06-40f9-b5de-1f137f17a64c";
            var superAdmin = "7e03a396-3fc0-4684-bfd7-a0a489138a77";
            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name= "Reader",
                    NormalizedName="Reader".ToUpper(),
                },
                  new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name= "Writer",
                    NormalizedName="Writer".ToUpper(),
                },

                    new IdentityRole
                {
                    Id = superAdmin,
                    ConcurrencyStamp = superAdmin,
                    Name= "SuperAdmin",
                    NormalizedName="SuperAdmin".ToUpper(),
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);

        }
    }
}
