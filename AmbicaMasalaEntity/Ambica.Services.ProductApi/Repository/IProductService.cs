using Ambica.Services.ProductApi.model;

namespace Ambica.Services.ProductApi.Repository
{
    public interface IProductService
    {
        public List<Product> GetAll();

        public Product GetById(int id);

        public bool PutDeleteById(int id);

        public bool  PostAddProduct(Product product);

        public Product PostUpdateProduct();

    }
}
