namespace أسامة_سعيد_محمد_حمود_سعيد
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
            this.pictureImageChoosen = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpLevel = new System.Windows.Forms.GroupBox();
            this.rdoLevel4 = new System.Windows.Forms.RadioButton();
            this.rdoLevel3 = new System.Windows.Forms.RadioButton();
            this.rdoLevel1 = new System.Windows.Forms.RadioButton();
            this.rdoLevel2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboPart = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImageChoosen)).BeginInit();
            this.grpLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureImageChoosen
            // 
            this.pictureImageChoosen.Location = new System.Drawing.Point(29, 60);
            this.pictureImageChoosen.Name = "pictureImageChoosen";
            this.pictureImageChoosen.Size = new System.Drawing.Size(234, 241);
            this.pictureImageChoosen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureImageChoosen.TabIndex = 23;
            this.pictureImageChoosen.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.LightGray;
            this.btnChooseImage.Location = new System.Drawing.Point(96, 319);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(100, 43);
            this.btnChooseImage.TabIndex = 22;
            this.btnChooseImage.Text = "إختيار صورة";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Location = new System.Drawing.Point(601, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(232, 43);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpLevel
            // 
            this.grpLevel.BackColor = System.Drawing.Color.LightGray;
            this.grpLevel.Controls.Add(this.rdoLevel4);
            this.grpLevel.Controls.Add(this.rdoLevel3);
            this.grpLevel.Controls.Add(this.rdoLevel1);
            this.grpLevel.Controls.Add(this.rdoLevel2);
            this.grpLevel.Location = new System.Drawing.Point(315, 60);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpLevel.Size = new System.Drawing.Size(99, 185);
            this.grpLevel.TabIndex = 21;
            this.grpLevel.TabStop = false;
            this.grpLevel.Text = "المستوى";
            // 
            // rdoLevel4
            // 
            this.rdoLevel4.AutoSize = true;
            this.rdoLevel4.Location = new System.Drawing.Point(22, 143);
            this.rdoLevel4.Name = "rdoLevel4";
            this.rdoLevel4.Size = new System.Drawing.Size(55, 20);
            this.rdoLevel4.TabIndex = 14;
            this.rdoLevel4.TabStop = true;
            this.rdoLevel4.Text = "الرابع";
            this.rdoLevel4.UseVisualStyleBackColor = true;
            // 
            // rdoLevel3
            // 
            this.rdoLevel3.AutoSize = true;
            this.rdoLevel3.Location = new System.Drawing.Point(22, 108);
            this.rdoLevel3.Name = "rdoLevel3";
            this.rdoLevel3.Size = new System.Drawing.Size(55, 20);
            this.rdoLevel3.TabIndex = 13;
            this.rdoLevel3.TabStop = true;
            this.rdoLevel3.Text = "الثالث";
            this.rdoLevel3.UseVisualStyleBackColor = true;
            // 
            // rdoLevel1
            // 
            this.rdoLevel1.AutoSize = true;
            this.rdoLevel1.Location = new System.Drawing.Point(26, 38);
            this.rdoLevel1.Name = "rdoLevel1";
            this.rdoLevel1.Size = new System.Drawing.Size(51, 20);
            this.rdoLevel1.TabIndex = 11;
            this.rdoLevel1.TabStop = true;
            this.rdoLevel1.Text = "الأول";
            this.rdoLevel1.UseVisualStyleBackColor = true;
            // 
            // rdoLevel2
            // 
            this.rdoLevel2.AutoSize = true;
            this.rdoLevel2.Location = new System.Drawing.Point(20, 73);
            this.rdoLevel2.Name = "rdoLevel2";
            this.rdoLevel2.Size = new System.Drawing.Size(57, 20);
            this.rdoLevel2.TabIndex = 12;
            this.rdoLevel2.TabStop = true;
            this.rdoLevel2.Text = "الثاني";
            this.rdoLevel2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "القسم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(915, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "اسم الطالب";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(686, 97);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(286, 22);
            this.txtStudentName.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(29, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 43);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboPart
            // 
            this.comboPart.FormattingEnabled = true;
            this.comboPart.Location = new System.Drawing.Point(437, 97);
            this.comboPart.Name = "comboPart";
            this.comboPart.Size = new System.Drawing.Size(226, 24);
            this.comboPart.TabIndex = 25;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(995, 458);
            this.Controls.Add(this.comboPart);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureImageChoosen);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentName);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImageChoosen)).EndInit();
            this.grpLevel.ResumeLayout(false);
            this.grpLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureImageChoosen;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpLevel;
        private System.Windows.Forms.RadioButton rdoLevel4;
        private System.Windows.Forms.RadioButton rdoLevel3;
        private System.Windows.Forms.RadioButton rdoLevel1;
        private System.Windows.Forms.RadioButton rdoLevel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboPart;
    }
}