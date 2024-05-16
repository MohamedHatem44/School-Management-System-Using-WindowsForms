using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Entities
{
    public class CourseSession
    {
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public string Title { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With Instructor Table
        // Each Instructor Has Many CoursesSessions
        // Each CoursesSessions Belong To One Instructor
        public Instructor Instructor { get; set; }
        // FK From Instructor Table
        public int InstructorID { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With Course Table
        // Each Course Has Many CoursesSessions
        // Each CoursesSessions Belong To One Course
        public Course Course { get; set; }
        // FK From Course Table
        public int CSessionCourseID { get; set; }
        /*-----------------------------------------------------------------------------*/
    }
}
