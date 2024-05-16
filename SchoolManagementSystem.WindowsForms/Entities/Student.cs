using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        /*-----------------------------------------------------------------------------*/
        // Relation With CoursesSessionsAttendance Table
        // Each Student Has Many CoursesSessionsAttendance
        // Each CoursesSessionsAttendance Belong To One Student
        public List<CourseSessionAttendance>? CourseSessionAttendance { get; set;}
        /*-----------------------------------------------------------------------------*/
        // Relation With Course_Student Table
        // Each Student Has Many Course_Student
        // Each Course_Student Belong To One Student
        public List<Course_Student>? Courses_Students { get; set; }
        /*-----------------------------------------------------------------------------*/
    }
}
