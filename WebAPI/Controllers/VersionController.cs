using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        [HttpGet()]
        [Route("")]
        public ActionResult Get()
        {
            return Ok("Yoklama Api 1.0");
        }
    }
}
