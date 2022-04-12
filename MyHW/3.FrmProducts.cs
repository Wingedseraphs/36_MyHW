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

namespace MyHW
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            label2.Text = $"{bindingSource1.Position + 1}/{bindingSource1.Count}";
            lblResult.Text = $"結果 {bindingSource1.Count} 筆";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void btnSearchUP_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.UnitPriceFillBy(this.nwDataSet1.Products, int.Parse(txtMin.Text), int.Parse(txtMax.Text));
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
        }

        private void btnSearchPN_Click(object sender, EventArgs e)
        {
            
            this.productsTableAdapter1.PDNameFillBy(this.nwDataSet1.Products,txtProduct.Text);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
        }
    }
}
