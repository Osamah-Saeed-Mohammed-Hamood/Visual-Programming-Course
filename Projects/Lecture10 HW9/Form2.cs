using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture10_HW9
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Form3 f3;
        Form4 f4;
        private void minuAddStudent_Click(object sender, EventArgs e)
        {
            if (f3 == null || f3.IsDisposed)
            {
                f3 = new Form3();
                f3.Show();
            }
            else
            {
                f3.Focus();
            }
        }

        private void mnueCloseAllFormsWithMainForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuShowStudents_Click(object sender, EventArgs e)
        {
            if (f4 == null || f4.IsDisposed)
            {
                f4 = new Form4();
                f4.Show();
            }
            else
            {
                f4.Focus();
            }
        }

        private void mnueClose_Click(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count;
            if (count > 1)
            {
                Application.OpenForms[count - 1].Close();
            }
        }

        private void mnueCloseAllForms_Click(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count;
            if (count > 1)
            {
                for (int i = count-1; i >= 1;i--)
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        public static string stname;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
