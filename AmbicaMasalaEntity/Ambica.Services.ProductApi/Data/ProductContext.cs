using Ambica.Services.ProductApi.model;
using Microsoft.EntityFrameworkCore;

namespace Ambica.Services.ProductApi.Data
{
    public class ProductContext:DbContext
    {

        //Dbcontext options == helps to parse the config of the current context like server and database location. 
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
       public  DbSet<Product> products {  get; set; }

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
