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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Height = 300;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.Red;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Image.FromFile(@"AbuObidah.jpg");
            pictureBox1.BackgroundImage = Image.FromFile(@"Img.jpg");
            toolTip1.SetToolTip(pictureBox1, "PictureBox Tool");
            this.AutoSize = true;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
