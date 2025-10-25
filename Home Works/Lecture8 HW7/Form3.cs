using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المشروع_السابع
{
    public partial class Form3 : Form
    {
        int CountOfItems = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            Random r = new Random();
            int i = 0;
            while (i <10)
            {
                int n = r.Next(100);
                if (!lstNum.Items.Contains(n)&&n<=100)
                {
                    lstNum.Items.Add(n);
                    i++;
                    CountOfItems++;
                }
            }
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CountOfItems < 20)
            {
                if (txtAdd.Text != "")
                {
                    int x = Convert.ToInt32(txtAdd.Text);
                    if (x <= 100 && !lstNum.Items.Contains(x))
                    {
                        lstNum.Items.Add(x);
                        CountOfItems++;
                        txtAdd.Text = "";
                        txtAdd.Focus();
                    }
                    else if (x > 100)
                    {
                        MessageBox.Show("العدد أكبر من 100");
                        txtAdd.Clear();
                        txtAdd.Focus();
                    }
                    else if (lstNum.Items.Contains(x))
                    {
                        MessageBox.Show("العنصر موجود في القائمة");
                        txtAdd.Focus();
                        txtAdd.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("أدخل العنصر المراد اضافته");
                    txtAdd.Focus();
                }
            }
            else
            {
                MessageBox.Show("تجاوزت الحد المسموح للقائمة");
                txtAdd.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(lstNum.SelectedIndex >-1)
            {
                lstNum.Items.RemoveAt(lstNum.SelectedIndex);
                CountOfItems--;
            }
            else
            {
                MessageBox.Show("قم بتحديد العنصر في القائمة");
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstNum.Items.Clear();
            CountOfItems = 0;
            txtSum.Text = "";
            txtAvg.Text = "";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (lstNum.Items.Count > 0)
            {
                int sum = 0;
                for (int i = 0; i < lstNum.Items.Count; i++)
                    sum += Convert.ToInt32(lstNum.Items[i]);
                txtSum.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("القائمة فارغة");
                txtAvg.Text = "";
                txtSum.Text = "";
            }
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            if (lstNum.Items.Count > 0)
            {
                if (txtSum.Text != "")
                {
                    txtAvg.Text = (Convert.ToDouble(txtSum.Text) / lstNum.Items.Count).ToString("0.00");
                }
                else
                {
                    int avg = 0;
                    for(int i=0; i<lstNum.Items.Count; i++)
                    {
                        avg+= Convert.ToInt32(lstNum.Items[i]);
                    }
                    txtAvg.Text = (Convert.ToDouble(avg) / lstNum.Items.Count).ToString("0.00");
                }
            }
            else
            {
                MessageBox.Show("القائمة فارغة");
                txtAvg.Text = "";
                txtSum.Text = "";
            }
        }
    }
}
