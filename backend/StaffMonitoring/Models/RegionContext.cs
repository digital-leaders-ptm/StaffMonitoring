using Microsoft.EntityFrameworkCore;

namespace StaffMonitoring.Models
{
    public class RegionContext : DbContext
    {
        public DbSet<Region> Regions { get; set; }

        public RegionContext(DbContextOptions<RegionContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        
    }
}