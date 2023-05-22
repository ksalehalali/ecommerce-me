﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecommerce_webapi.API.Data;

#nullable disable

namespace ecommerce_webapi.Migrations
{
    [DbContext(typeof(ECommerceDBContext))]
    [Migration("20230522082226_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ecommerce_webapi.Models.DTO.ImageUrlDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("QuantityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuantityId");

                    b.ToTable("ImageUrlDto");
                });

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_AR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("772da223-096e-4dfd-b900-95e22c3de191"),
                            ImageUrl = "aaaa",
                            Name_AR = "الموبايل",
                            Name_EN = "Mobile"
                        },
                        new
                        {
                            Id = new Guid("10e405c3-a390-4094-be7c-91a565fd1829"),
                            ImageUrl = "aaaa",
                            Name_AR = "ألبسة نسائية",
                            Name_EN = "Women's Clothing"
                        },
                        new
                        {
                            Id = new Guid("a8c77684-72f2-4e75-9d36-7c96451f03bb"),
                            ImageUrl = "aaaa",
                            Name_AR = "احذية رجالية",
                            Name_EN = "Men's shoes"
                        });
                });

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HEXCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtention")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.ModelProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ModelsProduct");
                });

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.Product", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BrandID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CatID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Create_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc_AR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc_EN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ModelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ModelProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name_AR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Offer")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid?>("ProductBrand")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Update_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ModelProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.Quantity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ItemsCount")
                        .HasColumnType("int");

                    b.Property<Guid>("SizeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("SizeId");

                    b.ToTable("Quantities");
                });

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("ecommerce_webapi.Models.DTO.ImageUrlDto", b =>
                {
                    b.HasOne("ecommerce_webapi.Models.Domain.Quantity", null)
                        .WithMany("ImagesUrl")
                        .HasForeignKey("QuantityId");
                });

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.Product", b =>
                {
                    b.HasOne("ecommerce_webapi.Models.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("ecommerce_webapi.Models.Domain.ModelProduct", "ModelProduct")
                        .WithMany()
                        .HasForeignKey("ModelProductId");

                    b.Navigation("Category");

                    b.Navigation("ModelProduct");
                });

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.Quantity", b =>
                {
                    b.HasOne("ecommerce_webapi.Models.Domain.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ecommerce_webapi.Models.Domain.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.Quantity", b =>
                {
                    b.Navigation("ImagesUrl");
                });
#pragma warning restore 612, 618
        }
    }
}