using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            LoadItems();
        }

        private void LoadItems()
        {
            string connectionString = "Data Source=LAPTOP-S27V0M4C\\SQLEXPRESS;Initial Catalog=PixelPay;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ID, ItemMLimage, ItemMLname, ItemMLprice, ItemMLstock  FROM tblML", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    byte[] imageData = (byte[])reader["ItemMLimage"];
                    string itemName = reader["ItemMLname"].ToString();
                    string itemPrice = reader["ItemMLprice"].ToString();
                    int stock = (int)reader["ItemMLstock"];

                    MemoryStream ms = new MemoryStream(imageData);
                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromStream(ms);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Width = 130;
                    pb.Height = 130;
                    pb.Margin = new Padding(5);
                    pb.Padding = new Padding(50);
                    pb.BorderStyle = BorderStyle.FixedSingle;

                    pb.Click += (sender, e) =>
                    {
                        foreach (var control in flowLayoutPanel1.Controls)
                        {
                            PictureBox otherPictureBox = control as PictureBox;
                            if (otherPictureBox != null && otherPictureBox != pb && otherPictureBox.BorderStyle == BorderStyle.Fixed3D)
                            {
                                otherPictureBox.BorderStyle = BorderStyle.FixedSingle;
                            }
                        }
                        pb.BorderStyle = pb.BorderStyle == BorderStyle.FixedSingle ? BorderStyle.Fixed3D : BorderStyle.FixedSingle;
                    };

                    Label lbl = new Label();
                    lbl.Text = itemName;
                    lbl.BackColor = Color.FromArgb(255, 185, 50);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Font = new Font("Open Sans", 8, FontStyle.Regular);
                    lbl.Height = 30;
                    lbl.Dock = DockStyle.Bottom;

                    Label lbl1 = new Label();
                    if (stock > 0)
                    {
                        lbl1.Text = "₱ " + itemPrice;
                    }
                    else
                    {
                        lbl1.Text = "OUT OF STOCK";
                    }
                    lbl1.BackColor = Color.FromArgb(226, 226, 226);
                    lbl1.TextAlign = ContentAlignment.MiddleCenter;
                    //lbl1.Width = 45;
                    lbl1.Font = new Font("Open Sans", 8, FontStyle.Regular);

                    flowLayoutPanel1.Controls.Add(pb);
                    pb.Controls.Add(lbl);
                    pb.Controls.Add(lbl1);
                }

                reader.Close();
            }
        }


        // Click event handler for the PictureBox
        private void PictureBox_Click(object sender, EventArgs e)
        {
            int imageId = (int)((PictureBox)sender).Tag; // Retrieve the image ID from the Tag property of the PictureBox
                                                         // Do something with the image ID, such as displaying the full-size image or opening a new window with additional information about the image
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiscover discover = new frmDiscover();
            discover.Show();
        }
    }
}
