﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotNetEFCoreV3.DataContext;

#nullable disable

namespace dotNetEFCoreV3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("dotNetEFCoreV3.DataContext.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CategoryCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_code");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.HasKey("Id");

                    b.ToTable("tbl_category");
                });

            modelBuilder.Entity("dotNetEFCoreV3.DataContext.CompanyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("company_name");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("logo");

                    b.Property<string>("Segmentasi")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("segmentasi");

                    b.HasKey("Id");

                    b.ToTable("tbl_company");
                });

            modelBuilder.Entity("dotNetEFCoreV3.DataContext.CustomerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("customer_name");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("tbl_customer");
                });

            modelBuilder.Entity("dotNetEFCoreV3.DataContext.OrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Count")
                        .HasColumnType("int")
                        .HasColumnName("count");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.HasKey("Id");

                    b.ToTable("tbl_order");
                });

            modelBuilder.Entity("dotNetEFCoreV3.DataContext.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("product_name");

                    b.HasKey("Id");

                    b.ToTable("tbl_product");
                });
#pragma warning restore 612, 618
        }
    }
}
