using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            but_Exit.BackColor = Color.Red;
            but_Clear.BackColor = Color.DarkGray;
            text_Result.BackColor = Color.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text_Result.ReadOnly = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            text_N1.Clear();
            text_N2.Clear();
            text_Result.Clear();
            text_N1.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_Sum_Click(object sender, EventArgs e)
        {
            if (text_N1.Text.Trim() != "" && text_N2.Text.Trim() != "")
            {
                double x = Convert.ToDouble(text_N1.Text);
                double y = Convert.ToDouble(text_N2.Text);
                double z = x + y;
                text_Result.Text = z.ToString();
            }
            else if (text_N1.Text.Trim() == "" && text_N2.Text!="")
            {
                text_Result.Clear();
                MessageBox.Show("أدخل العدد الاول !");
                text_N1.Focus();
            }
            else if (text_N2.Text.Trim() == "" && text_N1.Text!="")
            {
                text_Result.Clear();
                MessageBox.Show("أدخل العدد الثاني !");
                text_N2.Focus();
            }
            else if (text_N1.Text == "" && text_N2.Text == "")
            {
                MessageBox.Show("أدخل الاعداد !");
                text_Result.Clear();
                text_N1.Focus();
            }
        }

        private void text_Result_TextChanged(object sender, EventArgs e)
        {
            //   text_Result.ReadOnly = true;
        }

        private void text_N1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (text_N1.Text.Length == 0 && e.KeyChar == '-')
                e.Handled = false;
            else if (e.KeyChar == '-' && text_N1.Text.Contains("-"))
                e.Handled = true;

            if (e.KeyChar == '.')
            {
                if ((sender as TextBox).Text.Contains("."))
                    e.Handled = true;
            }

            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void text_N2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_N2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (text_N1.Text.Length == 0 && e.KeyChar == '-')
                e.Handled = false;
            else if (e.KeyChar == '-' && text_N1.Text.Contains("-"))
                e.Handled = true;

            if (e.KeyChar == '.')
            {
                if ((sender as TextBox).Text.Contains("."))
                    e.Handled = true;
            }

            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void but_Sub_Click(object sender, EventArgs e)
        {
            if (text_N1.Text.Trim() != "" && text_N2.Text.Trim() != "")
            {
                double x = Convert.ToDouble(text_N1.Text);
                double y = Convert.ToDouble(text_N2.Text);
                double z = x - y;
                text_Result.Text = z.ToString();
            }
            else if (text_N1.Text.Trim() == "" && text_N2.Text!="")
            {
                text_Result.Clear();
                MessageBox.Show("أدخل العدد الاول !");
                text_N1.Focus();
            }
            else if (text_N2.Text.Trim() == "" && text_N1.Text!="")
            {
                text_Result.Clear();
                MessageBox.Show("أدخل العدد الثاني !");
                text_N2.Focus();
            }
            else if (text_N1.Text == "" && text_N2.Text == "")
            {
                MessageBox.Show("أدخل الاعداد !");
                text_Result.Clear();
                text_N1.Focus();
            }
        }

        private void but_Mul_Click(object sender, EventArgs e)
        {
            if (text_N1.Text.Trim() != "" && text_N2.Text.Trim() != "")
            {
                double x = Convert.ToDouble(text_N1.Text);
                double y = Convert.ToDouble(text_N2.Text);
                double z = x * y;
                text_Result.Text = z.ToString();
            }
            else if (text_N1.Text.Trim() == "" && text_N2.Text!="")
            {
                text_Result.Clear();
                MessageBox.Show("أدخل العدد الاول !");
                text_N1.Focus();
            }
            else if (text_N2.Text.Trim() == "" && text_N1.Text!= "")
            {
                text_Result.Clear();
                MessageBox.Show("أدخل العدد الثاني !");
                text_N2.Focus();
            }
           else if (text_N1.Text == "" && text_N2.Text == "")
            {
                MessageBox.Show("أدخل الاعداد !");
                text_Result.Clear();
                text_N1.Focus();
            }
        }

        private void but_Div_Click(object sender, EventArgs e)
        {
            if (text_N1.Text.Trim() != "" && text_N2.Text.Trim() != "" && text_N2.Text != "0")
            {
                double x = Convert.ToDouble(text_N1.Text);
                double y = Convert.ToDouble(text_N2.Text);
                double z = x / y;
                text_Result.Text = z.ToString();
            }
            else if (text_N1.Text.Trim() == "" && text_N2.Text!="")
            {
                text_Result.Clear();
                MessageBox.Show("أدخل العدد الاول !");
                text_N1.Focus();
            }
            else if (text_N2.Text == "0" && text_N1.Text!="")
            {
                text_Result.Clear();
                MessageBox.Show("لا يمكن القسمة على صفر !");
                text_N2.Clear();
                text_N2.Focus();
            }
            else if (text_N2.Text.Trim() == "" && text_N1.Text!="")
            {
                text_Result.Clear();
                MessageBox.Show("أدخل العدد الثاني !");
                text_N2.Focus();
            }
           else if (text_N1.Text == "" && text_N2.Text == "")
            {
                MessageBox.Show("أدخل الاعداد !");
                text_Result.Clear();
                text_N1.Focus();
            }
        }
        private void but_N_Mul_Click(object sender, EventArgs e)
        {
            if (text_N1.Text != "" && text_N2.Text != "")
            {
                MessageBox.Show("ضع الرقم في خانة واحدة فقط !");
                text_Result.Clear();
                text_N2.Clear();
                text_N1.Focus();
            }
            else if (text_N1.Text != "" && text_N2.Text == "")
            {
                double a = Convert.ToDouble(text_N1.Text);
                if (a != Math.Truncate(a))
                {
                    MessageBox.Show("لا يمكن ايجاد المضروب لعدد عشري !");
                    text_Result.Clear();
                    text_N1.Focus();
                }
                else if (a < 0)
                {
                    MessageBox.Show("لا يمكن ايجاد المضروب للاعداد السالبة !");
                    text_Result.Clear();
                    text_N1.Focus();
                }
                else
                {
                    long f = 2;
                    if (a == 0 || a == 1)
                        f = 1;
                    else
                    {
                        for (int i = 3; i <= a; i++)
                            f *= i;
                    }
                    text_Result.Text = f.ToString();
                }
            }
            else if (text_N1.Text == "" && text_N2.Text != "")
            {
                double a = Convert.ToDouble(text_N2.Text);
                if (a != Math.Truncate(a))
                {
                    MessageBox.Show("لا يمكن ايجاد المضروب لعدد عشري !");
                    text_Result.Clear();
                    text_N2.Focus();
                }
                else if (a < 0)
                {
                    MessageBox.Show("لا يمكن ايجاد المضروب للاعداد السالبة !");
                    text_Result.Clear();
                    text_N2.Focus();
                }
                else
                {
                    long f = 2;
                    if (a == 1 || a == 0)
                        f = 1;
                    else
                    {
                        for (int i = 3; i <= a; i++)
                            f *= i;
                    }
                    text_Result.Text = f.ToString();
                }
            }
            else if (text_N1.Text == "" && text_N2.Text == "")
            {
                MessageBox.Show("أدخل عدد في أحد الخانات !");
                text_Result.Clear();
                text_N1.Focus();
            }
        }

        private void but_N2_Click(object sender, EventArgs e)
        {
            if (text_N1.Text != "" && text_N2.Text != "")
            {
                MessageBox.Show("ضع الرقم في خانة واحدة فقط !");
                text_Result.Clear();
                text_N2.Clear();
                text_N1.Focus();
            }
            else if (text_N1.Text != "" && text_N2.Text == "")
            {
                double a = Convert.ToDouble(text_N1.Text);
                a = Math.Pow(a, 2);
                text_Result.Text = a.ToString();
            }
            else if (text_N1.Text == "" && text_N2.Text != "")
            {
                double a = Convert.ToDouble(text_N2.Text);
                a = Math.Pow(a, 2);
                text_Result.Text = a.ToString();
            }
            else if (text_N1.Text == "" && text_N2.Text == "")
            {
                MessageBox.Show("أدخل عدد في أحد الخانات !");
                text_Result.Clear();
                text_N1.Focus();
            }
        }

        private void but_N3_Click(object sender, EventArgs e)
        {
            if (text_N1.Text != "" && text_N2.Text != "")
            {
                MessageBox.Show("ضع الرقم في خانة واحدة فقط !");
                text_Result.Clear();
                text_N2.Clear();
                text_N1.Focus();
            }
            else if (text_N1.Text != "" && text_N2.Text == "")
            {
                double a = Convert.ToDouble(text_N1.Text);
                a = Math.Pow(a, 3);
                text_Result.Text = a.ToString();
            }
            else if (text_N1.Text == "" && text_N2.Text != "")
            {
                double a = Convert.ToDouble(text_N2.Text);
                a = Math.Pow(a, 3);
                text_Result.Text = a.ToString();
            }
            else if (text_N1.Text == "" && text_N2.Text == "")
            {
                MessageBox.Show("أدخل عدد في أحد الخانات !");
                text_Result.Clear();
                text_N1.Focus();
            }
        }

        private void but_Sqrt_Click(object sender, EventArgs e)
        {
            if (text_N1.Text != "" && text_N2.Text != "")
            {
                MessageBox.Show("ضع الرقم في خانة واحدة فقط !");
                text_Result.Clear();
                text_N2.Clear();
                text_N1.Focus();
            }
            else if (text_N1.Text != "" && text_N2.Text == "")
            {
                double a = Convert.ToDouble(text_N1.Text);
                if (a < 0)
                {
                    MessageBox.Show("لا يمكن ايجاد الجذور للاعداد السالبة !");
                    text_Result.Clear();
                    text_N1.Focus();
                }
                else
                {
                    a = Math.Sqrt(a);
                    text_Result.Text = a.ToString();
                }
            }
            else if (text_N1.Text == "" && text_N2.Text != "")
            {
                double a = Convert.ToDouble(text_N2.Text);
                if (a < 0)
                {
                    MessageBox.Show("لا يمكن ايجاد الجذور للاعداد السالبة !");
                    text_Result.Clear();
                    text_N2.Focus();
                }
                else
                {
                    a = Math.Sqrt(a);
                    text_Result.Text = a.ToString();
                }
            }
            else if (text_N1.Text == "" && text_N2.Text == "")
            {
                MessageBox.Show("أدخل عدد في أحد الخانات !");
                text_Result.Clear();
                text_N1.Focus();
            }
        }

        private void but_Max_Click(object sender, EventArgs e)
        {
            if (text_N1.Text == "" && text_N2.Text == "")
            {
                MessageBox.Show("أدخل الاعداد !");
                text_Result.Clear();
                text_N1.Focus();
            }
            else if (text_N1.Text != "" && text_N2.Text == "")
            {
                MessageBox.Show("أدخل العدد الثاني !");
                text_Result.Clear();
                text_N2.Focus();
            }
            else if (text_N1.Text == "" && text_N2.Text != "")
            {
                MessageBox.Show("أدخل العدد الاول !");
                text_Result.Clear();
                text_N1.Focus();
            }
            else
            {
                double a = Math.Max(Convert.ToDouble(text_N1.Text), Convert.ToDouble(text_N2.Text));
                text_Result.Text = a.ToString();
            }
        }

        private void but_Min_Click(object sender, EventArgs e)
        {
            if (text_N1.Text == "" && text_N2.Text == "")
            {
                MessageBox.Show("أدخل الاعداد !");
                text_Result.Clear();
                text_N1.Focus();
            }
            else if (text_N1.Text != "" && text_N2.Text == "")
            {
                MessageBox.Show("أدخل العدد الثاني !");
                text_Result.Clear();
                text_N2.Focus();
            }
            else if (text_N1.Text == "" && text_N2.Text != "")
            {
                MessageBox.Show("أدخل العدد الاول !");
                text_Result.Clear();
                text_N1.Focus();
            }
            else
            {
                double a = Math.Min(Convert.ToDouble(text_N1.Text), Convert.ToDouble(text_N2.Text));
                text_Result.Text = a.ToString();
            }
        }
    }
}

