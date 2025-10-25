namespace Lecture5_HW4
{
    partial class Form3
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
            this.btnGoFrontBehined = new System.Windows.Forms.Button();
            this.btnGoTopBottom = new System.Windows.Forms.Button();
            this.btnMoveFront = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnForm4 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoFrontBehined
            // 
            this.btnGoFrontBehined.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGoFrontBehined.Location = new System.Drawing.Point(12, 12);
            this.btnGoFrontBehined.Name = "btnGoFrontBehined";
            this.btnGoFrontBehined.Size = new System.Drawing.Size(75, 23);
            this.btnGoFrontBehined.TabIndex = 0;
            this.btnGoFrontBehined.Text = ">";
            this.btnGoFrontBehined.UseVisualStyleBackColor = false;
            // 
            // btnGoTopBottom
            // 
            this.btnGoTopBottom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGoTopBottom.Location = new System.Drawing.Point(12, 59);
            this.btnGoTopBottom.Name = "btnGoTopBottom";
            this.btnGoTopBottom.Size = new System.Drawing.Size(75, 23);
            this.btnGoTopBottom.TabIndex = 1;
            this.btnGoTopBottom.Text = "v";
            this.btnGoTopBottom.UseVisualStyleBackColor = false;
            // 
            // btnMoveFront
            // 
            this.btnMoveFront.Location = new System.Drawing.Point(322, 333);
            this.btnMoveFront.Name = "btnMoveFront";
            this.btnMoveFront.Size = new System.Drawing.Size(136, 33);
            this.btnMoveFront.TabIndex = 2;
            this.btnMoveFront.Text = "التحرك إلى الأمام";
            this.btnMoveFront.UseVisualStyleBackColor = true;
            this.btnMoveFront.Click += new System.EventHandler(this.btnMoveFront_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(521, 333);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(136, 33);
            this.btnMoveDown.TabIndex = 3;
            this.btnMoveDown.Text = "التحرك إلى الأسفل";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnForm4
            // 
            this.btnForm4.BackColor = System.Drawing.Color.Silver;
            this.btnForm4.Location = new System.Drawing.Point(518, 397);
            this.btnForm4.Name = "btnForm4";
            this.btnForm4.Size = new System.Drawing.Size(163, 38);
            this.btnForm4.TabIndex = 12;
            this.btnForm4.Text = "Go To Form4   >>>";
            this.btnForm4.UseVisualStyleBackColor = false;
            this.btnForm4.Click += new System.EventHandler(this.btnForm4_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(201, 330);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 38);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "توقف";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnForm4);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveFront);
            this.Controls.Add(this.btnGoTopBottom);
            this.Controls.Add(this.btnGoFrontBehined);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoFrontBehined;
        private System.Windows.Forms.Button btnGoTopBottom;
        private System.Windows.Forms.Button btnMoveFront;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnForm4;
        private System.Windows.Forms.Button btnStop;
    }
}