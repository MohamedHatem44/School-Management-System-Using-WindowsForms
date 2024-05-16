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
    public partial class FormDepartment : Form
    {
        public FormDepartment()
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
        Department department;
        MyAppDBContext db = new MyAppDBContext();
        /*--------------------------------------------------------------------------*/
        public FormDepartment(int departmentID) : this()
        {
            Load(departmentID);
        }
        /*--------------------------------------------------------------------------*/
        void Load(int departmentID)
        {
            department = db.Departments.First(s => s.ID == departmentID);
            txtDeptID.Text = department.ID.ToString();
            txtDeptName.Text = department.Name;
            txtDeptLocation.Text = department.Location;
            txtManagerID.Text = department.ManagerID.ToString();
            IsNew = false;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Validate Department Name
            if (!Regex.IsMatch(txtDeptName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid department name. Please enter a name containing only letters.");
                return;
            }
            else
            {
                department.Name = txtDeptName.Text;
            }

            // Validate Department location
            if (!Regex.IsMatch(txtDeptLocation.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid department location. Please enter a location containing only letters.");
                return;
            }
            else
            {
                department.Location = txtDeptLocation.Text;

            }

            // Validate Department Manager ID
            if (!string.IsNullOrEmpty(txtManagerID.Text) && int.TryParse(txtManagerID.Text, out int managerID))
            {
                var existingManager = db.Instructors.FirstOrDefault(i => i.ID == managerID);

                if (existingManager != null)
                {
                    department.ManagerID = managerID;
                }
                else
                {
                    MessageBox.Show("Manager with the provided ID does not exist. Please enter a valid ID.");
                    return;
                }
            }
            else if(!string.IsNullOrEmpty(txtManagerID.Text))
            {
                MessageBox.Show("Invalid Manager ID. Please enter a valid ID.");
                return;
            }

            // Add Department to database if new, otherwise update
            if (IsNew)
            {
                db.Departments.Add(department);
            }
            int affected = await db.SaveChangesAsync();
            MessageBox.Show("Department Saved");
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
            department = new Department();
            txtDeptID.Text = "";
            txtDeptName.Text = "";
            txtDeptLocation.Text = "";
            txtManagerID.Text = "";
            lblResult.Text = "";
            IsNew = true;
        }
        /*--------------------------------------------------------------------------*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.Departments.Remove(department);
            int affected = db.SaveChanges();
            MessageBox.Show("Department Deleted");
            lblResult.Text = $"{affected} rows affected";
            txtDeptID.Text = "";
            txtDeptName.Text = "";
            txtDeptLocation.Text = "";
            txtManagerID.Text = "";
        }
    }
}
