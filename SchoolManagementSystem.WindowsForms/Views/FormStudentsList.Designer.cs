namespace EFProject.Views
{
    partial class FormStudentsList
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
            gridStudents = new DataGridView();
            btnLoad = new Button();
            btnOpen = new Button();
            txtStudLN = new TextBox();
            lblStudentLastName = new Label();
            txtStudFN = new TextBox();
            lblStudentFirstName = new Label();
            txtStudID = new TextBox();
            lblStudentID = new Label();
            ((System.ComponentModel.ISupportInitialize)gridStudents).BeginInit();
            SuspendLayout();
            // 
            // gridStudents
            // 
            gridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStudents.Location = new Point(12, 128);
            gridStudents.Name = "gridStudents";
            gridStudents.Size = new Size(590, 246);
            gridStudents.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 392);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(527, 392);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // txtStudLN
            // 
            txtStudLN.Location = new Point(169, 99);
            txtStudLN.Name = "txtStudLN";
            txtStudLN.Size = new Size(245, 23);
            txtStudLN.TabIndex = 11;
            // 
            // lblStudentLastName
            // 
            lblStudentLastName.AutoSize = true;
            lblStudentLastName.Location = new Point(21, 102);
            lblStudentLastName.Name = "lblStudentLastName";
            lblStudentLastName.Size = new Size(107, 15);
            lblStudentLastName.TabIndex = 10;
            lblStudentLastName.Text = "Student Last Name";
            // 
            // txtStudFN
            // 
            txtStudFN.Location = new Point(169, 56);
            txtStudFN.Name = "txtStudFN";
            txtStudFN.Size = new Size(245, 23);
            txtStudFN.TabIndex = 9;
            // 
            // lblStudentFirstName
            // 
            lblStudentFirstName.AutoSize = true;
            lblStudentFirstName.Location = new Point(21, 59);
            lblStudentFirstName.Name = "lblStudentFirstName";
            lblStudentFirstName.Size = new Size(108, 15);
            lblStudentFirstName.TabIndex = 8;
            lblStudentFirstName.Text = "Student First Name";
            // 
            // txtStudID
            // 
            txtStudID.Location = new Point(169, 12);
            txtStudID.Name = "txtStudID";
            txtStudID.Size = new Size(245, 23);
            txtStudID.TabIndex = 7;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(21, 15);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(62, 15);
            lblStudentID.TabIndex = 6;
            lblStudentID.Text = "Student ID";
            // 
            // FormStudentsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 427);
            Controls.Add(txtStudLN);
            Controls.Add(lblStudentLastName);
            Controls.Add(txtStudFN);
            Controls.Add(lblStudentFirstName);
            Controls.Add(txtStudID);
            Controls.Add(lblStudentID);
            Controls.Add(btnOpen);
            Controls.Add(btnLoad);
            Controls.Add(gridStudents);
            Name = "FormStudentsList";
            Text = "Students List";
            ((System.ComponentModel.ISupportInitialize)gridStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridStudents;
        private Button btnLoad;
        private Button btnOpen;
        private TextBox txtStudLN;
        private Label lblStudentLastName;
        private TextBox txtStudFN;
        private Label lblStudentFirstName;
        private TextBox txtStudID;
        private Label lblStudentID;
    }
}