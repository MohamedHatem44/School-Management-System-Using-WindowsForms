using EFProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EFProject
{
    public class MyAppDBContext : DbContext
    {
        /*------------------------------------------------------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["EFProjectDB"].ConnectionString);
        }
        /*------------------------------------------------------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Students Table
            var studentBulider = modelBuilder.Entity<Student>();
            studentBulider
                .ToTable("Students")
                .HasKey(s => s.ID);
            studentBulider
                .Property(p => p.ID)
                .HasColumnType("int");
            studentBulider
                .Property(p => p.FirstName)
                .IsRequired(true)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");
            studentBulider
                .Property(p => p.LastName)
                .IsRequired(true)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");
            studentBulider
                .Property(p => p.Phone)
                .IsRequired(true)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");
            // Relation With Student Table
            // Each Student Has Many CourseSessionAttendance
            // Each CourseSessionAttendance Belong To One Student
            studentBulider
                .HasMany(s => s.CourseSessionAttendance)
                .WithOne(csa => csa.Student)
                .HasForeignKey(csa => csa.StudentID)
                .OnDelete(DeleteBehavior.NoAction);
            // Relation With Courses_Students Table
            // Each Student Has Many Courses_Students
            // Each Courses_Students Belong To One Student
            studentBulider
                .HasMany(s => s.Courses_Students)
                .WithOne(cs => cs.Student)
                .HasForeignKey(cs => cs.StudentID)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion
            /*-----------------------------------------------------------------------------*/
            #region CoursesSessionsAttendance Table
            var courseSessionAttendanceBulider = modelBuilder.Entity<CourseSessionAttendance>();
            courseSessionAttendanceBulider
                .ToTable("CoursesSessionsAttendance")
                .HasKey(csa => csa.ID);
            courseSessionAttendanceBulider
                .Property(p => p.ID)
                .HasColumnType("int");
            courseSessionAttendanceBulider
                .Property(p => p.Grade)
                .IsRequired(true)
                .HasColumnType("int");
            courseSessionAttendanceBulider
                .Property(p => p.Notes)
                .IsRequired(false)
                .HasMaxLength(255)
                .HasColumnType("varchar(max)")
                .HasDefaultValue("No Notes");
            #endregion
            /*-----------------------------------------------------------------------------*/
            #region Departments Table
            var departmentBulider = modelBuilder.Entity<Department>();
            departmentBulider
                .ToTable("Departments")
                .HasKey(d => d.ID);
            departmentBulider
                .Property(p => p.ID)
                .HasColumnType("int");
            departmentBulider
                .Property(d => d.Name)
                .IsRequired(true)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");
            departmentBulider
               .Property(d => d.Location)
               .IsRequired(false)
               .HasMaxLength(255)
               .HasColumnType("varchar(255)");
            // Relation With Courses Table
            // Each Department Has Many Courses
            // Each Course Belong To One Department
            departmentBulider
                .HasMany(d => d.Courses)
                .WithOne(c => c.Department)
                .HasForeignKey(c => c.DepartmentID)
                .OnDelete(DeleteBehavior.NoAction);
            // Relation With Instructor Table
            // Each Department Has Many Instructors
            // Each Instructor Belong To One Department
            departmentBulider
                 .HasMany(d => d.Instructors)
                 .WithOne(i => i.Department)
                 .HasForeignKey(i => i.DepartmentID)
                 .OnDelete(DeleteBehavior.NoAction);
            #endregion
            /*-----------------------------------------------------------------------------*/
            #region Instructor Table
            var instructorBulider = modelBuilder.Entity<Instructor>();
            instructorBulider
                .ToTable("Instructors")
                .HasKey(i => i.ID);
            instructorBulider
                .Property(i => i.ID)
                .HasColumnType("int");
            instructorBulider
               .Property(i => i.FirstName)
               .IsRequired(true)
               .HasMaxLength(255)
               .HasColumnType("varchar(255)");
            instructorBulider
                .Property(i => i.LastName)
                .IsRequired(true)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");
            instructorBulider
                .Property(i => i.Phone)
                .IsRequired(true)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)");
            // Relation With CoursesSessions Table
            // Each Instructor Has Many CoursesSessions
            // Each CoursesSessions Belong To One Instructor
            instructorBulider
                .HasMany(i => i.CourseSessions)
                .WithOne(cs => cs.Instructor)
                .HasForeignKey(cs => cs.InstructorID)
                .OnDelete(DeleteBehavior.NoAction);
            // Relation With Course Table
            // Each Instructor Has Many Courses
            // Each Course Belong To One Instructor
            instructorBulider
                .HasMany(i => i.Courses)
                .WithOne(c => c.Instructor)
                .HasForeignKey(c => c.InstructorID)
                .OnDelete(DeleteBehavior.NoAction);
            // Define one-to-one relationship with Department using ManagerID
            // Relation With Department Table
            // Each Department Has One Instructor Manager
            // Each Instructor Manager Manage One Department
            instructorBulider
                .HasOne(i => i.DepartmentToBeManage)
                .WithOne(d => d.Manager)
                .HasForeignKey<Department>(d => d.ManagerID)
                .OnDelete(DeleteBehavior.SetNull);
            #endregion
            /*-----------------------------------------------------------------------------*/
            #region Courses Table 
            var courseBulider = modelBuilder.Entity<Course>();
            courseBulider
                .ToTable("Courses")
                .HasKey(c => c.ID);
            courseBulider
                .Property(c => c.ID)
                .HasColumnType("int");
            courseBulider
                .Property(c => c.Duration)
                .IsRequired(true)
                .HasColumnType("int");
            courseBulider
               .Property(c => c.Name)
               .HasMaxLength(255)
               .HasColumnType("varchar(255)");
            // Relation With Course_Student Table
            // Each Course Has Many Course_Student
            // Each Course_Student Belong To One Course
            courseBulider
                .HasMany(c => c.Courses_Students)
                .WithOne(cstudent => cstudent.Course)
                .HasForeignKey(cstudent => cstudent.CStudentCourseID)
                .OnDelete(DeleteBehavior.NoAction);
            // Relation With CourseSession Table
            // Each Course Has Many CoursesSessions
            // Each CourseSession Belong To One Course
            courseBulider
                .HasMany(c => c.CoursesSessions)
                .WithOne(cSession => cSession.Course)
                .HasForeignKey(cSession => cSession.CSessionCourseID)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion
            /*-----------------------------------------------------------------------------*/
            #region Courses_Students Table 
            var courses_StudentsBulider = modelBuilder.Entity<Course_Student>();
            courses_StudentsBulider
                .HasKey(cs => new { cs.StudentID, cs.CStudentCourseID });
            #endregion
            /*-----------------------------------------------------------------------------*/
            #region CoursesSessions Table
            var courseSessionBuilder = modelBuilder.Entity<CourseSession>();
            courseSessionBuilder
                .ToTable("CoursesSessions")
                .HasKey(cs => cs.ID);
            courseSessionBuilder
                .Property(p => p.Date)
                .IsRequired(false)
                .HasColumnType("date")
                .HasDefaultValueSql("GETDATE()");
            courseSessionBuilder
                .Property(cs => cs.Title)
                .IsRequired(false)
                .HasMaxLength(255)
                .HasColumnType("varchar(255)")
                .HasDefaultValue("No Title");
            #endregion
        }
        /*------------------------------------------------------------------------------------------------------*/
        #region DbSet
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Student> Courses_Students { get; set; }
        public DbSet<CourseSession> CoursesSessions { get; set; }
        public DbSet<CourseSessionAttendance> CoursesSessionsAttendance { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        #endregion
        /*------------------------------------------------------------------------------------------------------*/
    }
}
