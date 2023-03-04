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


namespace EcomGr3
{
    public partial class frmCart : Form
    {
        frmAcc acc = (frmAcc)Application.OpenForms["frmAcc"];
        int accountID;
        float total;
        public frmCart()
        {
            InitializeComponent();
            LoadGrid();
            int a = 0;
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                {
                    a += Convert.ToInt32(r.Cells[7].Value);
                }
            }
                txtTotal.Text = a.ToString();
            total = float.Parse(txtTotal.Text);
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-S27V0M4C\\SQLEXPRESS;Initial Catalog=PixelPay;Integrated Security=True");

        public void LoadGrid()
        {
            accountID = acc.getID();
            SqlCommand cmd = new SqlCommand("Select * from tblCart where accountID = @accountID", con);
            cmd.Parameters.AddWithValue("@accountID", accountID);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView2.DataSource = dt.DefaultView;
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiscover discover = new frmDiscover();
            discover.Show();
        }

        private void label4_Click(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAcc acc = new frmAcc();
            acc.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiscover discover = new frmDiscover();
            discover.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAcc acc = new frmAcc();
            acc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckout checkout = new frmCheckout();
            checkout.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public float getTotal()
        {
            return total;
        }
    }
}
