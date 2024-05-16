using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Entities
{
    public class Instructor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With CoursesSessions Table
        // Each Instructor Has Many CoursesSessions
        // Each CoursesSessions Belong To One Instructor
        public List<CourseSession> CourseSessions { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With Course Table
        // Each Instructor Has Many Courses
        // Each Course Belong To One Instructor
        public List<Course> Courses { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With Department Table
        // Each Department Has Many Instructors
        // Each Instructor Belong To One Department
        public Department Department { get; set; }
        //FK From Department Table
        public int DepartmentID { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With Department Table
        // Each Department Has One Instructor Manager
        // Each Instructor Manager Manage One Department
        public Department DepartmentToBeManage { get; set; }
        /*-----------------------------------------------------------------------------*/
    }
}
