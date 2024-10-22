using Microsoft.AspNetCore.Mvc;

namespace DigitalInnovation.Common.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet("Hello user")]
        public IActionResult GetHello()
        {
            return OK("Hello from Digital API!!");
        }

        [HttpGet("goodbye user")]
        public IActionResult GetGoodbye()
        {
            return OK("Goodbye from Digital API!!");
        }
    }
}