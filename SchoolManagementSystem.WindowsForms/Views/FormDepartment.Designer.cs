namespace EFProject.Views
{
    partial class FormDepartment
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
            txtDeptName = new TextBox();
            lblDepartmentName = new Label();
            txtDeptID = new TextBox();
            lblDepartmentID = new Label();
            txtDeptLocation = new TextBox();
            lblDepartmentLocation = new Label();
            txtManagerID = new TextBox();
            lblDepartmentManager = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(470, 152);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(470, 103);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(470, 56);
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
            lblResult.Location = new Point(470, 15);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 20;
            // 
            // txtDeptName
            // 
            txtDeptName.Location = new Point(164, 56);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(271, 23);
            txtDeptName.TabIndex = 15;
            // 
            // lblDepartmentName
            // 
            lblDepartmentName.AutoSize = true;
            lblDepartmentName.Location = new Point(16, 59);
            lblDepartmentName.Name = "lblDepartmentName";
            lblDepartmentName.Size = new Size(105, 15);
            lblDepartmentName.TabIndex = 14;
            lblDepartmentName.Text = "Department Name";
            // 
            // txtDeptID
            // 
            txtDeptID.Location = new Point(164, 12);
            txtDeptID.Name = "txtDeptID";
            txtDeptID.ReadOnly = true;
            txtDeptID.Size = new Size(271, 23);
            txtDeptID.TabIndex = 13;
            // 
            // lblDepartmentID
            // 
            lblDepartmentID.AutoSize = true;
            lblDepartmentID.Location = new Point(16, 15);
            lblDepartmentID.Name = "lblDepartmentID";
            lblDepartmentID.Size = new Size(84, 15);
            lblDepartmentID.TabIndex = 12;
            lblDepartmentID.Text = "Department ID";
            // 
            // txtDeptLocation
            // 
            txtDeptLocation.Location = new Point(164, 103);
            txtDeptLocation.Name = "txtDeptLocation";
            txtDeptLocation.Size = new Size(271, 23);
            txtDeptLocation.TabIndex = 25;
            // 
            // lblDepartmentLocation
            // 
            lblDepartmentLocation.AutoSize = true;
            lblDepartmentLocation.Location = new Point(16, 106);
            lblDepartmentLocation.Name = "lblDepartmentLocation";
            lblDepartmentLocation.Size = new Size(119, 15);
            lblDepartmentLocation.TabIndex = 24;
            lblDepartmentLocation.Text = "Department Location";
            // 
            // txtManagerID
            // 
            txtManagerID.Location = new Point(164, 152);
            txtManagerID.Name = "txtManagerID";
            txtManagerID.Size = new Size(271, 23);
            txtManagerID.TabIndex = 27;
            // 
            // lblDepartmentManager
            // 
            lblDepartmentManager.AutoSize = true;
            lblDepartmentManager.Location = new Point(16, 155);
            lblDepartmentManager.Name = "lblDepartmentManager";
            lblDepartmentManager.Size = new Size(68, 15);
            lblDepartmentManager.TabIndex = 26;
            lblDepartmentManager.Text = "Manager ID";
            // 
            // FormDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 222);
            Controls.Add(txtManagerID);
            Controls.Add(lblDepartmentManager);
            Controls.Add(txtDeptLocation);
            Controls.Add(lblDepartmentLocation);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(lblResult);
            Controls.Add(txtDeptName);
            Controls.Add(lblDepartmentName);
            Controls.Add(txtDeptID);
            Controls.Add(lblDepartmentID);
            Name = "FormDepartment";
            Text = "Department";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnSave;
        private Button btnNew;
        private Label lblResult;
        private TextBox txtDeptName;
        private Label lblDepartmentName;
        private TextBox txtDeptID;
        private Label lblDepartmentID;
        private TextBox txtDeptLocation;
        private Label lblDepartmentLocation;
        private TextBox txtManagerID;
        private Label lblDepartmentManager;
    }
}