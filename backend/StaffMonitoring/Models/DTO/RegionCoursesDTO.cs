using System.Collections.Generic;

namespace StaffMonitoring.Models
{
    public class RegionCoursesDTO
    {
        public string Region { get; set; }
        public ICollection<CourseDTO> Courses { get; set; }
    }
}