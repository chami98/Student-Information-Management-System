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
    public partial class FrmLecturers : Form
    {
        public FrmLecturers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string dob = dateTimeDob.Text;
            string gender;
            bool ischecked = radioMale.Checked;

            if (ischecked)
            {
                gender = radioMale.Text;
            }

            else
            {
                gender = radioFemale.Text;
            }

            string lectures = comboBoxLectures.Text;

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

                sql = "insert into lecturer (name,email,dob,gender,lectures) values ('" + name + "','" + email + "','" + dob + "' , '"+gender+"','"+lectures+"')";

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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
