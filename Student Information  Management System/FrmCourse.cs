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
    public partial class FrmCourse : Form
    {
        public FrmCourse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)


        {

            string moduleName = txtModuleName.Text;
            string moduleCode = txtModuleCode.Text;
            string creditValue = txtCreditValue.Text;


            try
            {
                SqlConnection cnn;
                string sql = "";
                string connectionString;

                connectionString = "Data Source=CHAMIKARA\\SQLEXPRESS;Initial Catalog=Student_Information_Management;Integrated Security=True";

                cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command;

                sql = "insert into course (moduleName,moduleCode,creditValue) values ('" + moduleName + "','" + moduleCode + "','" + creditValue + "')";

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
