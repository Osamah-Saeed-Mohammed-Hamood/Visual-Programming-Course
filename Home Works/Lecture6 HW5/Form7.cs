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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("C#.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        int i = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            i++;
            if (i <= 9)
            {
                pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
                BackgroundImage = Image.FromFile(i.ToString() + ".png");
            }
            else
            { 
                i = 1;
                pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
                BackgroundImage = Image.FromFile(i.ToString() + ".png");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            i--;
            if (i <= 0)
            {
                i = 9;
                pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
                BackgroundImage = Image.FromFile(i.ToString() + ".png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
                BackgroundImage = Image.FromFile(i.ToString() + ".png");
            }
        }

        private void btnForm8_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.ShowDialog();
        }
    }
}
