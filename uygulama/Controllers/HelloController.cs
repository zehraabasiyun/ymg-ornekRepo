using Microsoft.AspNetCore.Mvc;

namespace uygulama.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("hello world");
        }
    }
}