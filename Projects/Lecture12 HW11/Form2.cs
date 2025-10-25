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
    public partial class Form2 : Form
    {
        TextBox[] oneDarrTextbox;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtLength.KeyPress += numeric;

            this.AutoSize = true;
            this.AutoScroll = true;
            this.CenterToParent();
        }

        private void numeric(object sender,KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        void normal()
        {
            if (txtLength.Text.Trim() != "")
            {
                if (oneDarrTextbox != null)
                {
                    for (int i = 0; i < oneDarrTextbox.Length; i++)
                    {
                        oneDarrTextbox[i].Dispose();
                    }
                }

                oneDarrTextbox = new TextBox[Convert.ToInt32(txtLength.Text)];
                for (int i = 0; i < oneDarrTextbox.Length; i++)
                {
                    oneDarrTextbox[i] = new TextBox();
                    oneDarrTextbox[i].Size = new Size(60, 20);
                    if (rdoVertical.Checked)
                    {
                        oneDarrTextbox[i].Top = i * oneDarrTextbox[i].Height;
                        oneDarrTextbox[i].Left = 10;
                    }
                    else if (rdoHorizental.Checked)
                    {
                        oneDarrTextbox[i].Left = i * oneDarrTextbox[i].Width;
                        oneDarrTextbox[i].Top = 10;
                    }
                    Controls.Add(oneDarrTextbox[i]);
                }
            }
            else
            {
                MessageBox.Show("الرجاء تحديد الطول");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            normal();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
