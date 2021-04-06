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
    public partial class FrmViewDepartmentDetails : Form
    {
        public FrmViewDepartmentDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString;
                string sql = "";
                SqlConnection cnn;

                connectionString = "Data Source=CHAMIKARA\\SQLEXPRESS;Initial Catalog=Student_Information_Management;Integrated Security=True";
                //Created connection String    
                cnn = new SqlConnection(connectionString);
                //making connection


                cnn.Open();
                sql = "select * from department";
                SqlDataAdapter adapter = new SqlDataAdapter(sql,cnn);

                DataTable dtble = new DataTable();
                //created virtual table
                adapter.Fill(dtble);

                dgv.DataSource = dtble;




            }
            catch (Exception)
            {

                MessageBox.Show("There is an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
