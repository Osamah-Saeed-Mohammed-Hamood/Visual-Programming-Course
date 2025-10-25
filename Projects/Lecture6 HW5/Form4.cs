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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Height, pictureBox1.Width);
            Bitmap bmp2 = new Bitmap(this.Width, this.Height);
            int x, y;
            //  رسم مربع 
            for (x=20;x<120;x++)
            {
                bmp.SetPixel(x, 70, Color.Red);
                bmp2.SetPixel(x, 70, Color.Red);
            }
            for (y = 70; y < 170; y++)
            {
                bmp.SetPixel(20, y, Color.Red);
                bmp2.SetPixel(20, y, Color.Red);
            }
            for (x = 20; x < 120; x++)
            {
                bmp.SetPixel(x, 170, Color.Red);
                bmp2.SetPixel(x, 170, Color.Red);
            }
            for (y = 70; y < 170; y++)
            {
                bmp.SetPixel(120, y, Color.Red);
                bmp2.SetPixel(120, y, Color.Red);
            }
            pictureBox1.Image = bmp;
            this.BackgroundImage = bmp2;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnForm5_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
        }
    }
}
