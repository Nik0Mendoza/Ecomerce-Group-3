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
        frmLogin login = new frmLogin();
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-S27V0M4C\\SQLEXPRESS;Initial Catalog=PixelPlay;Integrated Security=True");

        public frmRegister()
        {
            InitializeComponent();

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

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            login.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtMobileNumber.Clear();
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
