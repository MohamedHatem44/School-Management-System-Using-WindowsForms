using EFProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFProject.Views
{
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();
            New();
        }
        /*--------------------------------------------------------------------------*/
        bool isNew;
        public bool IsNew
        {
            get => isNew;
            set
            {
                isNew = value;
                btnSave.Text = isNew ? "Add" : "Update";
                btnDelete.Enabled = !isNew;
            }
        }
        /*--------------------------------------------------------------------------*/
        Course course;
        MyAppDBContext db = new MyAppDBContext();
        /*--------------------------------------------------------------------------*/
        public FormCourse(int courseID) : this()
        {
            Load(courseID);
        }
        /*--------------------------------------------------------------------------*/
        void Load(int courseID)
        {
        

            course = db.Courses.First(c => c.ID == courseID);
            txtCourseID.Text = course.ID.ToString();
            txtCourseDuration.Text = course.Duration.ToString();
            txtCourseName.Text = course.Name;
            txtDepartmentID.Text = course.DepartmentID.ToString();
            txtInstructorID.Text = course.InstructorID.ToString();
            IsNew = false;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Validate Course name
            if (!Regex.IsMatch(txtCourseName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid course name. Please enter a name containing only letters.");
                return;
            }
            else
            {
                course.Name = txtCourseName.Text;
            }

            // Validate Course duration
            if (!int.TryParse(txtCourseDuration.Text, out int courseDuration))
            {
                MessageBox.Show("Invalid course duration. Please enter a valid integer value for duration.");
                return;
            }
            else
            {
                course.Duration = courseDuration;
            }

            // Validate Department ID
            if (int.TryParse(txtDepartmentID.Text, out int departmentID))
            {
                var existingDepartment = db.Departments.FirstOrDefault(d => d.ID == departmentID);

                if (existingDepartment != null)
                {
                    course.DepartmentID = departmentID;
                }
                else
                {
                    MessageBox.Show("Department with the provided ID does not exist. Please enter a valid ID.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Department ID. Please enter a valid ID.");
                return;
            }

            // Validate Instructor ID
            if (int.TryParse(txtInstructorID.Text, out int instructorID))
            {
                var existingInstructor = db.Instructors.FirstOrDefault(i => i.ID == instructorID);

                if (existingInstructor != null)
                {
                    course.InstructorID = instructorID;
                }
                else
                {
                    MessageBox.Show("Instructor with the provided ID does not exist. Please enter a valid ID.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Instructor ID. Please enter a valid ID.");
                return;
            }

            // Add Course to database if new, otherwise update
            if (IsNew)
            {
                db.Courses.Add(course);
            }
            int affected = await db.SaveChangesAsync();
            MessageBox.Show("Course Saved");
            IsNew = false;
            lblResult.Text = $"{affected} rows affected";
        }
        /*--------------------------------------------------------------------------*/
        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }
        /*--------------------------------------------------------------------------*/
        void New()
        {
            course = new Course();
            txtCourseID.Text = "";
            txtCourseDuration.Text = "";
            txtCourseName.Text = "";
            txtDepartmentID.Text = "";
            txtInstructorID.Text = "";
            lblResult.Text = "";
            IsNew = true;
        }
        /*--------------------------------------------------------------------------*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.Courses.Remove(course);
            int affected = db.SaveChanges();
            MessageBox.Show("Course Deleted");
            lblResult.Text = $"{affected} rows affected";
            txtCourseID.Text = "";
            txtCourseDuration.Text = "";
            txtCourseName.Text = "";
            txtDepartmentID.Text = "";
            txtInstructorID.Text = "";
        }
    }
}
