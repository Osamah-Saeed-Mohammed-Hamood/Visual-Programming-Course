namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentAvg = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtNumOfStudents = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lstInformation = new System.Windows.Forms.ListBox();
            this.btnForm4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "أدخل المعدل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "أدخل الاسم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "عدد الطلاب";
            // 
            // txtStudentAvg
            // 
            this.txtStudentAvg.Location = new System.Drawing.Point(12, 91);
            this.txtStudentAvg.Name = "txtStudentAvg";
            this.txtStudentAvg.Size = new System.Drawing.Size(164, 22);
            this.txtStudentAvg.TabIndex = 3;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(203, 91);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(234, 22);
            this.txtStudentName.TabIndex = 4;
            this.txtStudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentName_KeyPress);
            // 
            // txtNumOfStudents
            // 
            this.txtNumOfStudents.Location = new System.Drawing.Point(464, 91);
            this.txtNumOfStudents.Name = "txtNumOfStudents";
            this.txtNumOfStudents.Size = new System.Drawing.Size(119, 22);
            this.txtNumOfStudents.TabIndex = 5;
            this.txtNumOfStudents.TextChanged += new System.EventHandler(this.txtNumOfStudents_TextChanged);
            this.txtNumOfStudents.Leave += new System.EventHandler(this.txtNumOfStudents_Leave);
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.Color.Gray;
            this.btnAddToList.Location = new System.Drawing.Point(150, 134);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(328, 36);
            this.btnAddToList.TabIndex = 6;
            this.btnAddToList.Text = "إضافة للقائمة";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Gray;
            this.btnSort.Location = new System.Drawing.Point(150, 396);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(328, 36);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "ترتيب العناصر ";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lstInformation
            // 
            this.lstInformation.FormattingEnabled = true;
            this.lstInformation.ItemHeight = 16;
            this.lstInformation.Location = new System.Drawing.Point(150, 193);
            this.lstInformation.Name = "lstInformation";
            this.lstInformation.Size = new System.Drawing.Size(328, 180);
            this.lstInformation.TabIndex = 8;
            // 
            // btnForm4
            // 
            this.btnForm4.BackColor = System.Drawing.Color.LightGray;
            this.btnForm4.Location = new System.Drawing.Point(238, 461);
            this.btnForm4.Name = "btnForm4";
            this.btnForm4.Size = new System.Drawing.Size(156, 50);
            this.btnForm4.TabIndex = 11;
            this.btnForm4.Text = "Go To Form4   >>>";
            this.btnForm4.UseVisualStyleBackColor = false;
            this.btnForm4.Click += new System.EventHandler(this.btnForm4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(605, 519);
            this.Controls.Add(this.btnForm4);
            this.Controls.Add(this.lstInformation);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.txtNumOfStudents);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentAvg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentAvg;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtNumOfStudents;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lstInformation;
        private System.Windows.Forms.Button btnForm4;
    }
}