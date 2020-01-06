using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EFCoreLearning.Domain
{
    public class DatabaseContext : DbContext
    {
        #region One-To-One Mapping
        public DbSet<Author> Author { get; set; }
        public DbSet<AuthorBiography> AuthorBiography { get; set; } 
        #endregion

        #region Family Tree
        //Family Tree
        public DbSet<GrandGrandParent> GrandGrandParents { get; set; }
        public DbSet<GrandParent> GrandParents { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }

        #endregion

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
            #region One-To-One Mapping
            modelBuilder.Entity<Author>().ToTable("Authors");
            modelBuilder.Entity<AuthorBiography>().ToTable("AuthorBiographys");
            modelBuilder.Entity<Author>()
                .HasOne(x => x.Biography)
                .WithOne(x => x.Author)
                .HasForeignKey<AuthorBiography>(x => x.AuthorRef);
            #endregion

            #region One-to-Many Mapping
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

            #endregion

            #region Many-to-Many Mapping
            //Many-to-Many Mapping
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne<Student>(x => x.Student)
                .WithMany(x => x.StudentCourses)
                .HasForeignKey(x => x.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne<Course>(x => x.Course)
                .WithMany(x => x.StudentCourses)
                .HasForeignKey(x => x.CourseId);
            #endregion

            #region Family Tree Mapping
            //GrandParent-Parent-Child
            modelBuilder.Entity<GrandGrandParent>(entity =>
            {
                entity.ToTable("GrandGrandParents");
                entity.Property(X => X.GrandGrandParentID).HasColumnName("ID");
                entity.Property(x => x.GrandGrandParentName).HasColumnName("Name");
            });

            modelBuilder.Entity<GrandParent>(entity =>
            {
                entity.ToTable("GrandParents");
                entity.HasKey(x => x.GrandParentID);
                entity.Property(x => x.GrandParentID).HasColumnName("ID");
                entity.Property(x => x.GrandParentName).HasColumnName("Name");
            });
            modelBuilder.Entity<Parent>(entity =>
            {
                entity.ToTable("Parents");
                entity.Property(x => x.ParentID).HasColumnName("ID");
                entity.Property(x => x.ParentName).HasColumnName("Name");
            });
            modelBuilder.Entity<Child>(entity =>
            {
                entity.ToTable("Child");
                entity.Property(x => x.ChildID).HasColumnName("ID");
                entity.Property(x => x.ChildName).HasColumnName("Name");
            });

            modelBuilder.Entity<GrandGrandParent>()
                .HasMany(x => x.GrandParents)
                .WithOne(x => x.GrandGrandParent);

            modelBuilder.Entity<GrandParent>()
                .HasMany(x => x.Parents)
                .WithOne(x => x.GrandParent);

            modelBuilder.Entity<Parent>()
                .HasMany(x => x.Children)
                .WithOne(x => x.Parent); 
            #endregion

            //Lazy loading

            //Eager Loading

            base.OnModelCreating(modelBuilder);
        }
    }
}
