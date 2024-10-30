using Ambica.Services.ProductApi.model;

namespace Ambica.Services.ProductApi.Repository
{
    public interface IProductService
    {
        public Product GetAll();

        public Product GetById(int id);

        public void PutDeleteById(int id);

        public Product PostAddProduct();

        public Product PostUpdateProduct();

    }
}
