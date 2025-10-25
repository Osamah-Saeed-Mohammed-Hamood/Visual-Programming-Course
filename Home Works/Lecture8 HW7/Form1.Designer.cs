namespace المشروع_السابع
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
            this.txtAll = new System.Windows.Forms.TextBox();
            this.btnLengthAllText = new System.Windows.Forms.Button();
            this.btnLengthSelectText = new System.Windows.Forms.Button();
            this.btnNumOfWords = new System.Windows.Forms.Button();
            this.btnDeleteSelectText = new System.Windows.Forms.Button();
            this.btnCancelSelect = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtLengthAll = new System.Windows.Forms.TextBox();
            this.txtNumOfWords = new System.Windows.Forms.TextBox();
            this.txtLengthSelectedText = new System.Windows.Forms.TextBox();
            this.btnLengthAllTextWithoutSpace = new System.Windows.Forms.Button();
            this.btnLengthSelectedTextWithoutSpace = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchForAll = new System.Windows.Forms.Button();
            this.btnSearchForPrev = new System.Windows.Forms.Button();
            this.btnSearchForNext = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPast = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.txtPast = new System.Windows.Forms.TextBox();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowWords = new System.Windows.Forms.Button();
            this.btnShowLetters = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstLetters = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAll
            // 
            this.txtAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAll.Location = new System.Drawing.Point(16, 12);
            this.txtAll.Multiline = true;
            this.txtAll.Name = "txtAll";
            this.txtAll.Size = new System.Drawing.Size(902, 80);
            this.txtAll.TabIndex = 0;
            this.txtAll.Text = "من أهم استخدامات لغة السي شارب برمجة تطبيقات سطح المكتب وبرمجة تطبيقات الهواتف ال" +
    "ذكية وصناعة الالعاب";
            this.txtAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLengthAllText
            // 
            this.btnLengthAllText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLengthAllText.Location = new System.Drawing.Point(794, 103);
            this.btnLengthAllText.Name = "btnLengthAllText";
            this.btnLengthAllText.Size = new System.Drawing.Size(124, 41);
            this.btnLengthAllText.TabIndex = 1;
            this.btnLengthAllText.Text = "طول النص كامل";
            this.btnLengthAllText.UseVisualStyleBackColor = true;
            this.btnLengthAllText.Click += new System.EventHandler(this.btnLengthAllText_Click);
            // 
            // btnLengthSelectText
            // 
            this.btnLengthSelectText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLengthSelectText.Location = new System.Drawing.Point(647, 103);
            this.btnLengthSelectText.Name = "btnLengthSelectText";
            this.btnLengthSelectText.Size = new System.Drawing.Size(137, 41);
            this.btnLengthSelectText.TabIndex = 2;
            this.btnLengthSelectText.Text = "طول النص المحدد";
            this.btnLengthSelectText.UseVisualStyleBackColor = true;
            this.btnLengthSelectText.Click += new System.EventHandler(this.btnLengthSelectText_Click);
            // 
            // btnNumOfWords
            // 
            this.btnNumOfWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumOfWords.Location = new System.Drawing.Point(528, 103);
            this.btnNumOfWords.Name = "btnNumOfWords";
            this.btnNumOfWords.Size = new System.Drawing.Size(109, 41);
            this.btnNumOfWords.TabIndex = 3;
            this.btnNumOfWords.Text = "عدد الكلمات";
            this.btnNumOfWords.UseVisualStyleBackColor = true;
            this.btnNumOfWords.Click += new System.EventHandler(this.btnNumOfWords_Click);
            // 
            // btnDeleteSelectText
            // 
            this.btnDeleteSelectText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectText.Location = new System.Drawing.Point(381, 103);
            this.btnDeleteSelectText.Name = "btnDeleteSelectText";
            this.btnDeleteSelectText.Size = new System.Drawing.Size(137, 41);
            this.btnDeleteSelectText.TabIndex = 4;
            this.btnDeleteSelectText.Text = "حذف النص المحدد";
            this.btnDeleteSelectText.UseVisualStyleBackColor = true;
            this.btnDeleteSelectText.Click += new System.EventHandler(this.btnDeleteSelectText_Click);
            // 
            // btnCancelSelect
            // 
            this.btnCancelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSelect.Location = new System.Drawing.Point(262, 103);
            this.btnCancelSelect.Name = "btnCancelSelect";
            this.btnCancelSelect.Size = new System.Drawing.Size(109, 41);
            this.btnCancelSelect.TabIndex = 5;
            this.btnCancelSelect.Text = "إلغاء التحديد";
            this.btnCancelSelect.UseVisualStyleBackColor = true;
            this.btnCancelSelect.Click += new System.EventHandler(this.btnCancelSelect_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(183, 103);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(69, 41);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "نسخ";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCut.Location = new System.Drawing.Point(105, 103);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(68, 41);
            this.btnCut.TabIndex = 7;
            this.btnCut.Text = "قص";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(16, 103);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(79, 41);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "تنظيف";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtLengthAll
            // 
            this.txtLengthAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLengthAll.Location = new System.Drawing.Point(794, 154);
            this.txtLengthAll.Multiline = true;
            this.txtLengthAll.Name = "txtLengthAll";
            this.txtLengthAll.Size = new System.Drawing.Size(124, 41);
            this.txtLengthAll.TabIndex = 9;
            this.txtLengthAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumOfWords
            // 
            this.txtNumOfWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfWords.Location = new System.Drawing.Point(528, 154);
            this.txtNumOfWords.Multiline = true;
            this.txtNumOfWords.Name = "txtNumOfWords";
            this.txtNumOfWords.Size = new System.Drawing.Size(109, 41);
            this.txtNumOfWords.TabIndex = 10;
            this.txtNumOfWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLengthSelectedText
            // 
            this.txtLengthSelectedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLengthSelectedText.Location = new System.Drawing.Point(647, 154);
            this.txtLengthSelectedText.Multiline = true;
            this.txtLengthSelectedText.Name = "txtLengthSelectedText";
            this.txtLengthSelectedText.Size = new System.Drawing.Size(137, 41);
            this.txtLengthSelectedText.TabIndex = 11;
            this.txtLengthSelectedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLengthAllTextWithoutSpace
            // 
            this.btnLengthAllTextWithoutSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLengthAllTextWithoutSpace.Location = new System.Drawing.Point(287, 154);
            this.btnLengthAllTextWithoutSpace.Name = "btnLengthAllTextWithoutSpace";
            this.btnLengthAllTextWithoutSpace.Size = new System.Drawing.Size(231, 41);
            this.btnLengthAllTextWithoutSpace.TabIndex = 12;
            this.btnLengthAllTextWithoutSpace.Text = "طول النص كامل بدون فراغات";
            this.btnLengthAllTextWithoutSpace.UseVisualStyleBackColor = true;
            this.btnLengthAllTextWithoutSpace.Click += new System.EventHandler(this.btnLengthAllTextWithoutSpace_Click);
            // 
            // btnLengthSelectedTextWithoutSpace
            // 
            this.btnLengthSelectedTextWithoutSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLengthSelectedTextWithoutSpace.Location = new System.Drawing.Point(16, 154);
            this.btnLengthSelectedTextWithoutSpace.Name = "btnLengthSelectedTextWithoutSpace";
            this.btnLengthSelectedTextWithoutSpace.Size = new System.Drawing.Size(249, 41);
            this.btnLengthSelectedTextWithoutSpace.TabIndex = 13;
            this.btnLengthSelectedTextWithoutSpace.Text = "طول النص المحدد بدون فراغات";
            this.btnLengthSelectedTextWithoutSpace.UseVisualStyleBackColor = true;
            this.btnLengthSelectedTextWithoutSpace.Click += new System.EventHandler(this.btnLengthSelectedTextWithoutSpace_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReplace);
            this.groupBox1.Controls.Add(this.txtReplace);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(474, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(444, 180);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "استبدال";
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(151, 132);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(137, 41);
            this.btnReplace.TabIndex = 18;
            this.btnReplace.Text = "استبدال";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplace.Location = new System.Drawing.Point(151, 72);
            this.txtReplace.Multiline = true;
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(137, 41);
            this.txtReplace.TabIndex = 17;
            this.txtReplace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "النص الجديد";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchForAll);
            this.groupBox2.Controls.Add(this.btnSearchForPrev);
            this.groupBox2.Controls.Add(this.btnSearchForNext);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(444, 180);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بحث";
            // 
            // btnSearchForAll
            // 
            this.btnSearchForAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForAll.Location = new System.Drawing.Point(239, 132);
            this.btnSearchForAll.Name = "btnSearchForAll";
            this.btnSearchForAll.Size = new System.Drawing.Size(146, 41);
            this.btnSearchForAll.TabIndex = 24;
            this.btnSearchForAll.Text = "بحث عن كل الانماط";
            this.btnSearchForAll.UseVisualStyleBackColor = true;
            this.btnSearchForAll.Click += new System.EventHandler(this.btnSearchForAll_Click);
            // 
            // btnSearchForPrev
            // 
            this.btnSearchForPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForPrev.Location = new System.Drawing.Point(2, 132);
            this.btnSearchForPrev.Name = "btnSearchForPrev";
            this.btnSearchForPrev.Size = new System.Drawing.Size(121, 41);
            this.btnSearchForPrev.TabIndex = 23;
            this.btnSearchForPrev.Text = "بحث عن السابق";
            this.btnSearchForPrev.UseVisualStyleBackColor = true;
            this.btnSearchForPrev.Click += new System.EventHandler(this.btnSearchForPrev_Click);
            // 
            // btnSearchForNext
            // 
            this.btnSearchForNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForNext.Location = new System.Drawing.Point(121, 132);
            this.btnSearchForNext.Name = "btnSearchForNext";
            this.btnSearchForNext.Size = new System.Drawing.Size(121, 41);
            this.btnSearchForNext.TabIndex = 22;
            this.btnSearchForNext.Text = "بحث عن التالي";
            this.btnSearchForNext.UseVisualStyleBackColor = true;
            this.btnSearchForNext.Click += new System.EventHandler(this.btnSearchForNext_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(383, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 41);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(154, 72);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 41);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "النص المراد البحث عنه";
            // 
            // btnPast
            // 
            this.btnPast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPast.Location = new System.Drawing.Point(849, 429);
            this.btnPast.Name = "btnPast";
            this.btnPast.Size = new System.Drawing.Size(69, 41);
            this.btnPast.TabIndex = 16;
            this.btnPast.Text = "لصق";
            this.btnPast.UseVisualStyleBackColor = true;
            this.btnPast.Click += new System.EventHandler(this.btnPast_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(474, 429);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(69, 41);
            this.btnUndo.TabIndex = 17;
            this.btnUndo.Text = "تراجع";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // txtPast
            // 
            this.txtPast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPast.Location = new System.Drawing.Point(474, 486);
            this.txtPast.Multiline = true;
            this.txtPast.Name = "txtPast";
            this.txtPast.Size = new System.Drawing.Size(444, 180);
            this.txtPast.TabIndex = 18;
            // 
            // lstWords
            // 
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 16;
            this.lstWords.Location = new System.Drawing.Point(16, 518);
            this.lstWords.Name = "lstWords";
            this.lstWords.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstWords.Size = new System.Drawing.Size(208, 148);
            this.lstWords.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "أحرف الكلمة المحددة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "كلمات الجملة المحددة";
            // 
            // btnShowWords
            // 
            this.btnShowWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowWords.Location = new System.Drawing.Point(68, 460);
            this.btnShowWords.Name = "btnShowWords";
            this.btnShowWords.Size = new System.Drawing.Size(104, 41);
            this.btnShowWords.TabIndex = 23;
            this.btnShowWords.Text = "عرض";
            this.btnShowWords.UseVisualStyleBackColor = true;
            this.btnShowWords.Click += new System.EventHandler(this.btnShowWords_Click);
            // 
            // btnShowLetters
            // 
            this.btnShowLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLetters.Location = new System.Drawing.Point(304, 460);
            this.btnShowLetters.Name = "btnShowLetters";
            this.btnShowLetters.Size = new System.Drawing.Size(104, 41);
            this.btnShowLetters.TabIndex = 24;
            this.btnShowLetters.Text = "عرض ";
            this.btnShowLetters.UseVisualStyleBackColor = true;
            this.btnShowLetters.Click += new System.EventHandler(this.btnShowLetters_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(770, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "GoTo Form2    >>>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstLetters
            // 
            this.lstLetters.FormattingEnabled = true;
            this.lstLetters.ItemHeight = 16;
            this.lstLetters.Location = new System.Drawing.Point(252, 518);
            this.lstLetters.Name = "lstLetters";
            this.lstLetters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstLetters.Size = new System.Drawing.Size(208, 148);
            this.lstLetters.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 743);
            this.Controls.Add(this.lstLetters);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowLetters);
            this.Controls.Add(this.btnShowWords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstWords);
            this.Controls.Add(this.txtPast);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnPast);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLengthSelectedTextWithoutSpace);
            this.Controls.Add(this.btnLengthAllTextWithoutSpace);
            this.Controls.Add(this.txtLengthSelectedText);
            this.Controls.Add(this.txtNumOfWords);
            this.Controls.Add(this.txtLengthAll);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnCancelSelect);
            this.Controls.Add(this.btnDeleteSelectText);
            this.Controls.Add(this.btnNumOfWords);
            this.Controls.Add(this.btnLengthSelectText);
            this.Controls.Add(this.btnLengthAllText);
            this.Controls.Add(this.txtAll);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAll;
        private System.Windows.Forms.Button btnLengthAllText;
        private System.Windows.Forms.Button btnLengthSelectText;
        private System.Windows.Forms.Button btnNumOfWords;
        private System.Windows.Forms.Button btnDeleteSelectText;
        private System.Windows.Forms.Button btnCancelSelect;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtLengthAll;
        private System.Windows.Forms.TextBox txtNumOfWords;
        private System.Windows.Forms.TextBox txtLengthSelectedText;
        private System.Windows.Forms.Button btnLengthAllTextWithoutSpace;
        private System.Windows.Forms.Button btnLengthSelectedTextWithoutSpace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchForPrev;
        private System.Windows.Forms.Button btnSearchForNext;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPast;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.TextBox txtPast;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowWords;
        private System.Windows.Forms.Button btnShowLetters;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstLetters;
        private System.Windows.Forms.Button btnSearchForAll;
    }
}

