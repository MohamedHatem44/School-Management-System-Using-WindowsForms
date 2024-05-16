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
    public partial class FormCoursesList : Form
    {
        public FormCoursesList()
        {
            InitializeComponent();
        }
        /*--------------------------------------------------------------------------*/
        //async void LoadCourses()
        //{
        //    btnLoad.Enabled = false;
        //    MyAppDBContext db = new MyAppDBContext();
        //    var courses = db.Courses.AsQueryable();

        //    if (int.TryParse(txtCourseID.Text, out int courseID) && courseID > 0)
        //    {
        //        courses = courses.Where(c => c.ID == courseID);
        //    }
        //    else if (txtCourseName.Text.Length > 0)
        //    {
        //        courses = courses.Where(c => c.Name.Contains(txtCourseName.Text.Trim()));
        //    }
        //    gridCourses.DataSource = await courses.ToListAsync();
        //    btnLoad.Enabled = true;
        //}
        async Task LoadCourses()
        {
            btnLoad.Enabled = false;
            MyAppDBContext db = new MyAppDBContext();

            var courses = from c in db.Courses
                        join i in db.Instructors on c.InstructorID equals i.ID
                        join d in db.Departments on c.DepartmentID equals d.ID
                        select new
                        {
                            c.ID,
                            c.Duration,
                            c.Name,
                            c.InstructorID,
                            InstructorName = i.FirstName + " " + i.LastName,
                            c.DepartmentID,
                            DepartmentName = d.Name
                        };

            if (int.TryParse(txtCourseID.Text, out int courseID) && courseID > 0)
            {
                courses = courses.Where(c => c.ID == courseID);
            }
            if (txtCourseName.Text.Length > 0)
            {
                courses = courses.Where(c => c.Name.Contains(txtCourseName.Text.Trim()));
            }

            gridCourses.DataSource = await courses.ToListAsync();

            gridCourses.Columns["InstructorID"].Visible = false;
            gridCourses.Columns["DepartmentID"].Visible = false;
            //foreach (DataGridViewColumn column in gridCourses.Columns)
            //{
            //    if (column.Name == "InstructorID" || column.Name == "DepartmentID")
            //    {
            //        column.Visible = false;
            //    }
            //}
            btnLoad.Enabled = true;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadCourses();
        }
        /*--------------------------------------------------------------------------*/
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (gridCourses.CurrentRow?.DataBoundItem is { } item)
            {
                var properties = item.GetType().GetProperties();
                int courseID = (int)properties.FirstOrDefault(p => p.Name == "ID")?.GetValue(item);

                if (courseID != 0)
                {
                    FormCourse frmCourse = new FormCourse(courseID);
                    frmCourse.ShowDialog();
                    LoadCourses();
                }
            }
        }
    }
}
