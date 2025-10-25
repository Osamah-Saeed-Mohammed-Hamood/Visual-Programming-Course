using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture3Hw
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void ChickNum(object sender)
        {
            double n;
            double x = 1;
            try
            {
                 n = Convert.ToInt32(txtNum.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("أدخل عدد صالح ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNum.Text = "";
                txtNum.Focus();
                return;
            }
            if (sender == btnFact)
            { 
                for (int i = 2; i <= n; i++)
                    x *= i;
                lblFact.Text = x.ToString();
            }
            else if (sender == btnSqrt)
            {
                x = Math.Sqrt(n);
                lblSqrt.Text = x.ToString();
            }
            else if (sender == btnSum)
            {
                for (int i = 2; i <= n; i++)
                    x += i;
                lblSum.Text = x.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblFact.Text = lblSqrt.Text = lblSum.Text = "__";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            ChickNum(sender);
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            ChickNum(sender);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            ChickNum(sender);
        }
    }
}
