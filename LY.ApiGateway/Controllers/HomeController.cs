using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LY.ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        [HttpGet("Index")]
        public string Index()
        {
            return "Hello Ocelot";
        }
    }
}