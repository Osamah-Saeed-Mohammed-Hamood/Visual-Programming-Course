namespace Lecture3Hw
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
            this.lblDevice1 = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblDevice2 = new System.Windows.Forms.Label();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDevice1
            // 
            this.lblDevice1.AutoSize = true;
            this.lblDevice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevice1.Location = new System.Drawing.Point(97, 30);
            this.lblDevice1.Name = "lblDevice1";
            this.lblDevice1.Size = new System.Drawing.Size(45, 20);
            this.lblDevice1.TabIndex = 0;
            this.lblDevice1.Text = "جهاز1";
            this.lblDevice1.Click += new System.EventHandler(this.lblDevice1_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(16, 83);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(90, 42);
            this.btnRed.TabIndex = 1;
            this.btnRed.Text = "أحمر";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(144, 85);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(90, 42);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.Text = "أخضر";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(275, 85);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(90, 42);
            this.btnYellow.TabIndex = 3;
            this.btnYellow.Text = "أصفر";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "____";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblDevice2
            // 
            this.lblDevice2.AutoSize = true;
            this.lblDevice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevice2.Location = new System.Drawing.Point(228, 30);
            this.lblDevice2.Name = "lblDevice2";
            this.lblDevice2.Size = new System.Drawing.Size(45, 20);
            this.lblDevice2.TabIndex = 5;
            this.lblDevice2.Text = "جهاز2";
            this.lblDevice2.Click += new System.EventHandler(this.lblDevice2_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.BackColor = System.Drawing.Color.Silver;
            this.btnForm3.Location = new System.Drawing.Point(87, 223);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(174, 48);
            this.btnForm3.TabIndex = 15;
            this.btnForm3.Text = "Go TO Form3  >>>";
            this.btnForm3.UseVisualStyleBackColor = false;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 281);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.lblDevice2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.lblDevice1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "sender";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDevice1;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblDevice2;
        private System.Windows.Forms.Button btnForm3;
    }
}