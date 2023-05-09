using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionsController : ControllerBase
    {
        [HttpGet()]
        [Route("[action]")]
        public ActionResult Get()
        {
            string version = "1.0";
                return Ok(version);
        }
    }
}
