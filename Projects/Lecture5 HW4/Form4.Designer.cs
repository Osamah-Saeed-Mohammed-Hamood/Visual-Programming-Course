namespace Lecture5_HW4
{
    partial class Form4
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
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSum.Location = new System.Drawing.Point(11, 14);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(90, 35);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "جمع";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSub.Location = new System.Drawing.Point(153, 14);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(90, 35);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "طرح";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.Pink;
            this.btnDiv.Location = new System.Drawing.Point(437, 14);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(90, 35);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "قسمة";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.Thistle;
            this.btnMult.Location = new System.Drawing.Point(295, 14);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(90, 35);
            this.btnMult.TabIndex = 3;
            this.btnMult.Text = "ضرب";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // pnlOperations
            // 
            this.pnlOperations.Controls.Add(this.button2);
            this.pnlOperations.Controls.Add(this.btnResult);
            this.pnlOperations.Controls.Add(this.txtResult);
            this.pnlOperations.Controls.Add(this.txtNum2);
            this.pnlOperations.Controls.Add(this.txtNum1);
            this.pnlOperations.Controls.Add(this.label1);
            this.pnlOperations.Controls.Add(this.label2);
            this.pnlOperations.Controls.Add(this.label3);
            this.pnlOperations.Controls.Add(this.lblOperation);
            this.pnlOperations.Controls.Add(this.label5);
            this.pnlOperations.Location = new System.Drawing.Point(-5, 71);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(549, 206);
            this.pnlOperations.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(46, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "إغلاق";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Silver;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(396, 150);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(101, 40);
            this.btnResult.TabIndex = 13;
            this.btnResult.Text = "حساب";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(26, 81);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(119, 22);
            this.txtResult.TabIndex = 12;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(207, 81);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(119, 22);
            this.txtNum2.TabIndex = 11;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(396, 81);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(119, 22);
            this.txtNum1.TabIndex = 10;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "العدد الأول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "العدد الثاني";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "الناتج";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(351, 82);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(20, 20);
            this.lblOperation.TabIndex = 8;
            this.lblOperation.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "=";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 287);
            this.Controls.Add(this.pnlOperations);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSum);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
    }
}