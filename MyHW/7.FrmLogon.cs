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
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            enter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = UsernameTextBox.Text;
            string Password = PasswordTextBox.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();

                    command.CommandText = $"Insert into Mymember(UserName,Password) values ('{Username}','{Password}')";
                    command.Connection = conn;
                    conn.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Insert Member succerfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void enter()
        {
            string Username = UsernameTextBox.Text;
            string Password = PasswordTextBox.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();

                    command.CommandText = $"select * from Mymember where UserName = '{Username}'and Password = '{Password}'";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("Log on 成功");
                    }
                    else
                    {
                        MessageBox.Show("Log on 失敗");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogon_KeyDown(object sender, KeyEventArgs e)
        {
           if( e.Alt == true && e.KeyCode == Keys.O)
            {
                enter();
            }
           if(e.Alt == true && e.KeyCode == Keys.C)
            {
                Cancel_1();
            }
        }

        private void Cancel_1()
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Cancel_1();
        }
    }
}
