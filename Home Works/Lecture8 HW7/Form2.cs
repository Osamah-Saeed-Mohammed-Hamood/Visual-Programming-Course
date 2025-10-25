using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المشروع_السابع
{
    public partial class Form2 : Form
    {
        Stack<Tuple<string, int>> history = new Stack<Tuple<string, int>>();
        string WordCopy = "";
        private const int MaxHistory = 10;

        private void SaveState(string text, int textBoxNumber)
        {
            if (history.Count >= MaxHistory)
            {
                history = new Stack<Tuple<string, int>>(history.Take(MaxHistory - 1).Reverse());
            }
            history.Push(new Tuple<string, int>(text, textBoxNumber));
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (history.Count == 0)
            {
                MessageBox.Show("لا توجد أي عملية للتراجع عنها");
                return;
            }

            var previousState = history.Pop();  // التراجع عن آخر عملية

            if (previousState.Item2 == 1)
                textBox1.Text = previousState.Item1;
            else if (previousState.Item2 == 2)
                textBox2.Text = previousState.Item1;
            else
                MessageBox.Show("خطأ: عملية غير معروفة");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
                WordCopy = textBox1.SelectedText;
            else
                MessageBox.Show("قم بتحديد النص");
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                SaveState(textBox1.Text, 1);
                WordCopy = textBox1.SelectedText;
                textBox1.SelectedText = "";  // إزالة النص المحدد
            }
            else
                MessageBox.Show("قم بتحديد النص");
        }

        private void btnPast_Click(object sender, EventArgs e)
        {
            if (WordCopy != "")
            {
                SaveState(textBox2.Text, 2);
                textBox2.Text += WordCopy;
            }
            else
                MessageBox.Show("حدد الكلمة المراد نسخها");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
