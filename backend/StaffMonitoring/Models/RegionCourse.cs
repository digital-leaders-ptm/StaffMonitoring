namespace StaffMonitoring.Models
{
    public class RegionCourse
    {
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int Count { get; set; }
    }
}
