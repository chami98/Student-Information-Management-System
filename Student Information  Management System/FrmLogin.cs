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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=CHAMIKARA\\SQLEXPRESS;Initial Catalog=Student_Information_Management;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            
            
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                FrmHomepage frm = new FrmHomepage();
                frm.Show();
            }
            else
                MessageBox.Show("Invalid username or password", "Error",MessageBoxButtons.OK , MessageBoxIcon.Error);

        }
    }
}
