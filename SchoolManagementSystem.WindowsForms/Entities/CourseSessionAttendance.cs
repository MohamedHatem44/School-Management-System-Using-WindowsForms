using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Entities
{
    public class CourseSessionAttendance
    {
        public int ID { get; set; }
        public int Grade { get; set; }
        public string? Notes { get; set; }
     

        /*-----------------------------------------------------------------------------*/
        // Relation With Student Table
        // Each Student Has Many CourseSessionAttendance
        // Each CourseSessionAttendance Belong To One Student
        public Student Student { get; set; }
        // FK Student Table
        public int StudentID { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With CourseSession Table
        // Each CourseSession Has Many CourseSessionAttendance
        // Each CourseSessionAttendance Belong To One CourseSession
        public CourseSession CourseSession { get; set; }
        // FK From CourseSession Table
        public int CourseSessionID { get; set; }
        /*-----------------------------------------------------------------------------*/
    }
}
