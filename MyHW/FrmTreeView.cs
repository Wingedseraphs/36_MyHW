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
    public partial class FrmTreeView : Form
    {
        public FrmTreeView()
        {
            InitializeComponent();
        }
        private void FrmTreeView_Load(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * from Customers order by country";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string country = dataReader["Country"].ToString();
                        string city = dataReader["City"].ToString();

                        TreeNode tempNode;

                        if (treeView1.Nodes[country] == null)
                        {
                            TreeNode newNode = new TreeNode(country);
                            newNode.Name = country;
                            treeView1.Nodes.Add(newNode);
                            tempNode = newNode;
                        }
                        else
                        {
                            tempNode = treeView1.Nodes[country];
                        }
                        if (tempNode.Nodes[city] == null)
                        {
                            TreeNode newNode = new TreeNode(city);
                            newNode.Name = city;
                            tempNode.Nodes.Add(newNode);
                            tempNode = newNode;
                        }
                        else
                        {
                            tempNode = tempNode.Nodes[city];
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            this.customersTableAdapter1.FillByCity(nwDataSet1.Customers,e.Node.Text);
            this.bindingSource1.DataSource = this.nwDataSet1.Customers;
            this.dataGridView1.DataSource = this.nwDataSet1.Customers;

            if(bindingSource1.Count == 0)
            {
                this.label1.Text = "";
            }
            else
            {
                this.label1.Text = "總共" + this.bindingSource1.Count.ToString() + "筆 " + e.Node.Text  ;
            }
        }
    }
}
