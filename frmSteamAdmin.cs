using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcomGr3
{
    public partial class frmSteamAdmin : Form
    {
        public frmSteamAdmin()
        {
            InitializeComponent();
            LoadGrid();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-S27V0M4C\\SQLEXPRESS;Initial Catalog=PixelPay;Integrated Security=True");

        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("Select * from tblSteam", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            itemDisplay.Image.Save(stream, itemDisplay.Image.RawFormat);

            return stream.GetBuffer();
        }

        public void clearData()
        {
            txtItemName.Clear();
            txtItemPrice.Clear();
            txtItemStock.Clear();
            txtItemsearch.Clear();
            itemDisplay.Image = null;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin Ad = new frmAdmin();
            Ad.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                itemDisplay.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO tblSteam VALUES (@itemSteamname, @itemSteamprice, @itemSteamstock, @itemSteamimage)", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.Parameters.AddWithValue("@itemSteamname", txtItemName.Text);
            cmd.Parameters.AddWithValue("@itemSteamprice", txtItemPrice.Text);
            cmd.Parameters.AddWithValue("@itemSteamstock", txtItemStock.Text);
            cmd.Parameters.AddWithValue("@itemSteamimage", getPhoto());
            int i = cmd.ExecuteNonQuery();
            con.Close();
            LoadGrid();
            if (i > 0) MessageBox.Show("Item Successfully added...");
            clearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM tblSteam where ID = " + txtItemsearch.Text + " ", con);
            cmd.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0) MessageBox.Show("Item Successfully deleted...");
            LoadGrid();
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE tblSteam SET itemSteamname = '" + txtItemName.Text + "', itemSteamprice = '" + txtItemPrice.Text + "', itemSteamstock = '" + txtItemStock.Text + "', itemSteamimage = @itemSteamimage WHERE id = '" + txtItemsearch.Text + "' ", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@itemSteamimage", getPhoto());
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0) MessageBox.Show("Item Successfully updated...");
            LoadGrid();
            clearData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearData();
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
    }
}
