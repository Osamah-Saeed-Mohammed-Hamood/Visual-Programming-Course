using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture7_HW6
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Form1 f1 = new Form1("add", "Insert Item");
            //MessageBox.Show(f1.getbtmtext());
            //f1.design();
            //f1.visual();
            //f1.Show();
            //Form1 f2 = new Form1();
            //f2.set("إضافة", "أدخل العنصر");
            //f2.design();
            //f2.visual();
            //f2.Show();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
