using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المشروع_العاشر
{
    public partial class Form2 : Form
    {
        Button btnTimeAndDate;
        Button btnDateOnly;
        Button btnTimeOnly;
        Button btnDate;
        Button btnTime;
        Button btnClose;

        TextBox txtTimeAndDate;
        TextBox txtDateOnly;
        TextBox txtTimeOnly;
        TextBox txtDay;
        TextBox txtMonth;
        TextBox txtYear;
        TextBox txtHour;
        TextBox txtMinute;
        TextBox txtSecond;

        Label lblDay;
        Label lblMonth;
        Label lblYear;
        Label lblHour;
        Label lblMinute;
        Label lblSecond;

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("اتنفذ");
        }
        public Form2()
        {
            //InitializeComponent();
            btnTimeAndDate = new Button();
            btnDateOnly = new Button();
            btnTimeOnly = new Button();
            btnDate = new Button();
            btnTime = new Button();
            btnClose = new Button();

            txtTimeAndDate = new TextBox();
            txtDateOnly = new TextBox();
            txtTimeOnly = new TextBox();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            txtYear = new TextBox();
            txtHour = new TextBox();
            txtMinute = new TextBox();
            txtSecond = new TextBox();

            lblDay = new Label();
            lblMonth = new Label();
            lblYear = new Label();
            lblHour = new Label();
            lblMinute = new Label();
            lblSecond = new Label();

            this.Width = 490;
            this.Height = 350;
            this.Text = "Date and Time";

            btnTimeAndDate.Width = btnDateOnly.Width = btnTimeOnly.Width = btnDate.Width = btnTime.Width =
                txtTimeAndDate.Width = txtDateOnly.Width = txtTimeOnly.Width = 200;

            btnClose.Width = 70;
            btnClose.BackColor = Color.Red;

            txtDay.Width = txtMonth.Width = txtYear.Width = txtHour.Width = txtMinute.Width = txtSecond.Width = 50;

            btnTimeAndDate.Height = btnDateOnly.Height = btnTimeOnly.Height = btnDate.Height = btnTime.Height = btnClose.Height =
                txtTimeAndDate.Height = txtDateOnly.Height = txtTimeOnly.Height = txtDay.Height = txtMonth.Height
                = txtYear.Height = txtHour.Height = txtMinute.Height = txtSecond.Height = 30;

            btnTimeAndDate.Text = "الوقت والتاريخ";
            btnDateOnly.Text = " التاريخ فقط";
            btnTimeOnly.Text = " الوقت فقط";
            btnDate.Text = "التاريخ";
            btnTime.Text = "الوقت";
            btnClose.Text = "إغلاق";
            lblDay.Text = "اليوم";
            lblMonth.Text = "الشهر";
            lblYear.Text = "السنة";
            lblHour.Text = "الساعة";
            lblMinute.Text = "الدقائق";
            lblSecond.Text = "الثواني";

            btnTimeAndDate.Click += btnClick;
            btnDateOnly.Click += btnClick;
            btnTimeOnly.Click += btnClick;
            btnDate.Click += btnClick;
            btnTime.Click += btnClick;
            btnClose.Click += btnClick;

            design();
            visual();

            txtTimeAndDate.ReadOnly = txtDateOnly.ReadOnly = txtTimeOnly.ReadOnly =
    txtDay.ReadOnly = txtMonth.ReadOnly = txtYear.ReadOnly = txtHour.ReadOnly =
    txtMinute.ReadOnly = txtSecond.ReadOnly = true;

            txtTimeAndDate.TextAlign = txtDateOnly.TextAlign = txtTimeOnly.TextAlign =
    txtDay.TextAlign = txtMonth.TextAlign = txtYear.TextAlign = txtHour.TextAlign =
    txtMinute.TextAlign = txtSecond.TextAlign = HorizontalAlignment.Center;

            //lblHour.Font = lblMinute.Font = lblSecond.Font = new Font("Arial", 10);
            lblHour.AutoSize = lblMinute.AutoSize = lblSecond.AutoSize = false;

            lblHour.Size = lblMinute.Size = lblSecond.Size = new Size(50, 50);


            this.CenterToParent();
        }

        void btnClick(object sender, EventArgs e)
        {
            if (sender == btnTimeAndDate)
            {
                txtTimeAndDate.Text = DateTime.Now.ToString();
            }
            else if (sender == btnDateOnly)
            {
                txtDateOnly.Text = DateTime.Now.ToString("D");
            }
            else if (sender == btnTimeOnly)
            {
                txtTimeOnly.Text = DateTime.Now.ToString("t");
            }
            else if (sender == btnDate)
            {
                txtDay.Text = DateTime.Now.ToString("dd");
                txtMonth.Text = DateTime.Now.ToString("MM");
                txtYear.Text = DateTime.Now.ToString("yy");
            }
            else if (sender == btnTime)
            {
                txtSecond.Text = DateTime.Now.ToString("ss");
                txtMinute.Text = DateTime.Now.ToString("mm");
                txtHour.Text = DateTime.Now.ToString("hh");
            }
            else if (sender == btnClose)
            {
                this.Close();
            }
        }

        void visual()
        {
            this.Controls.Add(btnTimeAndDate);
            this.Controls.Add(btnDateOnly);
            this.Controls.Add(btnTimeOnly);
            this.Controls.Add(btnDate);
            this.Controls.Add(btnTime);
            this.Controls.Add(btnClose);
            this.Controls.Add(txtTimeAndDate);
            this.Controls.Add(txtDateOnly);
            this.Controls.Add(txtTimeOnly);
            this.Controls.Add(txtDay);
            this.Controls.Add(txtMonth);
            this.Controls.Add(txtYear);
            this.Controls.Add(txtHour);
            this.Controls.Add(txtMinute);
            this.Controls.Add(txtSecond);
            this.Controls.Add(lblDay);
            this.Controls.Add(lblMonth);
            this.Controls.Add(lblYear);
            this.Controls.Add(lblHour);
            this.Controls.Add(lblMinute);
            this.Controls.Add(lblSecond);
        }

        void design()
        {
            btnTimeAndDate.Left = btnDate.Left = btnTime.Left = btnDateOnly.Left = btnTimeOnly.Left = 250;
            txtTimeAndDate.Left = txtTimeOnly.Left = txtDateOnly.Left = txtYear.Left = txtHour.Left = btnClose.Left = 20;
            txtMonth.Left = txtMinute.Left = 95;
            txtDay.Left = txtSecond.Left = 170;
            lblYear.Left = lblHour.Left = 30;
            lblMonth.Left = lblMinute.Left = 105;
            lblDay.Left = lblSecond.Left = 180;

            btnTimeAndDate.Top = 40;
            txtTimeAndDate.Top = 45;

            btnDateOnly.Top= 75;
            txtDateOnly.Top = 80;

            btnTimeOnly.Top = 110;
            txtTimeOnly.Top = 115;

            btnDate.Top = 150;
            lblDay.Top = lblMonth.Top = lblYear.Top = 145;
            txtDay.Top = txtMonth.Top = txtYear.Top = 165;
            btnTime.Top = 200;
            lblSecond.Top = lblMinute.Top = lblHour.Top = 195;
            txtSecond.Top = txtMinute.Top = txtHour.Top = 213;
            btnClose.Top = 270;
        }

       
    }
}
