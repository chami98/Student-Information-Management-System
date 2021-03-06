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
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string departmentName = txtDepartmentName.Text;
            string departmentID = txtDepartmentID.Text;
            string departmentLocation = txtDepartmentLocation.Text;
            try
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = "Data Source=CHAMIKARA\\SQLEXPRESS;Initial Catalog=Student_Information_Management;Integrated Security=True";
                //Created connection String 
                cnn = new SqlConnection(connectionString);
                //making connection
                cnn.Open();

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = "";


                sql = "insert into department (departmentName , departmentID ,departmentLocation ) values ('" + departmentName + "','" + departmentID + "','" + departmentLocation + "')";
                command = new SqlCommand(sql, cnn);

                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();


                MessageBox.Show("Data entered succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("There is an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
