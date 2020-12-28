using AzureEmulator.Domain.Cloud;
using Microsoft.AspNetCore.Mvc;

namespace AzureEmulator.MVC.Controllers
{
    [Route("[controller]/oauth2")]
    public class CommonController : Controller
    {
        [HttpGet("authorize")]
        public IActionResult authorize([FromQuery] OAuth2_Authorize auth)
        {
            return View();
        }
    }
}
