using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture7_HW6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public Form5 (string btnText , string FormText)
        {
            InitializeComponent();
            btnResult.Text = btnText;
            this.Text = FormText;
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (btnResult.Text =="جمع")
            {
                if (txtNum1.Text ==""&&txtNum2.Text=="")
                {
                    MessageBox.Show("أدخل الأعداد");
                    txtNum1.Focus();
                }
                else if (txtNum1.Text =="")
                {
                    MessageBox.Show("أدخل العدد الأول");
                    txtNum1.Focus();
                }
                else if (txtNum2.Text =="")
                {
                    MessageBox.Show("أدخل العدد الثاني ");
                    txtNum2.Focus();
                }
                else
                {
                    int num = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text);
                    txtResult.Text = num.ToString();
                }
            }

            if (btnResult.Text == "طرح")
            {
                if (txtNum1.Text == "" && txtNum2.Text == "")
                {
                    MessageBox.Show("أدخل الأعداد");
                    txtNum1.Focus();
                }
                else if (txtNum1.Text == "")
                {
                    MessageBox.Show("أدخل العدد الأول");
                    txtNum1.Focus();
                }
                else if (txtNum2.Text == "")
                {
                    MessageBox.Show("أدخل العدد الثاني ");
                    txtNum2.Focus();
                }
                else
                {
                    int num = Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text);
                    txtResult.Text = num.ToString();
                }
            }
            if (btnResult.Text == "ضرب")
            {
                if (txtNum1.Text == "" && txtNum2.Text == "")
                {
                    MessageBox.Show("أدخل الأعداد");
                    txtNum1.Focus();
                }
                else if (txtNum1.Text == "")
                {
                    MessageBox.Show("أدخل العدد الأول");
                    txtNum1.Focus();
                }
                else if (txtNum2.Text == "")
                {
                    MessageBox.Show("أدخل العدد الثاني ");
                    txtNum2.Focus();
                }
                else
                {
                    int num = Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtNum2.Text);
                    txtResult.Text = num.ToString();
                }
            }

            if (btnResult.Text == "قسمة")
            {
                if (txtNum1.Text == "" && txtNum2.Text == "")
                {
                    MessageBox.Show("أدخل الأعداد");
                    txtNum1.Focus();
                }
                else if (txtNum1.Text == "")
                {
                    MessageBox.Show("أدخل العدد الأول");
                    txtNum1.Focus();
                }
                else if (txtNum2.Text == "")
                {
                    MessageBox.Show("أدخل العدد الثاني ");
                    txtNum2.Focus();
                }
                else
                {
                    if (Convert.ToInt32(txtNum2.Text) == 0)
                    {
                        MessageBox.Show("لا يمكن القسمة على صفر ");
                        txtNum2.Clear();
                        txtNum2.Focus();
                    }
                    else
                    {
                        double num = Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtNum2.Text);
                        txtResult.Text = num.ToString();
                    }
                }
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
