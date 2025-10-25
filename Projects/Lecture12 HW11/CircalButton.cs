using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;

namespace Draw
{
    public class CircalButton : Button
    {
        public CircalButton()
        {
            this.Text = "A";
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.DrawEllipse(new Pen(Color.Black, 2), 0, 0, Width - 1, Height - 1);
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, Width - 1, Height - 1);
            Region = new Region(g);
        }
    }
}
