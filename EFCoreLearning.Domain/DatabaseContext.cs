using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EFCoreLearning.Domain
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Author> Author { get; set; }
        public DbSet<AuthorBiography> AuthorBiography { get; set; }
        public DatabaseContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=localhost\MSSQLSERVER02;Initial Catalog=EFCoreLearning;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One-One Mapping
            modelBuilder.Entity<Author>().ToTable("Authors");
            modelBuilder.Entity<AuthorBiography>().ToTable("AuthorBiographys");
            modelBuilder.Entity<Author>()
                .HasOne(x => x.Biography)
                .WithOne(x => x.Author)
                .HasForeignKey<AuthorBiography>(x => x.AuthorRef);

            //One to Many mapping
            modelBuilder.Entity<Company>().ToTable("Companys");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Company>()
                .HasMany(c => c.Employees)
                .WithOne(e => e.Company);

            //Or
            //modelBuilder.Entity<Employee>()
            //    .HasOne(x => x.Company)
            //    .WithMany(x => x.Employees);

            //.IsRequired(); for non Optional Relationship

            //.OnDelete(DeleteBehavior.SetNull);
            //.OnDelete(DeleteBehavior.Delete);

            //Many-to-Many Mapping

            //GrandParent-Parent-Child

            //Lazy loading

            //Eager Loading

            base.OnModelCreating(modelBuilder);
        }
    }
}
