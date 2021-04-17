using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StaffMonitoring.Models;

namespace StaffMonitoring.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionCoursesController
    {
        [HttpPost]
        public void PostRegionCourses(IEnumerable<RegionCoursesDTO> regionCoursesDtos)
        {
        }
    }
}