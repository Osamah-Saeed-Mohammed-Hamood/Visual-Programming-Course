namespace Lecture5_HW4
{
    partial class HW4
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
            this.pnlForeColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rdoForeColorBlack = new System.Windows.Forms.RadioButton();
            this.rdoForeColorGreen = new System.Windows.Forms.RadioButton();
            this.rdoForeColorYellow = new System.Windows.Forms.RadioButton();
            this.rdoForeColorRed = new System.Windows.Forms.RadioButton();
            this.pnlBackColor = new System.Windows.Forms.Panel();
            this.lblWord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoBackColorBlack = new System.Windows.Forms.RadioButton();
            this.rdoBackColorGreen = new System.Windows.Forms.RadioButton();
            this.rdoBackColorYellow = new System.Windows.Forms.RadioButton();
            this.rdoBackColorRed = new System.Windows.Forms.RadioButton();
            this.grpSum = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.chkFiveHandred = new System.Windows.Forms.CheckBox();
            this.chkFourHandred = new System.Windows.Forms.CheckBox();
            this.chkTwoHandred = new System.Windows.Forms.CheckBox();
            this.chkThreeHandred = new System.Windows.Forms.CheckBox();
            this.chkOneHandred = new System.Windows.Forms.CheckBox();
            this.btnVisible = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.pnlForeColor.SuspendLayout();
            this.pnlBackColor.SuspendLayout();
            this.grpSum.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForeColor
            // 
            this.pnlForeColor.Controls.Add(this.label1);
            this.pnlForeColor.Controls.Add(this.button2);
            this.pnlForeColor.Controls.Add(this.rdoForeColorBlack);
            this.pnlForeColor.Controls.Add(this.rdoForeColorGreen);
            this.pnlForeColor.Controls.Add(this.rdoForeColorYellow);
            this.pnlForeColor.Controls.Add(this.rdoForeColorRed);
            this.pnlForeColor.Location = new System.Drawing.Point(195, 52);
            this.pnlForeColor.Name = "pnlForeColor";
            this.pnlForeColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlForeColor.Size = new System.Drawing.Size(146, 318);
            this.pnlForeColor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "لون النص";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(19, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "تطبيق";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdoForeColorBlack
            // 
            this.rdoForeColorBlack.AutoSize = true;
            this.rdoForeColorBlack.Location = new System.Drawing.Point(36, 174);
            this.rdoForeColorBlack.Name = "rdoForeColorBlack";
            this.rdoForeColorBlack.Size = new System.Drawing.Size(53, 20);
            this.rdoForeColorBlack.TabIndex = 4;
            this.rdoForeColorBlack.TabStop = true;
            this.rdoForeColorBlack.Text = "أسود";
            this.rdoForeColorBlack.UseVisualStyleBackColor = true;
            // 
            // rdoForeColorGreen
            // 
            this.rdoForeColorGreen.AutoSize = true;
            this.rdoForeColorGreen.Location = new System.Drawing.Point(34, 138);
            this.rdoForeColorGreen.Name = "rdoForeColorGreen";
            this.rdoForeColorGreen.Size = new System.Drawing.Size(57, 20);
            this.rdoForeColorGreen.TabIndex = 3;
            this.rdoForeColorGreen.TabStop = true;
            this.rdoForeColorGreen.Text = "أخضر";
            this.rdoForeColorGreen.UseVisualStyleBackColor = true;
            // 
            // rdoForeColorYellow
            // 
            this.rdoForeColorYellow.AutoSize = true;
            this.rdoForeColorYellow.Location = new System.Drawing.Point(35, 102);
            this.rdoForeColorYellow.Name = "rdoForeColorYellow";
            this.rdoForeColorYellow.Size = new System.Drawing.Size(54, 20);
            this.rdoForeColorYellow.TabIndex = 2;
            this.rdoForeColorYellow.TabStop = true;
            this.rdoForeColorYellow.Text = "أصفر";
            this.rdoForeColorYellow.UseVisualStyleBackColor = true;
            // 
            // rdoForeColorRed
            // 
            this.rdoForeColorRed.AutoSize = true;
            this.rdoForeColorRed.Location = new System.Drawing.Point(36, 66);
            this.rdoForeColorRed.Name = "rdoForeColorRed";
            this.rdoForeColorRed.Size = new System.Drawing.Size(53, 20);
            this.rdoForeColorRed.TabIndex = 1;
            this.rdoForeColorRed.TabStop = true;
            this.rdoForeColorRed.Text = "أحمر";
            this.rdoForeColorRed.UseVisualStyleBackColor = true;
            // 
            // pnlBackColor
            // 
            this.pnlBackColor.Controls.Add(this.lblWord);
            this.pnlBackColor.Controls.Add(this.label2);
            this.pnlBackColor.Controls.Add(this.rdoBackColorBlack);
            this.pnlBackColor.Controls.Add(this.rdoBackColorGreen);
            this.pnlBackColor.Controls.Add(this.rdoBackColorYellow);
            this.pnlBackColor.Controls.Add(this.rdoBackColorRed);
            this.pnlBackColor.Location = new System.Drawing.Point(28, 52);
            this.pnlBackColor.Name = "pnlBackColor";
            this.pnlBackColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlBackColor.Size = new System.Drawing.Size(146, 318);
            this.pnlBackColor.TabIndex = 1;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(12, 248);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(121, 37);
            this.lblWord.TabIndex = 9;
            this.lblWord.Text = "CrazyIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "لون الخلفية";
            // 
            // rdoBackColorBlack
            // 
            this.rdoBackColorBlack.AutoSize = true;
            this.rdoBackColorBlack.Location = new System.Drawing.Point(24, 183);
            this.rdoBackColorBlack.Name = "rdoBackColorBlack";
            this.rdoBackColorBlack.Size = new System.Drawing.Size(53, 20);
            this.rdoBackColorBlack.TabIndex = 3;
            this.rdoBackColorBlack.TabStop = true;
            this.rdoBackColorBlack.Text = "أسود";
            this.rdoBackColorBlack.UseVisualStyleBackColor = true;
            // 
            // rdoBackColorGreen
            // 
            this.rdoBackColorGreen.AutoSize = true;
            this.rdoBackColorGreen.Location = new System.Drawing.Point(22, 144);
            this.rdoBackColorGreen.Name = "rdoBackColorGreen";
            this.rdoBackColorGreen.Size = new System.Drawing.Size(57, 20);
            this.rdoBackColorGreen.TabIndex = 2;
            this.rdoBackColorGreen.TabStop = true;
            this.rdoBackColorGreen.Text = "أخضر";
            this.rdoBackColorGreen.UseVisualStyleBackColor = true;
            // 
            // rdoBackColorYellow
            // 
            this.rdoBackColorYellow.AutoSize = true;
            this.rdoBackColorYellow.Location = new System.Drawing.Point(23, 105);
            this.rdoBackColorYellow.Name = "rdoBackColorYellow";
            this.rdoBackColorYellow.Size = new System.Drawing.Size(54, 20);
            this.rdoBackColorYellow.TabIndex = 1;
            this.rdoBackColorYellow.TabStop = true;
            this.rdoBackColorYellow.Text = "أصفر";
            this.rdoBackColorYellow.UseVisualStyleBackColor = true;
            // 
            // rdoBackColorRed
            // 
            this.rdoBackColorRed.AutoSize = true;
            this.rdoBackColorRed.Location = new System.Drawing.Point(24, 66);
            this.rdoBackColorRed.Name = "rdoBackColorRed";
            this.rdoBackColorRed.Size = new System.Drawing.Size(53, 20);
            this.rdoBackColorRed.TabIndex = 0;
            this.rdoBackColorRed.TabStop = true;
            this.rdoBackColorRed.Text = "أحمر";
            this.rdoBackColorRed.UseVisualStyleBackColor = true;
            // 
            // grpSum
            // 
            this.grpSum.Controls.Add(this.txtResult);
            this.grpSum.Controls.Add(this.btnSum);
            this.grpSum.Controls.Add(this.chkFiveHandred);
            this.grpSum.Controls.Add(this.chkFourHandred);
            this.grpSum.Controls.Add(this.chkTwoHandred);
            this.grpSum.Controls.Add(this.chkThreeHandred);
            this.grpSum.Controls.Add(this.chkOneHandred);
            this.grpSum.Location = new System.Drawing.Point(362, 47);
            this.grpSum.Name = "grpSum";
            this.grpSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpSum.Size = new System.Drawing.Size(200, 318);
            this.grpSum.TabIndex = 2;
            this.grpSum.TabStop = false;
            this.grpSum.Text = "اختار ثم احسب ";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(17, 276);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(148, 22);
            this.txtResult.TabIndex = 6;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.LightGray;
            this.btnSum.Location = new System.Drawing.Point(44, 225);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(94, 36);
            this.btnSum.TabIndex = 5;
            this.btnSum.Text = "حساب";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // chkFiveHandred
            // 
            this.chkFiveHandred.AutoSize = true;
            this.chkFiveHandred.Location = new System.Drawing.Point(44, 182);
            this.chkFiveHandred.Name = "chkFiveHandred";
            this.chkFiveHandred.Size = new System.Drawing.Size(50, 20);
            this.chkFiveHandred.TabIndex = 4;
            this.chkFiveHandred.Tag = "500";
            this.chkFiveHandred.Text = "500";
            this.chkFiveHandred.UseVisualStyleBackColor = true;
            // 
            // chkFourHandred
            // 
            this.chkFourHandred.AutoSize = true;
            this.chkFourHandred.Location = new System.Drawing.Point(44, 145);
            this.chkFourHandred.Name = "chkFourHandred";
            this.chkFourHandred.Size = new System.Drawing.Size(50, 20);
            this.chkFourHandred.TabIndex = 3;
            this.chkFourHandred.Tag = "400";
            this.chkFourHandred.Text = "400";
            this.chkFourHandred.UseVisualStyleBackColor = true;
            // 
            // chkTwoHandred
            // 
            this.chkTwoHandred.AutoSize = true;
            this.chkTwoHandred.Location = new System.Drawing.Point(44, 71);
            this.chkTwoHandred.Name = "chkTwoHandred";
            this.chkTwoHandred.Size = new System.Drawing.Size(50, 20);
            this.chkTwoHandred.TabIndex = 2;
            this.chkTwoHandred.Tag = "200";
            this.chkTwoHandred.Text = "200";
            this.chkTwoHandred.UseVisualStyleBackColor = true;
            // 
            // chkThreeHandred
            // 
            this.chkThreeHandred.AutoSize = true;
            this.chkThreeHandred.Location = new System.Drawing.Point(44, 108);
            this.chkThreeHandred.Name = "chkThreeHandred";
            this.chkThreeHandred.Size = new System.Drawing.Size(50, 20);
            this.chkThreeHandred.TabIndex = 1;
            this.chkThreeHandred.Tag = "300";
            this.chkThreeHandred.Text = "300";
            this.chkThreeHandred.UseVisualStyleBackColor = true;
            // 
            // chkOneHandred
            // 
            this.chkOneHandred.AutoSize = true;
            this.chkOneHandred.Location = new System.Drawing.Point(44, 34);
            this.chkOneHandred.Name = "chkOneHandred";
            this.chkOneHandred.Size = new System.Drawing.Size(50, 20);
            this.chkOneHandred.TabIndex = 0;
            this.chkOneHandred.Tag = "100";
            this.chkOneHandred.Text = "100";
            this.chkOneHandred.UseVisualStyleBackColor = true;
            // 
            // btnVisible
            // 
            this.btnVisible.Location = new System.Drawing.Point(222, 445);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(89, 34);
            this.btnVisible.TabIndex = 7;
            this.btnVisible.Text = "Unvisible";
            this.btnVisible.UseVisualStyleBackColor = true;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(222, 392);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(89, 34);
            this.btnEnable.TabIndex = 9;
            this.btnEnable.Text = "Unenable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.BackColor = System.Drawing.Color.Silver;
            this.btnForm2.Location = new System.Drawing.Point(185, 493);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(163, 38);
            this.btnForm2.TabIndex = 10;
            this.btnForm2.Text = "Go To Form2   >>>";
            this.btnForm2.UseVisualStyleBackColor = false;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // HW4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 542);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.grpSum);
            this.Controls.Add(this.pnlBackColor);
            this.Controls.Add(this.pnlForeColor);
            this.MaximizeBox = false;
            this.Name = "HW4";
            this.Text = "HW4";
            this.pnlForeColor.ResumeLayout(false);
            this.pnlForeColor.PerformLayout();
            this.pnlBackColor.ResumeLayout(false);
            this.pnlBackColor.PerformLayout();
            this.grpSum.ResumeLayout(false);
            this.grpSum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForeColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdoForeColorBlack;
        private System.Windows.Forms.RadioButton rdoForeColorGreen;
        private System.Windows.Forms.RadioButton rdoForeColorYellow;
        private System.Windows.Forms.RadioButton rdoForeColorRed;
        private System.Windows.Forms.Panel pnlBackColor;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoBackColorBlack;
        private System.Windows.Forms.RadioButton rdoBackColorGreen;
        private System.Windows.Forms.RadioButton rdoBackColorYellow;
        private System.Windows.Forms.RadioButton rdoBackColorRed;
        private System.Windows.Forms.GroupBox grpSum;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.CheckBox chkFiveHandred;
        private System.Windows.Forms.CheckBox chkFourHandred;
        private System.Windows.Forms.CheckBox chkTwoHandred;
        private System.Windows.Forms.CheckBox chkThreeHandred;
        private System.Windows.Forms.CheckBox chkOneHandred;
        private System.Windows.Forms.Button btnVisible;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnForm2;
    }
}

