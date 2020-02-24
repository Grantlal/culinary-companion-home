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
    public class TechniqueHomeController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();

        [HttpGet]
        public async Task<string> GetTechniqueAsync(string keyword)
        {
            try
            {
                var exampleRequester = new HttpRequests();
                var url = "https://culinary-companion-technique.herokuapp.com/techniques?searchTag=";
                url += keyword;
                return await exampleRequester.GetAsync(url);
            }
            catch
            {
                return "Nope";
            }
        }
    }
}