using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Entities
{
    public class Course_Student
    {
        /*-----------------------------------------------------------------------------*/
        // Relation With Students Table
        // Each Student Has Many Course_Student
        // Each Course_Student Belong To One Student
        public Student Student { get; set; }
        // FK From Student Table
        public int StudentID { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With Courses Table
        // Each Course Has Many Course_Student
        // Each Course_Student Belong To One Course
        public Course Course { get; set; }
        // FK From Course Table
        public int CStudentCourseID { get; set; }
        /*-----------------------------------------------------------------------------*/
    }
}
