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
using static System.Collections.Specialized.BitVector32;

namespace EFProject.Views
{
    public partial class FormCourseSession : Form
    {
        public FormCourseSession()
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
        CourseSession courseSession;
        MyAppDBContext db = new MyAppDBContext();
        /*--------------------------------------------------------------------------*/
        public FormCourseSession(int courseSessionID) : this()
        {
            Load(courseSessionID);
        }
        /*--------------------------------------------------------------------------*/
        void Load(int courseSessionID)
        {
            courseSession = db.CoursesSessions.First(cs => cs.ID == courseSessionID);
            txtCourseSessionID.Text = courseSession.ID.ToString();
            txtCourseSessionDate.Text = courseSession.Date.ToString();
            txtCourseSessionTitle.Text = courseSession.Title;
            txtCourseID.Text = courseSession.CSessionCourseID.ToString();
            txtInstructorID.Text = courseSession.InstructorID.ToString();
            IsNew = false;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Validate courseSession Date
            if (!DateTime.TryParse(txtCourseSessionDate.Text, out DateTime dateValue))
            {
                MessageBox.Show("Invalid date format. Please enter a valid date.");
                return;
            }
            else
            {
                courseSession.Date = dateValue;
            }

            // Validate courseSession Title
            if (!Regex.IsMatch(txtCourseSessionTitle.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid Course Session Title. Please enter a Title containing only letters.");
                return;
            }
            else
            {
                courseSession.Title = txtCourseSessionTitle.Text;
            }

            // Validate Course ID
            if (int.TryParse(txtCourseID.Text, out int courseID))
            {
                // Check if Course with the provided ID exists in the database
                var existingCourse = db.Courses.FirstOrDefault(c => c.ID == courseID);

                if (existingCourse != null)
                {
                    courseSession.CSessionCourseID = courseID;
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

            // Validate Instructor ID
            if (int.TryParse(txtInstructorID.Text, out int instructorID))
            {
                var existingInstructor = db.Instructors.FirstOrDefault(i => i.ID == instructorID);

                if (existingInstructor != null)
                {
                    courseSession.InstructorID = instructorID;
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

            // Add Course Session to database if new, otherwise update
            if (IsNew)
            {
                db.CoursesSessions.Add(courseSession);
            }
            int affected = await db.SaveChangesAsync();
            MessageBox.Show("Course Session Saved");
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
            courseSession = new CourseSession();
            txtCourseSessionID.Text = "";
            txtCourseSessionDate.Text = "";
            txtCourseSessionTitle.Text = "";
            txtCourseID.Text = "";
            txtInstructorID.Text = "";
            lblResult.Text = "";
            IsNew = true;
        }
        /*--------------------------------------------------------------------------*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.CoursesSessions.Remove(courseSession);
            int affected = db.SaveChanges();
            MessageBox.Show("Course Session Deleted");
            lblResult.Text = $"{affected} rows affected";
            txtCourseSessionID.Text = "";
            txtCourseSessionDate.Text = "";
            txtCourseSessionTitle.Text = "";
            txtCourseID.Text = "";
            txtInstructorID.Text = "";
        }
    }
}
