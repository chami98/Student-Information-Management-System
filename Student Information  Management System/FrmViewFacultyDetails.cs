using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Information__Management_System
{
    public partial class FrmViewFacultyDetails : Form
    {
        public FrmViewFacultyDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString;
                SqlConnection cnn;
                string sql = "";

                connectionString = "Data Source=CHAMIKARA\\SQLEXPRESS;Initial Catalog=Student_Information_Management;Integrated Security=True";
                cnn = new SqlConnection(connectionString);

                cnn.Open();

                sql = "select * from faculty";
                SqlDataAdapter adapter = new SqlDataAdapter(sql,cnn);

                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                dgv.DataSource = dtbl;

                



               
                cnn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("There is an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
