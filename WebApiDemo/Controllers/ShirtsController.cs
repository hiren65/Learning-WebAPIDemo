using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [ApiController]
    public class ShirtsController: ControllerBase
    {

        // [HttpGet("shirts")]
        [HttpGet]
        [Route("shirts")]
        public IActionResult GetShirts()
        {
            return Ok("Shirts");
        }

        [HttpGet("shirts/{id}")]
        public IActionResult GetShirt(int id)
        {
            return Ok($"Shirt {id}");
        }

        [HttpPost("shirts")]
        public IActionResult CreateShirt()
        {
            return Ok("Shirt created");
        }

        [HttpPut("shirts/{id}")]
        public IActionResult UpdateShirt(int id)
        {
            return Ok($"Shirt {id} updated");
        }

        [HttpDelete("shirts/{id}")]
        public IActionResult DeleteShirt(int id)
        {
            return Ok($"Shirt {id} deleted");
        }
    }
}
