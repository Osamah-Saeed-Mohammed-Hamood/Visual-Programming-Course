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
    public partial class Form3 : Form
    {
        public Form3(int indexUser)
        {
            InitializeComponent();
            this.Text = " المستخدم : " + Form1.user[indexUser].GetUesrName();
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameOfPart.Text =="")
            {
                MessageBox.Show("أدخل اسم القسم الجديد");
                txtNameOfPart.Focus();
            }
            else
            {
                Form2.newDept= txtNameOfPart.Text.Trim();
                Form2.numberOfItemPart++;
                MessageBox.Show("تم إضافة القسم بنجاح");
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
