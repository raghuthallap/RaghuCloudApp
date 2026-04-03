using Microsoft.AspNetCore.Mvc;

namespace RaghuCloudApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("🔥 RaghuCloudApp Deployment SUCCESS - V3");
            return Ok("Healthy-V3");
        }

        [HttpGet("info")]
        public IActionResult GetInfo()
        {
            var info = new
            {
                Application = "RaghuCloudApp",
                Version = "1.0",
                Environment = Environment.MachineName,
                ServerTime = DateTime.UtcNow
            };

            return Ok(info);
        }
    }
}
