namespace Draw
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
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.circalButton1 = new Draw.CircalButton();
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.Location = new System.Drawing.Point(143, 89);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(510, 194);
            this.pnlDraw.TabIndex = 0;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(60, 379);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(84, 37);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "رسم";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // circalButton1
            // 
            this.circalButton1.Location = new System.Drawing.Point(645, 370);
            this.circalButton1.Name = "circalButton1";
            this.circalButton1.Size = new System.Drawing.Size(56, 36);
            this.circalButton1.TabIndex = 1;
            this.circalButton1.Text = "a";
            this.circalButton1.UseVisualStyleBackColor = true;
            this.circalButton1.Click += new System.EventHandler(this.circalButton1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circalButton1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pnlDraw);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Button btnDraw;
        private CircalButton circalButton1;
    }
}