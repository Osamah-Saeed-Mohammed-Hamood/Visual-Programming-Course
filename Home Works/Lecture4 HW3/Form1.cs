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
    public partial class Frm_data : Form
    {
        public Frm_data()
        {
            InitializeComponent();
        }

        private void Frm_data_Load(object sender, EventArgs e)
        {
            MessageBox.Show("أنقر على الواجهة للحصول على ألوان مختلفة", "ترحيب", MessageBoxButtons.OKCancel);
            this.CenterToParent();
            txtShow.Text = "أسامة سعيد محمد حمود سعيد" + "\r\n";
        }

        private void Frm_data_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            this.BackColor=Color.FromArgb(r.Next(0,255), r.Next(0,255), r.Next(0,255));
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (txtNum.Text.Trim() != "")
                txtNum.BackColor = Color.Yellow;
            else
                txtNum.BackColor = Color.White;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.Red;
            btnAdd.BackColor = Color.Yellow;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Gray;
            btnAdd.ForeColor = Color.Black;
        }

        private void Frm_data_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("مع السلامة");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsNumber(string s)
        {
            for (int i = 0;i<s.Length;i++)
                if (s[i] >=48&& s[i]<=57)
                    return true;
            return false;
        }
        int x = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNum.Text.Trim() != ""&&!IsNumber(txtNum.Text))
            {
                txtShow.Text += txtNum.Text+"\r\n".ToString();
                txtNum.Focus();
                txtNum.Clear();
            }
            else
            {
                MessageBox.Show("خطأ في مربع النص");
                txtNum.Focus();
                txtNum.Clear();
            }                
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Black;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
