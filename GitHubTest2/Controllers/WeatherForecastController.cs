using Microsoft.AspNetCore.Mvc;

namespace GitHubTest2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var response = new { name = "Ben Meunier" };
            return Ok(response);
        }
    }
}
