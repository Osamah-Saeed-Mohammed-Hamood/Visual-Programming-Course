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
    public partial class Form3 : Form
    {
        int[] a;
        int m = 0, i = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void txtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender == txtStudentAvg||sender==txtNumOfStudents)
            {
                if ((e.KeyChar <48||e.KeyChar >57)&&(e.KeyChar!=8))
                {
                    e.Handled = true;
                }
            }
            if (sender == txtStudentName)
            {
               //   النشاط
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

         }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if(txtStudentName.Text.Trim() !="" && txtStudentAvg.Text.Trim() !="")
            {
                if (i<m)
                {
                    lstInformation.Items.Add(txtStudentName.Text+"\t"+txtStudentAvg.Text);
                    a[i++]=int.Parse(txtStudentAvg.Text);
                    txtStudentAvg.Text = txtStudentName.Text = "";
                    txtStudentName.Focus();
                }
                else
                {
                    MessageBox.Show("تجاوزت حد المصفوفة");
                    txtStudentAvg.Clear();
                    txtStudentName.Clear();
                }
            }
            else
            {
                MessageBox.Show("خطأ في مربع النص");
            }
        }

        private void txtNumOfStudents_TextChanged(object sender, EventArgs e)
        {
            txtStudentAvg.Enabled = txtStudentName.Enabled = btnSort.Enabled = lstInformation.Enabled = btnAddToList.Enabled = true;
        }

        private void txtNumOfStudents_Leave(object sender, EventArgs e)
        {
            if(txtNumOfStudents.Text.Trim() !="")
            {
                m = int.Parse(txtNumOfStudents.Text.Trim());
                a = new int[m];
                i = 0;
            }
            lstInformation.Items.Clear();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int b = lstInformation.Items.Count, temp = a[0];
            string st = "";
            if (b>0)
            {
                for (int k =0; k < i; k++)
                {
                    for (int j=k+1; j < i; j++)
                    {
                        if (a[k]>a[j])
                        {
                            temp = a[k];
                            a[k] = a[j];
                            a[j] = temp;
                            st=lstInformation.Items[k].ToString();
                            lstInformation.Items[k]=lstInformation.Items[j].ToString();
                            lstInformation.Items[j]=st.ToString();
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("المصفوفة فارغة");
            }
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtStudentAvg.Enabled = txtStudentName.Enabled = btnSort.Enabled = lstInformation.Enabled = btnAddToList.Enabled = txtNumOfStudents.Text.Trim() != "";
            txtStudentAvg.KeyPress += txtStudentName_KeyPress;
            txtNumOfStudents.KeyPress += txtStudentName_KeyPress;
        }
    }
}
