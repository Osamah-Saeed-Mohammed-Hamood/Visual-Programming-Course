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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        int s = -1, m = 0, h = 12;
        bool b = true;

        private void btnForm7_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
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
                if (m > 59)
                {
                    m = 0;
                    h++; 

                    lblMinutes.Text = "0" + m.ToString();
                    if (h > 12)
                    {
                        h = 1; 
                    }

                    if (h > 9)
                    {
                        lblHours.Text = h.ToString();
                    }
                    else
                    {
                        lblHours.Text = "0" + h.ToString();
                    }

                    if (h == 12)
                    {
                        b = !b; 
                        lblAntePostMeridiem.Text = b ? "AM" : "PM";
                    }
                }    
            }
        }

   
        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
