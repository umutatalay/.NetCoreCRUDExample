using Microsoft.EntityFrameworkCore;
using NetCoresubat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoresubat.Contexts
{
    public class ProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-IT4752E; database=DbCoreProductsCategories; Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<products>().HasMany(I => I.ProductsCategories).WithOne(I => I.products).HasForeignKey(I => I.ProductsID);
            modelBuilder.Entity<category>().HasMany(I => I.ProductsCategories).WithOne(I => I.category).HasForeignKey(I => I.categoryID);
            // Veri Tekrarının önlenmesi 
            modelBuilder.Entity<ProductsCategory>().HasIndex(I => new
            {
                I.categoryID,
                I.ProductsID,
            }).IsUnique();
        }

        public DbSet<ProductsCategory> ProductsCategory { get; set; }
        public DbSet<products> Products { get; set; }
        public DbSet<category> Categories { get; set; }
    }
}
