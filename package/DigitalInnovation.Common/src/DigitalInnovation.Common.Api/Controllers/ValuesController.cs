using Microsoft.AspNetCore.Mvc;

namespace DigitalInnovation.Common.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            return Ok("Hello from DigitalInnovation API");
        }

        [HttpGet("goodbye")]
        public IActionResult GetGoodbye()
        {
            return Ok("Goodbye from DigitalInnovation API");
        }
    }
}