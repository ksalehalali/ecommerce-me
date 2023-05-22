using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ecommerce_webapi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_AR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HEXCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileExtention = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSizeInBytes = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModelsProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelsProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_AR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc_AR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Offer = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CatID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModelProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModelID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductBrand = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BrandID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ModelsProduct_ModelProductId",
                        column: x => x.ModelProductId,
                        principalTable: "ModelsProduct",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Quantities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemsCount = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quantities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quantities_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quantities_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageUrlDto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageUrlDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageUrlDto_Quantities_QuantityId",
                        column: x => x.QuantityId,
                        principalTable: "Quantities",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "Name_AR", "Name_EN" },
                values: new object[,]
                {
                    { new Guid("10e405c3-a390-4094-be7c-91a565fd1829"), "aaaa", "ألبسة نسائية", "Women's Clothing" },
                    { new Guid("772da223-096e-4dfd-b900-95e22c3de191"), "aaaa", "الموبايل", "Mobile" },
                    { new Guid("a8c77684-72f2-4e75-9d36-7c96451f03bb"), "aaaa", "احذية رجالية", "Men's shoes" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageUrlDto_QuantityId",
                table: "ImageUrlDto",
                column: "QuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ModelProductId",
                table: "Products",
                column: "ModelProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Quantities_ColorId",
                table: "Quantities",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Quantities_SizeId",
                table: "Quantities",
                column: "SizeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "ImageUrlDto");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Quantities");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ModelsProduct");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
