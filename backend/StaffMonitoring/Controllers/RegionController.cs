using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StaffMonitoring.Models;

namespace StaffMonitoring.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionController : ControllerBase
    {
        private readonly ApplicationContext db;

        public RegionController(ApplicationContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IEnumerable<RegionValuesDTO> GetRegions()
        {
            //TODO
            var rand = new Random();
            return db.Regions.Select(region => new RegionValuesDTO() {Region = region.Name, Value = rand.NextDouble()});
        }
    }
}