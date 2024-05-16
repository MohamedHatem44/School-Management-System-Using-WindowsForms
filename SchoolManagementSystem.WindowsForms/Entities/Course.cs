using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Entities
{
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With Course_Student Table
        // Each Course Has Many Course_Student
        // Each Course_Student Belong To One Course
        public List<Course_Student> Courses_Students { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With Department Table
        // Each Department Has Many Courses
        // Each Course Belong To One Department
        // FK From Department Table
        public Department Department { get; set; }
        public int DepartmentID { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With Instructor Table
        // Each Instructor Has Many Courses
        // Each Course Belong To One Instructor
        // FK From Instructor Table
        public Instructor Instructor { get; set; }
        public int InstructorID { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With CourseSession Table
        // Each Course Has Many CourseSession
        // Each CourseSession Belong To One Course
        public List<CourseSession> CoursesSessions { get; set; }
        /*-----------------------------------------------------------------------------*/
    }
}
