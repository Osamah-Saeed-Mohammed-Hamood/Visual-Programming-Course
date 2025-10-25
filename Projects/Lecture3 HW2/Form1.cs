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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click_1(object sender, EventArgs e)
        {
            double num1, num2, num3;
            string opr1 = txtOperation1.Text;
            string opr2 = txtOperation2.Text;
            string IntermediteResult = "";
            string finalResult = "";

            if (double.TryParse(txtNum1.Text, out num1) &&
                double.TryParse(txtNum2.Text, out num2) &&
               double.TryParse(txtNum3.Text, out num3))
            { 
                if ((txtOperation1.Text=="*"||txtOperation1.Text=="/"))
                {
                    IntermediteResult = PerformOperation(num1, num2, opr1).ToString();
                    if (IntermediteResult=="NaN")
                    {
                        MessageBox.Show("العملية الاولى غير صحيحة ");
                        txtOperation1.Focus();
                        return;
                    }
                    finalResult = PerformOperation(Convert.ToDouble(IntermediteResult), num3, opr2).ToString();
                    if (finalResult=="NaN")
                    {
                        MessageBox.Show("العملية الثانية غير صحيحة");
                        txtOperation2.Focus();
                        return;
                    }
                    txtResult.Text = finalResult.ToString();
                }
                else if((txtOperation2.Text == "*" || txtOperation2.Text == "/"))
                {
                    IntermediteResult = PerformOperation(num2, num3, opr2).ToString();
                    if (IntermediteResult=="NaN")
                    {
                        MessageBox.Show("العملية الثانية غير صحيحة ");
                        txtOperation2.Focus();
                        return;
                    }
                    finalResult = PerformOperation(Convert.ToDouble(IntermediteResult), num1, opr1).ToString();
                    if (finalResult=="NaN")
                    {
                        MessageBox.Show("العملية الأولى غير صحيحة");
                        txtOperation1.Focus();
                        return;
                    }
                    txtResult.Text = finalResult.ToString();
                }
                else
                {
                    IntermediteResult = PerformOperation(num1, num2, opr1).ToString();
                    if (IntermediteResult == "NaN")
                    {
                        MessageBox.Show("العملية الاولى غير صحيحة ");
                        txtOperation1.Focus();
                        return;
                    }
                    finalResult = PerformOperation(Convert.ToDouble(IntermediteResult), num3, opr2).ToString();
                    if (finalResult == "NaN")
                    {
                        MessageBox.Show("العملية الثانية غير صحيحة");
                        txtOperation2.Focus();
                        return;
                    }
                    txtResult.Text = finalResult.ToString();
                }
            }
            else
            {
                MessageBox.Show("يرجى ادخال أرقام صحيحة");
            }
        }
        private double PerformOperation(double num1,double num2,string op)
        {
            switch (op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num2 != 0 ? num1 / num2 : double.NaN;
                default:
                    return double.NaN;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
