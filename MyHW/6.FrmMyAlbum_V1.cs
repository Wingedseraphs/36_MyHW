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
    public partial class FrmMyAlbum_V1 : Form
    {
        public FrmMyAlbum_V1()
        {
            InitializeComponent();
        }

        private void FrmMyAlbum_V1_Load(object sender, EventArgs e)
        {
            //this.cityTableTableAdapter1.Fill(myphotoDataSet1.CityTable);
            //for (int i = 0; i <= myphotoDataSet1.CityTable.Rows.Count - 1; i++)
            //{
            //    LinkLabel x = new LinkLabel();
            //    x.Text = $"{myphotoDataSet1..CityTable.Rows[i][1]}";
            //    x.Left = 10;
            //    x.Top = 35 * i;
            //    x.Tag = i;

            //    x.Click += X_Click;
                // this.splitContainer1.Panel1.Controls.Add(x);
            }
        }
        //private void X_Click(object sender, EventArgs e)
        //{
        //    //LinkLabel x = sender as LinkLabel;
        //    //if (x != null)
        //    //{
        //    //    string s = x.Text;
        //    //    this.myphotoDataSet1.CityFillBy(myAlbumDataSet1.PhotoTable, $"{s}");
        //    //    this.dataGridView1.DataSource = this.myAlbumDataSet1.PhotoTable;
        //    //}
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //try
        //    //{
        //    //    using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
        //    //    {
        //    //        SqlCommand command = new SqlCommand();

        //    //        command.CommandText = $"Insert into PhotoTable(CityID,Photo) values (@Desc,@Image)";
        //    //        command.Connection = conn;

        //    //        byte[] bytes;
        //    //        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        //    //        this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    //        bytes = ms.GetBuffer();
        //    //        command.Parameters.Add("@Desc", SqlDbType.Int).Value = 2;
        //    //        command.Parameters.Add("@Image", SqlDbType.Image).Value = bytes;
        //    //        conn.Open();
        //    //        command.ExecuteNonQuery();
        //    //        MessageBox.Show("Insert Member successfully");
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message);
        //    //}
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    //openFileDialog1.Filter = "(*.jpg) | *.jpg|(*.png)|*.png";
        //    //if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    //{
        //    //    this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        //    //}
        //}
    }

