namespace Draw
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMainLine = new System.Windows.Forms.Button();
            this.btnSecondaryLine = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnQuad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 402);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMainLine
            // 
            this.btnMainLine.Location = new System.Drawing.Point(535, 452);
            this.btnMainLine.Name = "btnMainLine";
            this.btnMainLine.Size = new System.Drawing.Size(117, 41);
            this.btnMainLine.TabIndex = 1;
            this.btnMainLine.Text = "القطر الرئيسي";
            this.btnMainLine.UseVisualStyleBackColor = true;
            this.btnMainLine.Click += new System.EventHandler(this.btnMainLine_Click);
            // 
            // btnSecondaryLine
            // 
            this.btnSecondaryLine.Location = new System.Drawing.Point(390, 452);
            this.btnSecondaryLine.Name = "btnSecondaryLine";
            this.btnSecondaryLine.Size = new System.Drawing.Size(117, 41);
            this.btnSecondaryLine.TabIndex = 2;
            this.btnSecondaryLine.Text = "القطر الثانوي";
            this.btnSecondaryLine.UseVisualStyleBackColor = true;
            this.btnSecondaryLine.Click += new System.EventHandler(this.btnSecondaryLine_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(267, 452);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(95, 41);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "مربع";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(144, 452);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(95, 41);
            this.btnRectangle.TabIndex = 4;
            this.btnRectangle.Text = "مستطيل";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnQuad
            // 
            this.btnQuad.Location = new System.Drawing.Point(21, 452);
            this.btnQuad.Name = "btnQuad";
            this.btnQuad.Size = new System.Drawing.Size(95, 41);
            this.btnQuad.TabIndex = 5;
            this.btnQuad.Text = "مكعب";
            this.btnQuad.UseVisualStyleBackColor = true;
            this.btnQuad.Click += new System.EventHandler(this.btnQuad_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(504, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Go To Form2  >>>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(21, 506);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(95, 41);
            this.btnTriangle.TabIndex = 7;
            this.btnTriangle.Text = "مثلث";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(267, 506);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(95, 41);
            this.btnLine.TabIndex = 8;
            this.btnLine.Text = "خط";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(128, 506);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(126, 41);
            this.btnTrain.TabIndex = 9;
            this.btnTrain.Text = "مثلث قائم الزاوية";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(401, 506);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(95, 41);
            this.btnX.TabIndex = 10;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 556);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuad);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnSecondaryLine);
            this.Controls.Add(this.btnMainLine);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Draw";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMainLine;
        private System.Windows.Forms.Button btnSecondaryLine;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnQuad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnX;
    }
}

