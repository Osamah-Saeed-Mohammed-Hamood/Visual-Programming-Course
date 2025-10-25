namespace Draw
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
            this.pnlDrawTextBox = new System.Windows.Forms.Panel();
            this.btnForm4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlDrawTextBox
            // 
            this.pnlDrawTextBox.Location = new System.Drawing.Point(288, 78);
            this.pnlDrawTextBox.Name = "pnlDrawTextBox";
            this.pnlDrawTextBox.Size = new System.Drawing.Size(200, 100);
            this.pnlDrawTextBox.TabIndex = 0;
            // 
            // btnForm4
            // 
            this.btnForm4.BackColor = System.Drawing.Color.Silver;
            this.btnForm4.Location = new System.Drawing.Point(640, 455);
            this.btnForm4.Name = "btnForm4";
            this.btnForm4.Size = new System.Drawing.Size(148, 41);
            this.btnForm4.TabIndex = 11;
            this.btnForm4.Text = "Go To Form4  >>>";
            this.btnForm4.UseVisualStyleBackColor = false;
            this.btnForm4.Click += new System.EventHandler(this.btnForm4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "الأعمدة";
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(271, 464);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(100, 22);
            this.txtColumn.TabIndex = 9;
            this.txtColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(472, 459);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(102, 32);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "إنشاء";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "الصفوف";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(43, 464);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(100, 22);
            this.txtRow.TabIndex = 12;
            this.txtRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.btnForm4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColumn);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlDrawTextBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawTextBox;
        private System.Windows.Forms.Button btnForm4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRow;
    }
}