using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form3 : Form
    {
        TextBox[,] towDarrTextbox;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            txtColumn.KeyPress += numeric;
            txtRow.KeyPress += numeric;
            this.AutoSize = true;
            this.AutoScroll = true;
            pnlDrawTextBox.AutoScroll = true;
            pnlDrawTextBox.AutoSize = true;
        }
        private void numeric(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        int row = 0, column = 0;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtRow.Text.Trim()!="" && txtColumn.Text.Trim()!= "")
            {
                if(towDarrTextbox!=null)
                {
                    for (int i=0;i<row;i++)
                    {
                        for (int j=0;j<column;j++)
                        {
                            towDarrTextbox[i, j].Dispose();
                        }
                    }
                }
                row = Convert.ToInt32(txtRow.Text.Trim());
                column = Convert.ToInt32(txtColumn.Text.Trim());
                towDarrTextbox = new TextBox[row, column];

                for (int i=0;i<row;i++)
                {
                    for (int j=0;j<column;j++)
                    {
                        towDarrTextbox[i, j] = new TextBox();
                        towDarrTextbox[i, j].Size = new Size(30, 30);
                        towDarrTextbox[i, j].Multiline = true;
                        towDarrTextbox[i, j].Top = i * towDarrTextbox[i, j].Height;
                        towDarrTextbox[i, j].Left = j * towDarrTextbox[i, j].Width;
                        towDarrTextbox[i, j].KeyPress += oneOnly;
                        pnlDrawTextBox.Controls.Add(towDarrTextbox[i, j]);
                    }
                }
            }
            else if (txtRow.Text== "")
            {
                MessageBox.Show("الرجاء تحديد عدد الصفوف");
                txtRow.Focus();
            }
            else if (txtColumn.Text=="")
            {
                MessageBox.Show("الرجاء تحديد عدد الاعمدة");
                txtColumn.Focus();
            }
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void oneOnly (object sender,KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;

            if ((e.KeyChar == '1' && t.Text.Contains("1")) || (e.KeyChar != '1' && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
