using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codehaks.IranData;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCity.Controllers
{
    public class CityController : Controller
    {
        private readonly IranDbContext _db;
        public CityController(IranDbContext db)
        {
            _db = db;
        }

        [Route("api/city")]
        public IActionResult GetCities(int provinceId)
        {
            return Ok(_db.Cities.Where(c=>c.ProvinceID==provinceId));
        }

        [Route("api/province")]
        public IActionResult GetProvinces()
        {

            return Ok(_db.Provinces);
        }
    }
}