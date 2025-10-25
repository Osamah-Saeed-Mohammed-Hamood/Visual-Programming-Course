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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int index;
        void select(object sender)
        {
                index = ((ListBox)sender).SelectedIndex;
                lstNum.SelectedIndex = index;
                lstName.SelectedIndex = index;
                lstAge.SelectedIndex = index;
                lstGender.SelectedIndex = index;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != "" && txtName.Text != "" && txtAge.Text != "" && (rdoMale.Checked || rdoFemale.Checked))
            {
                lstNum.Items.Add(txtNum.Text);
                lstName.Items.Add(txtName.Text);
                lstAge.Items.Add(txtAge.Text);
                if (rdoMale.Checked == true)
                {
                    lstGender.Items.Add(rdoMale.Text);
                }
                if (rdoFemale.Checked == true)
                {
                    lstGender.Items.Add(rdoFemale.Text);
                }
                txtNum.Text = txtName.Text = txtAge.Text = "";
                rdoMale.Checked = rdoFemale.Checked = false;
                btnDelete.Enabled = btnDeleteAll.Enabled = btnUpdate.Enabled = true;
            }
            else if (txtNum.Text == "")
            {
                MessageBox.Show("أدخل الرقم");
                txtNum.Focus();
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("أدخل الاسم");
                txtName.Focus();
            }
            else if (txtAge.Text == "")
            {
                MessageBox.Show("أدخل العمر");
                txtAge.Focus();
            }
            else if (rdoFemale.Checked == false || rdoMale.Checked == false)
                MessageBox.Show("حدد النوع");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstName.SelectedIndex != -1 || lstName.SelectedIndex != -1 || lstAge.SelectedIndex != -1 || lstGender.SelectedIndex != -1)
            {
                int n = lstName.SelectedIndex;
                lstNum.Items.Remove(lstNum.Items[n]);
                lstName.Items.Remove(lstName.Items[n]);
                lstAge.Items.Remove(lstAge.Items[n]);
                lstGender.Items.Remove(lstGender.Items[n]);
                if(lstNum.Items.Count < 0)
                    btnDelete.Enabled = btnDeleteAll.Enabled = btnUpdate.Enabled = false;
            }
            else
            {
                MessageBox.Show("لا يوجد عنصر محدد");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            lstNum.Items.Clear();
            lstName.Items.Clear();
            lstAge.Items.Clear();
            lstGender.Items.Clear();
            btnDelete.Enabled = btnDeleteAll.Enabled = btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstNum.SelectedIndex != -1)
            {
                if (btnUpdate.Text == "تعديل")
                {
                    txtNum.Text = lstNum.SelectedItem.ToString();
                    txtName.Text = lstName.SelectedItem.ToString();
                    txtAge.Text = lstAge.SelectedItem.ToString();
                    if (lstGender.SelectedItem.ToString() == "ذكر")
                        rdoMale.Checked = true;
                    else
                        rdoFemale.Checked = true;
                    btnUpdate.Text = "حفظ";
                    btnAdd.Enabled = btnDelete.Enabled = btnDeleteAll.Enabled = false;
                }
                else
                {
                    btnUpdate.Text = "تعديل";
                    lstNum.Items[index] = txtNum.Text;

                    lstName.Items[index] = txtName.Text;

                    lstAge.Items[index] = txtAge.Text;

                    if (rdoMale.Checked)
                    {
                        lstGender.Items[index] = rdoMale.Text;
                    }
                    else
                    {
                        lstGender.Items[index] = rdoFemale.Text;
                    }
                    btnAdd.Enabled = btnDelete.Enabled = btnDeleteAll.Enabled = true;
                    txtNum.Text = txtName.Text = txtAge.Text = "";
                    rdoMale.Checked = rdoFemale.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("لا يوجد عنصر محدد");
            }
        }

        private void lstNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            select(sender);
        }

        private void lstName_SelectedIndexChanged(object sender, EventArgs e)
        {
            select(sender);
        }

        private void lstAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            select(sender);
        }

        private void lstGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            select(sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            btnDelete.Enabled = btnDeleteAll.Enabled = btnUpdate.Enabled = false;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 122) ||
                 (e.KeyChar >= 1569 && e.KeyChar <= 1610) ||
                 e.KeyChar == 8 ||
                 e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
