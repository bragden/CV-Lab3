using Microsoft.EntityFrameworkCore;

namespace CV_Lab3
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<Project> Projects { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}



