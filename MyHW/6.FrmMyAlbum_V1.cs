using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.cityTableTableAdapter1.Fill(myAlbumDataSet1.CityTable);
            for (int i = 0; i <= myAlbumDataSet1.CityTable.Rows.Count - 1; i++)
            {
                LinkLabel x = new LinkLabel();
                x.Text = $"{myAlbumDataSet1.CityTable.Rows[i][1]}";
                x.Left = 10;
                x.Top = 35 * i;
                x.Tag = i;

                x.Click += X_Click;
               // this.splitContainer1.Panel1.Controls.Add(x);
            }
        }
        private void X_Click(object sender, EventArgs e)
        {
            LinkLabel x = sender as LinkLabel;
            if (x != null)
            {
                string s = x.Text;
                this.photoTableTableAdapter1.CityFillBy(myAlbumDataSet1.PhotoTable, $"{s}");
                this.dataGridView1.DataSource = this.myAlbumDataSet1.PhotoTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
