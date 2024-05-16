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
    public partial class FormStudentsList : Form
    {
        public FormStudentsList()
        {
            InitializeComponent();
        }
        /*--------------------------------------------------------------------------*/
        async Task LoadStudents()
        {
            btnLoad.Enabled = false;
            MyAppDBContext db = new MyAppDBContext();
            var students = db.Students.AsQueryable();

            if (int.TryParse(txtStudID.Text, out int studentID) && studentID > 0)
            {
                students = students.Where(s => s.ID == studentID);
            }
            if (txtStudFN.Text.Length > 0)
            {
                students = students.Where(s => s.FirstName.Contains(txtStudFN.Text.Trim()));
            }
            if (txtStudLN.Text.Length > 0)
            {
                students = students.Where(s => s.LastName.Contains(txtStudLN.Text.Trim()));
            }
            gridStudents.DataSource = await students.ToListAsync();
            btnLoad.Enabled = true;
        }
        /*--------------------------------------------------------------------------*/
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadStudents();
        }
        /*--------------------------------------------------------------------------*/
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(gridStudents.CurrentRow.DataBoundItem is Student student)
            {
                int studID = student.ID;
                FormStudent frmStudent = new FormStudent(studID);
                frmStudent.ShowDialog();
                LoadStudents();
            }
        }
    }
}
