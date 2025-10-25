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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            lstOp.Items.Add("+");
            lstOp.Items.Add("-");
            lstOp.Items.Add("*");
            lstOp.Items.Add("/");
            lstOp.SelectedIndex = 0;
        }

        double x, y, z;
        string[] op = { "+", "-", "*", "/" };

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum2.Text = txtresult.Text = null;
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            txtresult.Text = "";
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            txtresult.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(txtNum1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("العدد الاول غير صالح", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtNum1.Text = "";
                txtNum1.Focus();
                return;
            }
            try
            {
                y = Convert.ToDouble(txtNum2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("العدد الثاني غير صالح", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtNum2.Text = "";
                txtNum2.Focus();
                return;
            }
            bool f = true;
            switch (lstOp.SelectedIndex)
            {
                default: break;
                case 0: z = x + y; break;
                case 1: z = x - y; break;
                case 2: z = x * y; break;
                case 3:
                    if (y != 0)
                    {
                        z = x / y;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("لا يمكن القسمة على صفر ");
                        f = false;
                        txtresult.Text = null;
                        txtNum2.Text = "";
                        txtNum2.Focus();
                    }
                    break;
            }
            if (f)
            {
                txtresult.Text = z.ToString();
            }
            //  هذا النشاط 
            else
            {
                txtresult.Text = "";
            }
        }

        private void btnForm5_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtresult.ReadOnly = true;
        }
    }
}
