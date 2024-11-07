using Microsoft.AspNetCore.Mvc;

namespace uygulama.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IslemController : ControllerBase
    {
        [HttpGet("add")]
        public ActionResult<int> AddTwoNumbers([FromQuery] int sayi1, [FromQuery] int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return Ok(sonuc);
        }
    }
}

