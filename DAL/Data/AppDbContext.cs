using System;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Product> Products{ get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ProductImage> ProductsImages { get; set; }
    }
}

