namespace EFProject
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainMenuStrip = new MenuStrip();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            stripMenuAddStudents = new ToolStripMenuItem();
            stripMenuViewStudents = new ToolStripMenuItem();
            departemtsToolStripMenuItem = new ToolStripMenuItem();
            stripMenuAddDepartments = new ToolStripMenuItem();
            stripMenuViewDepartments = new ToolStripMenuItem();
            instructorsToolStripMenuItem = new ToolStripMenuItem();
            stripMenuAddInstructors = new ToolStripMenuItem();
            stripMenuViewInstructors = new ToolStripMenuItem();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            stripMenuAddCourses = new ToolStripMenuItem();
            stripMenuViewCourses = new ToolStripMenuItem();
            coursesStudentToolStripMenuItem = new ToolStripMenuItem();
            stripMenuAddCoursesStudent = new ToolStripMenuItem();
            stripMenuViewCoursesStudent = new ToolStripMenuItem();
            coursesSessionsToolStripMenuItem = new ToolStripMenuItem();
            stripMenuAddCoursesSessions = new ToolStripMenuItem();
            stripMenuViewCoursesSessions = new ToolStripMenuItem();
            coursesSessionsAttendanceToolStripMenuItem = new ToolStripMenuItem();
            stripMenuAddCoursesSessionsAttendance = new ToolStripMenuItem();
            stripMenuViewCoursesSessionsAttendance = new ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, departemtsToolStripMenuItem, instructorsToolStripMenuItem, coursesToolStripMenuItem, coursesStudentToolStripMenuItem, coursesSessionsToolStripMenuItem, coursesSessionsAttendanceToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(692, 24);
            mainMenuStrip.TabIndex = 2;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripMenuAddStudents, stripMenuViewStudents });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(65, 20);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // stripMenuAddStudents
            // 
            stripMenuAddStudents.Name = "stripMenuAddStudents";
            stripMenuAddStudents.Size = new Size(99, 22);
            stripMenuAddStudents.Text = "Add";
            stripMenuAddStudents.Click += stripMenuAddStudents_Click;
            // 
            // stripMenuViewStudents
            // 
            stripMenuViewStudents.Name = "stripMenuViewStudents";
            stripMenuViewStudents.Size = new Size(99, 22);
            stripMenuViewStudents.Text = "View";
            stripMenuViewStudents.Click += stripMenuViewStudents_Click;
            // 
            // departemtsToolStripMenuItem
            // 
            departemtsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripMenuAddDepartments, stripMenuViewDepartments });
            departemtsToolStripMenuItem.Name = "departemtsToolStripMenuItem";
            departemtsToolStripMenuItem.Size = new Size(80, 20);
            departemtsToolStripMenuItem.Text = "Departemts";
            // 
            // stripMenuAddDepartments
            // 
            stripMenuAddDepartments.Name = "stripMenuAddDepartments";
            stripMenuAddDepartments.Size = new Size(99, 22);
            stripMenuAddDepartments.Text = "Add";
            stripMenuAddDepartments.Click += stripMenuAddDepartments_Click;
            // 
            // stripMenuViewDepartments
            // 
            stripMenuViewDepartments.Name = "stripMenuViewDepartments";
            stripMenuViewDepartments.Size = new Size(99, 22);
            stripMenuViewDepartments.Text = "View";
            stripMenuViewDepartments.Click += stripMenuViewDepartments_Click;
            // 
            // instructorsToolStripMenuItem
            // 
            instructorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripMenuAddInstructors, stripMenuViewInstructors });
            instructorsToolStripMenuItem.Name = "instructorsToolStripMenuItem";
            instructorsToolStripMenuItem.Size = new Size(75, 20);
            instructorsToolStripMenuItem.Text = "Instructors";
            // 
            // stripMenuAddInstructors
            // 
            stripMenuAddInstructors.Name = "stripMenuAddInstructors";
            stripMenuAddInstructors.Size = new Size(99, 22);
            stripMenuAddInstructors.Text = "Add";
            stripMenuAddInstructors.Click += stripMenuAddInstructors_Click;
            // 
            // stripMenuViewInstructors
            // 
            stripMenuViewInstructors.Name = "stripMenuViewInstructors";
            stripMenuViewInstructors.Size = new Size(99, 22);
            stripMenuViewInstructors.Text = "View";
            stripMenuViewInstructors.Click += stripMenuViewInstructors_Click;
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripMenuAddCourses, stripMenuViewCourses });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(61, 20);
            coursesToolStripMenuItem.Text = "Courses";
            // 
            // stripMenuAddCourses
            // 
            stripMenuAddCourses.Name = "stripMenuAddCourses";
            stripMenuAddCourses.Size = new Size(99, 22);
            stripMenuAddCourses.Text = "Add";
            stripMenuAddCourses.Click += stripMenuAddCourses_Click;
            // 
            // stripMenuViewCourses
            // 
            stripMenuViewCourses.Name = "stripMenuViewCourses";
            stripMenuViewCourses.Size = new Size(99, 22);
            stripMenuViewCourses.Text = "View";
            stripMenuViewCourses.Click += stripMenuViewCourses_Click;
            // 
            // coursesStudentToolStripMenuItem
            // 
            coursesStudentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripMenuAddCoursesStudent, stripMenuViewCoursesStudent });
            coursesStudentToolStripMenuItem.Name = "coursesStudentToolStripMenuItem";
            coursesStudentToolStripMenuItem.Size = new Size(105, 20);
            coursesStudentToolStripMenuItem.Text = "Courses Student";
            // 
            // stripMenuAddCoursesStudent
            // 
            stripMenuAddCoursesStudent.Name = "stripMenuAddCoursesStudent";
            stripMenuAddCoursesStudent.Size = new Size(99, 22);
            stripMenuAddCoursesStudent.Text = "Add";
            stripMenuAddCoursesStudent.Click += stripMenuAddCoursesStudent_Click;
            // 
            // stripMenuViewCoursesStudent
            // 
            stripMenuViewCoursesStudent.Name = "stripMenuViewCoursesStudent";
            stripMenuViewCoursesStudent.Size = new Size(99, 22);
            stripMenuViewCoursesStudent.Text = "View";
            stripMenuViewCoursesStudent.Click += stripMenuViewCoursesStudent_Click;
            // 
            // coursesSessionsToolStripMenuItem
            // 
            coursesSessionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripMenuAddCoursesSessions, stripMenuViewCoursesSessions });
            coursesSessionsToolStripMenuItem.Name = "coursesSessionsToolStripMenuItem";
            coursesSessionsToolStripMenuItem.Size = new Size(108, 20);
            coursesSessionsToolStripMenuItem.Text = "Courses Sessions";
            // 
            // stripMenuAddCoursesSessions
            // 
            stripMenuAddCoursesSessions.Name = "stripMenuAddCoursesSessions";
            stripMenuAddCoursesSessions.Size = new Size(99, 22);
            stripMenuAddCoursesSessions.Text = "Add";
            stripMenuAddCoursesSessions.Click += stripMenuAddCoursesSessions_Click;
            // 
            // stripMenuViewCoursesSessions
            // 
            stripMenuViewCoursesSessions.Name = "stripMenuViewCoursesSessions";
            stripMenuViewCoursesSessions.Size = new Size(99, 22);
            stripMenuViewCoursesSessions.Text = "View";
            stripMenuViewCoursesSessions.Click += stripMenuViewCoursesSessions_Click;
            // 
            // coursesSessionsAttendanceToolStripMenuItem
            // 
            coursesSessionsAttendanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripMenuAddCoursesSessionsAttendance, stripMenuViewCoursesSessionsAttendance });
            coursesSessionsAttendanceToolStripMenuItem.Name = "coursesSessionsAttendanceToolStripMenuItem";
            coursesSessionsAttendanceToolStripMenuItem.Size = new Size(172, 20);
            coursesSessionsAttendanceToolStripMenuItem.Text = "Courses Sessions Attendance";
            // 
            // stripMenuAddCoursesSessionsAttendance
            // 
            stripMenuAddCoursesSessionsAttendance.Name = "stripMenuAddCoursesSessionsAttendance";
            stripMenuAddCoursesSessionsAttendance.Size = new Size(180, 22);
            stripMenuAddCoursesSessionsAttendance.Text = "Add";
            stripMenuAddCoursesSessionsAttendance.Click += stripMenuAddCoursesSessionsAttendance_Click;
            // 
            // stripMenuViewCoursesSessionsAttendance
            // 
            stripMenuViewCoursesSessionsAttendance.Name = "stripMenuViewCoursesSessionsAttendance";
            stripMenuViewCoursesSessionsAttendance.Size = new Size(180, 22);
            stripMenuViewCoursesSessionsAttendance.Text = "View";
            stripMenuViewCoursesSessionsAttendance.Click += stripMenuViewCoursesSessionsAttendance_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 255);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Name = "FormMain";
            Text = "Main Form";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem stripMenuAddStudents;
        private ToolStripMenuItem stripMenuViewStudents;
        private ToolStripMenuItem departemtsToolStripMenuItem;
        private ToolStripMenuItem stripMenuAddDepartments;
        private ToolStripMenuItem stripMenuViewDepartments;
        private ToolStripMenuItem instructorsToolStripMenuItem;
        private ToolStripMenuItem stripMenuAddInstructors;
        private ToolStripMenuItem stripMenuViewInstructors;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem stripMenuAddCourses;
        private ToolStripMenuItem stripMenuViewCourses;
        private ToolStripMenuItem coursesStudentToolStripMenuItem;
        private ToolStripMenuItem stripMenuAddCoursesStudent;
        private ToolStripMenuItem stripMenuViewCoursesStudent;
        private ToolStripMenuItem coursesSessionsToolStripMenuItem;
        private ToolStripMenuItem coursesSessionsAttendanceToolStripMenuItem;
        private ToolStripMenuItem stripMenuAddCoursesSessions;
        private ToolStripMenuItem stripMenuViewCoursesSessions;
        private ToolStripMenuItem stripMenuAddCoursesSessionsAttendance;
        private ToolStripMenuItem stripMenuViewCoursesSessionsAttendance;
    }
}
