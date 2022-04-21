using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyHW.Properties;

namespace MyHW
{
    public partial class FrmMyAlbum_V2 : Form
    {
        public FrmMyAlbum_V2()
        {
            InitializeComponent();
            this.flowLayoutPanel3.AllowDrop = true;
            this.flowLayoutPanel3.DragEnter += FlowLayoutPanel3_DragEnter; ;
            this.flowLayoutPanel3.DragDrop += FlowLayoutPanel3_DragDrop; ;

            this.comboBox1.Items.Clear();
            SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString);
            conn.Open();
            SqlCommand command = new SqlCommand("select * from CityTable", conn);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string a = $"{dataReader["City"]}";
                this.comboBox1.Items.Add(a);
            }
            conn.Close();
        }

        private void FlowLayoutPanel3_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i <= files.Length - 1; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(files[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 100;
                pic.Height = 80;

                pic.Click += Pic_Click; 
                this.flowLayoutPanel3.Controls.Add(pic);
                try
                {
                    SqlConnection conn = null;
                    using (conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"Insert into PhotoTable(CityID,Photo) values(@Desc,@Image)";
                        command.Connection = conn;
                        byte[] bytes;
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        bytes = ms.GetBuffer();

                        command.Parameters.Add("@Desc", SqlDbType.Text).Value = comboBox1.SelectedItem;
                        command.Parameters.Add("@Image", SqlDbType.Image).Value = bytes;
                        conn.Open();
                        command.ExecuteNonQuery();
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Stretch;
            f.Show();
        }

        private void FlowLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void FrmMyAlbum_V2_Load(object sender, EventArgs e)
        {
            this.cityTableTableAdapter1.Fill(myAlbumDataSet1.CityTable);
            for (int i = 0; i <= myAlbumDataSet1.CityTable.Rows.Count - 1; i++)
            {
                LinkLabel x = new LinkLabel();
                x.Text = $"{myAlbumDataSet1.CityTable.Rows[i][1]}";
                x.Left = 10;
                x.Top = 35 * i;
                x.Tag = i;

                x.Click += X_Click;
                this.flowLayoutPanel2.Controls.Add(x);
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            LinkLabel x = sender as LinkLabel;
            ShowImageId((string)x.Text);
        }


        private void ShowImageId(string x)
        {
            flowLayoutPanel1.Controls.Clear();


            SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString);

            SqlCommand command = new SqlCommand();
            command.CommandText = $"select * from PhotoTable p join CityTable c on p.CityID = c.City where c.City = '{x}'";
            command.Connection = conn;
            conn.Open();
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {

                byte[] bytes = (byte[])dataReader["Photo"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                PictureBox pic = new PictureBox();
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 100;
                pic.Height = 80;

                this.flowLayoutPanel1.Controls.Add(pic);
            }
            conn.Close();

        }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.jpg) | *.jpg|(*.png)|*.png|(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PictureBox pic = new PictureBox();
                
                pic.Image = Image.FromFile(openFileDialog1.FileName);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 100;
                pic.Height = 80;

                
                this.flowLayoutPanel3.Controls.Add(pic);
            }

        }
    }
}
