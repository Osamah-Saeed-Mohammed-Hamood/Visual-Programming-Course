using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture5_HW4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            pnlOperations.Visible = false;
            pnlOperations.Location = new Point(1, 60);
            this.Height = btnDiv.Height + 60;
            this.Width = btnSum.Left + btnDiv.Right + 20;
            txtNum1.KeyPress += txtNum2_KeyPress;
        }
        void changePanel(object sender)
        {
            if (sender == btnSum)
            {
                pnlOperations.Visible = true;
                this.Height = pnlOperations.Height * 2;
                pnlOperations.BackColor = btnSum.BackColor;
                lblOperation.Text = "+";
            }
            else if (sender == btnSub)
            {
                pnlOperations.Visible = true;
                this.Height = pnlOperations.Height * 2;
                pnlOperations.BackColor = btnSub.BackColor;
                lblOperation.Text = "-";
            }
            else if (sender == btnMult)
            {
                pnlOperations.Visible = true;
                this.Height = pnlOperations.Height * 2;
                pnlOperations.BackColor = btnMult.BackColor;
                lblOperation.Text = "*";
            }
            else if (sender == btnDiv)
            {
                pnlOperations.Visible = true;
                this.Height = pnlOperations.Height * 2;
                pnlOperations.BackColor = btnDiv.BackColor;
                lblOperation.Text = "/";
            }
            txtNum1.Focus();
        }
        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum2.Text = txtResult.Text = "";
            changePanel(sender);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum2.Text = txtResult.Text = "";
            changePanel(sender);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum2.Text = txtResult.Text = "";
            changePanel(sender);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum2.Text = txtResult.Text = "";
            changePanel(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum2.Text = txtResult.Text = "";
            Form4_Load(null, null);
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0'||e.KeyChar > '9')&&(e.KeyChar != 8))
                e.Handled = true;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if ((txtNum1.Text != "") && (txtNum2.Text != ""))
            {
                if (lblOperation.Text=="+")
                {
                    txtResult.Text = Convert.ToString(Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text));
                }
                else if (lblOperation.Text == "-")
                {
                    txtResult.Text = Convert.ToString(Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text));
                }
                else if (lblOperation.Text == "*")
                {
                    txtResult.Text = Convert.ToString(Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtNum2.Text));
                }
                else if (lblOperation.Text == "/")
                {
                    if (Convert.ToInt32(txtNum2.Text) != 0)
                    {
                        txtResult.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtNum2.Text));
                    }
                    else
                    {
                        MessageBox.Show("لا يمكن القسمة على صفر");
                        txtNum2.Text = "";
                        txtNum2.Focus();
                    }
                }
            }
            else
            {
                if (txtNum1.Text==""&& txtNum2.Text=="") 
                {
                    MessageBox.Show("لا توجد أعداد");
                    txtNum1.Focus();
                }
                else if(txtNum1.Text == "")
                {
                    MessageBox.Show("أدخل العدد الأول");
                    txtNum1.Focus();
                }
                else if (txtNum2.Text == "")
                {
                    MessageBox.Show("أدخل العدد الثاني");
                    txtNum2.Focus();
                }
            }
        }
    }
}
