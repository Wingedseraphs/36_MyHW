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
            this.albumTableTableAdapter1.Fill(myAlbumDatabaseDataSet1.AlbumTable);

            for (int i = 0; i<=myAlbumDatabaseDataSet1.AlbumTable.Rows.Count-1;i++ ) 
            {
                LinkLabel x = new LinkLabel();
                x.Text = $"{myAlbumDatabaseDataSet1.AlbumTable.Rows[i][1]}";
                x.Left = 10;
                x.Top = 35 * i;
                x.Tag = i;

                x.Click += X_Click;
                this.splitContainer1.Panel1.Controls.Add(x);
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhotoFrm photo = new PhotoFrm();
            photo.Show();
        }
    }
}
