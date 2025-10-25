using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            btnPlayer.Top -= 5;
        }

        private void btnSumUp_Click(object sender, EventArgs e)
        {
            btnPlayer.Size = new Size(btnPlayer.Width, btnPlayer.Height + 5);
        }

        private void btnMinDown_Click(object sender, EventArgs e)
        {
            btnPlayer.Size = new Size(btnPlayer.Width, btnPlayer.Height - 5);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            btnPlayer.Location = new Point(btnPlayer.Left, btnPlayer.Top + 5);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            btnPlayer.Location = new Point(btnPlayer.Left + 5, btnPlayer.Top);
        }

        private void btnSumRight_Click(object sender, EventArgs e)
        {
            btnPlayer.Width += 5;
        }

        private void btnMinLeft_Click(object sender, EventArgs e)
        {
            btnPlayer.Width -= 5;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            btnPlayer.Location = new Point(btnPlayer.Left - 5, btnPlayer.Top);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (rdoUp.Checked)
            {
                for (int i = 0; i < Top; i++)
                {
                    if (chkFive.Checked)
                    {
                        btnPlayer.Top -= Convert.ToInt16(chkFive.Text);
                    }
                    else if (chkTen.Checked)
                    {
                        btnPlayer.Top -= Convert.ToInt32(chkTen.Text);
                    }
                    else if (chkFifteen.Checked)
                    {
                        btnPlayer.Top -= Convert.ToInt32(chkFifteen.Text);
                    }
                    else if (chkTwenty.Checked)
                    {
                        btnPlayer.Top -= Convert.ToInt32(chkTwenty.Text);
                    }

                    if (btnPlayer.Top <= 0)
                    {
                        btnPlayer.Top = 0; 
                        break; 
                    }
                    for (int j = 0; j < 100000000; j++) ;
                }
            }
        
            else if (rdoDown.Checked)
            {
                for (int i = 0; i < Top; i++)
                {
                    if (chkFive.Checked)
                    {
                        btnPlayer.Top += Convert.ToInt16(chkFive.Text);
                    }
                    else if (chkTen.Checked)
                    {
                        btnPlayer.Top += Convert.ToInt32(chkTen.Text);
                    }
                    else if (chkFifteen.Checked)
                    {
                        btnPlayer.Top += Convert.ToInt32(chkFifteen.Text);
                    }
                    else if (chkTwenty.Checked)
                    {
                        btnPlayer.Top += Convert.ToInt32(chkTwenty.Text);
                    }
                    for (int j = 0; j < 100000000; j++) ;
                }
            }
        }
    }
}
