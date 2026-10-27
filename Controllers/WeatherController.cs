
using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var weather = new
            {
                City = "Mumbai",
                Temperature = 30,
                Condition = "Sunny"
            };

            return Ok(weather);
        }
    }
}
