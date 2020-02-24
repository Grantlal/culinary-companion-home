using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using HomeAPI.Requests;

namespace HomeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();

        [HttpGet]
        public string Get(string keyword)
        {
            try
            {
                return "Healthy";
            }
            catch
            {
                return "Nope";
            }
        }
    }
}