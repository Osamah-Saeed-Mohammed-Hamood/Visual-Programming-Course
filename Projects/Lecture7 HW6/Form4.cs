using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture7_HW6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Form5 operationadd;
        Form5 operationsub;
        Form5 operationMult;
        Form5 operationDiv;
        private void btnSum_Click(object sender, EventArgs e)
        {
            if (operationadd == null|| operationadd.IsDisposed)
            {
                operationadd = new Form5("جمع","عملية الجمع");
                operationadd.ShowDialog();
            }
            else
            {
                operationadd.ShowDialog();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (operationsub == null|| operationsub.IsDisposed)
            {
                operationsub = new Form5("طرح","عملية الطرح");
                operationsub.ShowDialog();
            }
            else
            {
                operationsub.ShowDialog();
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (operationMult == null || operationMult.IsDisposed)
            {
                operationMult = new Form5("ضرب","عملية الضرب");
                operationMult.ShowDialog();
            }
            else
            {
                operationMult.ShowDialog();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (operationDiv == null || operationDiv.IsDisposed)
            {
                operationDiv = new Form5("قسمة","عملية القسمة");
                operationDiv.ShowDialog();
            }
            else
            {
                operationDiv.ShowDialog();
            }
        }

        private void menuSum_Click(object sender, EventArgs e)
        {
            if (operationadd == null || operationadd.IsDisposed)
            {
                operationadd = new Form5("جمع","عملية الجمع");
                operationadd.ShowDialog();
            }
            else
            {
                operationadd.ShowDialog();
            }
        }

        private void mnueSub_Click(object sender, EventArgs e)
        {
            if (operationsub == null || operationsub.IsDisposed)
            {
                operationsub = new Form5("طرح","عملية الطرح");
                operationsub.ShowDialog();
            }
            else
            {
                operationsub.ShowDialog();
            }
        }

        private void mnueMult_Click(object sender, EventArgs e)
        {
            if (operationMult == null || operationMult.IsDisposed)
            {
                operationMult = new Form5("ضرب","عملية الضرب");
                operationMult.ShowDialog();
            }
            else
            {
                operationMult.ShowDialog();
            }
        }

        private void mnueDiv_Click(object sender, EventArgs e)
        {
            if (operationDiv == null || operationDiv.IsDisposed)
            {
                operationDiv = new Form5("قسمة","عملية القسمة");
                operationDiv.ShowDialog();
            }
            else
            {
                operationDiv.ShowDialog();
            }
        }
    }
}
