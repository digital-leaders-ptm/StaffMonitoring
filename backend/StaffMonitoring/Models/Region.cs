using System.Collections.Generic;

namespace StaffMonitoring.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<RegionVacancy> Vacancies { get; set; }
        public ICollection<RegionCourse> Courses { get; set; }
    }
}