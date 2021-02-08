﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoresubat.Contexts;

namespace NetCoresubat.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20210208105427_InitalCrete2")]
    partial class InitalCrete2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("NetCoresubat.Entities.ProductsCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ProductsID")
                        .HasColumnType("int");

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProductsID");

                    b.HasIndex("categoryID", "ProductsID")
                        .IsUnique();

                    b.ToTable("ProductsCategory");
                });

            modelBuilder.Entity("NetCoresubat.Entities.category", b =>
                {
                    b.Property<int>("categoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("categoryName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("categoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NetCoresubat.Entities.products", b =>
                {
                    b.Property<int>("productsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("productsImage")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("productsName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("productsPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("productsID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("NetCoresubat.Entities.ProductsCategory", b =>
                {
                    b.HasOne("NetCoresubat.Entities.products", "products")
                        .WithMany("ProductsCategories")
                        .HasForeignKey("ProductsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetCoresubat.Entities.category", "category")
                        .WithMany("ProductsCategories")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("products");
                });

            modelBuilder.Entity("NetCoresubat.Entities.category", b =>
                {
                    b.Navigation("ProductsCategories");
                });

            modelBuilder.Entity("NetCoresubat.Entities.products", b =>
                {
                    b.Navigation("ProductsCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
