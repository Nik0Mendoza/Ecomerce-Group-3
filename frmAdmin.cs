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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
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

        private void pictureBox6_Click(object sender, EventArgs e)
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
        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCodAdmin codAd = new frmCodAdmin();
            codAd.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMLAdmin mlAd = new frmMLAdmin();
            mlAd.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenshinAdmin genAd = new frmGenshinAdmin();
            genAd.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWildAdmin wildAd = new frmWildAdmin();
            wildAd.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoLAdmin lolAd = new frmLoLAdmin();
            lolAd.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmValoAdmin valoAd = new frmValoAdmin();
            valoAd.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFreeAdmin freeAd = new frmFreeAdmin();
            freeAd.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLifeAdmin lifeAd = new frmLifeAdmin();
            lifeAd.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPubgAdmin pubgAd = new frmPubgAdmin();
            pubgAd.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMOrigAdmin morigAd = new frmMOrigAdmin();
            morigAd.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIdenAdmin idenAd = new frmIdenAdmin();
            idenAd.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSteamAdmin steamAd = new frmSteamAdmin();
            steamAd.Show();
        }
    }
}
