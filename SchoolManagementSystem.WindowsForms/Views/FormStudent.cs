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
    public partial class FormStudent : Form
    {
        public FormStudent()
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
        Student student;
        MyAppDBContext db = new MyAppDBContext();
        /*--------------------------------------------------------------------------*/
        public FormStudent(int studID) : this()
        {
            Load(studID);
        }
        /*--------------------------------------------------------------------------*/
        void Load(int studID)
        {
            student = db.Students.First(s => s.ID == studID);
            txtStudID.Text = student.ID.ToString();
            txtStudFN.Text = student.FirstName;
            txtStudLN.Text = student.LastName;
            txtStudPhone.Text = student.Phone;
            IsNew = false;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Validate first name
            if (!Regex.IsMatch(txtStudFN.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid first name. Please enter a name containing only letters.");
                return;
            }

            // Validate last name
            if (!Regex.IsMatch(txtStudLN.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Invalid last name. Please enter a name containing only letters.");
                return;
            }

            // Validate phone number
            if (!Regex.IsMatch(txtStudPhone.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Invalid phone number. Please enter a number containing only digits (0-9).");
                return;
            }

            // Update student object with input values
            student.FirstName = txtStudFN.Text;
            student.LastName = txtStudLN.Text;
            student.Phone = txtStudPhone.Text;

            // Add student to database if new, otherwise update
            if (IsNew)
            {
                db.Students.Add(student);
            }
            int affected = await db.SaveChangesAsync();
            MessageBox.Show("Student Saved");
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
            student = new Student();
            txtStudID.Text = "";
            txtStudFN.Text = "";
            txtStudLN.Text = "";
            txtStudPhone.Text = "";
            lblResult.Text = "";
            IsNew = true;
        }
        /*--------------------------------------------------------------------------*/
        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.Students.Remove(student);
            int affected = db.SaveChanges();
            MessageBox.Show("Student Deleted");
            lblResult.Text = $"{affected} rows affected";
            txtStudID.Text = "";
            txtStudFN.Text = "";
            txtStudLN.Text = "";
            txtStudPhone.Text = "";
        }
    }
}
