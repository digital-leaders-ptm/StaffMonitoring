using System.Collections.Generic;

namespace StaffMonitoring.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<RegionCourse> Regions { get; set; }
    }
}