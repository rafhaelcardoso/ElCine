using Microsoft.AspNetCore.Mvc;

namespace ElCine.Api.Controllers
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
