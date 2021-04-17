using System.Collections.Generic;

namespace StaffMonitoring.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}