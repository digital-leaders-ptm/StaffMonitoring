using System.Collections.Generic;

namespace StaffMonitoring.Models.DTO
{
    public class VacancyDTO
    {
        public ICollection<string> Skills { get; set; }
        public int Count { get; set; }
    }
}
