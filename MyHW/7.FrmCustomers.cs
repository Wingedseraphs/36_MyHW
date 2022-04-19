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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
            loadCountryCombox();
            CreateLisview();
        }

        private void CreateLisview()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select * from Customers", conn);
                    SqlDataReader datareader = command.ExecuteReader();
                    DataTable table = datareader.GetSchemaTable();

                    for (int i = 0; i <= table.Rows.Count - 1; i++)
                    {
                        this.listView1.Columns.Add(table.Rows[i][0].ToString());
                    }
                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadCountryCombox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select distinct Country from Customers", conn);
                    //Step3 : sqlDataReader
                    SqlDataReader datareader = command.ExecuteReader();
                    //datareader.Read();
                    //Step4 : UI Control
                    this.comboBox1.Items.Clear();
                    this.comboBox1.Items.Add("--AllCountry--");
                    while (datareader.Read())
                    {
                        this.comboBox1.Items.Add(datareader["Country"]);
                    }
                    this.comboBox1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    
                    
                    if (comboBox1.Text == "--AllCountry--")
                    {
                        Random r = new Random();
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers";
                        command.Connection = conn;
                        SqlDataReader datareader = command.ExecuteReader();

                        this.listView1.Items.Clear();
                        while (datareader.Read())
                        {
                            ListViewItem lis = this.listView1.Items.Add(datareader[0].ToString());
                            lis.ImageIndex = r.Next(0,lis.ImageList.Images.Count);
                            if (lis.Index % 2 == 0)
                            {
                                lis.BackColor = Color.Red;
                            }
                            else
                            {
                                lis.BackColor = Color.BurlyWood;
                            }
                            for (int i = 1; i <= datareader.FieldCount - 1; i++)
                            {
                                if (datareader.IsDBNull(i))
                                {
                                    lis.SubItems.Add("空值");
                                }
                                else
                                {
                                    lis.SubItems.Add(datareader[i].ToString());
                                }
                            }
                        }
                    }
                    else
                    {
                        Random r = new Random();
                        conn.Open();
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers where country = '{this.comboBox1.Text}'";
                        command.Connection = conn;
                        SqlDataReader datareader = command.ExecuteReader();

                        this.listView1.Items.Clear();
                        while (datareader.Read())
                        {
                            ListViewItem lis = this.listView1.Items.Add(datareader[0].ToString());
                            lis.ImageIndex = r.Next(0,lis.ImageList.Images.Count);
                            if (lis.Index % 2 == 0)
                            {
                                lis.BackColor = Color.Red;
                            }
                            else
                            {
                                lis.BackColor = Color.BurlyWood;
                            }
                            for (int i = 1; i <= datareader.FieldCount - 1; i++)
                            {
                                if (datareader.IsDBNull(i))
                                {
                                    lis.SubItems.Add("空值");
                                }
                                else
                                {
                                    lis.SubItems.Add(datareader[i].ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
