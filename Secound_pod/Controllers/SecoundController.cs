using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Secound_pod.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecoundController : ControllerBase
    {

        [HttpGet("Ping")]
        public string get_ping()
        {
            return "success from secound apis";
        }
    }
}
