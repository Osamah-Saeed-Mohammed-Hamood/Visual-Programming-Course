using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace أسامة_سعيد_محمد_حمود_سعيد
{
    public partial class Form5 : Form
    {
        int userIndex,studentIndex;
        bool isUpdateImg = false;
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(int userIndex,int studentIndex)
        {
            InitializeComponent();
            this.userIndex = userIndex;
            this.studentIndex = studentIndex;
    
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            comboPart.Items.Clear();
            for (int i = 0; i < Form2.numberOfItemPart; i++)
            {
                comboPart.Items.Add(Form2.AddnewDeptToCompo[i]);
            }

            this.Text = " المستخدم : " + Form1.user[userIndex].GetUesrName();

            LoadStudentData();
        }


        Student s = new Student();
        void LoadStudentData()
        {
            s = Form1.user[userIndex].GetStudentInformation(studentIndex);
            txtStudentName.Text = s.GetName();
            comboPart.Text = s.GetPart();
            if (s.GetLevel() == "الأول")
                rdoLevel1.Checked = true;
            if (s.GetLevel() == "الثاني")
                rdoLevel2.Checked = true;
            if (s.GetLevel() == "الثالث")
                rdoLevel3.Checked = true;
            if (s.GetLevel() == "الرابع")
                rdoLevel4.Checked = true;

            pictureImageChoosen.Image = Image.FromFile(s.GetImgPath());
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string level ="";
            string img = openFileDialog1.FileName;
            if (rdoLevel1.Checked)
                level = "الأول";
            if (rdoLevel2.Checked)
                level = "الثاني";
            if (rdoLevel3.Checked)
                level = "الثالث";
            if (rdoLevel4.Checked)
                level = "الرابع";

            if (isUpdateImg)
            {
                Form1.user[userIndex].SetStudentInformation(txtStudentName.Text.Trim(), comboPart.SelectedItem.ToString(), level, img);
            }
            else
            {
                Form1.user[userIndex].SetStudentInformation(txtStudentName.Text.Trim(), comboPart.SelectedItem.ToString(), level, Form1.user[userIndex].getStudentImg(studentIndex));
            }
                Close();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "img(*.jpg)|*.jpg|(img*.bmp;*.png)|*.bmp;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                isUpdateImg = true;
                pictureImageChoosen.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
