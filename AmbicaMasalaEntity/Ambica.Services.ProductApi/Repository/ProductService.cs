using Ambica.Services.ProductApi.Data;
using Ambica.Services.ProductApi.model;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Ambica.Services.ProductApi.Repository
{
    public class ProductService : IProductService
    {
        private readonly ProductContext _productContext;
        public ProductService(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public List<Product> GetAll()
        {
            return _productContext.products.ToList();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool  PostAddProduct(Product product)
        {
            if (product == null)
            {
                return false;
            }

            //Product product1 = new Product()
            //{
            //    Name = product.Name,
            //    Price = product.Price,
            //    Availability = product.Availability,
            //    Quantity = product.Quantity,
            //};

            _productContext.products.Add(product);
            _productContext.SaveChanges();

            return true;
            
        }

        public Product PostUpdateProduct()
        {
            throw new NotImplementedException();
        }

        public bool PutDeleteById(int id)
        {
            var product= _productContext.products.FirstOrDefault(x => x.Id==id);

            if (product == null) { return false; }

            _productContext.products.Remove(product);
            _productContext.SaveChanges();

            return true;


        }
    }
}
