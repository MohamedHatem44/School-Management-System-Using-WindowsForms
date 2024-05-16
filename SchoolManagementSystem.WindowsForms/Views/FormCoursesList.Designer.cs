namespace EFProject.Views
{
    partial class FormCoursesList
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
            gridCourses = new DataGridView();
            txtCourseName = new TextBox();
            lblCourseName = new Label();
            txtCourseID = new TextBox();
            lblCourseID = new Label();
            ((System.ComponentModel.ISupportInitialize)gridCourses).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(712, 379);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 8;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 379);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // gridCourses
            // 
            gridCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCourses.Location = new Point(12, 112);
            gridCourses.Name = "gridCourses";
            gridCourses.Size = new Size(775, 249);
            gridCourses.TabIndex = 6;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(123, 70);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(245, 23);
            txtCourseName.TabIndex = 41;
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(12, 73);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(79, 15);
            lblCourseName.TabIndex = 40;
            lblCourseName.Text = "Course Name";
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(123, 16);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(245, 23);
            txtCourseID.TabIndex = 39;
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Location = new Point(12, 19);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(58, 15);
            lblCourseID.TabIndex = 38;
            lblCourseID.Text = "Course ID";
            // 
            // FormCoursesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 415);
            Controls.Add(txtCourseName);
            Controls.Add(lblCourseName);
            Controls.Add(txtCourseID);
            Controls.Add(lblCourseID);
            Controls.Add(btnOpen);
            Controls.Add(btnLoad);
            Controls.Add(gridCourses);
            Name = "FormCoursesList";
            Text = "FormCoursesList";
            ((System.ComponentModel.ISupportInitialize)gridCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen;
        private Button btnLoad;
        private DataGridView gridCourses;
        private TextBox txtCourseName;
        private Label lblCourseName;
        private TextBox txtCourseID;
        private Label lblCourseID;
    }
}