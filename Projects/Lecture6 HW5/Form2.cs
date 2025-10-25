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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@txtPath.Text.Trim());
            //string filename = txtPath.Text.Trim();
            //Bitmap bmp = new Bitmap(filename);
            //pictureBox1.Image = bmp;
            btnClear.Enabled = true;
            btnShow.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            btnClear.Enabled = false;
            btnShow.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            txtPath.Text = "";
            btnShow.Enabled = false;
            btnClear.Enabled = false;
          
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            btnShow.Enabled = true;
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 f=new Form3();
            f.ShowDialog();
        }
    }
}
