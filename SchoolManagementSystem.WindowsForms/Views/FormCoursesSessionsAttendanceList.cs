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
    public partial class FormCoursesSessionsAttendanceList : Form
    {
        public FormCoursesSessionsAttendanceList()
        {
            InitializeComponent();
        }
        /*--------------------------------------------------------------------------*/
        async Task LoadCoursesSessionsAttendance()
        {
            btnLoad.Enabled = false;
            MyAppDBContext db = new MyAppDBContext();

            var courseSessionAttendance = from csa in db.CoursesSessionsAttendance
                                          join s in db.Students on csa.StudentID equals s.ID
                                          join cs in db.CoursesSessions on csa.CourseSessionID equals cs.ID
                                          select new
                                          {
                                              csa.ID,
                                              csa.Grade,
                                              csa.Notes,
                                              Student = s.FirstName + " " + s.LastName,
                                              csa.StudentID,
                                              cs.Title,
                                              csa.CourseSessionID
                                          };

            if (int.TryParse(txtCourseSessionAttendanceID.Text, out int courseSessionAttendanceID) && courseSessionAttendanceID > 0)
            {
                courseSessionAttendance = courseSessionAttendance.Where(csa => csa.ID == courseSessionAttendanceID);
            }
            if (int.TryParse(txtCourseSessionAttendanceGrade.Text.Trim(), out int grade) && grade > 0)
            {
                courseSessionAttendance = courseSessionAttendance.Where(csa => csa.Grade == grade);
            }
            if (int.TryParse(txtCourseSessionID.Text.Trim(), out int courseSessionID) && courseSessionID > 0)
            {
                courseSessionAttendance = courseSessionAttendance.Where(csa => csa.CourseSessionID == courseSessionID);
            }
            if (int.TryParse(txtStudentID.Text.Trim(), out int studentID) && studentID > 0)
            {
                courseSessionAttendance = courseSessionAttendance.Where(csa => csa.StudentID == studentID);
            }

            gridCoursesSessionAttendance.DataSource = await courseSessionAttendance.ToListAsync();
            btnLoad.Enabled = true;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadCoursesSessionsAttendance();
        }
        /*--------------------------------------------------------------------------*/
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (gridCoursesSessionAttendance.CurrentRow?.DataBoundItem is { } item)
            {
                var properties = item.GetType().GetProperties();
                int courseSessionAttendanceID = (int)properties.FirstOrDefault(p => p.Name == "ID")?.GetValue(item);

                if (courseSessionAttendanceID != 0)
                {
                    FormCourseSessionAttendance frmCourseSessionAttendance = new FormCourseSessionAttendance(courseSessionAttendanceID);
                    frmCourseSessionAttendance.ShowDialog();
                    LoadCoursesSessionsAttendance();
                }
            }
        }
    }
}
