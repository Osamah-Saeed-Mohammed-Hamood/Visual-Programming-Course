namespace Lecture10_HW9
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
            this.driveListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.dirListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.fileListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            this.combExtention = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblNNameOfFile = new System.Windows.Forms.Label();
            this.lblExtention = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // driveListBox1
            // 
            this.driveListBox1.FormattingEnabled = true;
            this.driveListBox1.Location = new System.Drawing.Point(617, 159);
            this.driveListBox1.Name = "driveListBox1";
            this.driveListBox1.Size = new System.Drawing.Size(678, 23);
            this.driveListBox1.TabIndex = 0;
            this.driveListBox1.SelectedIndexChanged += new System.EventHandler(this.driveListBox1_SelectedIndexChanged);
            // 
            // dirListBox1
            // 
            this.dirListBox1.FormattingEnabled = true;
            this.dirListBox1.IntegralHeight = false;
            this.dirListBox1.Location = new System.Drawing.Point(617, 196);
            this.dirListBox1.Name = "dirListBox1";
            this.dirListBox1.Size = new System.Drawing.Size(678, 199);
            this.dirListBox1.TabIndex = 1;
            this.dirListBox1.SelectedIndexChanged += new System.EventHandler(this.dirListBox1_SelectedIndexChanged);
            // 
            // fileListBox1
            // 
            this.fileListBox1.FormattingEnabled = true;
            this.fileListBox1.Location = new System.Drawing.Point(617, 447);
            this.fileListBox1.Name = "fileListBox1";
            this.fileListBox1.Pattern = "*.*";
            this.fileListBox1.Size = new System.Drawing.Size(678, 196);
            this.fileListBox1.TabIndex = 2;
            this.fileListBox1.SelectedIndexChanged += new System.EventHandler(this.fileListBox1_SelectedIndexChanged);
            // 
            // combExtention
            // 
            this.combExtention.FormattingEnabled = true;
            this.combExtention.Location = new System.Drawing.Point(617, 409);
            this.combExtention.Name = "combExtention";
            this.combExtention.Size = new System.Drawing.Size(678, 24);
            this.combExtention.TabIndex = 3;
            this.combExtention.SelectedIndexChanged += new System.EventHandler(this.combExtention_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 400);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(526, 243);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1225, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = ":  مسار الملف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1234, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = ":  اسم الملف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1246, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = ":  الامتداد";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(598, 32);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(28, 16);
            this.lblPath.TabIndex = 9;
            this.lblPath.Text = "___";
            // 
            // lblNNameOfFile
            // 
            this.lblNNameOfFile.AutoSize = true;
            this.lblNNameOfFile.Location = new System.Drawing.Point(598, 76);
            this.lblNNameOfFile.Name = "lblNNameOfFile";
            this.lblNNameOfFile.Size = new System.Drawing.Size(28, 16);
            this.lblNNameOfFile.TabIndex = 10;
            this.lblNNameOfFile.Text = "___";
            // 
            // lblExtention
            // 
            this.lblExtention.AutoSize = true;
            this.lblExtention.Location = new System.Drawing.Point(598, 120);
            this.lblExtention.Name = "lblExtention";
            this.lblExtention.Size = new System.Drawing.Size(28, 16);
            this.lblExtention.TabIndex = 11;
            this.lblExtention.Text = "___";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Picture Box Tool";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rich Text Box Tool";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 657);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblExtention);
            this.Controls.Add(this.lblNNameOfFile);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combExtention);
            this.Controls.Add(this.fileListBox1);
            this.Controls.Add(this.dirListBox1);
            this.Controls.Add(this.driveListBox1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox driveListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox dirListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox fileListBox1;
        private System.Windows.Forms.ComboBox combExtention;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblNNameOfFile;
        private System.Windows.Forms.Label lblExtention;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

