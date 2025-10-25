namespace WindowsFormsApplication4
{
    partial class Calculator
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
            this.text_N1 = new System.Windows.Forms.TextBox();
            this.text_N2 = new System.Windows.Forms.TextBox();
            this.text_Result = new System.Windows.Forms.TextBox();
            this.lab_N1 = new System.Windows.Forms.Label();
            this.lab_N2 = new System.Windows.Forms.Label();
            this.lab_Result = new System.Windows.Forms.Label();
            this.but_Sum = new System.Windows.Forms.Button();
            this.but_Sub = new System.Windows.Forms.Button();
            this.but_Mul = new System.Windows.Forms.Button();
            this.but_Div = new System.Windows.Forms.Button();
            this.but_N_Mul = new System.Windows.Forms.Button();
            this.but_N2 = new System.Windows.Forms.Button();
            this.but_N3 = new System.Windows.Forms.Button();
            this.but_Sqrt = new System.Windows.Forms.Button();
            this.but_Max = new System.Windows.Forms.Button();
            this.but_Min = new System.Windows.Forms.Button();
            this.but_Clear = new System.Windows.Forms.Button();
            this.but_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_N1
            // 
            this.text_N1.Location = new System.Drawing.Point(12, 38);
            this.text_N1.Name = "text_N1";
            this.text_N1.Size = new System.Drawing.Size(100, 20);
            this.text_N1.TabIndex = 0;
            this.text_N1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.text_N1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_N1_KeyPress);
            // 
            // text_N2
            // 
            this.text_N2.Location = new System.Drawing.Point(12, 108);
            this.text_N2.Name = "text_N2";
            this.text_N2.Size = new System.Drawing.Size(100, 20);
            this.text_N2.TabIndex = 1;
            this.text_N2.TextChanged += new System.EventHandler(this.text_N2_TextChanged);
            this.text_N2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_N2_KeyPress);
            // 
            // text_Result
            // 
            this.text_Result.Location = new System.Drawing.Point(14, 186);
            this.text_Result.Name = "text_Result";
            this.text_Result.Size = new System.Drawing.Size(100, 20);
            this.text_Result.TabIndex = 2;
            this.text_Result.TextChanged += new System.EventHandler(this.text_Result_TextChanged);
            // 
            // lab_N1
            // 
            this.lab_N1.AutoSize = true;
            this.lab_N1.Location = new System.Drawing.Point(54, 9);
            this.lab_N1.Name = "lab_N1";
            this.lab_N1.Size = new System.Drawing.Size(58, 13);
            this.lab_N1.TabIndex = 3;
            this.lab_N1.Text = "العدد الأول ";
            // 
            // lab_N2
            // 
            this.lab_N2.AutoSize = true;
            this.lab_N2.Location = new System.Drawing.Point(54, 75);
            this.lab_N2.Name = "lab_N2";
            this.lab_N2.Size = new System.Drawing.Size(60, 13);
            this.lab_N2.TabIndex = 4;
            this.lab_N2.Text = "العدد الثاني";
            // 
            // lab_Result
            // 
            this.lab_Result.AutoSize = true;
            this.lab_Result.Location = new System.Drawing.Point(80, 154);
            this.lab_Result.Name = "lab_Result";
            this.lab_Result.Size = new System.Drawing.Size(34, 13);
            this.lab_Result.TabIndex = 5;
            this.lab_Result.Text = "الناتج ";
            // 
            // but_Sum
            // 
            this.but_Sum.Location = new System.Drawing.Point(145, 23);
            this.but_Sum.Name = "but_Sum";
            this.but_Sum.Size = new System.Drawing.Size(51, 23);
            this.but_Sum.TabIndex = 6;
            this.but_Sum.Text = "Sum";
            this.but_Sum.UseVisualStyleBackColor = true;
            this.but_Sum.Click += new System.EventHandler(this.but_Sum_Click);
            // 
            // but_Sub
            // 
            this.but_Sub.Location = new System.Drawing.Point(145, 65);
            this.but_Sub.Name = "but_Sub";
            this.but_Sub.Size = new System.Drawing.Size(51, 23);
            this.but_Sub.TabIndex = 7;
            this.but_Sub.Text = "Sub";
            this.but_Sub.UseVisualStyleBackColor = true;
            this.but_Sub.Click += new System.EventHandler(this.but_Sub_Click);
            // 
            // but_Mul
            // 
            this.but_Mul.Location = new System.Drawing.Point(145, 108);
            this.but_Mul.Name = "but_Mul";
            this.but_Mul.Size = new System.Drawing.Size(51, 23);
            this.but_Mul.TabIndex = 8;
            this.but_Mul.Text = "Mul";
            this.but_Mul.UseVisualStyleBackColor = true;
            this.but_Mul.Click += new System.EventHandler(this.but_Mul_Click);
            // 
            // but_Div
            // 
            this.but_Div.Location = new System.Drawing.Point(145, 149);
            this.but_Div.Name = "but_Div";
            this.but_Div.Size = new System.Drawing.Size(51, 23);
            this.but_Div.TabIndex = 9;
            this.but_Div.Text = "Div";
            this.but_Div.UseVisualStyleBackColor = true;
            this.but_Div.Click += new System.EventHandler(this.but_Div_Click);
            // 
            // but_N_Mul
            // 
            this.but_N_Mul.Location = new System.Drawing.Point(145, 186);
            this.but_N_Mul.Name = "but_N_Mul";
            this.but_N_Mul.Size = new System.Drawing.Size(51, 23);
            this.but_N_Mul.TabIndex = 10;
            this.but_N_Mul.Text = "N !";
            this.but_N_Mul.UseVisualStyleBackColor = true;
            this.but_N_Mul.Click += new System.EventHandler(this.but_N_Mul_Click);
            // 
            // but_N2
            // 
            this.but_N2.Location = new System.Drawing.Point(214, 23);
            this.but_N2.Name = "but_N2";
            this.but_N2.Size = new System.Drawing.Size(51, 23);
            this.but_N2.TabIndex = 11;
            this.but_N2.Text = "^2";
            this.but_N2.UseVisualStyleBackColor = true;
            this.but_N2.Click += new System.EventHandler(this.but_N2_Click);
            // 
            // but_N3
            // 
            this.but_N3.Location = new System.Drawing.Point(214, 65);
            this.but_N3.Name = "but_N3";
            this.but_N3.Size = new System.Drawing.Size(51, 23);
            this.but_N3.TabIndex = 12;
            this.but_N3.Text = "^3";
            this.but_N3.UseVisualStyleBackColor = true;
            this.but_N3.Click += new System.EventHandler(this.but_N3_Click);
            // 
            // but_Sqrt
            // 
            this.but_Sqrt.Location = new System.Drawing.Point(214, 106);
            this.but_Sqrt.Name = "but_Sqrt";
            this.but_Sqrt.Size = new System.Drawing.Size(51, 23);
            this.but_Sqrt.TabIndex = 13;
            this.but_Sqrt.Text = "Sqrt";
            this.but_Sqrt.UseVisualStyleBackColor = true;
            this.but_Sqrt.Click += new System.EventHandler(this.but_Sqrt_Click);
            // 
            // but_Max
            // 
            this.but_Max.Location = new System.Drawing.Point(214, 149);
            this.but_Max.Name = "but_Max";
            this.but_Max.Size = new System.Drawing.Size(51, 23);
            this.but_Max.TabIndex = 14;
            this.but_Max.Text = "Max";
            this.but_Max.UseVisualStyleBackColor = true;
            this.but_Max.Click += new System.EventHandler(this.but_Max_Click);
            // 
            // but_Min
            // 
            this.but_Min.Location = new System.Drawing.Point(214, 186);
            this.but_Min.Name = "but_Min";
            this.but_Min.Size = new System.Drawing.Size(51, 23);
            this.but_Min.TabIndex = 15;
            this.but_Min.Text = "Min";
            this.but_Min.UseVisualStyleBackColor = true;
            this.but_Min.Click += new System.EventHandler(this.but_Min_Click);
            // 
            // but_Clear
            // 
            this.but_Clear.Location = new System.Drawing.Point(155, 221);
            this.but_Clear.Name = "but_Clear";
            this.but_Clear.Size = new System.Drawing.Size(75, 23);
            this.but_Clear.TabIndex = 16;
            this.but_Clear.Text = "Clear";
            this.but_Clear.UseVisualStyleBackColor = true;
            this.but_Clear.Click += new System.EventHandler(this.button11_Click);
            // 
            // but_Exit
            // 
            this.but_Exit.Location = new System.Drawing.Point(39, 221);
            this.but_Exit.Name = "but_Exit";
            this.but_Exit.Size = new System.Drawing.Size(75, 23);
            this.but_Exit.TabIndex = 17;
            this.but_Exit.Text = "Exit\r\n";
            this.but_Exit.UseVisualStyleBackColor = true;
            this.but_Exit.Click += new System.EventHandler(this.button12_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 256);
            this.Controls.Add(this.but_Exit);
            this.Controls.Add(this.but_Clear);
            this.Controls.Add(this.but_Min);
            this.Controls.Add(this.but_Max);
            this.Controls.Add(this.but_Sqrt);
            this.Controls.Add(this.but_N3);
            this.Controls.Add(this.but_N2);
            this.Controls.Add(this.but_N_Mul);
            this.Controls.Add(this.but_Div);
            this.Controls.Add(this.but_Mul);
            this.Controls.Add(this.but_Sub);
            this.Controls.Add(this.but_Sum);
            this.Controls.Add(this.lab_Result);
            this.Controls.Add(this.lab_N2);
            this.Controls.Add(this.lab_N1);
            this.Controls.Add(this.text_Result);
            this.Controls.Add(this.text_N2);
            this.Controls.Add(this.text_N1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_N1;
        private System.Windows.Forms.TextBox text_N2;
        private System.Windows.Forms.TextBox text_Result;
        private System.Windows.Forms.Label lab_N1;
        private System.Windows.Forms.Label lab_N2;
        private System.Windows.Forms.Label lab_Result;
        private System.Windows.Forms.Button but_Sum;
        private System.Windows.Forms.Button but_Sub;
        private System.Windows.Forms.Button but_Mul;
        private System.Windows.Forms.Button but_Div;
        private System.Windows.Forms.Button but_N_Mul;
        private System.Windows.Forms.Button but_N2;
        private System.Windows.Forms.Button but_N3;
        private System.Windows.Forms.Button but_Sqrt;
        private System.Windows.Forms.Button but_Max;
        private System.Windows.Forms.Button but_Min;
        private System.Windows.Forms.Button but_Clear;
        private System.Windows.Forms.Button but_Exit;
    }
}

