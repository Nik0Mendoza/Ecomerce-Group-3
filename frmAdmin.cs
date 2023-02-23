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

        private void label17_Click(object sender, EventArgs e)
        {
            panelCod.Visible = false;
            panelML.Visible = false;
            panelGenshin.Visible = false;
            paneLol.Visible = false;
            panelValo.Visible = false;
            panelWild.Visible = false;
            panelPubg.Visible = false;
            panelFree.Visible = false;
            panelLife.Visible = false;
            panelOrigin.Visible = false;
            panelIdentity.Visible = true;
            panelSteam.Visible = false;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            panelCod.Visible = true;
            panelML.Visible = false;
            panelGenshin.Visible = false;
            paneLol.Visible = false;
            panelValo.Visible = false;
            panelWild.Visible = false;
            panelPubg.Visible = false;
            panelFree.Visible = false;
            panelLife.Visible = false;
            panelOrigin.Visible = false;
            panelIdentity.Visible = false;
            panelSteam.Visible = false;

        }
            private void label8_Click(object sender, EventArgs e)
        {
            panelCod.Visible = false;
            panelML.Visible = true;
            panelGenshin.Visible = false;
            paneLol.Visible = false;
            panelValo.Visible = false;
            panelWild.Visible = false;
            panelPubg.Visible = false;
            panelFree.Visible = false;
            panelLife.Visible = false;
            panelOrigin.Visible = false;
            panelIdentity.Visible = false;
            panelSteam.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            panelCod.Visible = false;
            panelML.Visible = false;
            panelGenshin.Visible = true;
            paneLol.Visible = false;
            panelValo.Visible = false;
            panelWild.Visible = false;
            panelPubg.Visible = false;
            panelFree.Visible = false;
            panelLife.Visible = false;
            panelOrigin.Visible = false;
            panelIdentity.Visible = false;
            panelSteam.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            panelCod.Visible = false;
            panelML.Visible = false;
            panelGenshin.Visible = false;
            paneLol.Visible = true;
            panelValo.Visible = false;
            panelWild.Visible = false;
            panelPubg.Visible = false;
            panelFree.Visible = false;
            panelLife.Visible = false;
            panelOrigin.Visible = false;
            panelIdentity.Visible = false;
            panelSteam.Visible = false; paneLol.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            panelCod.Visible = false;
            panelML.Visible = false;
            panelGenshin.Visible = false;
            paneLol.Visible = false;
            panelValo.Visible = true;
            panelWild.Visible = false;
            panelPubg.Visible = false;
            panelFree.Visible = false;
            panelLife.Visible = false;
            panelOrigin.Visible = false;
            panelIdentity.Visible = false;
            panelSteam.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            panelCod.Visible = false;
            panelML.Visible = false;
            panelGenshin.Visible = false;
            paneLol.Visible = false;
            panelValo.Visible = false;
            panelWild.Visible = true;
            panelPubg.Visible = false;
            panelFree.Visible = false;
            panelLife.Visible = false;
            panelOrigin.Visible = false;
            panelIdentity.Visible = false;
            panelSteam.Visible = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            panelCod.Visible = false;
            panelML.Visible = false;
            panelGenshin.Visible = false;
            paneLol.Visible = false;
            panelValo.Visible = false;
            panelWild.Visible = false;
            panelPubg.Visible = true;
            panelFree.Visible = false;
            panelLife.Visible = false;
            panelOrigin.Visible = false;
            panelIdentity.Visible = false;
            panelSteam.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            panelCod.Visible = false;
            panelML.Visible = false;
            panelGenshin.Visible = false;
            paneLol.Visible = false;
            panelValo.Visible = false;
            panelWild.Visible = false;
            panelPubg.Visible = false;
            panelFree.Visible = true;
            panelLife.Visible = false;
            panelOrigin.Visible = false;
            panelIdentity.Visible = false;
            panelSteam.Visible = false;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            panelCod.Visible = false;
            panelML.Visible = false;
            panelGenshin.Visible = false;
            paneLol.Visible = false;
            panelValo.Visible = false;
            panelWild.Visible = false;
            panelPubg.Visible = false;
            panelFree.Visible = false;
            panelLife.Visible = true;
            panelOrigin.Visible = false;
            panelIdentity.Visible = false;
            panelSteam.Visible = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            panelCod.Visible = false;
            panelML.Visible = false;
            panelGenshin.Visible = false;
            paneLol.Visible = false;
            panelValo.Visible = false;
            panelWild.Visible = false;
            panelPubg.Visible = false;
            panelFree.Visible = false;
            panelLife.Visible = false;
            panelOrigin.Visible = true;
            panelIdentity.Visible = false;
            panelSteam.Visible = false;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            panelCod.Visible = false;
            panelML.Visible = false;
            panelGenshin.Visible = false;
            paneLol.Visible = false;
            panelValo.Visible = false;
            panelWild.Visible = false;
            panelPubg.Visible = false;
            panelFree.Visible = false;
            panelLife.Visible = false;
            panelOrigin.Visible = false;
            panelIdentity.Visible = false;
            panelSteam.Visible = true;
        }
    }
}
