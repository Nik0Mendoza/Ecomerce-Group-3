using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcomGr3
{
    public partial class frmDiscover : Form
    {
        public frmDiscover()
        {
            InitializeComponent();
        }

        private void frmDiscover_Load(object sender, EventArgs e)
        {

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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
                this.Hide();
                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
                this.Hide();
                frmCart cart = new frmCart();
                cart.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAcc acc = new frmAcc();
            acc.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCart cart = new frmCart();
            cart.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAcc acc = new frmAcc();
            acc.Show();
        }
    }
}
