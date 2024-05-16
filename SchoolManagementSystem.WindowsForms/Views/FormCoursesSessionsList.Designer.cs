namespace EFProject.Views
{
    partial class FormCoursesSessionsList
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
            gridCoursesSession = new DataGridView();
            txtCourseSessionTitle = new TextBox();
            lblCourseSessionTitle = new Label();
            txtCourseSessionID = new TextBox();
            lblCourseSessionID = new Label();
            ((System.ComponentModel.ISupportInitialize)gridCoursesSession).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(793, 369);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 51;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 369);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 50;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // gridCoursesSession
            // 
            gridCoursesSession.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCoursesSession.Location = new Point(12, 102);
            gridCoursesSession.Name = "gridCoursesSession";
            gridCoursesSession.Size = new Size(856, 249);
            gridCoursesSession.TabIndex = 49;
            // 
            // txtCourseSessionTitle
            // 
            txtCourseSessionTitle.Location = new Point(160, 55);
            txtCourseSessionTitle.Name = "txtCourseSessionTitle";
            txtCourseSessionTitle.Size = new Size(245, 23);
            txtCourseSessionTitle.TabIndex = 57;
            // 
            // lblCourseSessionTitle
            // 
            lblCourseSessionTitle.AutoSize = true;
            lblCourseSessionTitle.Location = new Point(12, 58);
            lblCourseSessionTitle.Name = "lblCourseSessionTitle";
            lblCourseSessionTitle.Size = new Size(111, 15);
            lblCourseSessionTitle.TabIndex = 56;
            lblCourseSessionTitle.Text = "Course Session Title";
            // 
            // txtCourseSessionID
            // 
            txtCourseSessionID.Location = new Point(160, 15);
            txtCourseSessionID.Name = "txtCourseSessionID";
            txtCourseSessionID.Size = new Size(245, 23);
            txtCourseSessionID.TabIndex = 55;
            // 
            // lblCourseSessionID
            // 
            lblCourseSessionID.AutoSize = true;
            lblCourseSessionID.Location = new Point(12, 18);
            lblCourseSessionID.Name = "lblCourseSessionID";
            lblCourseSessionID.Size = new Size(100, 15);
            lblCourseSessionID.TabIndex = 54;
            lblCourseSessionID.Text = "Course Session ID";
            // 
            // FormCoursesSessionsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 411);
            Controls.Add(txtCourseSessionTitle);
            Controls.Add(lblCourseSessionTitle);
            Controls.Add(txtCourseSessionID);
            Controls.Add(lblCourseSessionID);
            Controls.Add(btnOpen);
            Controls.Add(btnLoad);
            Controls.Add(gridCoursesSession);
            Name = "FormCoursesSessionsList";
            Text = "Courses Sessions List";
            ((System.ComponentModel.ISupportInitialize)gridCoursesSession).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOpen;
        private Button btnLoad;
        private DataGridView gridCoursesSession;
        private TextBox txtCourseSessionTitle;
        private Label lblCourseSessionTitle;
        private TextBox txtCourseSessionID;
        private Label lblCourseSessionID;
    }
}