namespace EFProject.Views
{
    partial class FormCourse
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
            txtInstructorID = new TextBox();
            lblInstructorID = new Label();
            txtDepartmentID = new TextBox();
            lblDepartmentID = new Label();
            txtCourseDuration = new TextBox();
            lblCourseDuration = new Label();
            txtCourseName = new TextBox();
            lblCourseName = new Label();
            txtCourseID = new TextBox();
            lblCourseID = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(469, 183);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(469, 138);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(469, 92);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 27;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(438, 31);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 26;
            // 
            // txtInstructorID
            // 
            txtInstructorID.Location = new Point(160, 184);
            txtInstructorID.Name = "txtInstructorID";
            txtInstructorID.Size = new Size(245, 23);
            txtInstructorID.TabIndex = 25;
            // 
            // lblInstructorID
            // 
            lblInstructorID.AutoSize = true;
            lblInstructorID.Location = new Point(12, 187);
            lblInstructorID.Name = "lblInstructorID";
            lblInstructorID.Size = new Size(72, 15);
            lblInstructorID.TabIndex = 24;
            lblInstructorID.Text = "Instructor ID";
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.Location = new Point(160, 139);
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.Size = new Size(245, 23);
            txtDepartmentID.TabIndex = 31;
            // 
            // lblDepartmentID
            // 
            lblDepartmentID.AutoSize = true;
            lblDepartmentID.Location = new Point(12, 142);
            lblDepartmentID.Name = "lblDepartmentID";
            lblDepartmentID.Size = new Size(84, 15);
            lblDepartmentID.TabIndex = 30;
            lblDepartmentID.Text = "Department ID";
            // 
            // txtCourseDuration
            // 
            txtCourseDuration.Location = new Point(160, 49);
            txtCourseDuration.Name = "txtCourseDuration";
            txtCourseDuration.Size = new Size(245, 23);
            txtCourseDuration.TabIndex = 37;
            // 
            // lblCourseDuration
            // 
            lblCourseDuration.AutoSize = true;
            lblCourseDuration.Location = new Point(12, 52);
            lblCourseDuration.Name = "lblCourseDuration";
            lblCourseDuration.Size = new Size(93, 15);
            lblCourseDuration.TabIndex = 36;
            lblCourseDuration.Text = "Course Duration";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(160, 92);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(245, 23);
            txtCourseName.TabIndex = 35;
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(12, 95);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(79, 15);
            lblCourseName.TabIndex = 34;
            lblCourseName.Text = "Course Name";
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(160, 6);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.ReadOnly = true;
            txtCourseID.Size = new Size(245, 23);
            txtCourseID.TabIndex = 33;
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Location = new Point(12, 9);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(58, 15);
            lblCourseID.TabIndex = 32;
            lblCourseID.Text = "Course ID";
            // 
            // FormCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 225);
            Controls.Add(txtCourseDuration);
            Controls.Add(lblCourseDuration);
            Controls.Add(txtCourseName);
            Controls.Add(lblCourseName);
            Controls.Add(txtCourseID);
            Controls.Add(lblCourseID);
            Controls.Add(txtDepartmentID);
            Controls.Add(lblDepartmentID);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(lblResult);
            Controls.Add(txtInstructorID);
            Controls.Add(lblInstructorID);
            Name = "FormCourse";
            Text = "FormCourse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnSave;
        private Button btnNew;
        private Label lblResult;
        private TextBox txtInstructorID;
        private Label lblInstructorID;
        private TextBox txtDepartmentID;
        private Label lblDepartmentID;
        private TextBox txtCourseDuration;
        private Label lblCourseDuration;
        private TextBox txtCourseName;
        private Label lblCourseName;
        private TextBox txtCourseID;
        private Label lblCourseID;
    }
}