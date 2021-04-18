using System.Collections.Generic;

namespace StaffMonitoring.Models
{
    public class RegionVacanciesDTO
    {
        public string Region { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}