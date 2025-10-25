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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(int indexUser)
        {
            InitializeComponent();
            this.Text = " المستخدم : " + Form1.user[indexUser].GetUesrName();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            for (int i=0;i<Form1.countOfUsers;i++)
            {
                lstUserName.Items.Add(Form1.user[i].GetUesrName());
                if (Form1.user[i].getIsSelected())
                {
                    lstUserName.SelectedIndex = i;
                }
            }
        }

        private void lstUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i =0; i<Form1.countOfUsers;i++)
            {
                if (lstUserName.SelectedIndex == i)
                    Form1.user[i].SetIsSelectedOrNot(true);
                else
                    Form1.user[i].SetIsSelectedOrNot(false);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
