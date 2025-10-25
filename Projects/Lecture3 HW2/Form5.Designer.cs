namespace Lecture3Hw
{
    partial class Form5
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
            this.lblSum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblFact = new System.Windows.Forms.Label();
            this.lblSqrt = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnFact = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "أدخل العدد";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(54, 141);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(49, 36);
            this.lblSum.TabIndex = 1;
            this.lblSum.Text = "__";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(84, 86);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(157, 22);
            this.txtNum.TabIndex = 2;
            this.txtNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFact
            // 
            this.lblFact.AutoSize = true;
            this.lblFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFact.Location = new System.Drawing.Point(54, 218);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(49, 36);
            this.lblFact.TabIndex = 3;
            this.lblFact.Text = "__";
            // 
            // lblSqrt
            // 
            this.lblSqrt.AutoSize = true;
            this.lblSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqrt.Location = new System.Drawing.Point(54, 292);
            this.lblSqrt.Name = "lblSqrt";
            this.lblSqrt.Size = new System.Drawing.Size(49, 36);
            this.lblSqrt.TabIndex = 4;
            this.lblSqrt.Text = "__";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(199, 141);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(96, 36);
            this.btnSum.TabIndex = 5;
            this.btnSum.Text = "المجموع";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnFact
            // 
            this.btnFact.Location = new System.Drawing.Point(199, 218);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(96, 36);
            this.btnFact.TabIndex = 6;
            this.btnFact.Text = "المضروب";
            this.btnFact.UseVisualStyleBackColor = true;
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(199, 292);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(96, 36);
            this.btnSqrt.TabIndex = 7;
            this.btnSqrt.Text = "الجذر";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(354, 348);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.lblSqrt);
            this.Controls.Add(this.lblFact);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblFact;
        private System.Windows.Forms.Label lblSqrt;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.Button btnSqrt;
    }
}