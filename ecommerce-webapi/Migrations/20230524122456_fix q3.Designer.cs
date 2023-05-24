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
    [Migration("20230524122456_fix q3")]
    partial class fixq3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ecommerce_webapi.Models.DTO.ImagesUrls", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuantityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("imagesUrls");
                });

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_AR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("51257a5e-ecdb-4935-a2f7-750b0bafe5a7"),
                            Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.seiu1000.org%2Fpost%2Fimage-dimensions&psig=AOvVaw0INXBPxzDdt40oc8apK8LH&ust=1683634630836000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCIim5vPZ5f4CFQAAAAAdAAAAABAE",
                            Name_AR = "ابل",
                            Name_EN = "Apple"
                        },
                        new
                        {
                            Id = new Guid("9d3e3322-a82a-4c53-be47-70ba4d1f56d5"),
                            Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.seiu1000.org%2Fpost%2Fimage-dimensions&psig=AOvVaw0INXBPxzDdt40oc8apK8LH&ust=1683634630836000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCIim5vPZ5f4CFQAAAAAdAAAAABAE",
                            Name_AR = "سامسونج",
                            Name_EN = "Samsung"
                        });
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

                    b.Property<Guid?>("CategoryID")
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

                    b.Property<Guid?>("ModelProductID")
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

                    b.Property<DateTime>("Update_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("BrandID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("ModelProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.Quantity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ItemsCount")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SizeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("User")
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

            modelBuilder.Entity("ecommerce_webapi.Models.Domain.Product", b =>
                {
                    b.HasOne("ecommerce_webapi.Models.Domain.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandID");

                    b.HasOne("ecommerce_webapi.Models.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("ecommerce_webapi.Models.Domain.ModelProduct", "ModelProduct")
                        .WithMany()
                        .HasForeignKey("ModelProductID");

                    b.Navigation("Brand");

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
#pragma warning restore 612, 618
        }
    }
}
