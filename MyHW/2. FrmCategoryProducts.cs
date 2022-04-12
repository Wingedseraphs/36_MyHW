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
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();
            this.comboBox1.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            conn.Open();
            SqlCommand command = new SqlCommand("select * from Categories", conn);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string b = $"{dataReader["CategoryName"]}"; //給40個位置-從左排列正從右排 :c2 貨幣留小數點兩位數
                this.comboBox1.Items.Add(b);
            }
            conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            string s = comboBox1.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            conn.Open();
            SqlCommand command = new SqlCommand($"select * from Products As p join Categories As c on p.CategoryID = c.CategoryID where CategoryName ='{s}'" ,conn);
            SqlDataReader dataReader = command.ExecuteReader();
           

            while (dataReader.Read())
            {
                string b = $"{dataReader["ProductName"],-40}--{dataReader["CategoryID"],-2}"; //給40個位置-從左排列正從右排 :c2 貨幣留小數點兩位數
                this.listBox1.Items.Add(b);
            }
            conn.Close();
        }
    }
}
