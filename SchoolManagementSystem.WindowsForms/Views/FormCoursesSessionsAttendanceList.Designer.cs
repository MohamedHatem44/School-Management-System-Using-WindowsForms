namespace EFProject.Views
{
    partial class FormCoursesSessionsAttendanceList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtStudentID = new TextBox();
            lblStudentID = new Label();
            txtCourseSessionID = new TextBox();
            lblCourseSessionID = new Label();
            txtCourseSessionAttendanceGrade = new TextBox();
            lblCourseSessionAttendanceGrade = new Label();
            txtCourseSessionAttendanceID = new TextBox();
            lblCourseSessionAttendanceID = new Label();
            btnOpen = new Button();
            btnLoad = new Button();
            gridCoursesSessionAttendance = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridCoursesSessionAttendance).BeginInit();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(208, 134);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(245, 23);
            txtStudentID.TabIndex = 35;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(12, 138);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(62, 15);
            lblStudentID.TabIndex = 34;
            lblStudentID.Text = "Student ID";
            // 
            // txtCourseSessionID
            // 
            txtCourseSessionID.Location = new Point(208, 91);
            txtCourseSessionID.Name = "txtCourseSessionID";
            txtCourseSessionID.Size = new Size(245, 23);
            txtCourseSessionID.TabIndex = 33;
            // 
            // lblCourseSessionID
            // 
            lblCourseSessionID.AutoSize = true;
            lblCourseSessionID.Location = new Point(12, 91);
            lblCourseSessionID.Name = "lblCourseSessionID";
            lblCourseSessionID.Size = new Size(100, 15);
            lblCourseSessionID.TabIndex = 32;
            lblCourseSessionID.Text = "Course Session ID";
            // 
            // txtCourseSessionAttendanceGrade
            // 
            txtCourseSessionAttendanceGrade.Location = new Point(208, 53);
            txtCourseSessionAttendanceGrade.Name = "txtCourseSessionAttendanceGrade";
            txtCourseSessionAttendanceGrade.Size = new Size(245, 23);
            txtCourseSessionAttendanceGrade.TabIndex = 29;
            // 
            // lblCourseSessionAttendanceGrade
            // 
            lblCourseSessionAttendanceGrade.AutoSize = true;
            lblCourseSessionAttendanceGrade.Location = new Point(12, 53);
            lblCourseSessionAttendanceGrade.Name = "lblCourseSessionAttendanceGrade";
            lblCourseSessionAttendanceGrade.Size = new Size(38, 15);
            lblCourseSessionAttendanceGrade.TabIndex = 28;
            lblCourseSessionAttendanceGrade.Text = "Grade";
            // 
            // txtCourseSessionAttendanceID
            // 
            txtCourseSessionAttendanceID.Location = new Point(208, 9);
            txtCourseSessionAttendanceID.Name = "txtCourseSessionAttendanceID";
            txtCourseSessionAttendanceID.Size = new Size(245, 23);
            txtCourseSessionAttendanceID.TabIndex = 27;
            txtCourseSessionAttendanceID.TabStop = false;
            // 
            // lblCourseSessionAttendanceID
            // 
            lblCourseSessionAttendanceID.AutoSize = true;
            lblCourseSessionAttendanceID.Location = new Point(12, 9);
            lblCourseSessionAttendanceID.Name = "lblCourseSessionAttendanceID";
            lblCourseSessionAttendanceID.Size = new Size(164, 15);
            lblCourseSessionAttendanceID.TabIndex = 26;
            lblCourseSessionAttendanceID.Text = "Course Session Attendance ID";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(793, 430);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 54;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 430);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 53;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // gridCoursesSessionAttendance
            // 
            gridCoursesSessionAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCoursesSessionAttendance.Location = new Point(12, 175);
            gridCoursesSessionAttendance.Name = "gridCoursesSessionAttendance";
            gridCoursesSessionAttendance.Size = new Size(856, 249);
            gridCoursesSessionAttendance.TabIndex = 52;
            // 
            // FormCoursesSessionsAttendanceList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 469);
            Controls.Add(btnOpen);
            Controls.Add(btnLoad);
            Controls.Add(gridCoursesSessionAttendance);
            Controls.Add(txtStudentID);
            Controls.Add(lblStudentID);
            Controls.Add(txtCourseSessionID);
            Controls.Add(lblCourseSessionID);
            Controls.Add(txtCourseSessionAttendanceGrade);
            Controls.Add(lblCourseSessionAttendanceGrade);
            Controls.Add(txtCourseSessionAttendanceID);
            Controls.Add(lblCourseSessionAttendanceID);
            Name = "FormCoursesSessionsAttendanceList";
            Text = "FormCoursesSessionsAttendanceList";
            ((System.ComponentModel.ISupportInitialize)gridCoursesSessionAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private Label lblStudentID;
        private TextBox txtCourseSessionID;
        private Label lblCourseSessionID;
        private TextBox txtCourseSessionAttendanceGrade;
        private Label lblCourseSessionAttendanceGrade;
        private TextBox txtCourseSessionAttendanceID;
        private Label lblCourseSessionAttendanceID;
        private Button btnOpen;
        private Button btnLoad;
        private DataGridView gridCoursesSessionAttendance;
    }
}