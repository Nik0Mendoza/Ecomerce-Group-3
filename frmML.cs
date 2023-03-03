using EcomGr3.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcomGr3
{
    public partial class frmML : Form
    {
        public frmML()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiscover discover = new frmDiscover();
            discover.Show();
        }

        private void frmML_Load(object sender, EventArgs e)
        {

        }

        private void widgets3_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
