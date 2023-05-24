using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecommerce_webapi.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ModelsProduct_ModelProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CatID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModelID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ModelProductId",
                table: "Products",
                newName: "ModelProductID");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ModelProductId",
                table: "Products",
                newName: "IX_Products_ModelProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryID");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Quantities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Quantities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "User",
                table: "Quantities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ModelsProduct_ModelProductID",
                table: "Products",
                column: "ModelProductID",
                principalTable: "ModelsProduct",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ModelsProduct_ModelProductID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Quantities");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Quantities");

            migrationBuilder.DropColumn(
                name: "User",
                table: "Quantities");

            migrationBuilder.RenameColumn(
                name: "ModelProductID",
                table: "Products",
                newName: "ModelProductId");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ModelProductID",
                table: "Products",
                newName: "IX_Products_ModelProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddColumn<Guid>(
                name: "CatID",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModelID",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ModelsProduct_ModelProductId",
                table: "Products",
                column: "ModelProductId",
                principalTable: "ModelsProduct",
                principalColumn: "Id");
        }
    }
}
