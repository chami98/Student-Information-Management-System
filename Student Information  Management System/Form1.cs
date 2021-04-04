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
    public partial class Form1 : Form
    {
        public Form1()
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
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            frm.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCourse frm = new FrmCourse();
            frm.Show();
        }

        private void addLecturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLecturers frm = new FrmLecturers();
            frm.Show();
        }
    }
}
