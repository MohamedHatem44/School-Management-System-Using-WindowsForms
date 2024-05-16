namespace EFProject.Views
{
    partial class FormCoursesStudentsList
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
            btnOpen = new Button();
            btnLoad = new Button();
            gridCoursesStudents = new DataGridView();
            txtCourseID = new TextBox();
            lblCourseID = new Label();
            txtStudID = new TextBox();
            lblStudentID = new Label();
            ((System.ComponentModel.ISupportInitialize)gridCoursesStudents).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(581, 369);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 44;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 369);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 43;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // gridCoursesStudents
            // 
            gridCoursesStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCoursesStudents.Location = new Point(12, 102);
            gridCoursesStudents.Name = "gridCoursesStudents";
            gridCoursesStudents.Size = new Size(644, 249);
            gridCoursesStudents.TabIndex = 42;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(160, 50);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(273, 23);
            txtCourseID.TabIndex = 48;
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Location = new Point(12, 53);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(58, 15);
            lblCourseID.TabIndex = 47;
            lblCourseID.Text = "Course ID";
            // 
            // txtStudID
            // 
            txtStudID.Location = new Point(160, 6);
            txtStudID.Name = "txtStudID";
            txtStudID.Size = new Size(273, 23);
            txtStudID.TabIndex = 46;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(12, 9);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(62, 15);
            lblStudentID.TabIndex = 45;
            lblStudentID.Text = "Student ID";
            // 
            // FormCoursesStudentsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 405);
            Controls.Add(txtCourseID);
            Controls.Add(lblCourseID);
            Controls.Add(txtStudID);
            Controls.Add(lblStudentID);
            Controls.Add(btnOpen);
            Controls.Add(btnLoad);
            Controls.Add(gridCoursesStudents);
            Name = "FormCoursesStudentsList";
            Text = "Courses Students List";
            ((System.ComponentModel.ISupportInitialize)gridCoursesStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOpen;
        private Button btnLoad;
        private DataGridView gridCoursesStudents;
        private TextBox txtCourseID;
        private Label lblCourseID;
        private TextBox txtStudID;
        private Label lblStudentID;
    }
}