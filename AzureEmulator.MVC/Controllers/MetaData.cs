using AzureEmulator.Domain.Cloud;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AzureEmulator.MVC.Controllers
{
    [Route("[controller]")]
    public class MetaData : Controller
    {
        /*
          az cloud register ^
          -n AzureEmulatorCloud ^
          --endpoint-resource-manager="http://localhost:5000" 
         */
        [HttpGet("endpoints")]
        public IActionResult EndPoints()
        {
            CloudEndpoints results = new CloudEndpoints()
            {
                galleryEndpoint = "http://gallery.localhost:5000/",
                graphEndpoint = "http://graph.localhost:5000/",
                portalEndpoint = "http://portal.localhost:5000",
                authentication = new Authentication()
                {
                    audiences = new List<string>() { "http://localhost:5000" },
                    loginEndpoint = "http://login.localhost:5000"
                }
            };

            return Ok(results);
        }
    }
}
