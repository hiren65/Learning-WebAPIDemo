using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  //Used Route attribute to define the route for the controller Template
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
        public IActionResult GetShirt(int id, [FromHeader (Name = "color")] string color)
        {
            return Ok($"Shirt {id} {color}");
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
