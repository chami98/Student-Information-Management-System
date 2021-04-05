
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // facultyToolStripMenuItem
            // 
            this.facultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFacultyToolStripMenuItem,
            this.viewFacultyToolStripMenuItem});
            this.facultyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.facultyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facultyToolStripMenuItem.Image")));
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(107, 32);
            this.facultyToolStripMenuItem.Text = "Faculty";
            // 
            // addFacultyToolStripMenuItem
            // 
            this.addFacultyToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.addFacultyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addFacultyToolStripMenuItem.Name = "addFacultyToolStripMenuItem";
            this.addFacultyToolStripMenuItem.Size = new System.Drawing.Size(269, 32);
            this.addFacultyToolStripMenuItem.Text = "Add Faculty";
            this.addFacultyToolStripMenuItem.Click += new System.EventHandler(this.addFacultyToolStripMenuItem_Click);
            // 
            // viewFacultyToolStripMenuItem
            // 
            this.viewFacultyToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.viewFacultyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewFacultyToolStripMenuItem.Name = "viewFacultyToolStripMenuItem";
            this.viewFacultyToolStripMenuItem.Size = new System.Drawing.Size(269, 32);
            this.viewFacultyToolStripMenuItem.Text = "View Faculty Details";
            this.viewFacultyToolStripMenuItem.Click += new System.EventHandler(this.viewFacultyToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepartmentToolStripMenuItem,
            this.viewDepartmentDetailsToolStripMenuItem});
            this.departmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.departmentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("departmentToolStripMenuItem.Image")));
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(151, 32);
            this.departmentToolStripMenuItem.Text = "Department";
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(313, 32);
            this.addDepartmentToolStripMenuItem.Text = "Add Department";
            this.addDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentToolStripMenuItem_Click);
            // 
            // viewDepartmentDetailsToolStripMenuItem
            // 
            this.viewDepartmentDetailsToolStripMenuItem.Name = "viewDepartmentDetailsToolStripMenuItem";
            this.viewDepartmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(313, 32);
            this.viewDepartmentDetailsToolStripMenuItem.Text = "View Department Details";
            this.viewDepartmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDepartmentDetailsToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.viewCourseDetailsToolStripMenuItem});
            this.courseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.courseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("courseToolStripMenuItem.Image")));
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(106, 32);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // viewCourseDetailsToolStripMenuItem
            // 
            this.viewCourseDetailsToolStripMenuItem.Name = "viewCourseDetailsToolStripMenuItem";
            this.viewCourseDetailsToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.viewCourseDetailsToolStripMenuItem.Text = "View Course Details";
            this.viewCourseDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewCourseDetailsToolStripMenuItem_Click);
            // 
            // lecturesToolStripMenuItem
            // 
            this.lecturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLecturesToolStripMenuItem,
            this.viewLecturerToolStripMenuItem});
            this.lecturesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lecturesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lecturesToolStripMenuItem.Image")));
            this.lecturesToolStripMenuItem.Name = "lecturesToolStripMenuItem";
            this.lecturesToolStripMenuItem.Size = new System.Drawing.Size(124, 32);
            this.lecturesToolStripMenuItem.Text = "Lecturers";
            this.lecturesToolStripMenuItem.Click += new System.EventHandler(this.lecturesToolStripMenuItem_Click);
            // 
            // addLecturesToolStripMenuItem
            // 
            this.addLecturesToolStripMenuItem.Name = "addLecturesToolStripMenuItem";
            this.addLecturesToolStripMenuItem.Size = new System.Drawing.Size(278, 32);
            this.addLecturesToolStripMenuItem.Text = "Add Lectuers";
            this.addLecturesToolStripMenuItem.Click += new System.EventHandler(this.addLecturesToolStripMenuItem_Click);
            // 
            // viewLecturerToolStripMenuItem
            // 
            this.viewLecturerToolStripMenuItem.Name = "viewLecturerToolStripMenuItem";
            this.viewLecturerToolStripMenuItem.Size = new System.Drawing.Size(278, 32);
            this.viewLecturerToolStripMenuItem.Text = "View Lecturer Details";
            this.viewLecturerToolStripMenuItem.Click += new System.EventHandler(this.viewLecturerToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentsToolStripMenuItem,
            this.viewStudentDetailsToolStripMenuItem});
            this.studentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsToolStripMenuItem.Image")));
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(122, 32);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // addStudentsToolStripMenuItem
            // 
            this.addStudentsToolStripMenuItem.Name = "addStudentsToolStripMenuItem";
            this.addStudentsToolStripMenuItem.Size = new System.Drawing.Size(276, 32);
            this.addStudentsToolStripMenuItem.Text = "Add Students";
            this.addStudentsToolStripMenuItem.Click += new System.EventHandler(this.addStudentsToolStripMenuItem_Click);
            // 
            // viewStudentDetailsToolStripMenuItem
            // 
            this.viewStudentDetailsToolStripMenuItem.Name = "viewStudentDetailsToolStripMenuItem";
            this.viewStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(276, 32);
            this.viewStudentDetailsToolStripMenuItem.Text = "View Student Details";
            this.viewStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentDetailsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(87, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Information Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(56, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 100);
            this.label2.TabIndex = 2;
            // 
            // FrmHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

