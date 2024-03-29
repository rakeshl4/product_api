﻿using BigPurpleBank.Product.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BigPurpleBank.Product.API.Controllers.Infrastructure
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<ProductItem> ProductItem { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }

    public class ProductContextDesignFactory : IDesignTimeDbContextFactory<ProductContext>
    {
        public ProductContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductContext>()
                .UseSqlServer("Server=.;Initial Catalog=BigPurpleBank.Product.API.ProductDb;Integrated Security=true");
            return new ProductContext(optionsBuilder.Options);
        }
    }
}
