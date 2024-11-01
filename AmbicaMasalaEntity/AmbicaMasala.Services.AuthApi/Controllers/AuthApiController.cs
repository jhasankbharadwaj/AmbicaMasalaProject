using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmbicaMasala.Services.AuthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthApiController : ControllerBase
    {
        [HttpPost]
        public  async Task<IActionResult> PostNewUser()
        {

            return Ok();
        }
    }
}
