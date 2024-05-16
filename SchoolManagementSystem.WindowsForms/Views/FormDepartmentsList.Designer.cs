namespace EFProject.Views
{
    partial class FormDepartmentsList
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
            gridDepartments = new DataGridView();
            txtDepartmentName = new TextBox();
            lblDepartmentName = new Label();
            txtDepartmentID = new TextBox();
            lblDepartmentID = new Label();
            ((System.ComponentModel.ISupportInitialize)gridDepartments).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(527, 362);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 5;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 362);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // gridDepartments
            // 
            gridDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDepartments.Location = new Point(12, 95);
            gridDepartments.Name = "gridDepartments";
            gridDepartments.Size = new Size(590, 249);
            gridDepartments.TabIndex = 3;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(158, 56);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(245, 23);
            txtDepartmentName.TabIndex = 15;
            // 
            // lblDepartmentName
            // 
            lblDepartmentName.AutoSize = true;
            lblDepartmentName.Location = new Point(10, 59);
            lblDepartmentName.Name = "lblDepartmentName";
            lblDepartmentName.Size = new Size(105, 15);
            lblDepartmentName.TabIndex = 14;
            lblDepartmentName.Text = "Department Name";
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.Location = new Point(158, 12);
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.Size = new Size(245, 23);
            txtDepartmentID.TabIndex = 13;
            // 
            // lblDepartmentID
            // 
            lblDepartmentID.AutoSize = true;
            lblDepartmentID.Location = new Point(10, 15);
            lblDepartmentID.Name = "lblDepartmentID";
            lblDepartmentID.Size = new Size(84, 15);
            lblDepartmentID.TabIndex = 12;
            lblDepartmentID.Text = "Department ID";
            // 
            // FormDepartmentsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 401);
            Controls.Add(txtDepartmentName);
            Controls.Add(lblDepartmentName);
            Controls.Add(txtDepartmentID);
            Controls.Add(lblDepartmentID);
            Controls.Add(btnOpen);
            Controls.Add(btnLoad);
            Controls.Add(gridDepartments);
            Name = "FormDepartmentsList";
            Text = "FormDepartmentsList";
            ((System.ComponentModel.ISupportInitialize)gridDepartments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen;
        private Button btnLoad;
        private DataGridView gridDepartments;
        private TextBox txtDepartmentName;
        private Label lblDepartmentName;
        private TextBox txtDepartmentID;
        private Label lblDepartmentID;
    }
}