using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lecture5_HW4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Thread threadgoHorizontal;
        Thread threadgoVertical;
        bool MoveRight = true;
        bool MoveDown = true;
        bool IsRunning = true;

        void goHorizantal()
        {
            while (IsRunning)
            {
                Invoke((Action)(() =>
                {
                    if (MoveRight)
                    {
                        btnGoFrontBehined.Left += 10;
                        if (btnGoFrontBehined.Left >= this.Width - btnGoFrontBehined.Width - 50)
                        {
                            MoveRight = false;
                        }
                    }
                    else
                    {
                        btnGoFrontBehined.Left -= 10;
                        if (btnGoFrontBehined.Left <= 0)
                        {
                            MoveRight = true;
                        }
                    }
                }));
                Thread.Sleep(100);
            }
        }
        void goVertical()
        {
            while (IsRunning)
            {
                Invoke((Action)(() =>
                {
                    if (MoveDown)
                    {
                        btnGoTopBottom.Top += 10;
                        if (btnGoTopBottom.Top >= this.Height - btnGoTopBottom.Height - 70)
                        {
                            MoveDown = false;
                        }
                    }
                    else
                    {
                        btnGoTopBottom.Top -= 10;
                        if (btnGoTopBottom.Top <= 0)
                        {
                            MoveDown = true;
                        }
                    }
                }));
                Thread.Sleep(100);
            }
        }
        private void btnMoveFront_Click(object sender, EventArgs e)
        {
            IsRunning = true;
            threadgoHorizontal = new Thread(goHorizantal);
            threadgoHorizontal.Start();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            IsRunning = true;
            threadgoVertical = new Thread(goVertical);
            threadgoVertical.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            IsRunning = false;
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }
    }
}
