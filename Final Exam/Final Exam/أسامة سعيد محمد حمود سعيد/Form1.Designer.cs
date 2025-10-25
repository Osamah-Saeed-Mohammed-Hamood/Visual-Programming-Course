namespace أسامة_سعيد_محمد_حمود_سعيد
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
            this.grpSignIn = new System.Windows.Forms.GroupBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.comboUserName = new System.Windows.Forms.ComboBox();
            this.linkNewSign = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCreateNewUser = new System.Windows.Forms.GroupBox();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.txtPasswordIsOK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateNewPassword = new System.Windows.Forms.Button();
            this.txtPasswordNewUser = new System.Windows.Forms.TextBox();
            this.linkSignIn = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpSignIn.SuspendLayout();
            this.grpCreateNewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSignIn
            // 
            this.grpSignIn.BackColor = System.Drawing.Color.LightYellow;
            this.grpSignIn.Controls.Add(this.btnSignIn);
            this.grpSignIn.Controls.Add(this.txtPassword);
            this.grpSignIn.Controls.Add(this.comboUserName);
            this.grpSignIn.Controls.Add(this.linkNewSign);
            this.grpSignIn.Controls.Add(this.label2);
            this.grpSignIn.Controls.Add(this.label1);
            this.grpSignIn.Location = new System.Drawing.Point(14, 12);
            this.grpSignIn.Name = "grpSignIn";
            this.grpSignIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpSignIn.Size = new System.Drawing.Size(388, 376);
            this.grpSignIn.TabIndex = 0;
            this.grpSignIn.TabStop = false;
            this.grpSignIn.Text = "تسجيل الدخول";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSignIn.Location = new System.Drawing.Point(13, 241);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSignIn.Size = new System.Drawing.Size(343, 32);
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.Text = "تسجيل الدخول";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(13, 157);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(254, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboUserName
            // 
            this.comboUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUserName.FormattingEnabled = true;
            this.comboUserName.Location = new System.Drawing.Point(13, 69);
            this.comboUserName.Name = "comboUserName";
            this.comboUserName.Size = new System.Drawing.Size(254, 24);
            this.comboUserName.TabIndex = 4;
            // 
            // linkNewSign
            // 
            this.linkNewSign.AutoSize = true;
            this.linkNewSign.Location = new System.Drawing.Point(138, 315);
            this.linkNewSign.Name = "linkNewSign";
            this.linkNewSign.Size = new System.Drawing.Size(93, 16);
            this.linkNewSign.TabIndex = 3;
            this.linkNewSign.TabStop = true;
            this.linkNewSign.Text = "إنشاء حساب جديد";
            this.linkNewSign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNewSign_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 157);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = ":  كلمة المرور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 69);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = ":  اسم المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(133, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم الطالب  :  أسامة سعيد محمد حمود سعيد";
            // 
            // grpCreateNewUser
            // 
            this.grpCreateNewUser.BackColor = System.Drawing.Color.LightYellow;
            this.grpCreateNewUser.Controls.Add(this.txtNewUserName);
            this.grpCreateNewUser.Controls.Add(this.txtPasswordIsOK);
            this.grpCreateNewUser.Controls.Add(this.label6);
            this.grpCreateNewUser.Controls.Add(this.btnCreateNewPassword);
            this.grpCreateNewUser.Controls.Add(this.txtPasswordNewUser);
            this.grpCreateNewUser.Controls.Add(this.linkSignIn);
            this.grpCreateNewUser.Controls.Add(this.label4);
            this.grpCreateNewUser.Controls.Add(this.label5);
            this.grpCreateNewUser.Location = new System.Drawing.Point(437, 12);
            this.grpCreateNewUser.Name = "grpCreateNewUser";
            this.grpCreateNewUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpCreateNewUser.Size = new System.Drawing.Size(388, 376);
            this.grpCreateNewUser.TabIndex = 3;
            this.grpCreateNewUser.TabStop = false;
            this.grpCreateNewUser.Text = "إنشاء حساب جديد";
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Location = new System.Drawing.Point(7, 69);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(242, 22);
            this.txtNewUserName.TabIndex = 9;
            // 
            // txtPasswordIsOK
            // 
            this.txtPasswordIsOK.Location = new System.Drawing.Point(7, 177);
            this.txtPasswordIsOK.Name = "txtPasswordIsOK";
            this.txtPasswordIsOK.Size = new System.Drawing.Size(246, 22);
            this.txtPasswordIsOK.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 177);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = ":  تأكيد كلمة المرور ";
            // 
            // btnCreateNewPassword
            // 
            this.btnCreateNewPassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCreateNewPassword.Location = new System.Drawing.Point(14, 241);
            this.btnCreateNewPassword.Name = "btnCreateNewPassword";
            this.btnCreateNewPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateNewPassword.Size = new System.Drawing.Size(343, 32);
            this.btnCreateNewPassword.TabIndex = 6;
            this.btnCreateNewPassword.Text = "إنساء حساب جديد";
            this.btnCreateNewPassword.UseVisualStyleBackColor = false;
            this.btnCreateNewPassword.Click += new System.EventHandler(this.btnCreateNewPassword_Click);
            // 
            // txtPasswordNewUser
            // 
            this.txtPasswordNewUser.Location = new System.Drawing.Point(7, 123);
            this.txtPasswordNewUser.Name = "txtPasswordNewUser";
            this.txtPasswordNewUser.Size = new System.Drawing.Size(242, 22);
            this.txtPasswordNewUser.TabIndex = 5;
            // 
            // linkSignIn
            // 
            this.linkSignIn.AutoSize = true;
            this.linkSignIn.Location = new System.Drawing.Point(139, 315);
            this.linkSignIn.Name = "linkSignIn";
            this.linkSignIn.Size = new System.Drawing.Size(74, 16);
            this.linkSignIn.TabIndex = 3;
            this.linkSignIn.TabStop = true;
            this.linkSignIn.Text = "تسجيل الدخول";
            this.linkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignIn_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 123);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = ":  كلمة المرور";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 69);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = ":  اسم المستخدم";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.grpCreateNewUser);
            this.Controls.Add(this.grpSignIn);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSignIn.ResumeLayout(false);
            this.grpSignIn.PerformLayout();
            this.grpCreateNewUser.ResumeLayout(false);
            this.grpCreateNewUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSignIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox comboUserName;
        private System.Windows.Forms.LinkLabel linkNewSign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.GroupBox grpCreateNewUser;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.TextBox txtPasswordIsOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateNewPassword;
        private System.Windows.Forms.TextBox txtPasswordNewUser;
        private System.Windows.Forms.LinkLabel linkSignIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

