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
    public partial class FormInstructor : Form
    {
        public FormInstructor()
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
        Instructor instructor;
        MyAppDBContext db = new MyAppDBContext();
        /*--------------------------------------------------------------------------*/
        public FormInstructor(int instructorID) : this()
        {
            Load(instructorID);
        }
        /*--------------------------------------------------------------------------*/
        void Load(int instructorID)
        {
            instructor = db.Instructors.First(i => i.ID == instructorID);
            txtInstructorID.Text = instructor.ID.ToString();
            txtInstructorFN.Text = instructor.FirstName;
            txtInstructorLN.Text = instructor.LastName;
            txtInstructorPhone.Text = instructor.Phone;
            txtDepartmentID.Text = instructor.DepartmentID.ToString();
            IsNew = false;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Validate first name
            if (!Regex.IsMatch(txtInstructorFN.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid first name. Please enter a name containing only letters.");
                return;
            }
            else
            {
                instructor.FirstName = txtInstructorFN.Text;
            }

            // Validate last name
            if (!Regex.IsMatch(txtInstructorLN.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid last name. Please enter a name containing only letters.");
                return;
            }
            else
            {
                instructor.LastName = txtInstructorLN.Text;
            }

            // Validate phone number
            if (!Regex.IsMatch(txtInstructorPhone.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Invalid phone number. Please enter a number containing only digits (0-9).");
                return;
            }
            else
            {
                instructor.Phone = txtInstructorPhone.Text;
            }

            // Validate Department ID
            if (int.TryParse(txtDepartmentID.Text, out int departmentID))
            {
                // Check if department with the provided ID exists in the database
                var existingDepartment = db.Departments.FirstOrDefault(d => d.ID == departmentID);

                if (existingDepartment != null)
                {
                    instructor.DepartmentID = departmentID;
                }
                else
                {
                    MessageBox.Show("Department with the provided ID does not exist. Please enter a valid ID.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Department ID. Please enter a valid ID.");
                return;
            }

            // Add student to database if new, otherwise update
            if (IsNew)
            {
                db.Instructors.Add(instructor);
            }
            int affected = await db.SaveChangesAsync();
            MessageBox.Show("Instructor Saved");
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
            instructor = new Instructor();
            txtInstructorID.Text = "";
            txtInstructorFN.Text = "";
            txtInstructorLN.Text = "";
            txtInstructorPhone.Text = "";
            txtDepartmentID.Text = "";
            lblResult.Text = "";
            IsNew = true;
        }
        /*--------------------------------------------------------------------------*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.Instructors.Remove(instructor);
            int affected = db.SaveChanges();
            MessageBox.Show("Instructor Deleted");
            lblResult.Text = $"{affected} rows affected";
            txtInstructorID.Text = "";
            txtInstructorFN.Text = "";
            txtInstructorLN.Text = "";
            txtInstructorPhone.Text = "";
            txtDepartmentID.Text = "";
        }
    }
}
