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
    public partial class FrmDataSet_結構 : Form
    {
        public FrmDataSet_結構()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);

            this.dataGridView1.DataSource = this.nwDataSet1.Products;
            this.dataGridView2.DataSource = this.nwDataSet1.Categories;
            this.dataGridView3.DataSource = this.nwDataSet1.Customers;

            this.listBox1.Items.Clear();

            for(int i = 0; i <= this.nwDataSet1.Tables.Count - 1; i++)
            {
                DataTable table = this.nwDataSet1.Tables[i];
                this.listBox1.Items.Add(table.TableName);

                string s = "";
                for(int colum = 0; colum <= table.Columns.Count - 1; colum++)
                {
                    s += $"{table.Columns[colum].ColumnName,-40}";
                }
                this.listBox1.Items.Add(s);
                for(int row = 0; row <= table.Rows.Count-1; row++)
                {
                    string b = "";
                    for(int cu = 0; cu <= table.Columns.Count-1; cu++)
                    {
                        b += $"{table.Rows[row][cu],-40}";
                    }
                    this.listBox1.Items.Add(b);
                }
            }
        }
    }
}
