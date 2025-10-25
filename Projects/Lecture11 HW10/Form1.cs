using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المشروع_العاشر
{
    public partial class Form1 : Form
    {
        Button b;
        Label l;
        TextBox t;
        ListBox lst;
        Button clear;
        Button b2;
        Panel p;
        Timer timer;
        Button GoToForm2;
        public Form1()
        {
            // InitializeComponent();

            b = new Button();
            l = new Label();
            t = new TextBox();
            lst = new ListBox();
            clear = new Button();
            b2 = new Button();
            p = new Panel();
            timer = new Timer();
            GoToForm2 = new Button();

            this.Width = 250;
            this.Height = 280;

            this.CenterToParent();

            b.Text = "Add";
            b.Click += bclick;
            l.Text = "Insert";
            l.Click += all;
            clear.Text = "Clear";
            clear.Click += clean;

            p.Width = 200;
            p.Height = 200;
            p.BackColor = Color.Gray;

            b2.Text = "Open File";
            b2.Click += openFile;
            timer.Tick += tick;
            timer.Interval = 1000;
            timer.Enabled = true;

            GoToForm2.Text = "Go To Form2   >>>";
            GoToForm2.BackColor = Color.LightGray;
            GoToForm2.Click += GoToForm2Click;

            design();
            visual();

            b.Click += all;
            timer.Tick += all;
        }

        void GoToForm2Click(object sender,EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        public void design()
        {
            b.Top = 30;
            b.Left = 12;
            lst.Top = 60;
            t.Top = 10;
            l.Left = 110;
            l.Top = 10;
            t.Left = lst.Left = 10;
            t.Width = 80;
            t.Height = 30;
            clear.Top = 170;
            p.Left = 10;
            p.Top = 10;
            b2.Top = 210;
            GoToForm2.Top = 210;
            GoToForm2.Left = 100;
            GoToForm2.Width += 50;
        }

        public void visual()
        {
            p.Controls.Add(b);
            p.Controls.Add(l);
            p.Controls.Add(t);
            p.Controls.Add(lst);
            p.Controls.Add(clear);
            this.Controls.Add(p);
            this.Controls.Add(b2);
            this.Controls.Add(GoToForm2);
        }

        public void bclick(object sender,EventArgs e)
        {
            lst.Items.Add(t.Text);
        }

        void clean(object sender,EventArgs e)
        {
            //List<string> students = new List<string>();
            //students.Add("Ali");
            //students.Add("Ahmed");
            //students.Add("Retal");
            //students.Add("Khalid");

            //students.Clear();
            //List<int> id = new List<int>();
            //id.Add(1);
            //id.Add(2);
            //id.Add(3);
            //id.Add(4);
            //id.Add(5);
            //id.Add(6);
            //id.Remove(1);
            //id.RemoveAt(1);
            //id.Clear();


            //  ====================  نشاط 1  ======================  //

            // سبب ان دالة ال Dispose  لا تحذف الاوات في بعض الاحيان

            //  1- لان الدالة تعمل على الكائنات الغير مدارة - اما الكائنات المدارة فتترك لل GC
            //  2-  الكائن ما زال مستخدما في مكان اخر
            //  3-  الدالة لا تحذف الكائنات من الذاكرة مباشرة وانما تقوم بتحرير الموارد فقط

            //  ========================================================= //


            //foreach (Control obj in Controls)
            //{
            //    obj.Dispose();
            //}

            //foreach (Control obj in Controls)
            //{
            //    if (obj is ListBox)
            //    {
            //        ((ListBox)obj).Items.Clear();
            //    }
            //    if (obj is Button)
            //    {
            //        obj.Left = 100;
            //    }
            //}

            //foreach (object obj in Controls)
            //{
            //    if (obj is ListBox)
            //    {
            //        ((ListBox)obj).Items.Clear();
            //    }
            //    if (obj is Button)
            //    {
            //        ((Button)obj).Left = 100;
            //    }
            //}

            //foreach (Button obj in Controls.OfType<Button>())
            //{
            //    obj.BackColor = Color.Red;
            //    obj.Left += 100;
            //}

            //foreach (TextBox obj in Controls.OfType<TextBox>())
            //{
            //    obj.Clear();
            //    obj.Left += 100;
            //}

            foreach (Control obj in this.Controls)
            {
                if (obj is Panel || obj is GroupBox)
                {
                    foreach (Control objchiled in obj.Controls)
                    {
                        if (objchiled is Button)
                        {
                            objchiled.Left += 100;
                        }
                        else if (objchiled is ListBox)
                            ((ListBox)objchiled).Items.Clear();
                       
                    }
                }
                if (obj is Button)
                {
                    obj.Left += 100;
                }
            }
        }

        void openFile(object sender,EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            op.Dispose();
        }

        void all(object sender,EventArgs e)
        {
            // =============== النشاط 2 =================//

            Control myb = null;

            if (sender is Control)
            {
                myb = (Control)sender;
            }

            if (sender is Label)
            {
                MessageBox.Show("You click on Label");
            }
            else if (sender is Button && myb != null)
            {
                if (myb.Text == "Add")
                {
                    lst.Items.Add(t.Text);
                }
                else if (myb == b2)
                {
                    OpenFileDialog op = new OpenFileDialog();
                    op.ShowDialog();
                    op.Dispose();
                }
                else if (myb == clear)
                {
                    lst.Items.Clear();
                }
            }
            else if (sender is Timer)
            {
                l.Text +=2 ;
            }

        }

        void all2(object sender,EventArgs e)
        {
            // all(nul,null);
            // all(sender,e);
            // all(sender,null);
        }

        int c = 0;
        void tick(object sender,EventArgs e)
        {
            l.Text += 1.ToString();
        }
    }
}
