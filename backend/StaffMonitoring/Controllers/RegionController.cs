using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StaffMonitoring.Models;

namespace StaffMonitoring.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Region> GetRegions()
        {
            return null;
        }
    }
}