using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController: ControllerBase
    {

        // [HttpGet("shirts")]
        [HttpGet]
        //[Route("shirts")]
        public IActionResult GetShirts()
        {
            return Ok("Shirts");
        }

        [HttpGet("{id}")]
        public IActionResult GetShirt(int id)
        {
            return Ok($"Shirt {id}");
        }

        [HttpPost]
        public IActionResult CreateShirt()
        {
            return Ok("Shirt created");
        }

        [HttpPut("shirts/{id}")]
        public IActionResult UpdateShirt(int id)
        {
            return Ok($"Shirt {id} updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteShirt(int id)
        {
            return Ok($"Shirt {id} deleted");
        }
    }
}
