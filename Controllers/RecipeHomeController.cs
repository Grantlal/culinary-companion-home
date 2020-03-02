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
    public class RecipeHomeController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();

        [HttpPost]
        public async Task<string> PostAsync(string value)
        {
            try
            {
                var recipeRequester = new HttpRequests();
                var uri = "https://u7bwesiqoc.execute-api.us-east-1.amazonaws.com/Prod/search/";
                var body = value;
                return await recipeRequester.PostAsync(uri, body, "JSON");
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}