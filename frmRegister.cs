using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcomGr3
{
    public partial class frmRegister : Form
    {
        
        public frmRegister()
        {
            InitializeComponent();

            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            email = txtEmail.Text;
            password = txtPassword.Text;
            mobileNumber = txtMobileNumber.Text;

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-S27V0M4C\\SQLEXPRESS;Initial Catalog=PixelPlay;Integrated Security=True");
                SqlCommand cmd = conn.CreateCommand();

                conn.Open();

                cmd.CommandText = String.Format("INSERT INTO tblAccounts(firstName, lastName, email, password, mobileNumber, isAdmin) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", firstName, lastName, email, password, mobileNumber, 0);
                cmd.ExecuteReader();

                conn.Close();

                MessageBox.Show("Account created successfully!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            txtFirstName.Text = String.Empty; 
            txtLastName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtMobileNumber.Text = String.Empty;

            this.Hide();
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtMobileNumber.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_MouseDown(object sender, MouseEventArgs e)
        {
            btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(159)))), ((int)(((byte)(48)))));
        }

        private void btnRegister_MouseUp(object sender, MouseEventArgs e)
        {
            btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
        }
    }
}
