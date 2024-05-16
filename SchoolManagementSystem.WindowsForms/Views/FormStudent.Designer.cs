namespace EFProject.Views
{
    partial class FormStudent
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
            lblStudentID = new Label();
            txtStudID = new TextBox();
            txtStudFN = new TextBox();
            lblStudentFirstName = new Label();
            txtStudLN = new TextBox();
            lblStudentLastName = new Label();
            txtStudPhone = new TextBox();
            lblStudentPhone = new Label();
            lblResult = new Label();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(22, 20);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(62, 15);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID";
            // 
            // txtStudID
            // 
            txtStudID.Location = new Point(170, 17);
            txtStudID.Name = "txtStudID";
            txtStudID.ReadOnly = true;
            txtStudID.Size = new Size(245, 23);
            txtStudID.TabIndex = 1;
            // 
            // txtStudFN
            // 
            txtStudFN.Location = new Point(170, 61);
            txtStudFN.Name = "txtStudFN";
            txtStudFN.Size = new Size(245, 23);
            txtStudFN.TabIndex = 3;
            // 
            // lblStudentFirstName
            // 
            lblStudentFirstName.AutoSize = true;
            lblStudentFirstName.Location = new Point(22, 64);
            lblStudentFirstName.Name = "lblStudentFirstName";
            lblStudentFirstName.Size = new Size(108, 15);
            lblStudentFirstName.TabIndex = 2;
            lblStudentFirstName.Text = "Student First Name";
            // 
            // txtStudLN
            // 
            txtStudLN.Location = new Point(170, 104);
            txtStudLN.Name = "txtStudLN";
            txtStudLN.Size = new Size(245, 23);
            txtStudLN.TabIndex = 5;
            // 
            // lblStudentLastName
            // 
            lblStudentLastName.AutoSize = true;
            lblStudentLastName.Location = new Point(22, 107);
            lblStudentLastName.Name = "lblStudentLastName";
            lblStudentLastName.Size = new Size(107, 15);
            lblStudentLastName.TabIndex = 4;
            lblStudentLastName.Text = "Student Last Name";
            // 
            // txtStudPhone
            // 
            txtStudPhone.Location = new Point(170, 145);
            txtStudPhone.Name = "txtStudPhone";
            txtStudPhone.Size = new Size(245, 23);
            txtStudPhone.TabIndex = 7;
            // 
            // lblStudentPhone
            // 
            lblStudentPhone.AutoSize = true;
            lblStudentPhone.Location = new Point(22, 148);
            lblStudentPhone.Name = "lblStudentPhone";
            lblStudentPhone.Size = new Size(85, 15);
            lblStudentPhone.TabIndex = 6;
            lblStudentPhone.Text = "Student Phone";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(451, 20);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 8;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(474, 61);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 9;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(474, 104);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(474, 145);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 216);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(lblResult);
            Controls.Add(txtStudPhone);
            Controls.Add(lblStudentPhone);
            Controls.Add(txtStudLN);
            Controls.Add(lblStudentLastName);
            Controls.Add(txtStudFN);
            Controls.Add(lblStudentFirstName);
            Controls.Add(txtStudID);
            Controls.Add(lblStudentID);
            Name = "FormStudent";
            Text = "Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private TextBox txtStudID;
        private TextBox txtStudFN;
        private Label lblStudentFirstName;
        private TextBox txtStudLN;
        private Label lblStudentLastName;
        private TextBox txtStudPhone;
        private Label lblStudentPhone;
        private Label lblResult;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
    }
}