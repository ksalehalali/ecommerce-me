﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecommerce_webapi.Migrations
{
    /// <inheritdoc />
    public partial class fixq2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_ImageUrlDto_QuantityId",
                table: "ImageUrlDto",
                column: "QuantityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageUrlDto");
        }
    }
}
