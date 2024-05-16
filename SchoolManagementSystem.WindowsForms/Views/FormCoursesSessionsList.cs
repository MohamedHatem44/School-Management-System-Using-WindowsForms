using EFProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFProject.Views
{
    public partial class FormCoursesSessionsList : Form
    {
        public FormCoursesSessionsList()
        {
            InitializeComponent();
        }
        /*--------------------------------------------------------------------------*/
        async Task LoadCoursesSessions()
        {
            btnLoad.Enabled = false;
            MyAppDBContext db = new MyAppDBContext();

            var courseSession = from cs in db.CoursesSessions
                                join i in db.Instructors on cs.InstructorID equals i.ID
                                join c in db.Courses on cs.CSessionCourseID equals c.ID
                                select new
                                {
                                    cs.ID,
                                    cs.Date,
                                    cs.Title,
                                    cs.InstructorID,
                                    Instructor = i.FirstName + " " + i.LastName,
                                    CourseName = c.Name,
                                    cs.CSessionCourseID,
                                };

            if (int.TryParse(txtCourseSessionID.Text, out int courseSessionID) && courseSessionID > 0)
            {
                courseSession = courseSession.Where(cs => cs.ID == courseSessionID);
            }
            if (txtCourseSessionTitle.Text.Length > 0)
            {
                courseSession = courseSession.Where(cs => cs.Title.Contains(txtCourseSessionTitle.Text.Trim()));
            }

            gridCoursesSession.DataSource = await courseSession.ToListAsync();
            btnLoad.Enabled = true;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadCoursesSessions();
        }
        /*--------------------------------------------------------------------------*/
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (gridCoursesSession.CurrentRow?.DataBoundItem is { } item)
            {
                var properties = item.GetType().GetProperties();
                int courseSessionID = (int)properties.FirstOrDefault(p => p.Name == "ID")?.GetValue(item);

                if (courseSessionID != 0)
                {
                    FormCourseSession frmCourseSession = new FormCourseSession(courseSessionID);
                    frmCourseSession.ShowDialog();
                    LoadCoursesSessions();
                }
            }
        }
    }
}
