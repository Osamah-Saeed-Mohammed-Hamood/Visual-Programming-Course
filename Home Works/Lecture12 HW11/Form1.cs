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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btnMainLine_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (x = 0; x < 100; x++)
            {
                bmp.SetPixel(x, x, Color.Black);
            }
            pictureBox1.Image = bmp;
        }

        private void btnSecondaryLine_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            for (x = 0; x < 100; x++)
            {
                bmp.SetPixel(pictureBox1.Width - 1 - x, x, Color.Black);
            }

            pictureBox1.Image = bmp;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            for (x = 80; x < 180; x++)
            {
                bmp.SetPixel(x, 180, Color.Black);
                bmp.SetPixel(180, x, Color.Black);
                bmp.SetPixel(x, 80, Color.Black);
                bmp.SetPixel(80, x, Color.Black);
            }
            pictureBox1.Image = bmp;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            for (x = 80; x < 300; x++)
            {
                bmp.SetPixel(x, 80, Color.Black);
                bmp.SetPixel(x, 200, Color.Black);

                if (x <= 200)
                {
                    bmp.SetPixel(80, x, Color.Black);
                    bmp.SetPixel(300, x, Color.Black);
                }
            }

            //for (x = 80; x < 200; x++)
            //{
            //    bmp.SetPixel(80, x, Color.Black);
            //    bmp.SetPixel(300, x, Color.Black);
            //}

            pictureBox1.Image = bmp;

        }

        private void btnQuad_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int y = 220;
            int z = 80;
            for (x = 80; x < 180; x++)
            {
                bmp.SetPixel(x, 180, Color.Black);
                bmp.SetPixel(180, x, Color.Black);
                bmp.SetPixel(x, 80, Color.Black);
                bmp.SetPixel(80, x, Color.Black);

                bmp.SetPixel(x - 40, 220, Color.Black);
                bmp.SetPixel(40, x + 40, Color.Black);
                bmp.SetPixel(x - 40, 120, Color.Black);
                bmp.SetPixel(140, x + 40, Color.Black);

                if (x > 140)
                {
                    z--;
                    y--;
                    bmp.SetPixel(x, y, Color.Black);
                    bmp.SetPixel(z, x + 40, Color.Black);

                    bmp.SetPixel(y - 40, x - 60, Color.Black);
                    bmp.SetPixel(x - 100, z + 40, Color.Black);
                }

            }
            pictureBox1.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            int y = 280;
            for (x = 80; x < 280; x++)
            {
                bmp.SetPixel(x, 280, Color.Black);
                if (x < 180)
                {
                    y--;
                    bmp.SetPixel(x + 1, y, Color.Black);
                    bmp.SetPixel(y, y, Color.Black);
                }

            }
            pictureBox1.Image = bmp;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (x = 80; x < 280; x++)
            {
                bmp.SetPixel(x, 180, Color.Black);
            }
            pictureBox1.Image = bmp;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            int y = 280;
            for (x = 80; x < 280; x++)
            {
                y--;
                bmp.SetPixel(x, 280, Color.Black);
                bmp.SetPixel(280, x, Color.Black);
                bmp.SetPixel(x + 1, y, Color.Black);
            }
            pictureBox1.Image = bmp;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int y = 280;
            for (x = 80; x < 280; x++)
            {
                bmp.SetPixel(x, x, Color.Black);
                bmp.SetPixel(x, y, Color.Black);
                y--;
            }
            pictureBox1.Image = bmp;
        }
    }
}
