using Microsoft.AspNetCore.Mvc;

namespace UC1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, World!");
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"You requested data for ID: {id}");
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return CreatedAtAction(nameof(Get), new { id = 1 }, value);
        }
    }
}