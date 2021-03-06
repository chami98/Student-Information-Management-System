using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information__Management_System
{
    public partial class FrmHomepage : Form
    {
        public FrmHomepage()
        {
            InitializeComponent();
        }

        private void lecturesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addFacultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFaculty frm = new FrmFaculty();
            frm.Show();
            //Created object of the faculty form 
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            frm.Show();
            //Created object of the department form 
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCourse frm = new FrmCourse();
            frm.Show();
            //Created object of the course form 
        }

        private void addLecturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLecturers frm = new FrmLecturers();
            frm.Show();
            //Created object of the lecturer form 
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudents frm = new FrmStudents();
            frm.Show();
            //Created object of the student form 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void viewFacultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewFacultyDetails frm = new FrmViewFacultyDetails();
                frm.Show();
            //Created object of the facultydetails form 
        }

        private void viewDepartmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewDepartmentDetails frm = new FrmViewDepartmentDetails();
            frm.Show();
            //Created object of the viewDepartment form 
        }

        private void viewCourseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewCourseDetails frm = new frmViewCourseDetails();
            frm.Show();
            //Created object of the faculty viewCourseDetails form 
        }

        private void viewLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewLectureDetails frm = new FrmViewLectureDetails();
            frm.Show();
            //Created object of the faculty viewLectureDetails form 
        }

        private void viewStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewStudentDetails frm = new FrmViewStudentDetails();
            frm.Show();
            ////Created object of the faculty viewStudentDetails form 
        }
    }
}
