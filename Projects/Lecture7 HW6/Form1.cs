using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture7_HW6
{
    public partial class Form1 : Form
    {
        Button b;
        Label l;
        TextBox t;
        ListBox lst;

        public Form1()
        {
            InitializeComponent();
            b = new Button();
            l = new Label();
            lst = new ListBox();
            t = new TextBox();
            b.Click += bClick;
        }

        public Form1(string btntext,string lbltext)
        {
            InitializeComponent();
            b = new Button();
            l = new Label();
            lst = new ListBox();
            t = new TextBox();
            b.Click += bClick;
            b.Text = btntext;
            l.Text = lbltext;
        }

        public void set(string btntext, string lbltext)
        {
            b.Text = btntext;
            l.Text = lbltext;
        }


        private void bClick(object sender, EventArgs e)
        {
            lst.Items.Add(t.Text);
        }

        public void design ()
        {
            b.Top = 30;
            b.Left = 25;
            lst.Top = 60;
            t.Top = 10;
            l.Left = 110;
            l.Top = 10;
            t.Left = lst.Left = 10;
        }

        public void visual ()
        {
            this.Controls.Add(b);
            this.Controls.Add(l);
            this.Controls.Add(t);
            this.Controls.Add(lst);
        }

        public string getbtmtext()
        {
            return b.Text;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
