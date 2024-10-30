using Ambica.Services.ProductApi.model;
using Microsoft.EntityFrameworkCore;

namespace Ambica.Services.ProductApi.Data
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        DbSet<Product> products {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1112,
                Name = "Mirchi Powder",
                Availability = true,
                Price = 250,
                Quantity = 500
            });



        }

    }
}
