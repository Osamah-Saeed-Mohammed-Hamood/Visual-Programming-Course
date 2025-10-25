namespace أسامة_سعيد_محمد_حمود_سعيد
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اللإدارةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةقسمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إغلاقالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpStudentInformation = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstName = new System.Windows.Forms.ListBox();
            this.lstLevel = new System.Windows.Forms.ListBox();
            this.lstPart = new System.Windows.Forms.ListBox();
            this.pictureImageChoosen = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpLevel = new System.Windows.Forms.GroupBox();
            this.rdoLevel4 = new System.Windows.Forms.RadioButton();
            this.rdoLevel3 = new System.Windows.Forms.RadioButton();
            this.rdoLevel1 = new System.Windows.Forms.RadioButton();
            this.rdoLevel2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboPart = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.grpStudentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImageChoosen)).BeginInit();
            this.grpLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightYellow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اللإدارةToolStripMenuItem,
            this.إغلاقToolStripMenuItem,
            this.إغلاقالكلToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // اللإدارةToolStripMenuItem
            // 
            this.اللإدارةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إضافةقسمToolStripMenuItem,
            this.المستخدمينToolStripMenuItem});
            this.اللإدارةToolStripMenuItem.Name = "اللإدارةToolStripMenuItem";
            this.اللإدارةToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.اللإدارةToolStripMenuItem.Text = "اللإدارة";
            // 
            // إضافةقسمToolStripMenuItem
            // 
            this.إضافةقسمToolStripMenuItem.Name = "إضافةقسمToolStripMenuItem";
            this.إضافةقسمToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.إضافةقسمToolStripMenuItem.Text = "إضافة قسم";
            this.إضافةقسمToolStripMenuItem.Click += new System.EventHandler(this.إضافةقسمToolStripMenuItem_Click);
            // 
            // المستخدمينToolStripMenuItem
            // 
            this.المستخدمينToolStripMenuItem.Name = "المستخدمينToolStripMenuItem";
            this.المستخدمينToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.المستخدمينToolStripMenuItem.Text = "المستخدمين";
            this.المستخدمينToolStripMenuItem.Click += new System.EventHandler(this.المستخدمينToolStripMenuItem_Click);
            // 
            // إغلاقToolStripMenuItem
            // 
            this.إغلاقToolStripMenuItem.Name = "إغلاقToolStripMenuItem";
            this.إغلاقToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.إغلاقToolStripMenuItem.Text = "إغلاق";
            this.إغلاقToolStripMenuItem.Click += new System.EventHandler(this.إغلاقToolStripMenuItem_Click);
            // 
            // إغلاقالكلToolStripMenuItem
            // 
            this.إغلاقالكلToolStripMenuItem.Name = "إغلاقالكلToolStripMenuItem";
            this.إغلاقالكلToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.إغلاقالكلToolStripMenuItem.Text = "إغلاق الكل";
            this.إغلاقالكلToolStripMenuItem.Click += new System.EventHandler(this.إغلاقالكلToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grpStudentInformation
            // 
            this.grpStudentInformation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpStudentInformation.Controls.Add(this.comboPart);
            this.grpStudentInformation.Controls.Add(this.label5);
            this.grpStudentInformation.Controls.Add(this.label4);
            this.grpStudentInformation.Controls.Add(this.label3);
            this.grpStudentInformation.Controls.Add(this.lstName);
            this.grpStudentInformation.Controls.Add(this.lstLevel);
            this.grpStudentInformation.Controls.Add(this.lstPart);
            this.grpStudentInformation.Controls.Add(this.pictureImageChoosen);
            this.grpStudentInformation.Controls.Add(this.btnChooseImage);
            this.grpStudentInformation.Controls.Add(this.btnAdd);
            this.grpStudentInformation.Controls.Add(this.grpLevel);
            this.grpStudentInformation.Controls.Add(this.label2);
            this.grpStudentInformation.Controls.Add(this.label1);
            this.grpStudentInformation.Controls.Add(this.txtStudentName);
            this.grpStudentInformation.Location = new System.Drawing.Point(19, 100);
            this.grpStudentInformation.Name = "grpStudentInformation";
            this.grpStudentInformation.Size = new System.Drawing.Size(991, 486);
            this.grpStudentInformation.TabIndex = 2;
            this.grpStudentInformation.TabStop = false;
            this.grpStudentInformation.Text = "بيانات الطالب";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "المســــــــتــوى";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "القســــــــــــــــــــــــــــــم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(811, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "الاســــــــــــــــــــــــــم";
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.ItemHeight = 16;
            this.lstName.Location = new System.Drawing.Point(757, 273);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(217, 196);
            this.lstName.TabIndex = 16;
            // 
            // lstLevel
            // 
            this.lstLevel.FormattingEnabled = true;
            this.lstLevel.ItemHeight = 16;
            this.lstLevel.Location = new System.Drawing.Point(281, 273);
            this.lstLevel.Name = "lstLevel";
            this.lstLevel.Size = new System.Drawing.Size(217, 196);
            this.lstLevel.TabIndex = 15;
            // 
            // lstPart
            // 
            this.lstPart.FormattingEnabled = true;
            this.lstPart.ItemHeight = 16;
            this.lstPart.Location = new System.Drawing.Point(519, 273);
            this.lstPart.Name = "lstPart";
            this.lstPart.Size = new System.Drawing.Size(217, 196);
            this.lstPart.TabIndex = 14;
            // 
            // pictureImageChoosen
            // 
            this.pictureImageChoosen.Location = new System.Drawing.Point(16, 50);
            this.pictureImageChoosen.Name = "pictureImageChoosen";
            this.pictureImageChoosen.Size = new System.Drawing.Size(234, 309);
            this.pictureImageChoosen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureImageChoosen.TabIndex = 12;
            this.pictureImageChoosen.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.LightYellow;
            this.btnChooseImage.Location = new System.Drawing.Point(83, 379);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(100, 43);
            this.btnChooseImage.TabIndex = 11;
            this.btnChooseImage.Text = "إختيار صورة";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightYellow;
            this.btnAdd.Location = new System.Drawing.Point(597, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(232, 43);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpLevel
            // 
            this.grpLevel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpLevel.Controls.Add(this.rdoLevel4);
            this.grpLevel.Controls.Add(this.rdoLevel3);
            this.grpLevel.Controls.Add(this.rdoLevel1);
            this.grpLevel.Controls.Add(this.rdoLevel2);
            this.grpLevel.Location = new System.Drawing.Point(302, 50);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.Size = new System.Drawing.Size(99, 177);
            this.grpLevel.TabIndex = 10;
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
            this.rdoLevel1.CheckedChanged += new System.EventHandler(this.rdoLevel1_CheckedChanged);
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
            this.label2.Location = new System.Drawing.Point(618, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "القسم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم الطالب";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(673, 87);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(286, 22);
            this.txtStudentName.TabIndex = 7;
            this.txtStudentName.Click += new System.EventHandler(this.txtStudentName_Click);
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Red;
            this.lblUserName.Location = new System.Drawing.Point(587, 53);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(29, 20);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "__";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(858, 592);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 43);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(74, 592);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 43);
            this.btnClose.TabIndex = 5;
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
            this.comboPart.Location = new System.Drawing.Point(424, 84);
            this.comboPart.Name = "comboPart";
            this.comboPart.Size = new System.Drawing.Size(226, 24);
            this.comboPart.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1022, 654);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.grpStudentInformation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpStudentInformation.ResumeLayout(false);
            this.grpStudentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImageChoosen)).EndInit();
            this.grpLevel.ResumeLayout(false);
            this.grpLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grpStudentInformation;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem اللإدارةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إغلاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إغلاقالكلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ListBox lstLevel;
        private System.Windows.Forms.ListBox lstPart;
        private System.Windows.Forms.PictureBox pictureImageChoosen;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpLevel;
        private System.Windows.Forms.RadioButton rdoLevel1;
        private System.Windows.Forms.RadioButton rdoLevel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdoLevel4;
        private System.Windows.Forms.RadioButton rdoLevel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem إضافةقسمToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المستخدمينToolStripMenuItem;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPart;
    }
}