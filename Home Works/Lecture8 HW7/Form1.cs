using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المشروع_السابع
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btnLengthAllText_Click(object sender, EventArgs e)
        {
            if (txtAll.Text.Trim() != "")
            {
                txtLengthAll.Text = txtAll.Text.Trim().Length.ToString();
            }
            else
            {
                MessageBox.Show("أدخل النص");
                txtLengthAll.Text = "";
            }
        }

        private void btnLengthSelectText_Click(object sender, EventArgs e)
        {
            if(txtAll.SelectedText.Length>0)
            {
                txtLengthSelectedText.Text = txtAll.SelectionLength.ToString();
            }
            else
            {
                MessageBox.Show("قم بتحديد النص");
                txtLengthSelectedText.Text = "";
            }
        }

        private void btnNumOfWords_Click(object sender, EventArgs e)
        {
            if (txtAll.Text.Trim() != "")
            {
                string[] strword=txtAll.Text.Trim().Split(' ');
                int x = 0;
                for (int i = 0; i < strword.Length; i++)
                {
                    if (strword[i] != "")
                        x++;
                }
                txtNumOfWords.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("أدخل النص");
                txtNumOfWords.Text = "";
            }
        }

        private void btnDeleteSelectText_Click(object sender, EventArgs e)
        {
            if(txtAll.SelectionLength > 0)
            {
                txtAll.SelectedText = "";
            }
            else
            {
                MessageBox.Show("قم بتحديد النص");
                txtAll.Focus();
            }
        }

        private void btnCancelSelect_Click(object sender, EventArgs e)
        {
            txtAll.SelectionLength = 0;
        }

        string mySelectedText = "";
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if(txtAll.SelectedText.Length>0)
            {
                mySelectedText = txtAll.SelectedText;
            }
            else
            {
                MessageBox.Show("لا يوجد نص محدد");
            }
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (txtAll.SelectedText.Length > 0)
            {
                mySelectedText = txtAll.SelectedText;
                txtAll.SelectedText = "";
            }
            else
            {
                MessageBox.Show("لا يوجد نص محدد");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtAll.Clear();
        }

        private void btnPast_Click(object sender, EventArgs e)
        {
            if (mySelectedText != "")
            {
                txtPast.Text += mySelectedText.Trim();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            txtAll.Undo();
            txtPast.Undo();
        }

        private void btnLengthAllTextWithoutSpace_Click(object sender, EventArgs e)
        {
            if (txtAll.Text.Length > 0)
            {
                int x = 0;
                for (int i = 0; i < txtAll.Text.Length; i++)
                {
                    if (txtAll.Text[i] != ' ')
                    {
                        x++;
                    }
                }
                MessageBox.Show(x.ToString());
            }
            else
            {
                MessageBox.Show("أدخل النص");
                txtAll.Focus();
            }
        }

        private void btnLengthSelectedTextWithoutSpace_Click(object sender, EventArgs e)
        {
            if(txtAll.SelectedText.Length>0)
            {
                int x = 0;
                for (int i = 0;i< txtAll.SelectedText.Length;i++)
                {
                    if(txtAll.SelectedText[i] != ' ')
                    {
                        x++;
                    }
                }
                MessageBox.Show(x.ToString());
            }
            else
            {
                MessageBox.Show("قم بتحديد النص");
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (txtAll.SelectionLength>0)
            {
                if(txtReplace.Text.Trim()!="")
                {
                    txtAll.SelectedText = txtReplace.Text;
                }
                else
                {
                    MessageBox.Show("أدخل النص الجديد");
                }
            }
            else
            {
                MessageBox.Show("حدد النص المراد تعديلة");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim()!="")
            {
                int index = txtAll.Text.IndexOf(txtSearch.Text, 0);
                if (index > -1)
                {
                    txtAll.SelectionStart = index;
                    txtAll.SelectionLength = txtSearch.Text.Length;
                    txtAll.Focus();
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
            else
            {
                MessageBox.Show("أدخل النص المراد البحث عنه");
                txtSearch.Focus();
            }
        }

        private void btnSearchForNext_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim()!="")
            {
                int index = txtAll.Text.IndexOf(txtSearch.Text, txtAll.SelectionStart + txtAll.SelectionLength);
                if(index > -1)
                {
                    txtAll.Focus();
                    txtAll.Select(index, txtSearch.Text.Length);
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
            else
            {
                MessageBox.Show("أدخل النص المراد البحث عنه");
                txtSearch.Focus();
            }
        }

        private void btnSearchForPrev_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "")
            {
                int index = txtAll.Text.LastIndexOf(txtSearch.Text, txtAll.SelectionStart - txtAll.SelectionLength);
                if (index > -1)
                {
                    txtAll.Focus();
                    txtAll.Select(index, txtSearch.Text.Length);
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
            else
            {
                MessageBox.Show("أدخل النص المراد البحث عنه");
                txtSearch.Focus();
            }
        }

        private void btnShowLetters_Click(object sender, EventArgs e)
        {
            lstLetters.Items.Clear();
            if (txtAll.SelectionLength > 0)
            {
                string s = txtAll.SelectedText;
                char[] ch = s.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    lstLetters.Items.Add(ch[i]);
                }
            }
            else
            {
                MessageBox.Show("قم بتحديد النص");
            }
        }

        private void btnShowWords_Click(object sender, EventArgs e)
        {
            lstWords.Items.Clear();
            if (txtAll.SelectionLength > 0)
            {
                string[] s = txtAll.SelectedText.Split(' ');
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != "")
                    {
                        lstWords.Items.Add(s[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("قم بتحديد النص");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void btnSearchForAll_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != "")
            {
                int startIndex = txtAll.Text.IndexOf(txtSearch.Text, 0); ;
                bool found = false;

                txtAll.SelectionLength = 0;

                while ((startIndex = txtAll.Text.IndexOf(txtSearch.Text, startIndex)) != -1)
                {
                    txtAll.SelectionStart = startIndex;
                    txtAll.SelectionLength = txtSearch.Text.Length;
                    startIndex += txtSearch.Text.Length; 
                    found = true;
                }

                if (!found)
                {
                    MessageBox.Show("Not Found");
                }
            }
            else
            {
                MessageBox.Show("أدخل النص المراد البحث عنه");
                txtSearch.Focus();
            }

        }
    }
}
