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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       public void traingforsender(object sender,EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn == btnYellow)
                    button4.BackColor = Color.Yellow;
                else if (btn == btnGreen)
                {
                    button4.BackColor = Color.Green;
                }
                else if (btn == btnRed)
                {
                    button4.BackColor= Color.Red;
                }
            }
            else if (sender is Label lbl)
            {
                if (lbl.Text=="جهاز1")
                {
                    button4.Text = lblDevice1.Text;
                }
                else if (lbl.Text=="جهاز2")
                {
                    button4.Text=lblDevice2.Text;
                }
            }
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            traingforsender(sender,e);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            traingforsender(sender, e);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            traingforsender(sender, e);
        }

        private void lblDevice2_Click(object sender, EventArgs e)
        {
            traingforsender(sender, e);
        }

        private void lblDevice1_Click(object sender, EventArgs e)
        {
            traingforsender(sender, e);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 f=new Form3();
            f.ShowDialog();
        }
    }
}
