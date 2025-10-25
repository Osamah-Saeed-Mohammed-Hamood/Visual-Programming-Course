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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string getName()
        {
            return txtForm2.Text;
        }

        public void updateName(string name)
        {
            txtForm2.Text = name;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form3 form1 = new Form3();
            form1.Show();
        }

        private void btnShowDialogWithConstructor_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3("التعامل مع الواجهات المتعددة");
            f.ShowDialog();
            f.Show();
        }

        private void btnShowwithFunction_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.setValue(txtForm2.Text);
            f.Show();
        }

        private void btnShowwithModifier_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.txtForm3.Text = txtForm2.Text;
            f.Show();
        }

        private void btnShowwithStaticVariable_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            Form3.staticVariable = txtForm2.Text;
            f.Show();
        }

        private void btnShowWithOutealObject_Click(object sender, EventArgs e)
        {
            new Form3(txtForm2.Text).Show();
        }

        private void btnShowandSendListObject_Click(object sender, EventArgs e)
        {
            Form3 f= new Form3(lstText);
            f.Show();
        }

        private void btnShowandSendThisForm_Click(object sender, EventArgs e)
        {
            Form3 f=new Form3(this);
            f.Show();
        }

        Form3 formOnes = new Form3();
        private void btnShowOnce_Click(object sender, EventArgs e)
        {
            formOnes.Show();
        }

        Form3 formalOject;
        private void btnShowFormalObject_Click(object sender, EventArgs e)
        {
            if (formalOject==null||formalOject.IsDisposed)
            {
                formalOject = new Form3();
                formalOject.Show();
            }
            else
            {
                formalOject.Show();
               // formalOject.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lstText.Items.Add(txtForm2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }
    }
}
