using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ecommerce_webapi.Migrations
{
    /// <inheritdoc />
    public partial class addproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_AR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Image", "Name_AR", "Name_EN" },
                values: new object[,]
                {
                    { new Guid("51257a5e-ecdb-4935-a2f7-750b0bafe5a7"), "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.seiu1000.org%2Fpost%2Fimage-dimensions&psig=AOvVaw0INXBPxzDdt40oc8apK8LH&ust=1683634630836000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCIim5vPZ5f4CFQAAAAAdAAAAABAE", "ابل", "Apple" },
                    { new Guid("9d3e3322-a82a-4c53-be47-70ba4d1f56d5"), "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.seiu1000.org%2Fpost%2Fimage-dimensions&psig=AOvVaw0INXBPxzDdt40oc8apK8LH&ust=1683634630836000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCIim5vPZ5f4CFQAAAAAdAAAAABAE", "سامسونج", "Samsung" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
