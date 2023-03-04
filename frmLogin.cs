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
using System.Xml.Linq;

namespace EcomGr3
{
    public partial class frmLogin : Form
    {
        string password;
        string email;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-S27V0M4C\\SQLEXPRESS;Initial Catalog=PixelPay;Integrated Security=True");
        
        public frmLogin()
        {
            InitializeComponent();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister register = new frmRegister();
            register.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_MouseDown(object sender, MouseEventArgs e)
        {
            btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(159)))), ((int)(((byte)(48)))));
        }

        private void btnLogin_MouseUp(object sender, MouseEventArgs e)
        {
            btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
        }

        private void btnClear_MouseDown(object sender, MouseEventArgs e)
        {
            btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
        }

        private void btnClear_MouseUp(object sender, MouseEventArgs e)
        {
            btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        internal string getEmail()
        {
            email = txtEmail.Text;
            return email; 
        }

        internal string getPassword()
        {
            password = txtPassword.Text;
            return password;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT isAdmin FROM tblAccounts WHERE email = @email AND password = @password;", conn);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            var result = (int?)cmd.ExecuteScalar();
            if (result != null)
            {
                if (result == 1)
                {
                    this.Hide();
                    frmAdmin dashboard = new frmAdmin();
                    dashboard.Show();
                }
                else if (result == 0)
                {
                    this.Hide();
                    frmDashboard dashboard = new frmDashboard();
                    dashboard.Show();
                }
            }
        }
    }
}
