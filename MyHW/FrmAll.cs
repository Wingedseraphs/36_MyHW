using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace MyHW
{
    public partial class FrmAll : Form
    {
        public FrmAll()
        {
            InitializeComponent();
        }

        private void btnNorthwind_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmCategoryProducts f = new FrmCategoryProducts();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void btnAdventureWorks_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmAdventure f = new FrmAdventure();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void btnDataSet_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmDataSet_結構 f = new FrmDataSet_結構();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmCustomers f = new FrmCustomers();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmMyAlbum_V2 f = new FrmMyAlbum_V2();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }
    }
}
