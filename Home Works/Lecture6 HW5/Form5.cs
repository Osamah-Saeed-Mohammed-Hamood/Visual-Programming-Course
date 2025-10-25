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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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
        int s = 0, m = 0, h = 0, d = 0;

        private void btnForm6_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.ShowDialog();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s > 9)
            {
                lblSecond.Text = s.ToString();
            }
            else
            {
                lblSecond.Text = "0" + s.ToString();
            }
            if (s > 59)
            {
                s = 0;
                m++;
               lblSecond.Text = "0" + s.ToString();

                if (m > 9)
                {
                    lblMinutes.Text = m.ToString();
                }
                else
                {
                    lblMinutes.Text = "0" + m.ToString();
                }
            }
            if (m>59)
            {
                m = 0;
                lblMinutes.Text = "0" + m.ToString();
                h++;
                if (h>9)
                {
                    lblHours.Text = h.ToString();
                }
                else
                {
                    lblHours.Text = "0" + h.ToString();
                }
            }
            if (h>23)
            {
                h = 0;
                lblHours.Text = "0" + h.ToString();
                d++;
                if (d>9)
                {
                    lblDays.Text = d.ToString();
                }
                else
                {
                    lblDays.Text = "0" + d.ToString();
                }
            }
        }
    }

}


