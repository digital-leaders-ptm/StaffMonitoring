using Microsoft.EntityFrameworkCore;

namespace StaffMonitoring.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated(); // создаем базу данных при первом обращении
            TestValues();
        }

        private void TestValues()
        {
            Regions.Add(new Region() {Name = "Саратовская область" });
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=D:\staffmonitoring.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegionCourse>().HasKey(sc => new { sc.RegionId, sc.CourseId });
            modelBuilder.Entity<RegionVacancy>().HasKey(sc => new {sc.RegionId, sc.VacancyId});
        }
    }
}