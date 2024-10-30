using Ambica.Services.ProductApi.Data;
using Ambica.Services.ProductApi.model;
using Ambica.Services.ProductApi.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ambica.Services.ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

            public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        // GET: api/<ProductsController>
        [HttpGet]
        public IActionResult GetDetails()
        {
            return Ok(_productService.GetAll());
              
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            bool result =  _productService.PostAddProduct(product);
            return Ok(result);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result =_productService.PutDeleteById(id);

            return Ok(result);
        }
    }
}
