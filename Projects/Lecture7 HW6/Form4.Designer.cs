namespace Lecture7_HW6
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
            this.menuOperation = new System.Windows.Forms.MenuStrip();
            this.العملياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSum = new System.Windows.Forms.ToolStripMenuItem();
            this.mnueSub = new System.Windows.Forms.ToolStripMenuItem();
            this.mnueMult = new System.Windows.Forms.ToolStripMenuItem();
            this.mnueDiv = new System.Windows.Forms.ToolStripMenuItem();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.menuOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOperation
            // 
            this.menuOperation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.العملياتToolStripMenuItem,
            this.ملفToolStripMenuItem});
            this.menuOperation.Location = new System.Drawing.Point(0, 0);
            this.menuOperation.Name = "menuOperation";
            this.menuOperation.Size = new System.Drawing.Size(365, 28);
            this.menuOperation.TabIndex = 0;
            this.menuOperation.Text = "menuStrip1";
            // 
            // العملياتToolStripMenuItem
            // 
            this.العملياتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSum,
            this.mnueSub,
            this.mnueMult,
            this.mnueDiv});
            this.العملياتToolStripMenuItem.Name = "العملياتToolStripMenuItem";
            this.العملياتToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.العملياتToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.العملياتToolStripMenuItem.Text = "العمليات";
            // 
            // menuSum
            // 
            this.menuSum.Name = "menuSum";
            this.menuSum.Size = new System.Drawing.Size(224, 26);
            this.menuSum.Text = "جمع";
            this.menuSum.Click += new System.EventHandler(this.menuSum_Click);
            // 
            // mnueSub
            // 
            this.mnueSub.Name = "mnueSub";
            this.mnueSub.Size = new System.Drawing.Size(224, 26);
            this.mnueSub.Text = "طرح";
            this.mnueSub.Click += new System.EventHandler(this.mnueSub_Click);
            // 
            // mnueMult
            // 
            this.mnueMult.Name = "mnueMult";
            this.mnueMult.Size = new System.Drawing.Size(224, 26);
            this.mnueMult.Text = "ضرب";
            this.mnueMult.Click += new System.EventHandler(this.mnueMult_Click);
            // 
            // mnueDiv
            // 
            this.mnueDiv.Name = "mnueDiv";
            this.mnueDiv.Size = new System.Drawing.Size(224, 26);
            this.mnueDiv.Text = "قسمة";
            this.mnueDiv.Click += new System.EventHandler(this.mnueDiv_Click);
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(79, 48);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(176, 43);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "جمع";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(79, 101);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(176, 43);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "طرح";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(79, 154);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(176, 43);
            this.btnMult.TabIndex = 3;
            this.btnMult.Text = "ضرب";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(79, 207);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(176, 43);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Text = "قسمة";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 261);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.menuOperation);
            this.MainMenuStrip = this.menuOperation;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form4";
            this.menuOperation.ResumeLayout(false);
            this.menuOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOperation;
        private System.Windows.Forms.ToolStripMenuItem العملياتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSum;
        private System.Windows.Forms.ToolStripMenuItem mnueSub;
        private System.Windows.Forms.ToolStripMenuItem mnueMult;
        private System.Windows.Forms.ToolStripMenuItem mnueDiv;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
    }
}