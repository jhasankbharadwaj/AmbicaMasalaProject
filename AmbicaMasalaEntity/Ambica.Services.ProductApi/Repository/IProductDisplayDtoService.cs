using Ambica.Services.ProductApi.model.Dto;

namespace Ambica.Services.ProductApi.Repository
{
    public interface IProductDisplayDtoService
    {
        Task<List<ProductDisplayDto>> GetProduct();

     
    }
}
