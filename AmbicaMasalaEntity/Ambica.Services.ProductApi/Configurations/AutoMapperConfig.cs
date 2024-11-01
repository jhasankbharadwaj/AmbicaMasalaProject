using Ambica.Services.ProductApi.model;
using Ambica.Services.ProductApi.model.Dto;
using AutoMapper;

namespace Ambica.Services.ProductApi.Configurations
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            //CreateMap<Product, ProductDisplayDto>();
            //CreateMap<ProductDisplayDto, Product>();
            CreateMap<Product,ProductDisplayDto>().ReverseMap();
        }
    }
}
