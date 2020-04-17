using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeAPI.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GrocerLinkController : ControllerBase
    {
        [HttpGet]
        public async Task<string> GetAsync(string keyword)
        {
            try
            {
                var exampleRequester = new HttpRequests();
                var url = "https://culinarycompaniongrocerlink.azurewebsites.net/grocerlink?keyword=";
                url += keyword;
                return await exampleRequester.GetAsync(url);
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}