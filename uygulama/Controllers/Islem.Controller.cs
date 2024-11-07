using Microsoft.AspNetCore.Mvc;
using uygulama.Models;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IslemController : ControllerBase
    {
        [HttpPost("carpim")]
        public IActionResult PostCarpim([FromBody] CarpimRequest request)
        {
            int carpim = request.sayi1 * request.sayi2;

            return Ok(new { sonuc = carpim });
        }

        [HttpGet("topla")]
        public IActionResult GetTopla([FromQuery] int sayi1, [FromQuery] int sayi22)
        {
            int toplam = sayi1 + sayi22;

            return Ok(new { sonuc = toplam });
        }
    }
}
