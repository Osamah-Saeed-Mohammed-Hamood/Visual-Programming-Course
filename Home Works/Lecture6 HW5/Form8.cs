using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture6_HW5
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i<=9)
            {
                pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
            }
            else
            {
                i = 1;
                pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
