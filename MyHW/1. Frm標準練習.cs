
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm標準練習 : Form
    {
        public Frm標準練習()
        {
            InitializeComponent();
        }

        int MyMinScore(int[] nums)
        {
            return 10;
        }

        private void btnOddandEven_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("請輸入正確數值");
                txtInput.Focus();
            }
            else
            {
                int sum = int.Parse(txtInput.Text);
                if (sum % 2 == 0)
                {
                    lblResult.Text = sum + " 是偶數";
                }
                else
                {
                    lblResult.Text = sum + " 是奇數";
                }
            }
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            int a = 44, b = 100, c = 88;
            if(a > b && a > c)
            {
                lblResult.Text = "a = 44, b = 100, c = 88  ," + a + " 是最大的";
            }else if(b > a && b > c)
            {
                lblResult.Text = "a = 44, b = 100, c = 88  ," + b + " 是最大的";
            }
            else
            {
                lblResult.Text = "a = 44, b = 100, c = 88  ," + c + " 是最大的";
            }
        }

        private void btnNinetyNine_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            for (int i = 1;i < 10; i++)
            {
                lblResult.Text += "\n";
                for (int j = 1;j < 10; j++)
                {
                    if(i * j < 10)
                    {
                        lblResult.Text += j + "*" + i + "=" + " " + i * j + " ";
                    }
                    else
                    {
                        lblResult.Text += j + "*" + i + "=" + i * j + " ";
                    }

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "結果";
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(100, 2);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            int[] nums = { 33, 4, 5, 11, 222, 34 };
            foreach (int i in nums)
            {
                if (i % 2 == 0)
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }
            lblResult.Text = " 33, 4, 5, 11, 222, 34 " + "\n偶數有 " + a + "\n奇數有 " + b;
        }

        private void buttonString_Click(object sender, EventArgs e)
        {
            string mix = "";
            int j = 0;
            string[] names = { "aaa", "ksdkfjsdk", "cccssf", "kahgkuagewgwe", "ohugeg" };
            foreach (string i in names)
            {
                if (j < i.Length)
                {
                    j = i.Length;
                    mix = i;
                }
            }
            lblResult.Text = "aaa, ksdkfjsdk, cccssf, kahgkuagewgwe, ohugeg\n" + "最長的是 " + mix;
        }

        private void btnFindC_Click(object sender, EventArgs e)
        {
            string[] names = { "adff", "Ciojaf", "eiojjc", "eeieiceei", "ioajf" };
            int Sum = 0;
            foreach(string i in names)
            {
                if (i.Contains("C") || i.Contains("c"))
                {
                    Sum++;
                }
            }
            lblResult.Text = "adff, Ciojaf, eiojjc, eeieiceei, ioajf\n" + "有C或c總共有 " + Sum + " 個";
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };

            int Max = scores.Max();
            int Min = scores.Min();

            lblResult.Text = $" 2, 3, 46, 33, 22, 100, 150, 33, 55 \n 最大的數是：{Max} 最小的數是：{Min}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Max();
        }
        void Max()
        {
            int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };

            int Max = scores.Max();
            int Min = scores.Min();

            lblResult.Text = $" 2, 3, 46, 33, 22, 100, 150, 33, 55 \n 最大的數是：{Max} 最小的數是：{Min}";

        }

        private void btnLotto_Click(object sender, EventArgs e)
        {
            Random Random = new Random();
            List<int> listNumbers = new List<int>();
            int number = 0;
            string b = "";
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    number = Random.Next(1, 49);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
                b += " " + listNumbers[i];
            }
            lblResult.Text = "樂透號碼\n" + b;
        }
    }
}
