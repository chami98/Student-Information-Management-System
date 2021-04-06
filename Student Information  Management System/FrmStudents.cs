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
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {

        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

            string phoneNumber = txtPhone.Text;
            string regNo = txtRegNo.Text;


            try
            {
                SqlConnection cnn;
                string sql = "";
                string connectionString;

                connectionString = "Data Source=CHAMIKARA\\SQLEXPRESS;Initial Catalog=Student_Information_Management;Integrated Security=True";
                //Created connection String 

                cnn = new SqlConnection(connectionString);
                //making connection
                cnn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command;

                sql = "insert into student (name,email,dob,gender,phoneNumber,regNo) values ('" + name + "','" + email + "','" + dob + "' , '" + gender + "','" + phoneNumber + "','"+regNo+"')";

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
