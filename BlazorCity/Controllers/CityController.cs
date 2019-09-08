using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCity.Controllers
{
    public class CityController : Controller
    {
        [Route("api/city")]
        public IActionResult Index()
        {
            return Ok("I'm working!");
        }
    }
}