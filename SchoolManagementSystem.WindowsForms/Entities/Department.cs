using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Entities
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With Course Table
        // Each Department Has Many Courses
        // Each Course Belong To One Department
        public List<Course> Courses { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With Instructor Table
        // Each Department Has One Instructor Manager
        // Each Instructor Manager Manage One Department
        //FK From Instructor Table
        public Instructor Manager { get; set; }
        public int? ManagerID { get; set; }
        /*-----------------------------------------------------------------------------*/
        // Relation With Instructor Table
        // Each Department Has Many Instructors
        // Each Instructor Belong To One Department
        public List<Instructor> Instructors { get; set; }
        /*-----------------------------------------------------------------------------*/
    }
}
