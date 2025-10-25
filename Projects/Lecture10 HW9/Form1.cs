using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lecture10_HW9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combExtention.DropDownStyle = ComboBoxStyle.DropDownList;
            combExtention.Items.Add("*.png");
            combExtention.Items.Add("*.jpg");
            combExtention.Items.Add("*.jpeg");
            combExtention.Items.Add("*.txt");
        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dirListBox1.Path = driveListBox1.Drive;
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Path = dirListBox1.Path;
        }

        private void combExtention_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Pattern = combExtention.Text.Trim();
            pictureBox1.Image = null;
            richTextBox1.Text = "";
            lblPath.Text = lblNNameOfFile.Text = lblExtention.Text = "___";
        }

        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPath.Text = fileListBox1.Path+"\\"+fileListBox1.FileName;
            lblNNameOfFile.Text = Path.GetFileName(lblPath.Text);
            lblExtention.Text = Path.GetExtension(lblPath.Text);

            if (lblExtention.Text.Trim().ToLower() ==".txt")
            {
                richTextBox1.Text = File.ReadAllText(lblPath.Text);
                pictureBox1.Image = null;
            }
            else if (lblExtention.Text.Trim().ToLower() == ".png"|| lblExtention.Text.Trim().ToLower() == ".jpg"|| lblExtention.Text.Trim().ToLower() == ".jpeg")
            {
                pictureBox1.Image = Image.FromFile(lblPath.Text);
                richTextBox1.Text = "";
            }
        }
    }
}
