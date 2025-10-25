using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture5_HW4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnPlayer.Size = new Size(btnPlayer.Width, btnPlayer.Height - 5);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = this.Width + 100;
            this.Height = this.Height + 100;
            btnPlayer.Top = btnPlayer.Left = 20;
        }
        private void move(object sender)
        {
            if (sender == btnUp)
            {
                btnUp.Top -= 5;
                btnBigHight.Top -= 5;
                btnBigWeight.Top -= 5;
                btnDown.Top -= 5;
                btnLeft.Top -= 5;
                btnRight.Top -= 5;
                btnSmallHight.Top -= 5;
                btnSmallWeight.Top -= 5;
            }
            else if (sender == btnDown)
            {
                btnUp.Top += 5;
                btnBigHight.Top += 5;
                btnBigWeight.Top += 5;
                btnDown.Top += 5;
                btnLeft.Top += 5;
                btnRight.Top += 5;
                btnSmallHight.Top += 5;
                btnSmallWeight.Top += 5;
            }
            else if (sender == btnLeft)
            {
                btnUp.Left -= 5;
                btnBigHight.Left -= 5;
                btnBigWeight.Left -= 5;
                btnDown.Left -= 5;
                btnLeft.Left -= 5;
                btnRight.Left -= 5;
                btnSmallHight.Left -= 5;
                btnSmallWeight.Left -= 5;
            }
            else if (sender == btnRight)
            {
                btnUp.Left += 5;
                btnBigHight.Left += 5;
                btnBigWeight.Left += 5;
                btnDown.Left += 5;
                btnLeft.Left += 5;
                btnRight.Left += 5;
                btnSmallHight.Left += 5;
                btnSmallWeight.Left += 5;
            }
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            //btnPlayer.Top -= 5;
            move(sender);

        }

        private void btnBigHight_Click(object sender, EventArgs e)
        {
            btnPlayer.Size = new Size(btnPlayer.Width, btnPlayer.Height + 5);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //btnPlayer.Location = new Point(btnPlayer.Left, btnPlayer.Top + 5);
            move(sender);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            //btnPlayer.Location = new Point(btnPlayer.Left + 5, btnPlayer.Top);
            move(sender);
        }

        private void btnBigWeight_Click(object sender, EventArgs e)
        {
            btnPlayer.Width += 5;
        }

        private void btnSmallWeight_Click(object sender, EventArgs e)
        {
            btnPlayer.Width -= 5;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            // btnPlayer.Location = new Point(btnPlayer.Left - 5, btnPlayer.Top);
            move(sender);
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
