using Ambica.Services.ProductApi.model;
using Ambica.Services.ProductApi.model.Dto;
using Ambica.Services.ProductApi.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ambica.Services.ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDisplayDtoController : ControllerBase
    {
        private readonly IProductDisplayDtoService _productDisplayService;

        public ProductDisplayDtoController(IProductDisplayDtoService productDisplayService)
        {
            _productDisplayService = productDisplayService;
        }
        // GET: api/<ProductDisplayDtoController>
       
        [HttpGet]
        public async  Task<IActionResult> GetDetails()
        {
            var result = await _productDisplayService.GetProduct();
            return Ok (result);

        }

        

     
       
      
    }
}
