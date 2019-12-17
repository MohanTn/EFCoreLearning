using Microsoft.EntityFrameworkCore;

namespace EFCoreLearning.Domain
{
    public class BeforeDataContext : DbContext
    {
        protected BeforeDataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                // Specify the sql connection string
                optionsBuilder.UseSqlServer("server=localhost;database=myDb;uid=myUser;password=myPass;");
            }
        }
        protected void OnModelCreation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");
                entity.HasKey("StudentID");
                entity.
            });
        }
    }
}
