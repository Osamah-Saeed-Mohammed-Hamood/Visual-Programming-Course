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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static Student[] s = new Student[100];
        public static int count = 0;
        bool IsChoiceImage = false, IsWriteName = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "")
                IsWriteName = true;

            if (count<100)
            {
                if (IsChoiceImage&&IsWriteName)
                {
                    s[count] = new Student();
                    s[count].SetNumber(Convert.ToInt32(numericUpDown1.Value));
                    s[count].SetName(txtName.Text);
                    s[count].SetBirthDate(dateTimePicker1.Text);
                    s[count].SetImgPath(openFileDialog1.FileName);
                    count++;
                    IsChoiceImage = IsWriteName = false;
                    pictImage.Image = null;
                    numericUpDown1.Value = 0;
                    txtName.Text = "";
                    MessageBox.Show("تم إضافة الطالب بنجاح", "نجاح");
                }
                else
                {
                    if (IsChoiceImage)
                    {
                        MessageBox.Show("أدخل اسم الطالب");
                        txtName.Focus();
                    }
                    else if (IsWriteName)
                    {
                        MessageBox.Show("أدخل صورة الطالب");
                    }
                }
            }
            else
            {
                MessageBox.Show("الحد المسموح به مائة طالب فقط");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkPathImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "img(*.jpg)|*.jpg|(img*.bmp;*.png)|*.bmp;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictImage.Image = Image.FromFile(openFileDialog1.FileName);
                IsChoiceImage = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
