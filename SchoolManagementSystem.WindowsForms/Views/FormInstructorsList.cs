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
    public partial class FormInstructorsList : Form
    {
        public FormInstructorsList()
        {
            InitializeComponent();
        }
        /*--------------------------------------------------------------------------*/
        async Task LoadInstructors()
        {
            btnLoad.Enabled = false;
            MyAppDBContext db = new MyAppDBContext();
            //var instructors = db.Instructors.AsQueryable();

            var instructors = from i in db.Instructors
                              join d in db.Departments on i.DepartmentID equals d.ID
                              select new
                              {
                                  i.ID,
                                  i.FirstName,
                                  i.LastName,
                                  i.Phone,
                                  Department = d.Name,
                                  i.DepartmentID,
                              };

            if (int.TryParse(txtInstructorID.Text, out int instructorID) && instructorID > 0)
            {
                instructors = instructors.Where(i => i.ID == instructorID);
            }
            else if (txtInstructorFN.Text.Length > 0)
            {
                instructors = instructors.Where(i => i.FirstName.Contains(txtInstructorFN.Text.Trim()));
            }
            else if (txtInstructorLN.Text.Length > 0)
            {
                instructors = instructors.Where(i => i.LastName.Contains(txtInstructorLN.Text.Trim()));
            }
            gridInstructors.DataSource = await instructors.ToListAsync();
            btnLoad.Enabled = true;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadInstructors();
        }
        /*--------------------------------------------------------------------------*/
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (gridInstructors.CurrentRow?.DataBoundItem is { } item)
            {
                var properties = item.GetType().GetProperties();
                int instructorID = (int)properties.FirstOrDefault(p => p.Name == "ID")?.GetValue(item);

                if (instructorID != 0)
                {
                    FormInstructor frmInstructor = new FormInstructor(instructorID);
                    frmInstructor.ShowDialog();
                    LoadInstructors();
                }
            }
        }
    }
}
