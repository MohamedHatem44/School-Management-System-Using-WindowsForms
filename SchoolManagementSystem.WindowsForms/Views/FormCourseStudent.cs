using EFProject.Entities;
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
    public partial class FormCourseStudent : Form
    {
        public FormCourseStudent()
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
        Course_Student course_student;
        MyAppDBContext db = new MyAppDBContext();
        /*--------------------------------------------------------------------------*/
        public FormCourseStudent(int studID, int courseID) : this()
        {
            Load(studID, courseID);
        }
        /*--------------------------------------------------------------------------*/
        void Load(int studID, int courseID)
        {
            course_student = db.Courses_Students.FirstOrDefault(cs => cs.StudentID == studID && cs.CStudentCourseID == courseID);
            txtStudID.Text = course_student.StudentID.ToString();
            txtCourseID.Text = course_student.CStudentCourseID.ToString();
            IsNew = false;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Validate Student ID
            if (int.TryParse(txtStudID.Text, out int studentID))
            {
                // Check if Student with the provided ID exists in the database
                var existingStudent = db.Students.FirstOrDefault(s => s.ID == studentID);

                if (existingStudent != null)
                {
                    // Update course_student object with input values
                    course_student.StudentID = studentID;
                }
                else
                {
                    MessageBox.Show("Student with the provided ID does not exist. Please enter a valid ID.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Student ID. Please enter a valid ID.");
                return;
            }

            // Validate Course ID
            if (int.TryParse(txtCourseID.Text, out int courseID))
            {
                // Check if Course with the provided ID exists in the database
                var existingCourse = db.Courses.FirstOrDefault(d => d.ID == courseID);

                if (existingCourse != null)
                {
                    // Update course_student object with input values
                    course_student.CStudentCourseID = courseID;
                }
                else
                {
                    MessageBox.Show("Course with the provided ID does not exist. Please enter a valid ID.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Course ID. Please enter a valid ID.");
                return;
            }

            // Add course_student to database if new, otherwise update
            if (IsNew)
            {
                db.Courses_Students.Add(course_student);
            }
            int affected = await db.SaveChangesAsync();
            MessageBox.Show("Course_Student Saved");
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
            course_student = new Course_Student();
            txtStudID.Text = "";
            txtCourseID.Text = "";
            lblResult.Text = "";
            IsNew = true;
        }
        /*--------------------------------------------------------------------------*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.Courses_Students.Remove(course_student);
            int affected = db.SaveChanges();
            MessageBox.Show("Course_Student Deleted");
            lblResult.Text = $"{affected} rows affected";
            txtStudID.Text = "";
            txtCourseID.Text = "";
        }
    }
}
