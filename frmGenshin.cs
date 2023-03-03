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

    public partial class frmGenshin : Form
    {
        frmAcc acc = (frmAcc)Application.OpenForms["frmAcc"];
        int accountID;
        int ID;
        string productName;

        public frmGenshin()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiscover discover = new frmDiscover();
            discover.Show();
        }

        private void frmGenshin_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems()
        {
            string connectionString = "Data Source=LAPTOP-S27V0M4C\\SQLEXPRESS;Initial Catalog=PixelPay;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ID, ItemGenshinimage, ItemGenshinname, ItemGenshinprice, itemGenshinstock FROM tblCod", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    byte[] imageData = (byte[])reader["ItemGenshinimage"];
                    string itemName = reader["ItemGenshinname"].ToString();
                    string itemPrice = reader["ItemGenshinprice"].ToString();
                    string itemStock = reader["ItemGenshinstock"].ToString();

                    MemoryStream ms = new MemoryStream(imageData);
                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromStream(ms);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Width = 130;
                    pb.Height = 130;
                    pb.Margin = new Padding(5);
                    pb.Padding = new Padding(50);
                    pb.BorderStyle = BorderStyle.FixedSingle;

                    if (itemStock == "0")
                    {
                        pb.Enabled = false;
                    }

                    pb.Click += (sender, e) =>
                    {
                        if (pb.Enabled)
                        {
                            foreach (var control in flowLayoutPanel1.Controls)
                            {
                                PictureBox otherPictureBox = control as PictureBox;
                                //deselect
                                if (otherPictureBox != null && otherPictureBox != pb && otherPictureBox.BorderStyle == BorderStyle.Fixed3D)
                                {
                                    otherPictureBox.BorderStyle = BorderStyle.FixedSingle;
                                }
                            }
                            //select
                            pb.BorderStyle = pb.BorderStyle == BorderStyle.FixedSingle ? BorderStyle.Fixed3D : BorderStyle.FixedSingle;
                            ID = id;
                            productName = itemName;
                        }
                    };

                    Label lbl = new Label();
                    lbl.Text = itemName;
                    lbl.BackColor = Color.FromArgb(255, 185, 50);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Font = new Font("Open Sans", 8, FontStyle.Regular);
                    lbl.Height = 30;
                    lbl.Dock = DockStyle.Bottom;

                    Label lbl1 = new Label();
                    if (itemStock == "0")
                    {
                        lbl1.Text = "OUT OF STOCK";
                        lbl1.BackColor = Color.FromArgb(226, 226, 226);
                        lbl1.TextAlign = ContentAlignment.MiddleCenter;
                        lbl1.Font = new Font("Open Sans", 8, FontStyle.Regular);
                    }
                    else
                    {
                        lbl1.Text = "₱ " + itemPrice;
                        lbl1.BackColor = Color.FromArgb(226, 226, 226);
                        lbl1.TextAlign = ContentAlignment.MiddleCenter;
                        lbl1.Font = new Font("Open Sans", 8, FontStyle.Regular);

                    }

                    flowLayoutPanel1.Controls.Add(pb);
                    pb.Controls.Add(lbl);
                    pb.Controls.Add(lbl1);
                }

                reader.Close();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
