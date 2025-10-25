namespace Lecture10_HW9
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.إدارةبياناتالطلابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnueCloseAllFormsWithMainForm = new System.Windows.Forms.ToolStripMenuItem();
            this.minuAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnueClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnueCloseAllForms = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إدارةبياناتالطلابToolStripMenuItem,
            this.ملفToolStripMenuItem,
            this.mnueCloseAllFormsWithMainForm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(617, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // إدارةبياناتالطلابToolStripMenuItem
            // 
            this.إدارةبياناتالطلابToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minuAddStudent,
            this.menuShowStudents});
            this.إدارةبياناتالطلابToolStripMenuItem.Name = "إدارةبياناتالطلابToolStripMenuItem";
            this.إدارةبياناتالطلابToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.إدارةبياناتالطلابToolStripMenuItem.Text = "إدارة بيانات الطلاب";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnueClose,
            this.mnueCloseAllForms});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // mnueCloseAllFormsWithMainForm
            // 
            this.mnueCloseAllFormsWithMainForm.Name = "mnueCloseAllFormsWithMainForm";
            this.mnueCloseAllFormsWithMainForm.Size = new System.Drawing.Size(55, 24);
            this.mnueCloseAllFormsWithMainForm.Text = "خروج";
            this.mnueCloseAllFormsWithMainForm.Click += new System.EventHandler(this.mnueCloseAllFormsWithMainForm_Click);
            // 
            // minuAddStudent
            // 
            this.minuAddStudent.Name = "minuAddStudent";
            this.minuAddStudent.Size = new System.Drawing.Size(224, 26);
            this.minuAddStudent.Text = "إضافة طالب";
            this.minuAddStudent.Click += new System.EventHandler(this.minuAddStudent_Click);
            // 
            // menuShowStudents
            // 
            this.menuShowStudents.Name = "menuShowStudents";
            this.menuShowStudents.Size = new System.Drawing.Size(224, 26);
            this.menuShowStudents.Text = "عرض الطلاب ";
            this.menuShowStudents.Click += new System.EventHandler(this.menuShowStudents_Click);
            // 
            // mnueClose
            // 
            this.mnueClose.Name = "mnueClose";
            this.mnueClose.Size = new System.Drawing.Size(224, 26);
            this.mnueClose.Text = "إغلاق ";
            this.mnueClose.Click += new System.EventHandler(this.mnueClose_Click);
            // 
            // mnueCloseAllForms
            // 
            this.mnueCloseAllForms.Name = "mnueCloseAllForms";
            this.mnueCloseAllForms.Size = new System.Drawing.Size(224, 26);
            this.mnueCloseAllForms.Text = "إغلاق الكل ";
            this.mnueCloseAllForms.Click += new System.EventHandler(this.mnueCloseAllForms_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 267);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem إدارةبياناتالطلابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minuAddStudent;
        private System.Windows.Forms.ToolStripMenuItem menuShowStudents;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnueClose;
        private System.Windows.Forms.ToolStripMenuItem mnueCloseAllForms;
        private System.Windows.Forms.ToolStripMenuItem mnueCloseAllFormsWithMainForm;
    }
}