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
    public partial class Form2 : Form
    {
        string[] a;
        int m = 0, i = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNum.Text.Trim() != "")
            {
                if (i < m)
                {
                    a[i++] = txtNum.Text.ToString();
                    txtNum.Focus();
                    txtNum.Clear();
                }
                else
                {
                    MessageBox.Show("تجاوزت حجم المصفوفة");
                    txtNum.Clear();
                }
            }
            else
            {
                MessageBox.Show("أدخل الرقم");
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<48||e.KeyChar>57)
                e.Handled = true;
            if (e.KeyChar==8)
                e.Handled= false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstNum.Items.Clear();
            if (i>0)
            {
                for (int h = 0; h < i; h++)
                    lstNum.Items.Add(a[h]);
            }
            else
            {
                MessageBox.Show("المصفوفة فارغة");
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (lstNum.Items.Count > 0)
            {
                for (int h=0;h<i;h++)
                {
                    s += int.Parse(a[h]);
                }
                txtSum.Text = s.ToString();
            }
            else
            {
                MessageBox.Show("القائمة فارغة");
            }
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            bool f = (txtSize.Text != "");
            txtNum.Enabled = btnAdd.Enabled = btnClear.Enabled = btnShow.Enabled = lstNum.Enabled = txtSum.Enabled = btnSum.Enabled = f;
            lstNum.Items.Clear ();
            txtSum.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int b = lstNum.Items.Count;
            if (b>0)
            {
                for (int h=1;h<=b;h++)
                    lstNum.Items.Remove(lstNum.Items[0]);
                i = m = 0;
                a = new string[0];
                txtNum.Text = txtSize.Text = txtSum.Text = "";
                Form2_Load(null, null);
            }
            else
            {
                MessageBox.Show("القائمة فارغة");
            }
        }

        private void txtSize_Leave(object sender, EventArgs e)
        {
            if (txtSize.Text.Trim() != "")
            {
                m=int.Parse(txtSize.Text);
                a = new string[m];
            }
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtNum.Enabled = btnAdd.Enabled = btnClear.Enabled = btnShow.Enabled = lstNum.Enabled = txtSum.Enabled = btnSum.Enabled = false;
            if (sender is Button)
            {
                MessageBox.Show(((Button)sender).Text.ToString());
            }
            if (sender is Form)
            {
                MessageBox.Show(((Form)sender).Text.ToString());
            }
        }
    }
}
