using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المشروع_الثامن
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int index;
        void select(object sender)
        {
            index = ((ListBox)sender).SelectedIndex;
            lstNum1.SelectedIndex = index;
            lstNum2.SelectedIndex = index;
            lstResult.SelectedIndex = index;
            lstOperation.SelectedIndex = index;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            btnDelete.Enabled = btnDeleteAll.Enabled = btnUpdate.Enabled = false;
            cmbOperation.Items.Add("+");
            cmbOperation.Items.Add("-");
            cmbOperation.Items.Add("*");
            cmbOperation.Items.Add("/");
        }

        private void btnCalcAndAdd_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text != "" && txtNum2.Text != "" && cmbOperation.Text != "" )
            {
                int n1 = Convert.ToInt32(txtNum1.Text),
                    n2 = Convert.ToInt32(txtNum2.Text);

                if (cmbOperation.Text == "+")
                    txtResult.Text = (n1 + n2).ToString();
                else if (cmbOperation.Text == "-")
                    txtResult.Text = (n1 - n2).ToString();
                else if (cmbOperation.Text == "*")
                    txtResult.Text = (n1 * n2).ToString();
                else if (cmbOperation.Text == "/")
                    txtResult.Text = (n1 / n2).ToString();

                lstNum1.Items.Add(txtNum1.Text);
                lstOperation.Items.Add(cmbOperation.Text);
                lstNum2.Items.Add(txtNum2.Text);
                lstResult.Items.Add(txtResult.Text);

                btnDelete.Enabled = btnDeleteAll.Enabled = btnUpdate.Enabled = true;
            }
            else if (txtNum1.Text == "")
            {
                MessageBox.Show("أدخل الرقم الاول");
                txtNum1.Focus();
            }
            else if (txtNum2.Text == "")
            {
                MessageBox.Show("أدخل الرقم الثاني");
                txtNum2.Focus();
            }
            else if (cmbOperation.Text == "")
            {
                MessageBox.Show("حدد العملية ");
                cmbOperation.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstNum1.SelectedIndex != -1 || lstNum2.SelectedIndex != -1 || lstOperation.SelectedIndex != -1 || lstResult.SelectedIndex != -1)
            {
                int n = lstNum1.SelectedIndex;
                lstNum1.Items.Remove(lstNum1.Items[n]);
                lstNum2.Items.Remove(lstNum2.Items[n]);
                lstOperation.Items.Remove(lstOperation.Items[n]);
                lstResult.Items.Remove(lstResult.Items[n]);
                if (lstNum1.Items.Count < 0)
                    btnDelete.Enabled = btnDeleteAll.Enabled = btnUpdate.Enabled = false;
            }
            else
            {
                MessageBox.Show("لا يوجد عنصر محدد");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            lstNum1.Items.Clear();
            lstNum2.Items.Clear();
            lstOperation.Items.Clear();
            lstResult.Items.Clear();
            btnDelete.Enabled = btnDeleteAll.Enabled = btnUpdate.Enabled = false;
            txtNum1.Text = txtNum2.Text = txtResult.Text = "";
            cmbOperation.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstNum1.SelectedIndex != -1)
            {
                if (btnUpdate.Text == "تعديل")
                {
                    txtNum1.Text = lstNum1.SelectedItem.ToString();
                    txtNum2.Text = lstNum2.SelectedItem.ToString();
                    txtResult.Text = lstResult.SelectedItem.ToString();
                    cmbOperation.Text = lstOperation.SelectedItem.ToString();
                    btnUpdate.Text = "حفظ";
                    btnCalcAndAdd.Enabled = btnDelete.Enabled = btnDeleteAll.Enabled = false;
                }
                else
                {
                    if (txtNum1.Text != "" && txtNum2.Text != "" && cmbOperation.Text != "")
                    {
                        int n1 = Convert.ToInt32(txtNum1.Text),
                            n2 = Convert.ToInt32(txtNum2.Text);

                        if (cmbOperation.Text == "+")
                            txtResult.Text = (n1 + n2).ToString();
                        else if (cmbOperation.Text == "-")
                            txtResult.Text = (n1 - n2).ToString();
                        else if (cmbOperation.Text == "*")
                            txtResult.Text = (n1 * n2).ToString();
                        else if (cmbOperation.Text == "/")
                            txtResult.Text = (n1 / n2).ToString();

                        btnUpdate.Text = "تعديل";

                        lstNum1.Items[index] = txtNum1.Text;

                        lstNum2.Items[index] = txtNum2.Text;

                        lstResult.Items[index] = txtResult.Text;

                        lstOperation.Items[index] = cmbOperation.Text;

                        btnCalcAndAdd.Enabled = btnDelete.Enabled = btnDeleteAll.Enabled = true;
                    }
                    else if (txtNum1.Text == "")
                    {
                        MessageBox.Show("أدخل الرقم الاول");
                        txtNum1.Focus();
                    }
                    else if (txtNum2.Text == "")
                    {
                        MessageBox.Show("أدخل الرقم الثاني");
                        txtNum2.Focus();
                    }
                    else if (cmbOperation.Text == "")
                    {
                        MessageBox.Show("حدد العملية ");
                        cmbOperation.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("لا يوجد عنصر محدد");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstNum1_SelectedIndexChanged(object sender, EventArgs e)
        {
            select(sender);
        }

        private void lstOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            select(sender);
        }

        private void lstNum2_SelectedIndexChanged(object sender, EventArgs e)
        {
            select(sender);
        }

        private void lstResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            select(sender);
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }    
}