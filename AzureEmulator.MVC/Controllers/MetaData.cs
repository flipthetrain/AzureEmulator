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
          --cloud-config @"cloud.json"
         */
        [HttpGet("endpoints")]
        public IActionResult EndPoints()
        {
            Cloud results = new Cloud()
            {
                 endpoints=new Endpoints() { },
                 suffixes=new Suffixes() { }
            };

            return Ok(results);
        }
    }
}
