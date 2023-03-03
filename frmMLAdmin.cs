using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Image = System.Drawing.Image;

namespace EcomGr3
{
    public partial class frmMLAdmin : Form
    {
        public frmMLAdmin()
        {
            InitializeComponent();
            LoadGrid();
        }

        SqlConnection con = new SqlConnection("Data Source=MAYLADYEYN\\SQLEXPRESS01;Initial Catalog=PixelPlay;Integrated Security=True");

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin Ad = new frmAdmin();
            Ad.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtItemsearch.Text = row.Cells[0].Value.ToString();
                txtItemName.Text = row.Cells[1].Value.ToString();
                txtItemPrice.Text = row.Cells[2].Value.ToString();
                txtItemStock.Text = row.Cells[3].Value.ToString();

                    if (row.Cells[4].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells[4].Value;
                    MemoryStream ms = new MemoryStream(imageBytes);
                    itemDisplay.Image = Image.FromStream(ms);
                }
                else
                {
                    itemDisplay.Image = null;
                }
            }
        }


    public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("Select * from tblML", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO tblML VALUES (@itemMLname, @itemMLprice, @itemMLstock, @itemMLimage)", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.Parameters.AddWithValue("@itemMLname", txtItemName.Text);
            cmd.Parameters.AddWithValue("@itemMLprice", txtItemPrice.Text);
            cmd.Parameters.AddWithValue("@itemMLstock", txtItemStock.Text);
            cmd.Parameters.AddWithValue("@itemMLimage", getPhoto());
            int i = cmd.ExecuteNonQuery();
            con.Close();
            LoadGrid();
            if (i > 0) MessageBox.Show("Item Successfully added...");
            clearData();
        }
        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            itemDisplay.Image.Save(stream, itemDisplay.Image.RawFormat);

            return stream.GetBuffer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMLAdmin_Load(object sender, EventArgs e)
        {
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                itemDisplay.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE tblML SET itemMLname = '" + txtItemName.Text + "', itemMLprice = '" + txtItemPrice.Text + "', itemMLstock = '" + txtItemStock.Text + "', itemMLimage = @itemMLimage WHERE id = '" + txtItemsearch.Text + "' ", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@itemMLimage", getPhoto());
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0) MessageBox.Show("Item Successfully updated...");
            LoadGrid();
            clearData();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void clearData()
        {
            txtItemName.Clear();
            txtItemPrice.Clear();
            txtItemStock.Clear();
            txtItemsearch.Clear();
            itemDisplay.Image = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM tblML where ID = " + txtItemsearch.Text + " ", con);
            cmd.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0) MessageBox.Show("Item Successfully deleted...");
            LoadGrid();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void itemDisplay_Click(object sender, EventArgs e)
        {

        }

        private void txtItemStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblMLBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
