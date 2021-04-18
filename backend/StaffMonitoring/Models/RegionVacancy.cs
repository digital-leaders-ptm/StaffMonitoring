namespace StaffMonitoring.Models
{
    public class RegionVacancy
    {
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public int VacancyId { get; set; }
        public Vacancy Vacancy { get; set; }
        public int Count { get; set; }
    }
}
