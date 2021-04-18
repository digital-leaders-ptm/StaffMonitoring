using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StaffMonitoring.Models;

namespace StaffMonitoring.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionCoursesController
    {
        private readonly ApplicationContext db;

        public RegionCoursesController(ApplicationContext db)
        {
            this.db = db;
        }

        [HttpPost]
        public void PostRegionCourses(IEnumerable<RegionCoursesDTO> regionCoursesDtos)
        {
            foreach (var regionCoursesDto in regionCoursesDtos)
            {
                var region = db.Regions.FirstOrDefault(region => region.Name == regionCoursesDto.Region);
                foreach (var courseDTO in regionCoursesDto.Courses)
                {
                    var regionCourse = region.Courses.FirstOrDefault(regionCourse => regionCourse.Course.Name == courseDTO.Name);
                    regionCourse.Count = courseDTO.Count;
                }
            }
            db.SaveChanges();
        }
    }
}