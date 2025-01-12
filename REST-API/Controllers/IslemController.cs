using Microsoft.AspNetCore.Mvc;
using REST_API.Models;

namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IslemController : ControllerBase
    {
        [HttpPost("carpim")]
        public IActionResult PostCarpim([FromBody] CarpimRequest request)
        {
            int carpim = request.Sayı1 * request.Sayı2;

            return Ok(new { sonuc = carpim });
        }

        [HttpGet("topla")]
        public IActionResult GetTopla([FromQuery] int Sayı1, [FromQuery] int Sayı2)
        {
            int toplam = Sayı1 + Sayı2;

            return Ok(new { sonuc = toplam });
        }
    }
}
