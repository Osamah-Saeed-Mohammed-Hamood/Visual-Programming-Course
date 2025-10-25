namespace Lecture7_HW6
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
            this.lstText = new System.Windows.Forms.ListBox();
            this.txtForm3 = new System.Windows.Forms.TextBox();
            this.btnModifiy = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstText
            // 
            this.lstText.FormattingEnabled = true;
            this.lstText.ItemHeight = 16;
            this.lstText.Location = new System.Drawing.Point(250, 77);
            this.lstText.Name = "lstText";
            this.lstText.Size = new System.Drawing.Size(204, 180);
            this.lstText.TabIndex = 2;
            // 
            // txtForm3
            // 
            this.txtForm3.Location = new System.Drawing.Point(171, 41);
            this.txtForm3.Name = "txtForm3";
            this.txtForm3.Size = new System.Drawing.Size(363, 22);
            this.txtForm3.TabIndex = 3;
            this.txtForm3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnModifiy
            // 
            this.btnModifiy.Location = new System.Drawing.Point(35, 37);
            this.btnModifiy.Name = "btnModifiy";
            this.btnModifiy.Size = new System.Drawing.Size(104, 31);
            this.btnModifiy.TabIndex = 4;
            this.btnModifiy.Text = "تعديل";
            this.btnModifiy.UseVisualStyleBackColor = true;
            this.btnModifiy.Click += new System.EventHandler(this.btnModifiy_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(566, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(26, 246);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 42);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "رجوع";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 296);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModifiy);
            this.Controls.Add(this.txtForm3);
            this.Controls.Add(this.lstText);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstText;
        private System.Windows.Forms.Button btnModifiy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.TextBox txtForm3;
    }
}