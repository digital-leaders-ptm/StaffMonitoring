using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StaffMonitoring.Models;

namespace StaffMonitoring.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionController : ControllerBase
    {
        private RegionContext regionContext;

        public RegionController(RegionContext regionContext)
        {
            this.regionContext = regionContext;
            if (!regionContext.Regions.Any())
            {
                regionContext.Regions.Add(new Region(1, "Saratov", 0.1));
                regionContext.Regions.Add(new Region(2, "Moscow", 0.5));
                regionContext.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<Region> GetRegions()
        {
            return regionContext.Regions.ToList();
        }
    }
}