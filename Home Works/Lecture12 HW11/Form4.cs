using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            pnlDraw.CreateGraphics().DrawLine(Pens.Red, new Point(125, 100), new Point(150, 150));
            pnlDraw.CreateGraphics().DrawLine(Pens.Red, new Point(150, 150), new Point(100, 150));
            pnlDraw.CreateGraphics().DrawLine(Pens.Red, new Point(100, 150), new Point(125, 100));
            //pnlDraw.CreateGraphics().DrawLine(Pens.Red, new Point(125, 100), new Point(125, 150));
            //pnlDraw.CreateGraphics().DrawLines(Pens.Red, new Point[] {new Point(100+50,100+50),new Point(300+50,100+50),
            //new Point(200+50,300+50),new Point(100+50,100+50)});
        }

        private void circalButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("أداة جديدة");
        }
    }
}
