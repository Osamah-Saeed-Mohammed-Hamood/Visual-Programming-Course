namespace Lecture7_HW6
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
            this.txtForm2 = new System.Windows.Forms.TextBox();
            this.lstText = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnShowandSendListObject = new System.Windows.Forms.Button();
            this.btnShowDialogWithConstructor = new System.Windows.Forms.Button();
            this.btnShowandSendThisForm = new System.Windows.Forms.Button();
            this.btnShowwithFunction = new System.Windows.Forms.Button();
            this.btnShowOnce = new System.Windows.Forms.Button();
            this.btnShowwithModifier = new System.Windows.Forms.Button();
            this.btnShowFormalObject = new System.Windows.Forms.Button();
            this.btnShowwithStaticVariable = new System.Windows.Forms.Button();
            this.btnShowWithOutealObject = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtForm2
            // 
            this.txtForm2.Location = new System.Drawing.Point(242, 26);
            this.txtForm2.Name = "txtForm2";
            this.txtForm2.Size = new System.Drawing.Size(511, 22);
            this.txtForm2.TabIndex = 0;
            this.txtForm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstText
            // 
            this.lstText.FormattingEnabled = true;
            this.lstText.ItemHeight = 16;
            this.lstText.Location = new System.Drawing.Point(12, 67);
            this.lstText.Name = "lstText";
            this.lstText.Size = new System.Drawing.Size(204, 180);
            this.lstText.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(261, 67);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(224, 46);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShowandSendListObject
            // 
            this.btnShowandSendListObject.Location = new System.Drawing.Point(514, 67);
            this.btnShowandSendListObject.Name = "btnShowandSendListObject";
            this.btnShowandSendListObject.Size = new System.Drawing.Size(224, 46);
            this.btnShowandSendListObject.TabIndex = 3;
            this.btnShowandSendListObject.Text = "Show and Send ListBox Object ";
            this.btnShowandSendListObject.UseVisualStyleBackColor = true;
            this.btnShowandSendListObject.Click += new System.EventHandler(this.btnShowandSendListObject_Click);
            // 
            // btnShowDialogWithConstructor
            // 
            this.btnShowDialogWithConstructor.Location = new System.Drawing.Point(261, 158);
            this.btnShowDialogWithConstructor.Name = "btnShowDialogWithConstructor";
            this.btnShowDialogWithConstructor.Size = new System.Drawing.Size(224, 46);
            this.btnShowDialogWithConstructor.TabIndex = 4;
            this.btnShowDialogWithConstructor.Text = "Show Dialog with Constructor";
            this.btnShowDialogWithConstructor.UseVisualStyleBackColor = true;
            this.btnShowDialogWithConstructor.Click += new System.EventHandler(this.btnShowDialogWithConstructor_Click);
            // 
            // btnShowandSendThisForm
            // 
            this.btnShowandSendThisForm.Location = new System.Drawing.Point(514, 158);
            this.btnShowandSendThisForm.Name = "btnShowandSendThisForm";
            this.btnShowandSendThisForm.Size = new System.Drawing.Size(224, 46);
            this.btnShowandSendThisForm.TabIndex = 5;
            this.btnShowandSendThisForm.Text = "Show and Send This Form ";
            this.btnShowandSendThisForm.UseVisualStyleBackColor = true;
            this.btnShowandSendThisForm.Click += new System.EventHandler(this.btnShowandSendThisForm_Click);
            // 
            // btnShowwithFunction
            // 
            this.btnShowwithFunction.Location = new System.Drawing.Point(261, 249);
            this.btnShowwithFunction.Name = "btnShowwithFunction";
            this.btnShowwithFunction.Size = new System.Drawing.Size(224, 46);
            this.btnShowwithFunction.TabIndex = 6;
            this.btnShowwithFunction.Text = "Show with Function";
            this.btnShowwithFunction.UseVisualStyleBackColor = true;
            this.btnShowwithFunction.Click += new System.EventHandler(this.btnShowwithFunction_Click);
            // 
            // btnShowOnce
            // 
            this.btnShowOnce.Location = new System.Drawing.Point(514, 249);
            this.btnShowOnce.Name = "btnShowOnce";
            this.btnShowOnce.Size = new System.Drawing.Size(224, 46);
            this.btnShowOnce.TabIndex = 7;
            this.btnShowOnce.Text = "Show Once ";
            this.btnShowOnce.UseVisualStyleBackColor = true;
            this.btnShowOnce.Click += new System.EventHandler(this.btnShowOnce_Click);
            // 
            // btnShowwithModifier
            // 
            this.btnShowwithModifier.Location = new System.Drawing.Point(261, 340);
            this.btnShowwithModifier.Name = "btnShowwithModifier";
            this.btnShowwithModifier.Size = new System.Drawing.Size(224, 46);
            this.btnShowwithModifier.TabIndex = 8;
            this.btnShowwithModifier.Text = "Show with Modifier";
            this.btnShowwithModifier.UseVisualStyleBackColor = true;
            this.btnShowwithModifier.Click += new System.EventHandler(this.btnShowwithModifier_Click);
            // 
            // btnShowFormalObject
            // 
            this.btnShowFormalObject.Location = new System.Drawing.Point(514, 340);
            this.btnShowFormalObject.Name = "btnShowFormalObject";
            this.btnShowFormalObject.Size = new System.Drawing.Size(224, 46);
            this.btnShowFormalObject.TabIndex = 9;
            this.btnShowFormalObject.Text = "Show Formal Object";
            this.btnShowFormalObject.UseVisualStyleBackColor = true;
            this.btnShowFormalObject.Click += new System.EventHandler(this.btnShowFormalObject_Click);
            // 
            // btnShowwithStaticVariable
            // 
            this.btnShowwithStaticVariable.Location = new System.Drawing.Point(261, 431);
            this.btnShowwithStaticVariable.Name = "btnShowwithStaticVariable";
            this.btnShowwithStaticVariable.Size = new System.Drawing.Size(224, 46);
            this.btnShowwithStaticVariable.TabIndex = 10;
            this.btnShowwithStaticVariable.Text = "Show with Static Variable ";
            this.btnShowwithStaticVariable.UseVisualStyleBackColor = true;
            this.btnShowwithStaticVariable.Click += new System.EventHandler(this.btnShowwithStaticVariable_Click);
            // 
            // btnShowWithOutealObject
            // 
            this.btnShowWithOutealObject.Location = new System.Drawing.Point(514, 431);
            this.btnShowWithOutealObject.Name = "btnShowWithOutealObject";
            this.btnShowWithOutealObject.Size = new System.Drawing.Size(224, 46);
            this.btnShowWithOutealObject.TabIndex = 11;
            this.btnShowWithOutealObject.Text = "Show without Real Object";
            this.btnShowWithOutealObject.UseVisualStyleBackColor = true;
            this.btnShowWithOutealObject.Click += new System.EventHandler(this.btnShowWithOutealObject_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(28, 448);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 42);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "رجوع";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(611, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Go To Form4   >>>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShowWithOutealObject);
            this.Controls.Add(this.btnShowwithStaticVariable);
            this.Controls.Add(this.btnShowFormalObject);
            this.Controls.Add(this.btnShowwithModifier);
            this.Controls.Add(this.btnShowOnce);
            this.Controls.Add(this.btnShowwithFunction);
            this.Controls.Add(this.btnShowandSendThisForm);
            this.Controls.Add(this.btnShowDialogWithConstructor);
            this.Controls.Add(this.btnShowandSendListObject);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstText);
            this.Controls.Add(this.txtForm2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstText;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnShowandSendListObject;
        private System.Windows.Forms.Button btnShowDialogWithConstructor;
        private System.Windows.Forms.Button btnShowandSendThisForm;
        private System.Windows.Forms.Button btnShowwithFunction;
        private System.Windows.Forms.Button btnShowOnce;
        private System.Windows.Forms.Button btnShowwithModifier;
        private System.Windows.Forms.Button btnShowFormalObject;
        private System.Windows.Forms.Button btnShowwithStaticVariable;
        private System.Windows.Forms.Button btnShowWithOutealObject;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.TextBox txtForm2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
    }
}