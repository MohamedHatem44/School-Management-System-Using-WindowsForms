namespace EFProject.Views
{
    partial class FormInstructor
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
            txtInstructorPhone = new TextBox();
            lblInstructorPhone = new Label();
            txtInstructorLN = new TextBox();
            lblInstructorLastName = new Label();
            txtInstructorFN = new TextBox();
            lblInstructorFirstName = new Label();
            txtInstructorID = new TextBox();
            lblInstructorID = new Label();
            txtDepartmentID = new TextBox();
            lblDepartmentID = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(442, 183);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(442, 142);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(442, 99);
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
            lblResult.Location = new Point(442, 40);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 20;
            // 
            // txtInstructorPhone
            // 
            txtInstructorPhone.Location = new Point(161, 140);
            txtInstructorPhone.Name = "txtInstructorPhone";
            txtInstructorPhone.Size = new Size(245, 23);
            txtInstructorPhone.TabIndex = 19;
            // 
            // lblInstructorPhone
            // 
            lblInstructorPhone.AutoSize = true;
            lblInstructorPhone.Location = new Point(13, 143);
            lblInstructorPhone.Name = "lblInstructorPhone";
            lblInstructorPhone.Size = new Size(95, 15);
            lblInstructorPhone.TabIndex = 18;
            lblInstructorPhone.Text = "Instructor Phone";
            // 
            // txtInstructorLN
            // 
            txtInstructorLN.Location = new Point(161, 99);
            txtInstructorLN.Name = "txtInstructorLN";
            txtInstructorLN.Size = new Size(245, 23);
            txtInstructorLN.TabIndex = 17;
            // 
            // lblInstructorLastName
            // 
            lblInstructorLastName.AutoSize = true;
            lblInstructorLastName.Location = new Point(13, 102);
            lblInstructorLastName.Name = "lblInstructorLastName";
            lblInstructorLastName.Size = new Size(117, 15);
            lblInstructorLastName.TabIndex = 16;
            lblInstructorLastName.Text = "Instructor Last Name";
            // 
            // txtInstructorFN
            // 
            txtInstructorFN.Location = new Point(161, 56);
            txtInstructorFN.Name = "txtInstructorFN";
            txtInstructorFN.Size = new Size(245, 23);
            txtInstructorFN.TabIndex = 15;
            // 
            // lblInstructorFirstName
            // 
            lblInstructorFirstName.AutoSize = true;
            lblInstructorFirstName.Location = new Point(13, 59);
            lblInstructorFirstName.Name = "lblInstructorFirstName";
            lblInstructorFirstName.Size = new Size(118, 15);
            lblInstructorFirstName.TabIndex = 14;
            lblInstructorFirstName.Text = "Instructor First Name";
            // 
            // txtInstructorID
            // 
            txtInstructorID.Location = new Point(161, 12);
            txtInstructorID.Name = "txtInstructorID";
            txtInstructorID.ReadOnly = true;
            txtInstructorID.Size = new Size(245, 23);
            txtInstructorID.TabIndex = 13;
            // 
            // lblInstructorID
            // 
            lblInstructorID.AutoSize = true;
            lblInstructorID.Location = new Point(13, 15);
            lblInstructorID.Name = "lblInstructorID";
            lblInstructorID.Size = new Size(72, 15);
            lblInstructorID.TabIndex = 12;
            lblInstructorID.Text = "Instructor ID";
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.Location = new Point(161, 182);
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.Size = new Size(245, 23);
            txtDepartmentID.TabIndex = 25;
            // 
            // lblDepartmentID
            // 
            lblDepartmentID.AutoSize = true;
            lblDepartmentID.Location = new Point(13, 185);
            lblDepartmentID.Name = "lblDepartmentID";
            lblDepartmentID.Size = new Size(84, 15);
            lblDepartmentID.TabIndex = 24;
            lblDepartmentID.Text = "Department ID";
            // 
            // FormInstructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 241);
            Controls.Add(txtDepartmentID);
            Controls.Add(lblDepartmentID);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(lblResult);
            Controls.Add(txtInstructorPhone);
            Controls.Add(lblInstructorPhone);
            Controls.Add(txtInstructorLN);
            Controls.Add(lblInstructorLastName);
            Controls.Add(txtInstructorFN);
            Controls.Add(lblInstructorFirstName);
            Controls.Add(txtInstructorID);
            Controls.Add(lblInstructorID);
            Name = "FormInstructor";
            Text = "Instructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnSave;
        private Button btnNew;
        private Label lblResult;
        private TextBox txtInstructorPhone;
        private Label lblInstructorPhone;
        private TextBox txtInstructorLN;
        private Label lblInstructorLastName;
        private TextBox txtInstructorFN;
        private Label lblInstructorFirstName;
        private TextBox txtInstructorID;
        private Label lblInstructorID;
        private TextBox txtDepartmentID;
        private Label lblDepartmentID;
    }
}