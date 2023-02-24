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
    public partial class frmFreeAdmin : Form
    {
        public frmFreeAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin Ad = new frmAdmin();
            Ad.Show();
        }
    }
}
