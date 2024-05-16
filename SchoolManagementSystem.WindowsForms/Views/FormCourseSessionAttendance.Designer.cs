namespace EFProject.Views
{
    partial class FormCourseSessionAttendance
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
            btnDelete = new Button();
            btnSave = new Button();
            btnNew = new Button();
            lblResult = new Label();
            txtCourseSessionID = new TextBox();
            lblCourseSessionID = new Label();
            lblCourseSessionAttendanceNotes = new Label();
            txtCourseSessionAttendanceGrade = new TextBox();
            lblCourseSessionAttendanceGrade = new Label();
            txtCourseSessionAttendanceID = new TextBox();
            lblCourseSessionAttendanceID = new Label();
            txtStudentID = new TextBox();
            lblStudentID = new Label();
            txtCourseSessionAttendanceNotes = new TextBox();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(504, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(504, 139);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(504, 96);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(489, 12);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 20;
            // 
            // txtCourseSessionID
            // 
            txtCourseSessionID.Location = new Point(208, 137);
            txtCourseSessionID.Name = "txtCourseSessionID";
            txtCourseSessionID.Size = new Size(245, 23);
            txtCourseSessionID.TabIndex = 19;
            // 
            // lblCourseSessionID
            // 
            lblCourseSessionID.AutoSize = true;
            lblCourseSessionID.Location = new Point(12, 137);
            lblCourseSessionID.Name = "lblCourseSessionID";
            lblCourseSessionID.Size = new Size(100, 15);
            lblCourseSessionID.TabIndex = 18;
            lblCourseSessionID.Text = "Course Session ID";
            // 
            // lblCourseSessionAttendanceNotes
            // 
            lblCourseSessionAttendanceNotes.AutoSize = true;
            lblCourseSessionAttendanceNotes.Location = new Point(12, 96);
            lblCourseSessionAttendanceNotes.Name = "lblCourseSessionAttendanceNotes";
            lblCourseSessionAttendanceNotes.Size = new Size(38, 15);
            lblCourseSessionAttendanceNotes.TabIndex = 16;
            lblCourseSessionAttendanceNotes.Text = "Notes";
            // 
            // txtCourseSessionAttendanceGrade
            // 
            txtCourseSessionAttendanceGrade.Location = new Point(208, 53);
            txtCourseSessionAttendanceGrade.Name = "txtCourseSessionAttendanceGrade";
            txtCourseSessionAttendanceGrade.Size = new Size(245, 23);
            txtCourseSessionAttendanceGrade.TabIndex = 15;
            // 
            // lblCourseSessionAttendanceGrade
            // 
            lblCourseSessionAttendanceGrade.AutoSize = true;
            lblCourseSessionAttendanceGrade.Location = new Point(12, 53);
            lblCourseSessionAttendanceGrade.Name = "lblCourseSessionAttendanceGrade";
            lblCourseSessionAttendanceGrade.Size = new Size(38, 15);
            lblCourseSessionAttendanceGrade.TabIndex = 14;
            lblCourseSessionAttendanceGrade.Text = "Grade";
            // 
            // txtCourseSessionAttendanceID
            // 
            txtCourseSessionAttendanceID.Location = new Point(208, 9);
            txtCourseSessionAttendanceID.Name = "txtCourseSessionAttendanceID";
            txtCourseSessionAttendanceID.ReadOnly = true;
            txtCourseSessionAttendanceID.Size = new Size(245, 23);
            txtCourseSessionAttendanceID.TabIndex = 13;
            // 
            // lblCourseSessionAttendanceID
            // 
            lblCourseSessionAttendanceID.AutoSize = true;
            lblCourseSessionAttendanceID.Location = new Point(12, 9);
            lblCourseSessionAttendanceID.Name = "lblCourseSessionAttendanceID";
            lblCourseSessionAttendanceID.Size = new Size(164, 15);
            lblCourseSessionAttendanceID.TabIndex = 12;
            lblCourseSessionAttendanceID.Text = "Course Session Attendance ID";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(208, 180);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(245, 23);
            txtStudentID.TabIndex = 25;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(12, 184);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(62, 15);
            lblStudentID.TabIndex = 24;
            lblStudentID.Text = "Student ID";
            // 
            // txtCourseSessionAttendanceNotes
            // 
            txtCourseSessionAttendanceNotes.Location = new Point(208, 96);
            txtCourseSessionAttendanceNotes.Name = "txtCourseSessionAttendanceNotes";
            txtCourseSessionAttendanceNotes.Size = new Size(245, 23);
            txtCourseSessionAttendanceNotes.TabIndex = 17;
            // 
            // FormCourseSessionAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 230);
            Controls.Add(txtStudentID);
            Controls.Add(lblStudentID);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(lblResult);
            Controls.Add(txtCourseSessionID);
            Controls.Add(lblCourseSessionID);
            Controls.Add(txtCourseSessionAttendanceNotes);
            Controls.Add(lblCourseSessionAttendanceNotes);
            Controls.Add(txtCourseSessionAttendanceGrade);
            Controls.Add(lblCourseSessionAttendanceGrade);
            Controls.Add(txtCourseSessionAttendanceID);
            Controls.Add(lblCourseSessionAttendanceID);
            Name = "FormCourseSessionAttendance";
            Text = "Course Session Attendance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnSave;
        private Button btnNew;
        private Label lblResult;
        private TextBox txtCourseSessionID;
        private Label lblCourseSessionID;
        private Label lblCourseSessionAttendanceNotes;
        private TextBox txtCourseSessionAttendanceGrade;
        private Label lblCourseSessionAttendanceGrade;
        private TextBox txtCourseSessionAttendanceID;
        private Label lblCourseSessionAttendanceID;
        private TextBox txtStudentID;
        private Label lblStudentID;
        private TextBox txtCourseSessionAttendanceNotes;
    }
}