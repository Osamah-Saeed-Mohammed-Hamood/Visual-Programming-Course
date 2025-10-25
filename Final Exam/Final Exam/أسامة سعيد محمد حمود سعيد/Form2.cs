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
    public partial class Form2 : Form
    {
        private int indexUser;
        bool IsChoiceImage = false, IsWriteName = false;
        public static string[] AddnewDeptToCompo = new string[100];
        public static string newDept = "";
        public static int numberOfItemPart = 3;
        int index;
        public static bool IsUpdate = false;
        public Form2()
        {
            InitializeComponent();
            this.indexUser = Form1.index;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstName.SelectedIndex != -1)
            {
                if (Form1.user[indexUser].getIsSelected() != false)
                {
                    Form5 f = new Form5(indexUser, index);
                    f.ShowDialog();
                    lstName.Items[index]=Form1.user[indexUser].getStudentName(index).ToString();
                    lstPart.Items[index] = Form1.user[indexUser].getStudentPart(index).ToString();
                    lstLevel.Items[index] = Form1.user[indexUser].getStudentLevel(index).ToString();
                    pictureImageChoosen.Image = Image.FromFile(Form1.user[indexUser].getStudentImg(index));
                }
                else
                {
                    MessageBox.Show("لا توجد لديك صلاحية");
                }
            }
            else
            {
                MessageBox.Show("حدد الطالب المراد تعديلة", "تحذير");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.Text = " المستخدم : "+Form1.user[indexUser].GetUesrName();
            indexUser = Form1.index;
            lblUserName.Text = "مرحباً : "+Form1.user[indexUser].GetUesrName();
            //comboPart.SelectedIndex = 1;
            rdoLevel1.Checked = true;

            AddnewDeptToCompo[0] = "تقنية معلومات";
            AddnewDeptToCompo[1] = "كيمياء";
            AddnewDeptToCompo[2] = "رياضيات حاسوب";

            comboPart.Items.Add(AddnewDeptToCompo[0]);
            comboPart.Items.Add(AddnewDeptToCompo[1]);
            comboPart.Items.Add(AddnewDeptToCompo[2]);

            LoadStudentData();
            lstName.SelectedIndexChanged += findSelectedIndexList;
            lstPart.SelectedIndexChanged += findSelectedIndexList;
            lstLevel.SelectedIndexChanged += findSelectedIndexList;
        }
        void LoadStudentData()
        {
            for (int i = 0; i < Form1.user[indexUser].getCountOfStudent(); i++)
            {
                lstName.Items.Add(Form1.user[indexUser].getStudentName(i).ToString());
                lstPart.Items.Add(Form1.user[indexUser].getStudentPart(i).ToString());
                lstLevel.Items.Add(Form1.user[indexUser].getStudentLevel(i).ToString());
                pictureImageChoosen.Image = Image.FromFile(Form1.user[indexUser].getStudentImg(i));
            }
        }

        void findSelectedIndexList(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                index = lstLevel.SelectedIndex = lstName.SelectedIndex = lstPart.SelectedIndex = ((ListBox)sender).SelectedIndex;
                pictureImageChoosen.Image = Image.FromFile(Form1.user[indexUser].getStudentImg(index));
            }
        }
        private string ChooseLevel()
        {
            if (rdoLevel1.Checked)
                return "الأول";
            if (rdoLevel2.Checked)
                return "الثاني";
            if (rdoLevel3.Checked)
                return "الثالث";
            if (rdoLevel4.Checked)
                return "الرابع";
            else 
                return "";
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            lstName.SelectedIndex = lstPart.SelectedIndex = lstLevel.SelectedIndex = -1;
            pictureImageChoosen.Image = null;
            openFileDialog1.Filter = "img(*.jpg)|*.jpg|(img*.bmp;*.png)|*.bmp;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureImageChoosen.Image = Image.FromFile(openFileDialog1.FileName);
                IsChoiceImage = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void إضافةقسمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
            if (newDept != "")
            {
                for (int i = 0; i < numberOfItemPart; i++)
                {
                    if (AddnewDeptToCompo[i] == newDept)
                    {
                        numberOfItemPart--;
                        newDept = "";
                        return;
                    }
                }
                AddnewDeptToCompo[numberOfItemPart] = newDept;
                comboPart.Items.Add(newDept);
                newDept = "";
            }
        }

        private void comboPart_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void rdoLevel1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count;
            if (count > 1)
            {
                Application.OpenForms[count - 1].Close();
            }
        }

        private void إغلاقالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count;
            if (count > 1)
            {
                for (int i = count - 1; i >= 1; i--)
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Form4 f4;
        private void المستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void lstName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            lstName.SelectedIndex = lstPart.SelectedIndex = lstLevel.SelectedIndex = -1;
            pictureImageChoosen.Image = null;
        }

        private void comboPart_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            //if (newDept != "")
            //{
            //    for (int i = 0; i < numberOfItemPart; i++)
            //    {
            //        if (AddnewDeptToCompo[i] == newDept)
            //        {
            //            numberOfItemPart--;
            //            newDept = "";
            //            return;
            //        }
            //    }
            //    AddnewDeptToCompo[numberOfItemPart] = newDept;
            //    comboPart.Items.Add(newDept);
            //    newDept = "";
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Form1.user[indexUser].getCountOfStudent() < 100)
            {
                if (txtStudentName.Text.Trim() != "")
                    IsWriteName = true;

                if (IsChoiceImage && IsWriteName)
                {
                    Form1.user[indexUser].SetStudentInformation(txtStudentName.Text.Trim(), comboPart.Items.ToString(),
                         ChooseLevel(), openFileDialog1.FileName);
                    lstName.Items.Add(txtStudentName.Text.Trim());
                    lstPart.Items.Add(comboPart.SelectedItem.ToString());
                    lstLevel.Items.Add(ChooseLevel());
                    IsChoiceImage = IsWriteName = false;
                    pictureImageChoosen.Image = null;
                    txtStudentName.Text = "";
                    comboPart.SelectedIndex = 0;
                    rdoLevel1.Checked = true;

                    MessageBox.Show("تم إضافة الطالب بنجاح", "نجاح");
                  
                }
                else if (!IsWriteName)
                {
                    MessageBox.Show("أدخل اسم الطالب");
                    txtStudentName.Focus();
                }
                else
                {
                    MessageBox.Show("أدخل صورة الطالب");
                    openFileDialog1.Filter = "img(*.jpg)|*.jpg|(img*.bmp;*.png)|*.bmp;*.png";
                    openFileDialog1.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("الحد المسموح به مائة طالب فقط");
            }
        }
    }
}
