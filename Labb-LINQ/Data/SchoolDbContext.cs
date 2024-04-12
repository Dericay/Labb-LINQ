using Microsoft.EntityFrameworkCore;
using Labb_LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_LINQ.Data
{
    internal class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = ANTON ;Initial Catalog = Labb-LINQ;TrustServerCertificate =True;Integrated security =True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(new Student { StudentID = 1, StudentName = "Anton Larsson", TeacherID = 1});
            modelBuilder.Entity<Student>().HasData(new Student { StudentID = 2, StudentName = "Maureen Supit", TeacherID = 2 });
            modelBuilder.Entity<Student>().HasData(new Student { StudentID = 3, StudentName = "Alfred Larsson", TeacherID = 4 });
            modelBuilder.Entity<Student>().HasData(new Student { StudentID = 4, StudentName = "Hilma Lundahl", TeacherID = 3 });
            modelBuilder.Entity<Student>().HasData(new Student { StudentID = 5, StudentName = "Lars-Göte", TeacherID = 1 });

            modelBuilder.Entity<Teacher>().HasData(new Teacher {  TeacherID = 1, TeacherName = "Anas Qlok", SubjectID = 1 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherID = 2, TeacherName = "Tobias Qlok", SubjectID = 2 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherID = 3, TeacherName = "Reidar Qlok", SubjectID = 3 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherID = 4, TeacherName = "Sara Sarasson", SubjectID = 1 });

            modelBuilder.Entity<Course>().HasData(new Course { CourseID = 1, CourseName = "SUT23" });
            modelBuilder.Entity<Course>().HasData(new Course { CourseID = 2, CourseName = "SUT24" });

            modelBuilder.Entity<Subject>().HasData(new Subject { SubjectID = 1, SubjectName = "Advanced.NET" });
            modelBuilder.Entity<Subject>().HasData(new Subject { SubjectID = 2, SubjectName = "Programing 1" });
            modelBuilder.Entity<Subject>().HasData(new Subject { SubjectID = 3, SubjectName = "Math" });
            modelBuilder.Entity<Subject>().HasData(new Subject { SubjectID = 4, SubjectName = "Programing 2" });
        }
    }
}
