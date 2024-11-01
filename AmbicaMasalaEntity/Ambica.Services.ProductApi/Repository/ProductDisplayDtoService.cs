using Ambica.Services.ProductApi.Data;
using Ambica.Services.ProductApi.model.Dto;
using Ambica.Services.ProductApi.Repository.IRepository;
using AutoMapper;
using Humanizer;
using Microsoft.EntityFrameworkCore;

namespace Ambica.Services.ProductApi.Repository
{
    public class ProductDisplayDtoService :IProductDisplayDtoService
    {
        private readonly ProductContext _productContext;//
        private readonly IMapper _mapper;


        public ProductDisplayDtoService(ProductContext productContext, IMapper mapper)
        {
            _productContext = productContext;
            _mapper = mapper;

        }

        //writing an dto and map<lst<dto>>(_db.dbset.ToList())
        public async Task<List<ProductDisplayDto>> GetProduct()
        {
           var productData=_mapper.Map<List<ProductDisplayDto>>(_productContext.products.ToListAsync());
            return productData;
        }
    }
}
