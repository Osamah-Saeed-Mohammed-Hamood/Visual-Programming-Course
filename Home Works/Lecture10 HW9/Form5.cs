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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int index;

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        void LoadStudentData()
        {
            index = Form4.index;
            numericUpDown1.Value = Convert.ToDecimal(Form3.s[index].GetNumber());
            txtName.Text = Form3.s[index].GetName();
            dateTimePicker1.Text = Form3.s[index].GetBirthDate();
            pictImage.Image = Image.FromFile(Form3.s[index].GetImgPath());
        }

        private bool isUpdateImage = false;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form3.s[index].SetName(txtName.Text);
            Form3.s[index].SetNumber(Convert.ToInt32(numericUpDown1.Value));
            Form3.s[index].SetBirthDate(dateTimePicker1.Text);
            if (isUpdateImage)
            {
                Form3.s[index].SetImgPath(openFileDialog1.FileName);
            }
            Close();
        }

        private void linkPathImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "img(*.jpg)|*.jpg|(img*.bmp;*.png)|*.bmp;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                isUpdateImage = true;
                pictImage.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
