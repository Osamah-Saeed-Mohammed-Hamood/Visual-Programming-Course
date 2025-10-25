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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoSortAllLst2_CheckedChanged(object sender, EventArgs e)
        {
            sortAnyListBox(listBox2);
        }

        void setEnabled()
        {
            btnMoveSelect.Enabled = listBox1.SelectedIndex > -1;
        }

        void revers(ListBox l)
        {
            if (l.Items.Count > 0)
            {
                for (int i = l.Items.Count - 1; i >= 0; i--)
                {
                    l.Items.Add(l.Items[i]);
                    l.Items.Remove(l.Items[i]);
                }
            }
            else
            {
                MessageBox.Show("القائمة فارغة");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            setEnabled();
            Height = groupBox1.Top + 40;
            Random r = new Random();
            for (int x=0;x<10;x++)
            {
                int n = r.Next(100);
                listBox1.Items.Add(n);
            }
        }

        private void btnAddNum_Click(object sender, EventArgs e)
        {
            if (isNumeric(txtAdd.Text.Trim()))
            {
                if (!repeated(listBox1,txtAdd.Text))
                {
                    listBox1.Items.Add(txtAdd.Text);
                    txtAdd.Clear();
                    txtAdd.Focus();
                }
                else
                {
                    MessageBox.Show("الرقم موجود مسبقا");
                    txtAdd.Clear();
                    txtAdd.Focus();
                }
            }
            else
            {
                MessageBox.Show("يجب ان يكون المدخل رقما");
                txtAdd.Clear();
                txtAdd.Focus();
            }
        }

        private void btnMoveSelect_Click(object sender, EventArgs e)
        {
            int c = listBox1.SelectedItems.Count;
            if (c > 0)
            {
                for (int i = 0; i < c; i++)
                {
                    if (!repeated(listBox2, listBox1.SelectedItems[0].ToString()))
                    {
                        listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    }
                }
            }
            else
                MessageBox.Show("القائمة فارغة");
        }

        private void btnMoveAll_Click(object sender, EventArgs e)
        {
            int c = listBox1.Items.Count;
            if (c > 0)
            {
                for (int i = 0; i < c; i++)
                {
                    if (!listBox2.Items.Contains(listBox1.Items[0]))
                    {
                        listBox2.Items.Add(listBox1.Items[0]);
                        listBox1.Items.Remove(listBox1.Items[0]);
                    }
                }
            }
            else
            {
                MessageBox.Show("القائمة فارغة");
            }
        }

        private void rdoSortAllLst1_CheckedChanged(object sender, EventArgs e)
        {
            sortAnyListBox(listBox1);
        }

        private void rodReverseLst1_CheckedChanged(object sender, EventArgs e)
        {
            revers(listBox1);
        }

        private void rdoEven_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            if(rdoEven.Checked)
            {
                for(int i=0; i <listBox1.Items.Count; i++)
                {
                    if(Convert.ToInt32(listBox1.Items[i])%2==0)
                    {
                        listBox1.SelectedIndex = i;
                    }
                }
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show("لا توجد عناصر زوجية");
            }
        }

        private void rdoOdd_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            if (rdoOdd.Checked)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2 != 0)
                    {
                        listBox1.SelectedIndex = i;
                    }
                }
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show("لا توجد عناصر فردية");
            }
        }

        private void rdoPrime_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            bool flag = true;
            if(rdoPrime.Checked)
            {
                for(int i=0;i<listBox1.Items.Count;i++)
                {
                    int n = Convert.ToInt32(listBox1.Items[i]);
                    flag = true;
                    for(int j=2;j<n;j++)
                    {
                        if (n%j == 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        listBox1.SelectedIndex = i;
                }
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show("لا توجد عناصر أولية");
            }
        }

        private void btnOpenAll_Click(object sender, EventArgs e)
        {
            if (btnOpenAll.Text== "▾")
            {
                Height = btnClose.Top + btnClose.Height + 50;
                btnOpenAll.Text = "^";
            }
            else
            {
                btnOpenAll.Text = "▾";
                Height = groupBox1.Top + 40;
            }
        }

        private void btnDeleteSelectElementLst1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("قم بتحديد العنصر");
                listBox1.Focus();
            }
        }

        private void sortAnyListBox(ListBox l)
        {
            int t;
            int c = l.Items.Count;
            if (c > 0)
            {
                for (int i = 0; i < c; i++)
                {
                    for (int j = i + 1; j < c; j++)
                    {
                        int n1 = Convert.ToInt32(l.Items[i]),
                            n2 = Convert.ToInt32(l.Items[j]);
                        if (n1 < n2)
                        {
                            t = n1;
                            l.Items[i] = n2;
                            l.Items[j] = t;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("القائمة فارغة");
            }
        }

        private void rdoMoveReverse_CheckedChanged(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    listBox2.Items.Add(listBox1.Items[listBox1.Items.Count - 1]);
                    listBox1.Items.Remove(listBox1.Items[listBox1.Items.Count - 1]);
                }
            }
            else
                MessageBox.Show("القائمة فارغة");
        }

        private void rodReverseLst2_CheckedChanged(object sender, EventArgs e)
        {
            revers(listBox2);
        }

        private void btnDoSelect_Click(object sender, EventArgs e)
        {
            //if (txtDoSelect.Text != "")
            //{
            //    listBox1.SelectedItems.Add(txtDoSelect.Text);
            //}
            //else
            //    MessageBox.Show("أدخل العنصر المراد تحديده");
            if (txtDoSelect.Text!="")
            {
                int index = listBox1.Items.IndexOf(txtDoSelect.Text);
                if (index != -1)  // إذا كان العنصر موجوداً
                {
                    listBox1.SetSelected(index, true);  // تحديد العنصر
                }
                else
                {
                    MessageBox.Show("العنصر غير موجود في القائمة.");
                }
            }
            else
            {
                MessageBox.Show("أدخل العنصر المراد تحديده.");
            }

        }

        private void btnRemoveSelect_Click(object sender, EventArgs e)
        {
            if (txtRemoveSelect.Text != "")
                listBox1.SelectedItems.Remove(txtRemoveSelect.Text);
            else
                MessageBox.Show("أدخل العنصر المراد الغاء تحديده");
        }


        private void btnNumSelectElements_Click(object sender, EventArgs e)
        {
            //txtNumSelectElements.Text = listBox1.SelectedItems.Count.ToString();
            int selectedCount = 0;
            foreach (var item in listBox1.SelectedItems)
            {
                selectedCount++;
            }
            txtNumSelectElements.Text = selectedCount.ToString();
        }

        private void btnNoneSelectElement_Click(object sender, EventArgs e)
        {
            txtNoneSelectElement.Text = (listBox1.Items.Count - listBox1.SelectedItems.Count).ToString();
        }

        private void rdoSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                for (int i =0; i<listBox1.Items.Count; i++)
                {
                    listBox1.SelectedIndex = i;
                }
            }
            else
            {
                MessageBox.Show("القائمة فارغة");
            }
        }

        private void rdoRemoveSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = -1;
            }
            else
                MessageBox.Show("القائمة فارغة");
        }

        private void btnDeleteAllLst1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void rdoSortSelectElement_CheckedChanged(object sender, EventArgs e)
        {
            int t;
            int c = listBox1.SelectedItems.Count;
            if (c > 0)
            {
                for (int i = listBox1.SelectedIndex; i < listBox1.SelectedIndex + c - 1; i++)
                {
                    for (int j = i + 1; j < listBox1.SelectedIndex + c; j++)
                    {
                        int n1 = Convert.ToInt32(listBox1.Items[i]),
                            n2 = Convert.ToInt32(listBox1.Items[j]);
                        if (n1 < n2)
                        {
                            t = n1;
                            listBox1.Items[i] = n2;
                            listBox1.Items[j] = t;
                        }
                    }
                    listBox1.SelectedIndex = i;
                }
            }
            else
            {
                MessageBox.Show("القائمة فارغة");
            }
        }

        private void btnDeleteSelectElementLst2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("قم بتحديد العنصر");
                listBox2.Focus();
            }
        }

        private void btnDeleteAllLst2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btnRemoveSelectByIndex_Click(object sender, EventArgs e)
        {
            if (txtRemoveSelectByIndex.Text != "")
            {
                int index = listBox1.Items.IndexOf(txtRemoveSelectByIndex.Text);
                if (index != -1)
                {
                    listBox1.SetSelected(index, false);
                }
            }
            else
            {
                MessageBox.Show("  قم بتحديد العنصر المراد الغاء تحديده");
            }

        }

        private void btnNumElements_Click(object sender, EventArgs e)
        {
            //txtNumElements.Text = listBox1.Items.Count.ToString();
            int itemCount = 0;
            foreach (var item in listBox1.Items)
            {
                itemCount++;
            }
            txtNumElements.Text = itemCount.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setEnabled();
        }

        bool isNumeric(string element)
        {
            if (element == "")
                return false;
            for (int i = 0;i<element.Length;i++)
            {
                if (element[i] < 48 || element[i] > 57)
                {
                    return false;
                }
            }
            return true;
        }
        bool repeated(ListBox l,string s)
        {
            for(int i=0;i<l.Items.Count;i++)
            {
                if(l.Items[i].ToString() == s)
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
