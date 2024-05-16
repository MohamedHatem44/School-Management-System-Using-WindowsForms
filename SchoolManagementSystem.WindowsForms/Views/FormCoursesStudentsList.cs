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
    public partial class FormCoursesStudentsList : Form
    {
        public FormCoursesStudentsList()
        {
            InitializeComponent();
        }
        /*--------------------------------------------------------------------------*/
        async Task LoadCoursesStudents()
        {
            btnLoad.Enabled = false;
            MyAppDBContext db = new MyAppDBContext();

            var courses_students = from cs in db.Courses_Students
                                   join s in db.Students on cs.StudentID equals s.ID
                                   join c in db.Courses on cs.CStudentCourseID equals c.ID
                                   select new
                                   {
                                       Student = s.FirstName + " " + s.LastName,
                                       cs.StudentID,
                                       c.Name,
                                       cs.CStudentCourseID,
                                   };

            if (int.TryParse(txtStudID.Text, out int studID) && studID > 0)
            {
                courses_students = courses_students.Where(cs => cs.StudentID == studID);
            }
            if (int.TryParse(txtCourseID.Text, out int courseID) && courseID > 0)
            {
                courses_students = courses_students.Where(cs => cs.CStudentCourseID == courseID);
            }
            gridCoursesStudents.DataSource = await courses_students.ToListAsync();
            btnLoad.Enabled = true;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadCoursesStudents();
        }
        /*--------------------------------------------------------------------------*/
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (gridCoursesStudents.CurrentRow?.DataBoundItem is { } item)
            {
                var properties = item.GetType().GetProperties();
                int studID = (int)properties.FirstOrDefault(p => p.Name == "StudentID")?.GetValue(item);
                int courseID = (int)properties.FirstOrDefault(p => p.Name == "CStudentCourseID")?.GetValue(item);

                if (studID != 0 && courseID != 0)
                {
                    FormCourseStudent frmCourseStudent = new FormCourseStudent(studID, courseID);
                    frmCourseStudent.ShowDialog();
                    LoadCoursesStudents();
                }
            }
        }
    }
}
