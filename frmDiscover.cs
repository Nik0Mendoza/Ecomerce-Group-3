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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCod cod = new frmCod();
            cod.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmML Ml = new frmML();
            Ml.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenshin genshin = new frmGenshin();
            genshin.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWild wild = new frmWild();
            wild.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLol lol = new frmLol();
            lol.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmValo valo = new frmValo();
            valo.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFree free = new frmFree();
            free.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLife life = new frmLife();
            life.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPubg pubg = new frmPubg();
            pubg.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMOrig orig = new frmMOrig();
            orig.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIden iden = new frmIden();
            iden.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSteam steam = new frmSteam();
            steam.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInfo info = new frmInfo();
            info.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInfo info = new frmInfo();
            info.Show();
        }
    }
}
