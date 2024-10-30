using Ambica.Services.ProductApi.Data;
using Ambica.Services.ProductApi.model.Dto;
using Humanizer;

namespace Ambica.Services.ProductApi.Repository
{
    public class ProductDisplayDtoService :IProductDisplayDtoService
    {
        private readonly ProductContext _productContext;//

        public ProductDisplayDtoService(ProductContext productContext)
        {
            _productContext = productContext;

        }

        public async Task<List<ProductDisplayDto>> GetProduct()
        {
            List<ProductDisplayDto> l= new List<ProductDisplayDto>();
            var lis = _productContext.products;           
            foreach(var i in lis )
            {
                l.Add(new ProductDisplayDto()
                {
                    Name = i.Name,
                    Price = i.Price,
                    Quantity = i.Quantity,
                    Availability = i.Availability
                });
            }
            return  l;
        }
    }
}
