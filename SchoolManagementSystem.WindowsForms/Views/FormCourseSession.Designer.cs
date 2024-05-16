namespace EFProject.Views
{
    partial class FormCourseSession
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
            txtCourseSessionID = new TextBox();
            lblCourseSessionID = new Label();
            btnDelete = new Button();
            btnSave = new Button();
            btnNew = new Button();
            lblResult = new Label();
            txtInstructorID = new TextBox();
            lblInstructorID = new Label();
            txtCourseID = new TextBox();
            lblCourseID = new Label();
            txtCourseSessionDate = new TextBox();
            lblCourseSessionDate = new Label();
            txtCourseSessionTitle = new TextBox();
            lblCourseSessionTitle = new Label();
            SuspendLayout();
            // 
            // txtCourseSessionID
            // 
            txtCourseSessionID.Location = new Point(160, 6);
            txtCourseSessionID.Name = "txtCourseSessionID";
            txtCourseSessionID.ReadOnly = true;
            txtCourseSessionID.Size = new Size(245, 23);
            txtCourseSessionID.TabIndex = 47;
            // 
            // lblCourseSessionID
            // 
            lblCourseSessionID.AutoSize = true;
            lblCourseSessionID.Location = new Point(12, 9);
            lblCourseSessionID.Name = "lblCourseSessionID";
            lblCourseSessionID.Size = new Size(100, 15);
            lblCourseSessionID.TabIndex = 46;
            lblCourseSessionID.Text = "Course Session ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(469, 164);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(469, 124);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(469, 83);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 41;
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
            lblResult.TabIndex = 40;
            // 
            // txtInstructorID
            // 
            txtInstructorID.Location = new Point(160, 164);
            txtInstructorID.Name = "txtInstructorID";
            txtInstructorID.Size = new Size(245, 23);
            txtInstructorID.TabIndex = 39;
            // 
            // lblInstructorID
            // 
            lblInstructorID.AutoSize = true;
            lblInstructorID.Location = new Point(12, 167);
            lblInstructorID.Name = "lblInstructorID";
            lblInstructorID.Size = new Size(72, 15);
            lblInstructorID.TabIndex = 38;
            lblInstructorID.Text = "Instructor ID";
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(160, 124);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(245, 23);
            txtCourseID.TabIndex = 49;
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Location = new Point(12, 127);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(58, 15);
            lblCourseID.TabIndex = 48;
            lblCourseID.Text = "Course ID";
            // 
            // txtCourseSessionDate
            // 
            txtCourseSessionDate.Location = new Point(160, 43);
            txtCourseSessionDate.Name = "txtCourseSessionDate";
            txtCourseSessionDate.Size = new Size(245, 23);
            txtCourseSessionDate.TabIndex = 53;
            // 
            // lblCourseSessionDate
            // 
            lblCourseSessionDate.AutoSize = true;
            lblCourseSessionDate.Location = new Point(12, 46);
            lblCourseSessionDate.Name = "lblCourseSessionDate";
            lblCourseSessionDate.Size = new Size(31, 15);
            lblCourseSessionDate.TabIndex = 52;
            lblCourseSessionDate.Text = "Date";
            // 
            // txtCourseSessionTitle
            // 
            txtCourseSessionTitle.Location = new Point(160, 83);
            txtCourseSessionTitle.Name = "txtCourseSessionTitle";
            txtCourseSessionTitle.Size = new Size(245, 23);
            txtCourseSessionTitle.TabIndex = 51;
            // 
            // lblCourseSessionTitle
            // 
            lblCourseSessionTitle.AutoSize = true;
            lblCourseSessionTitle.Location = new Point(12, 86);
            lblCourseSessionTitle.Name = "lblCourseSessionTitle";
            lblCourseSessionTitle.Size = new Size(111, 15);
            lblCourseSessionTitle.TabIndex = 50;
            lblCourseSessionTitle.Text = "Course Session Title";
            // 
            // FormCourseSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 224);
            Controls.Add(txtCourseSessionDate);
            Controls.Add(lblCourseSessionDate);
            Controls.Add(txtCourseSessionTitle);
            Controls.Add(lblCourseSessionTitle);
            Controls.Add(txtCourseID);
            Controls.Add(lblCourseID);
            Controls.Add(txtCourseSessionID);
            Controls.Add(lblCourseSessionID);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(lblResult);
            Controls.Add(txtInstructorID);
            Controls.Add(lblInstructorID);
            Name = "FormCourseSession";
            Text = "Course Session";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCourseSessionID;
        private Label lblCourseSessionID;
        private Button btnDelete;
        private Button btnSave;
        private Button btnNew;
        private Label lblResult;
        private TextBox txtInstructorID;
        private Label lblInstructorID;
        private TextBox txtCourseID;
        private Label lblCourseID;
        private TextBox txtCourseSessionDate;
        private Label lblCourseSessionDate;
        private TextBox txtCourseSessionTitle;
        private Label lblCourseSessionTitle;
    }
}