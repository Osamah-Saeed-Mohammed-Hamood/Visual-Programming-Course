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
    public partial class Form1 : Form
    {

        public static Users[] user = new Users[100];
        public static int countOfUsers = 0;
        public static int index = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.Width = grpSignIn.Width + 40;
            grpSignIn.Visible = true;
            grpCreateNewUser.Visible = false;
        }

        private void linkNewSign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNewUserName.Text = txtPasswordIsOK.Text = txtPasswordNewUser.Text = "";
            grpCreateNewUser.Visible = true;
            grpCreateNewUser.Location = grpSignIn.Location;
            grpSignIn.Visible = false;
        }

        private void linkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            comboUserName.SelectedIndex = -1;
            txtPassword.Text = "";
            grpCreateNewUser.Visible = false;
            grpSignIn.Visible = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (comboUserName.SelectedIndex != -1 && txtPassword.Text.Trim() != "")
            {
                for (int i = 0; i < countOfUsers; i++)
                {
                    if (comboUserName.Text.Trim() == user[i].GetUesrName())
                    {
                        index = i;
                        break;
                    }
                }
                if (txtPassword.Text.Trim() != user[index].GetPassword())
                {
                    MessageBox.Show("كلمة المرور غير صحيحة", "تحذير");
                    txtPassword.Focus();
                }
                else
                {
                    Form2 f = new Form2();
                    f.ShowDialog();
                }
            }
            else if (comboUserName.SelectedIndex == -1)
            {
                MessageBox.Show("أختر اسم المستخدم", "تحذير");
                comboUserName.Focus();
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("أدخل كلمة المرور", "تحذير");
                txtPassword.Focus();
            }
        }

        private void btnCreateNewPassword_Click(object sender, EventArgs e)
        {
            if (txtNewUserName.Text.Trim() !=""&&txtPasswordNewUser.Text.Trim()!=""&&txtPasswordIsOK.Text.Trim()!="")
            {
                if (txtPasswordNewUser.Text == txtPasswordIsOK.Text)
                {
                    user[countOfUsers] = new Users();
                    user[countOfUsers].SetUserName(txtNewUserName.Text.Trim());
                    user[countOfUsers].SetPassword(txtPasswordNewUser.Text.Trim());
                    MessageBox.Show("تم إنشاء الحساب بنجاح", "نجاح");
                    comboUserName.Items.Add(txtNewUserName.Text.Trim());
                    grpCreateNewUser.Visible = false;
                    grpSignIn.Visible = true;
                    countOfUsers++;
                }
                else
                {
                    MessageBox.Show("كلمة المرور غير مطابقة");
                    txtPasswordIsOK.Focus();
                }
            }
            else if (txtNewUserName.Text.Trim() == "")
            {
                MessageBox.Show("أدخل اسم المستخدم");
                txtNewUserName.Focus();
            }
            else if (txtPasswordNewUser.Text.Trim() == "")
            {
                MessageBox.Show("أدخل كلمة المرور ");
                txtPasswordNewUser.Focus();
            }
            else if (txtPasswordIsOK.Text.Trim() == "")
            {
                MessageBox.Show("يرجى تأكيد كلمة المرور  ");
                txtPasswordIsOK.Focus();
            }
        }
    }
}
