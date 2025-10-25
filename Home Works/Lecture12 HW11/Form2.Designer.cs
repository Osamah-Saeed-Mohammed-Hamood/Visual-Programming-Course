namespace Draw
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.rdoHorizental = new System.Windows.Forms.RadioButton();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoVertical = new System.Windows.Forms.RadioButton();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(453, 438);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(102, 32);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "إنشاء";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rdoHorizental
            // 
            this.rdoHorizental.AutoSize = true;
            this.rdoHorizental.Location = new System.Drawing.Point(156, 442);
            this.rdoHorizental.Name = "rdoHorizental";
            this.rdoHorizental.Size = new System.Drawing.Size(53, 20);
            this.rdoHorizental.TabIndex = 1;
            this.rdoHorizental.TabStop = true;
            this.rdoHorizental.Text = "أفقياً";
            this.rdoHorizental.UseVisualStyleBackColor = true;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(271, 442);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 2;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "الطول";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdoVertical
            // 
            this.rdoVertical.AutoSize = true;
            this.rdoVertical.Location = new System.Drawing.Point(33, 442);
            this.rdoVertical.Name = "rdoVertical";
            this.rdoVertical.Size = new System.Drawing.Size(61, 20);
            this.rdoVertical.TabIndex = 4;
            this.rdoVertical.TabStop = true;
            this.rdoVertical.Text = "عمودياً";
            this.rdoVertical.UseVisualStyleBackColor = true;
            // 
            // btnForm3
            // 
            this.btnForm3.BackColor = System.Drawing.Color.Silver;
            this.btnForm3.Location = new System.Drawing.Point(593, 434);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(148, 41);
            this.btnForm3.TabIndex = 7;
            this.btnForm3.Text = "Go To Form3  >>>";
            this.btnForm3.UseVisualStyleBackColor = false;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 482);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.rdoVertical);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.rdoHorizental);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton rdoHorizental;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoVertical;
        private System.Windows.Forms.Button btnForm3;
    }
}