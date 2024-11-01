using Ambica.Services.ProductApi.model.Dto;

namespace Ambica.Services.ProductApi.Repository.IRepository
{
    public interface IProductDisplayDtoService
    {
        Task<List<ProductDisplayDto>> GetProduct();


    }
}
