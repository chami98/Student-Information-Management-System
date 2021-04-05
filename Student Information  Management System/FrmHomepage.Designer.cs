
namespace Student_Information__Management_System
{
    partial class FrmHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomepage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.facultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFacultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFacultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDepartmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCourseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLecturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facultyToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.lecturesToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // facultyToolStripMenuItem
            // 
            this.facultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFacultyToolStripMenuItem,
            this.viewFacultyToolStripMenuItem});
            this.facultyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facultyToolStripMenuItem.Image")));
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.facultyToolStripMenuItem.Text = "Faculty";
            // 
            // addFacultyToolStripMenuItem
            // 
            this.addFacultyToolStripMenuItem.Name = "addFacultyToolStripMenuItem";
            this.addFacultyToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.addFacultyToolStripMenuItem.Text = "Add Faculty";
            this.addFacultyToolStripMenuItem.Click += new System.EventHandler(this.addFacultyToolStripMenuItem_Click);
            // 
            // viewFacultyToolStripMenuItem
            // 
            this.viewFacultyToolStripMenuItem.Name = "viewFacultyToolStripMenuItem";
            this.viewFacultyToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.viewFacultyToolStripMenuItem.Text = "View Faculty Details";
            this.viewFacultyToolStripMenuItem.Click += new System.EventHandler(this.viewFacultyToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepartmentToolStripMenuItem,
            this.viewDepartmentDetailsToolStripMenuItem});
            this.departmentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("departmentToolStripMenuItem.Image")));
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.departmentToolStripMenuItem.Text = "Department";
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.addDepartmentToolStripMenuItem.Text = "Add Department";
            this.addDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentToolStripMenuItem_Click);
            // 
            // viewDepartmentDetailsToolStripMenuItem
            // 
            this.viewDepartmentDetailsToolStripMenuItem.Name = "viewDepartmentDetailsToolStripMenuItem";
            this.viewDepartmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.viewDepartmentDetailsToolStripMenuItem.Text = "View Department Details";
            this.viewDepartmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDepartmentDetailsToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.viewCourseDetailsToolStripMenuItem});
            this.courseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("courseToolStripMenuItem.Image")));
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // viewCourseDetailsToolStripMenuItem
            // 
            this.viewCourseDetailsToolStripMenuItem.Name = "viewCourseDetailsToolStripMenuItem";
            this.viewCourseDetailsToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.viewCourseDetailsToolStripMenuItem.Text = "View Course Details";
            this.viewCourseDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewCourseDetailsToolStripMenuItem_Click);
            // 
            // lecturesToolStripMenuItem
            // 
            this.lecturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLecturesToolStripMenuItem,
            this.viewLecturerToolStripMenuItem});
            this.lecturesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lecturesToolStripMenuItem.Image")));
            this.lecturesToolStripMenuItem.Name = "lecturesToolStripMenuItem";
            this.lecturesToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.lecturesToolStripMenuItem.Text = "Lecturers";
            this.lecturesToolStripMenuItem.Click += new System.EventHandler(this.lecturesToolStripMenuItem_Click);
            // 
            // addLecturesToolStripMenuItem
            // 
            this.addLecturesToolStripMenuItem.Name = "addLecturesToolStripMenuItem";
            this.addLecturesToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.addLecturesToolStripMenuItem.Text = "Add Lectuers";
            this.addLecturesToolStripMenuItem.Click += new System.EventHandler(this.addLecturesToolStripMenuItem_Click);
            // 
            // viewLecturerToolStripMenuItem
            // 
            this.viewLecturerToolStripMenuItem.Name = "viewLecturerToolStripMenuItem";
            this.viewLecturerToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.viewLecturerToolStripMenuItem.Text = "View Lecturer Details";
            this.viewLecturerToolStripMenuItem.Click += new System.EventHandler(this.viewLecturerToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentsToolStripMenuItem,
            this.viewStudentDetailsToolStripMenuItem});
            this.studentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsToolStripMenuItem.Image")));
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // addStudentsToolStripMenuItem
            // 
            this.addStudentsToolStripMenuItem.Name = "addStudentsToolStripMenuItem";
            this.addStudentsToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.addStudentsToolStripMenuItem.Text = "Add Students";
            this.addStudentsToolStripMenuItem.Click += new System.EventHandler(this.addStudentsToolStripMenuItem_Click);
            // 
            // viewStudentDetailsToolStripMenuItem
            // 
            this.viewStudentDetailsToolStripMenuItem.Name = "viewStudentDetailsToolStripMenuItem";
            this.viewStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.viewStudentDetailsToolStripMenuItem.Text = "View Student Details";
            this.viewStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentDetailsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // FrmHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem facultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFacultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFacultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLecturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDepartmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCourseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentDetailsToolStripMenuItem;
    }
}

