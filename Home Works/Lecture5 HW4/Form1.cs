using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture5_HW4
{
    public partial class HW4 : Form
    {
        public HW4()
        {
            InitializeComponent();
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            int s = 0;
            bool f = false;
            txtResult.Text = null;
            if (chkOneHandred.Checked==true)
            {
                s+=Convert.ToInt32(chkOneHandred.Tag);
                f = true;
            }
            if (chkTwoHandred.Checked == true)
            {
                s += Convert.ToInt32(chkTwoHandred.Tag);
                f = true;
            }
            if (chkThreeHandred.Checked == true)
            {
                s += Convert.ToInt32(chkThreeHandred.Tag);
                f = true;
            }
            if (chkFourHandred.Checked == true)
            {
                s += Convert.ToInt32(chkFourHandred.Tag);
                f = true;
            }
            if (chkFiveHandred.Checked == true)
            {
                s += Convert.ToInt32(chkFiveHandred.Tag);
                f = true;
            }
            if (f)
                txtResult.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdoBackColorRed.Checked == true)
                lblWord.BackColor = Color.Red;
            else if (rdoBackColorYellow.Checked == true)
                lblWord.BackColor = Color.Yellow;
            else if (rdoBackColorGreen.Checked == true)
                lblWord.BackColor = Color.Green;
            else if (rdoBackColorBlack.Checked == true)
                lblWord.BackColor = Color.Black;

            if (rdoForeColorRed.Checked == true)
                lblWord.ForeColor = Color.Red;
            else if (rdoForeColorYellow.Checked == true)
                lblWord.ForeColor = Color.Yellow;
            else if (rdoForeColorGreen.Checked == true)
                lblWord.ForeColor = Color.Green;
            else if (rdoForeColorBlack.Checked == true)
                lblWord.ForeColor = Color.Black;
        }
        bool ClickEnableUnenable = true;
        bool ClickVisableUnvisable = true;
        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (ClickEnableUnenable)
            {
                pnlBackColor.Enabled = false;
                ClickEnableUnenable = false;
                btnEnable.Text = "Enable";
            }
            else
            {
                pnlBackColor.Enabled = true;
                ClickEnableUnenable = true;
                btnEnable.Text = "Unenable";
            }
        }

        private void btnUnEnable_Click(object sender, EventArgs e)
        {
            pnlBackColor.Enabled = false;
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (ClickVisableUnvisable)
            {
                pnlForeColor.Visible = false;
                ClickVisableUnvisable = false;
                btnVisible.Text = "Visible";
            }
            else
            {
                pnlForeColor.Visible = true;
                ClickVisableUnvisable = true;
                btnVisible.Text = "Unvisible";
            }
        }

        private void btnUnVisible_Click(object sender, EventArgs e)
        {
            pnlForeColor.Visible = false;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
