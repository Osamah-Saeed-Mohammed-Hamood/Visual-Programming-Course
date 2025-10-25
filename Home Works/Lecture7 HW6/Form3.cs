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
    public partial class Form3 : Form
    {
        public static string staticVariable = "";

        public Form3()
        {
            InitializeComponent();

        }

        public Form3(string name)
        {
            InitializeComponent();
            this.Text = name;
        }

        Form2 objF2;

        public Form3(Form2 objectForm2)
        {
            InitializeComponent();
            txtForm3.Text = objectForm2.getName();
            txtForm3.Text = objectForm2.txtForm2.Text;
            objF2 = objectForm2;

        }

        public Form3(ListBox myList)
        {
            InitializeComponent();
           // lstText = myList;
           for(int i = 0;i <myList.Items.Count;i++)
            {
                lstText.Items.Add(myList.Items[i]);
            }

        }

        public void setValue(string name)
        {
            txtForm3.Text = name;
        }

        public string getValue()
        {
            return txtForm3.Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           // txtForm3.Text = staticVariable;
        }

        private void btnModifiy_Click(object sender, EventArgs e)
        {
            objF2.updateName(getValue());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstText.Items.Add(txtForm3.Text);
        }
    }
}
