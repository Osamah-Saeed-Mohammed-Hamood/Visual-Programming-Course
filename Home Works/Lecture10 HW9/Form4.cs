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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        void LoadStudentData()
        {
            for (int i=0;i<Form3.count;i++)
            {
                lstNumber.Items.Add(Form3.s[i].GetNumber().ToString());
                lstName.Items.Add(Form3.s[i].GetName().ToString());
                lstDate.Items.Add(Form3.s[i].GetBirthDate().ToString());
                pictImage.Image = Image.FromFile(Form3.s[i].GetImgPath());
            }
            //lstNumber.SelectedIndex = lstName.SelectedIndex = lstDate.SelectedIndex = 0;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstNumber.SelectedItem !=null)
            {
                lstNumber.Items.Remove(lstNumber.SelectedItem);
                lstName.Items.Remove(lstName.SelectedItem);
                lstDate.Items.Remove(lstDate.SelectedItem);
                for (int i=index;i<Form3.count;i++)
                {
                    Form3.s[i] = Form3.s[i + 1];
                }
                Form3.count--;
                if (Form3.count >= 1)
                {
                    pictImage.Image = Image.FromFile(Form3.s[0].GetImgPath());
                    lstNumber.SelectedIndex = lstName.SelectedIndex = lstDate.SelectedIndex = 0;
                }
                else
                    pictImage.Image = null;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            lstNumber.SelectedIndexChanged += findSelectedIndexList;
            lstName.SelectedIndexChanged += findSelectedIndexList;
            lstDate.SelectedIndexChanged += findSelectedIndexList;
        }

        public static int index = -1;

        void findSelectedIndexList(object sender,EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                index = lstNumber.SelectedIndex = lstName.SelectedIndex = lstDate.SelectedIndex = ((ListBox)sender).SelectedIndex;
                pictImage.Image = Image.FromFile(Form3.s[index].GetImgPath());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstNumber.SelectedItem != null)
            {
                Form5 f = new Form5();
                f.ShowDialog();
                lstNumber.Items[index] = Form3.s[index].GetNumber();
                lstName.Items[index] = Form3.s[index].GetName();
                lstDate.Items[index] = Form3.s[index].GetBirthDate();
                pictImage.Image = Image.FromFile(Form3.s[index].GetImgPath());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstNumber.Items.Clear();
            lstName.Items.Clear();
            lstDate.Items.Clear();
            LoadStudentData();
        }
    }
}
