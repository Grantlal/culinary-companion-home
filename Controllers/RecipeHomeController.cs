﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;


namespace HomeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeHomeController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();

        [HttpGet]
        public string Get()
        {
            try
            {

            }
            catch
            {

            }
            return "Culinary Companion Home API";
        }
    }
}