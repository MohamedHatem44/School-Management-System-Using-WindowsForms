namespace EFProject.Views
{
    partial class FormCourseStudent
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
            txtCourseID = new TextBox();
            lblCourseID = new Label();
            txtStudID = new TextBox();
            lblStudentID = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(358, 115);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(258, 115);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(160, 115);
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
            lblResult.Location = new Point(207, 87);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 20;
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(160, 50);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(273, 23);
            txtCourseID.TabIndex = 15;
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Location = new Point(12, 53);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(58, 15);
            lblCourseID.TabIndex = 14;
            lblCourseID.Text = "Course ID";
            // 
            // txtStudID
            // 
            txtStudID.Location = new Point(160, 6);
            txtStudID.Name = "txtStudID";
            txtStudID.Size = new Size(273, 23);
            txtStudID.TabIndex = 13;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(12, 9);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(62, 15);
            lblStudentID.TabIndex = 12;
            lblStudentID.Text = "Student ID";
            // 
            // FormCourseStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 174);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(lblResult);
            Controls.Add(txtCourseID);
            Controls.Add(lblCourseID);
            Controls.Add(txtStudID);
            Controls.Add(lblStudentID);
            Name = "FormCourseStudent";
            Text = "Course Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnSave;
        private Button btnNew;
        private Label lblResult;
        private TextBox txtCourseID;
        private Label lblCourseID;
        private TextBox txtStudID;
        private Label lblStudentID;
    }
}