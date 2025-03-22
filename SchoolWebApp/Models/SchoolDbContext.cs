using Microsoft.EntityFrameworkCore;

namespace SchoolWebApp.Models
{
    /// <summary>
    /// Database context for the School Database using MySQL.
    /// </summary>
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }

        // Optional: configure table names and relationships here
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().ToTable("teachers");
        }
    }
}
