using System.Collections.Generic;

namespace StaffMonitoring.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}