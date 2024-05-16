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
    public partial class FormCourseSessionAttendance : Form
    {
        public FormCourseSessionAttendance()
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
        CourseSessionAttendance courseSessionAttendance;
        MyAppDBContext db = new MyAppDBContext();
        /*--------------------------------------------------------------------------*/
        public FormCourseSessionAttendance(int courseSessionAttendanceID) : this()
        {
            Load(courseSessionAttendanceID);
        }
        /*--------------------------------------------------------------------------*/
        void Load(int courseSessionAttendanceID)
        {
            courseSessionAttendance = db.CoursesSessionsAttendance.First(csa => csa.ID == courseSessionAttendanceID);
            txtCourseSessionAttendanceID.Text = courseSessionAttendance.ID.ToString();
            txtCourseSessionAttendanceGrade.Text = courseSessionAttendance.Grade.ToString();
            txtCourseSessionAttendanceNotes.Text = courseSessionAttendance.Notes;
            txtCourseSessionID.Text = courseSessionAttendance.CourseSessionID.ToString();
            txtStudentID.Text = courseSessionAttendance.StudentID.ToString();
            IsNew = false;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Validate courseSessionAttendance Grade
            if (!int.TryParse(txtCourseSessionAttendanceGrade.Text, out int courseSessionAttendanceGrade))
            {
                MessageBox.Show("Invalid Course Session Attendance Grade. Please enter a valid number");
                return;
            }
            else
            {
                courseSessionAttendance.Grade = courseSessionAttendanceGrade;
            }

            // Validate courseSessionAttendance Notes
            if (!Regex.IsMatch(txtCourseSessionAttendanceNotes.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid Course Session Attendance Notes. Please enter a Notes containing only letters.");
                return;
            }
            else
            {
                courseSessionAttendance.Notes = txtCourseSessionAttendanceNotes.Text;
            }

            // Validate CourseSession ID
            if (int.TryParse(txtCourseSessionID.Text, out int courseSessionID))
            {
                // Check if CourseSession with the provided ID exists in the database
                var existingCourseSession = db.CoursesSessions.FirstOrDefault(cs => cs.ID == courseSessionID);

                if (existingCourseSession != null)
                {
                    courseSessionAttendance.CourseSessionID = courseSessionID;
                }
                else
                {
                    MessageBox.Show("Course with the provided ID does not exist. Please enter a valid ID.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Course Session ID. Please enter a valid ID.");
                return;
            }

            // Validate Student ID
            if (int.TryParse(txtStudentID.Text, out int studentID))
            {
                var existingStudent = db.Instructors.FirstOrDefault(s => s.ID == studentID);

                if (existingStudent != null)
                {
                    courseSessionAttendance.StudentID = studentID;
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

            // Add Course Session to database if new, otherwise update
            if (IsNew)
            {
                db.CoursesSessionsAttendance.Add(courseSessionAttendance);
            }
            int affected = await db.SaveChangesAsync();
            MessageBox.Show("Course Session Attendance Saved");
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
            courseSessionAttendance = new CourseSessionAttendance();
            txtCourseSessionAttendanceID.Text = "";
            txtCourseSessionAttendanceGrade.Text = "";
            txtCourseSessionAttendanceGrade.Text = "";
            txtCourseSessionAttendanceNotes.Text = "";
            txtCourseSessionID.Text = "";
            lblResult.Text = "";
            IsNew = true;
        }
        /*--------------------------------------------------------------------------*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.CoursesSessionsAttendance.Remove(courseSessionAttendance);
            int affected = db.SaveChanges();
            MessageBox.Show("Course Session Attendance Deleted");
            lblResult.Text = $"{affected} rows affected";
            txtCourseSessionAttendanceID.Text = "";
            txtCourseSessionAttendanceGrade.Text = "";
            txtCourseSessionAttendanceGrade.Text = "";
            txtCourseSessionAttendanceNotes.Text = "";
            txtCourseSessionID.Text = "";
        }
    }
}
