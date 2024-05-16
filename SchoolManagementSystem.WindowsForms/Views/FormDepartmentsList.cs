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
    public partial class FormDepartmentsList : Form
    {
        public FormDepartmentsList()
        {
            InitializeComponent();
        }
        /*--------------------------------------------------------------------------*/
        async Task LoadDepartments()
        {
            btnLoad.Enabled = false;
            MyAppDBContext db = new MyAppDBContext();

            var departments = from d in db.Departments
                              join i in db.Instructors on d.ManagerID equals i.ID into instructorsJoin
                              from instructor in instructorsJoin.DefaultIfEmpty()
                              select new
                              {
                                  d.ID,
                                  d.Name,
                                  d.Location,
                                  Manager = instructor != null ? instructor.FirstName + " " + instructor.LastName : "No Manager",
                                  ManagerID = instructor != null ? d.ManagerID.ToString() : "No Manager",
                              };

            if (int.TryParse(txtDepartmentID.Text, out int departmentID) && departmentID > 0)
            {
                departments = departments.Where(d => d.ID == departmentID);
            }
            if (txtDepartmentName.Text.Length > 0)
            {
                departments = departments.Where(d => d.Name.Contains(txtDepartmentName.Text.Trim()));
            }
            gridDepartments.DataSource = await departments.ToListAsync();
            btnLoad.Enabled = true;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadDepartments();
        }
        /*--------------------------------------------------------------------------*/
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (gridDepartments.CurrentRow?.DataBoundItem is { } item)
            {
                var properties = item.GetType().GetProperties();
                int departmentID = (int)properties.FirstOrDefault(p => p.Name == "ID")?.GetValue(item);

                if (departmentID != 0)
                {
                    FormDepartment frmDepartment = new FormDepartment(departmentID);
                    frmDepartment.ShowDialog();
                    LoadDepartments();
                }
            }
        }
    }
}
