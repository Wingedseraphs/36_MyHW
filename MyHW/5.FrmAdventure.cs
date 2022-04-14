using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmAdventure : Form
    {
        public FrmAdventure()
        {
            InitializeComponent();
        }

        private void FrmAdventure_Load(object sender, EventArgs e)
        {
            this.productPhotoTableAdapter1.Fill(this.awdDataSet1.ProductPhoto);
            this.bindingSource1.DataSource = this.awdDataSet1.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;

            this.comboBox1.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks;Integrated Security=True");
            conn.Open();
            SqlCommand command = new SqlCommand("select year(ModifiedDate) from Production.ProductPhoto group by year(ModifiedDate)", conn);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string b = $"{dataReader[""]}";
                this.comboBox1.Items.Add(b);
            }
            conn.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Dn = dateTimePicker1.Value;
            DateTime Dx = dateTimePicker2.Value;
            this.productPhotoTableAdapter1.DataFillBy(this.awdDataSet1.ProductPhoto, Dn, Dx);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime Dn = dateTimePicker1.Value;
            DateTime Dx = dateTimePicker2.Value;

            this.productPhotoTableAdapter1.OrderFillBy(this.awdDataSet1.ProductPhoto, Dn, Dx);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal ss = Convert.ToDecimal(comboBox1.SelectedItem);
            this.productPhotoTableAdapter1.YearFillBy(this.awdDataSet1.ProductPhoto, ss);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label4.Text = $"{this.bindingSource1.Position + 1} / {this.bindingSource1.Count}";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }



       
    }
}
