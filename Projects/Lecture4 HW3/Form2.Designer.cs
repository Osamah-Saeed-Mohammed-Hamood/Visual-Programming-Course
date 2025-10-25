namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lstNum = new System.Windows.Forms.ListBox();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "أدخل الرقم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "أدخل عدد العناصر";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(35, 71);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(121, 22);
            this.txtNum.TabIndex = 2;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(203, 71);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(128, 22);
            this.txtSize.TabIndex = 3;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            this.txtSize.Leave += new System.EventHandler(this.txtSize_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.Location = new System.Drawing.Point(35, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(296, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "إضافـــــــة للمصفوفـــــــة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.Location = new System.Drawing.Point(212, 168);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 43);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "حذف العناصر";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Silver;
            this.btnShow.Location = new System.Drawing.Point(35, 168);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(119, 43);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "عرض العناصر";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.Silver;
            this.btnSum.Location = new System.Drawing.Point(212, 393);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(119, 43);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "المجموع";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(35, 393);
            this.txtSum.Multiline = true;
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(119, 43);
            this.txtSum.TabIndex = 8;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstNum
            // 
            this.lstNum.FormattingEnabled = true;
            this.lstNum.ItemHeight = 16;
            this.lstNum.Location = new System.Drawing.Point(35, 224);
            this.lstNum.Name = "lstNum";
            this.lstNum.Size = new System.Drawing.Size(296, 148);
            this.lstNum.TabIndex = 9;
            // 
            // btnForm3
            // 
            this.btnForm3.BackColor = System.Drawing.Color.Silver;
            this.btnForm3.Location = new System.Drawing.Point(106, 456);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(156, 50);
            this.btnForm3.TabIndex = 10;
            this.btnForm3.Text = "Go To Form3   >>>";
            this.btnForm3.UseVisualStyleBackColor = false;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(368, 514);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.lstNum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.ListBox lstNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnForm3;
    }
}