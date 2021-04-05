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
    public partial class FrmFaculty : Form
    {
        public FrmFaculty()
        {
            InitializeComponent();
        }

        private void FrmFaculty_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string facultyName = txtFacultyName.Text;
            string facultyID = txtFacultyID.Text;
            string facultyLocation = txtFacultyLocation.Text;
            try
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = "Data Source=CHAMIKARA\\SQLEXPRESS;Initial Catalog=Student_Information_Management;Integrated Security=True";
                cnn = new SqlConnection(connectionString);

                cnn.Open();

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = "";


                sql = "insert into faculty (facultyName , facultyID ,facultyLocation ) values ('" + facultyName + "','" + facultyID + "','" + facultyLocation + "')";
                command = new SqlCommand(sql, cnn);

                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();


                MessageBox.Show("Data entered succesfully!" ,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
