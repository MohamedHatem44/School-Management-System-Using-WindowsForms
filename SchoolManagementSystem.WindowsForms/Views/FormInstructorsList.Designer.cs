namespace EFProject.Views
{
    partial class FormInstructorsList
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
            gridInstructors = new DataGridView();
            txtInstructorLN = new TextBox();
            lblInstructorLastName = new Label();
            txtInstructorFN = new TextBox();
            lblInstructorFirstName = new Label();
            txtInstructorID = new TextBox();
            lblInstructorID = new Label();
            ((System.ComponentModel.ISupportInitialize)gridInstructors).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(590, 386);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 14;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(9, 386);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // gridInstructors
            // 
            gridInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridInstructors.Location = new Point(9, 134);
            gridInstructors.Name = "gridInstructors";
            gridInstructors.Size = new Size(656, 246);
            gridInstructors.TabIndex = 12;
            // 
            // txtInstructorLN
            // 
            txtInstructorLN.Location = new Point(160, 93);
            txtInstructorLN.Name = "txtInstructorLN";
            txtInstructorLN.Size = new Size(245, 23);
            txtInstructorLN.TabIndex = 23;
            // 
            // lblInstructorLastName
            // 
            lblInstructorLastName.AutoSize = true;
            lblInstructorLastName.Location = new Point(12, 96);
            lblInstructorLastName.Name = "lblInstructorLastName";
            lblInstructorLastName.Size = new Size(117, 15);
            lblInstructorLastName.TabIndex = 22;
            lblInstructorLastName.Text = "Instructor Last Name";
            // 
            // txtInstructorFN
            // 
            txtInstructorFN.Location = new Point(160, 50);
            txtInstructorFN.Name = "txtInstructorFN";
            txtInstructorFN.Size = new Size(245, 23);
            txtInstructorFN.TabIndex = 21;
            // 
            // lblInstructorFirstName
            // 
            lblInstructorFirstName.AutoSize = true;
            lblInstructorFirstName.Location = new Point(12, 53);
            lblInstructorFirstName.Name = "lblInstructorFirstName";
            lblInstructorFirstName.Size = new Size(118, 15);
            lblInstructorFirstName.TabIndex = 20;
            lblInstructorFirstName.Text = "Instructor First Name";
            // 
            // txtInstructorID
            // 
            txtInstructorID.Location = new Point(160, 6);
            txtInstructorID.Name = "txtInstructorID";
            txtInstructorID.Size = new Size(245, 23);
            txtInstructorID.TabIndex = 19;
            // 
            // lblInstructorID
            // 
            lblInstructorID.AutoSize = true;
            lblInstructorID.Location = new Point(12, 9);
            lblInstructorID.Name = "lblInstructorID";
            lblInstructorID.Size = new Size(72, 15);
            lblInstructorID.TabIndex = 18;
            lblInstructorID.Text = "Instructor ID";
            // 
            // FormInstructorsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 419);
            Controls.Add(txtInstructorLN);
            Controls.Add(lblInstructorLastName);
            Controls.Add(txtInstructorFN);
            Controls.Add(lblInstructorFirstName);
            Controls.Add(txtInstructorID);
            Controls.Add(lblInstructorID);
            Controls.Add(btnOpen);
            Controls.Add(btnLoad);
            Controls.Add(gridInstructors);
            Name = "FormInstructorsList";
            Text = "Instructors List";
            ((System.ComponentModel.ISupportInitialize)gridInstructors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOpen;
        private Button btnLoad;
        private DataGridView gridInstructors;
        private TextBox txtInstructorLN;
        private Label lblInstructorLastName;
        private TextBox txtInstructorFN;
        private Label lblInstructorFirstName;
        private TextBox txtInstructorID;
        private Label lblInstructorID;
    }
}