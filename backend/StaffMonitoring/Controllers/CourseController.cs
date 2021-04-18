using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StaffMonitoring.Models;

namespace StaffMonitoring.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ApplicationContext db;

        public CourseController(ApplicationContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IEnumerable<string> GetCourses()
        {
            return db.Courses.Select(course => course.Name);
        }
    }
}