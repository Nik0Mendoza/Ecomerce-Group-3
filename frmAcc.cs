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
    public partial class frmAcc : Form
    {
        frmLogin login = (frmLogin)Application.OpenForms["frmLogin"];
        string email;
        string password;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-S27V0M4C\\SQLEXPRESS;Initial Catalog=PixelPay;Integrated Security=True");
        public frmAcc()
        {
            InitializeComponent();
        }

        private void lblDiscover_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiscover discover = new frmDiscover();
            discover.Show();
        }

        private void imgDiscover_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiscover discover = new frmDiscover();
            discover.Show();
        }

        private void lblCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCart cart = new frmCart();
            cart.Show();
        }

        private void imgCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCart cart = new frmCart();
            cart.Show();
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
            else
            {
                // User clicked "No" or closed the message box, do nothing
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE dbo.tblAccounts SET firstName = @firstName, lastName = @lastName, email = @email, password = @password  WHERE accountID = @accountID", conn);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@accountID", txtUserID.Text);
            cmd.ExecuteNonQuery();
            frmAcc_Load();
            MessageBox.Show("All changes are saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmAcc_Load(object sender, EventArgs e)
        {
            email = login.getEmail();
            password = login.getPassword();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.tblAccounts WHERE email = @email AND password = @password;", conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    txtUserID.Text = Convert.ToString(reader["accountID"]);
                    txtMobileNumber.Text = Convert.ToString(reader["mobileNumber"]);
                    txtFirstName.Text = Convert.ToString(reader["firstName"]);
                    txtLastName.Text = Convert.ToString(reader["lastName"]);
                    txtEmail.Text = Convert.ToString(reader["email"]);
                    txtPassword.Text = Convert.ToString(reader["password"]);
                }
            }
        }

        private void frmAcc_Load()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.tblAccounts WHERE email = @email AND password = @password;", conn);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    txtUserID.Text = Convert.ToString(reader["accountID"]);
                    txtMobileNumber.Text = Convert.ToString(reader["mobileNumber"]);
                    txtFirstName.Text = Convert.ToString(reader["firstName"]);
                    txtLastName.Text = Convert.ToString(reader["lastName"]);
                    txtEmail.Text = Convert.ToString(reader["email"]);
                    txtPassword.Text = Convert.ToString(reader["password"]);
                }
            }
        }
    }
}
