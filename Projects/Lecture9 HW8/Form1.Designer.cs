namespace المشروع_الثامن
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAddNum = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdoEven = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteSelectElementLst1 = new System.Windows.Forms.Button();
            this.btnDeleteAllLst1 = new System.Windows.Forms.Button();
            this.rdoSortAllLst1 = new System.Windows.Forms.RadioButton();
            this.rdoSortSelectElement = new System.Windows.Forms.RadioButton();
            this.rodReverseLst1 = new System.Windows.Forms.RadioButton();
            this.rdoMoveReverse = new System.Windows.Forms.RadioButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.rdoOdd = new System.Windows.Forms.RadioButton();
            this.rdoPrime = new System.Windows.Forms.RadioButton();
            this.btnMoveSelect = new System.Windows.Forms.Button();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.btnOpenAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteSelectElementLst2 = new System.Windows.Forms.Button();
            this.btnDeleteAllLst2 = new System.Windows.Forms.Button();
            this.rodReverseLst2 = new System.Windows.Forms.RadioButton();
            this.rdoSortAllLst2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoSelectAll = new System.Windows.Forms.RadioButton();
            this.rdoRemoveSelect = new System.Windows.Forms.RadioButton();
            this.txtDoSelect = new System.Windows.Forms.TextBox();
            this.txtRemoveSelect = new System.Windows.Forms.TextBox();
            this.txtRemoveSelectByIndex = new System.Windows.Forms.TextBox();
            this.txtNumElements = new System.Windows.Forms.TextBox();
            this.txtNumSelectElements = new System.Windows.Forms.TextBox();
            this.txtNoneSelectElement = new System.Windows.Forms.TextBox();
            this.btnNumSelectElements = new System.Windows.Forms.Button();
            this.btnNumElements = new System.Windows.Forms.Button();
            this.btnDoSelect = new System.Windows.Forms.Button();
            this.btnRemoveSelect = new System.Windows.Forms.Button();
            this.btnRemoveSelectByIndex = new System.Windows.Forms.Button();
            this.btnNoneSelectElement = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "أدخل العدد";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(231, 31);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdd.Size = new System.Drawing.Size(160, 22);
            this.txtAdd.TabIndex = 1;
            this.txtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddNum
            // 
            this.btnAddNum.Location = new System.Drawing.Point(401, 23);
            this.btnAddNum.Name = "btnAddNum";
            this.btnAddNum.Size = new System.Drawing.Size(87, 38);
            this.btnAddNum.TabIndex = 2;
            this.btnAddNum.Text = "إضافة";
            this.btnAddNum.UseVisualStyleBackColor = true;
            this.btnAddNum.Click += new System.EventHandler(this.btnAddNum_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(382, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(163, 180);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rdoEven
            // 
            this.rdoEven.AutoSize = true;
            this.rdoEven.Location = new System.Drawing.Point(282, 103);
            this.rdoEven.Name = "rdoEven";
            this.rdoEven.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoEven.Size = new System.Drawing.Size(58, 20);
            this.rdoEven.TabIndex = 4;
            this.rdoEven.TabStop = true;
            this.rdoEven.Text = "زوجي";
            this.rdoEven.UseVisualStyleBackColor = true;
            this.rdoEven.CheckedChanged += new System.EventHandler(this.rdoEven_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteSelectElementLst1);
            this.groupBox1.Controls.Add(this.btnDeleteAllLst1);
            this.groupBox1.Controls.Add(this.rdoSortAllLst1);
            this.groupBox1.Controls.Add(this.rdoSortSelectElement);
            this.groupBox1.Controls.Add(this.rodReverseLst1);
            this.groupBox1.Controls.Add(this.rdoMoveReverse);
            this.groupBox1.Location = new System.Drawing.Point(330, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(288, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عمليات على القائمة الأولى";
            // 
            // btnDeleteSelectElementLst1
            // 
            this.btnDeleteSelectElementLst1.Location = new System.Drawing.Point(157, 128);
            this.btnDeleteSelectElementLst1.Name = "btnDeleteSelectElementLst1";
            this.btnDeleteSelectElementLst1.Size = new System.Drawing.Size(109, 29);
            this.btnDeleteSelectElementLst1.TabIndex = 12;
            this.btnDeleteSelectElementLst1.Text = "حذف عنصر مظلل";
            this.btnDeleteSelectElementLst1.UseVisualStyleBackColor = true;
            this.btnDeleteSelectElementLst1.Click += new System.EventHandler(this.btnDeleteSelectElementLst1_Click);
            // 
            // btnDeleteAllLst1
            // 
            this.btnDeleteAllLst1.Location = new System.Drawing.Point(31, 128);
            this.btnDeleteAllLst1.Name = "btnDeleteAllLst1";
            this.btnDeleteAllLst1.Size = new System.Drawing.Size(109, 29);
            this.btnDeleteAllLst1.TabIndex = 11;
            this.btnDeleteAllLst1.Text = "حذف الكل";
            this.btnDeleteAllLst1.UseVisualStyleBackColor = true;
            this.btnDeleteAllLst1.Click += new System.EventHandler(this.btnDeleteAllLst1_Click);
            // 
            // rdoSortAllLst1
            // 
            this.rdoSortAllLst1.AutoSize = true;
            this.rdoSortAllLst1.Location = new System.Drawing.Point(61, 21);
            this.rdoSortAllLst1.Name = "rdoSortAllLst1";
            this.rdoSortAllLst1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoSortAllLst1.Size = new System.Drawing.Size(158, 20);
            this.rdoSortAllLst1.TabIndex = 8;
            this.rdoSortAllLst1.TabStop = true;
            this.rdoSortAllLst1.Text = "ترتيب العناصر كامل تنازليا";
            this.rdoSortAllLst1.UseVisualStyleBackColor = true;
            this.rdoSortAllLst1.CheckedChanged += new System.EventHandler(this.rdoSortAllLst1_CheckedChanged);
            // 
            // rdoSortSelectElement
            // 
            this.rdoSortSelectElement.AutoSize = true;
            this.rdoSortSelectElement.Location = new System.Drawing.Point(91, 48);
            this.rdoSortSelectElement.Name = "rdoSortSelectElement";
            this.rdoSortSelectElement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoSortSelectElement.Size = new System.Drawing.Size(128, 20);
            this.rdoSortSelectElement.TabIndex = 7;
            this.rdoSortSelectElement.TabStop = true;
            this.rdoSortSelectElement.Text = "ترتيب العناصر المظللة";
            this.rdoSortSelectElement.UseVisualStyleBackColor = true;
            this.rdoSortSelectElement.CheckedChanged += new System.EventHandler(this.rdoSortSelectElement_CheckedChanged);
            // 
            // rodReverseLst1
            // 
            this.rodReverseLst1.AutoSize = true;
            this.rodReverseLst1.Location = new System.Drawing.Point(122, 75);
            this.rodReverseLst1.Name = "rodReverseLst1";
            this.rodReverseLst1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rodReverseLst1.Size = new System.Drawing.Size(97, 20);
            this.rodReverseLst1.TabIndex = 6;
            this.rodReverseLst1.TabStop = true;
            this.rodReverseLst1.Text = "عكس العناصر";
            this.rodReverseLst1.UseVisualStyleBackColor = true;
            this.rodReverseLst1.CheckedChanged += new System.EventHandler(this.rodReverseLst1_CheckedChanged);
            // 
            // rdoMoveReverse
            // 
            this.rdoMoveReverse.AutoSize = true;
            this.rdoMoveReverse.Location = new System.Drawing.Point(92, 102);
            this.rdoMoveReverse.Name = "rdoMoveReverse";
            this.rdoMoveReverse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoMoveReverse.Size = new System.Drawing.Size(127, 20);
            this.rdoMoveReverse.TabIndex = 5;
            this.rdoMoveReverse.TabStop = true;
            this.rdoMoveReverse.Text = "نقل العناصر معكوسة";
            this.rdoMoveReverse.UseVisualStyleBackColor = true;
            this.rdoMoveReverse.CheckedChanged += new System.EventHandler(this.rdoMoveReverse_CheckedChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(83, 66);
            this.listBox2.Name = "listBox2";
            this.listBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox2.Size = new System.Drawing.Size(163, 180);
            this.listBox2.TabIndex = 6;
            // 
            // rdoOdd
            // 
            this.rdoOdd.AutoSize = true;
            this.rdoOdd.Location = new System.Drawing.Point(285, 143);
            this.rdoOdd.Name = "rdoOdd";
            this.rdoOdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoOdd.Size = new System.Drawing.Size(55, 20);
            this.rdoOdd.TabIndex = 7;
            this.rdoOdd.TabStop = true;
            this.rdoOdd.Text = "فردي";
            this.rdoOdd.UseVisualStyleBackColor = true;
            this.rdoOdd.CheckedChanged += new System.EventHandler(this.rdoOdd_CheckedChanged);
            // 
            // rdoPrime
            // 
            this.rdoPrime.AutoSize = true;
            this.rdoPrime.Location = new System.Drawing.Point(288, 183);
            this.rdoPrime.Name = "rdoPrime";
            this.rdoPrime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoPrime.Size = new System.Drawing.Size(52, 20);
            this.rdoPrime.TabIndex = 8;
            this.rdoPrime.TabStop = true;
            this.rdoPrime.Text = "أولي";
            this.rdoPrime.UseVisualStyleBackColor = true;
            this.rdoPrime.CheckedChanged += new System.EventHandler(this.rdoPrime_CheckedChanged);
            // 
            // btnMoveSelect
            // 
            this.btnMoveSelect.Location = new System.Drawing.Point(274, 66);
            this.btnMoveSelect.Name = "btnMoveSelect";
            this.btnMoveSelect.Size = new System.Drawing.Size(75, 23);
            this.btnMoveSelect.TabIndex = 9;
            this.btnMoveSelect.Text = "<";
            this.btnMoveSelect.UseVisualStyleBackColor = true;
            this.btnMoveSelect.Click += new System.EventHandler(this.btnMoveSelect_Click);
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.Location = new System.Drawing.Point(274, 223);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnMoveAll.TabIndex = 10;
            this.btnMoveAll.Text = "<<";
            this.btnMoveAll.UseVisualStyleBackColor = true;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // btnOpenAll
            // 
            this.btnOpenAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAll.Location = new System.Drawing.Point(83, 252);
            this.btnOpenAll.Name = "btnOpenAll";
            this.btnOpenAll.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAll.TabIndex = 11;
            this.btnOpenAll.Text = "▾";
            this.btnOpenAll.UseVisualStyleBackColor = true;
            this.btnOpenAll.Click += new System.EventHandler(this.btnOpenAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteSelectElementLst2);
            this.groupBox2.Controls.Add(this.btnDeleteAllLst2);
            this.groupBox2.Controls.Add(this.rodReverseLst2);
            this.groupBox2.Controls.Add(this.rdoSortAllLst2);
            this.groupBox2.Location = new System.Drawing.Point(17, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(288, 160);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عمليات على القائمة الثانية";
            // 
            // btnDeleteSelectElementLst2
            // 
            this.btnDeleteSelectElementLst2.Location = new System.Drawing.Point(152, 128);
            this.btnDeleteSelectElementLst2.Name = "btnDeleteSelectElementLst2";
            this.btnDeleteSelectElementLst2.Size = new System.Drawing.Size(109, 29);
            this.btnDeleteSelectElementLst2.TabIndex = 12;
            this.btnDeleteSelectElementLst2.Text = "حذف عنصر مظلل";
            this.btnDeleteSelectElementLst2.UseVisualStyleBackColor = true;
            this.btnDeleteSelectElementLst2.Click += new System.EventHandler(this.btnDeleteSelectElementLst2_Click);
            // 
            // btnDeleteAllLst2
            // 
            this.btnDeleteAllLst2.Location = new System.Drawing.Point(27, 128);
            this.btnDeleteAllLst2.Name = "btnDeleteAllLst2";
            this.btnDeleteAllLst2.Size = new System.Drawing.Size(109, 29);
            this.btnDeleteAllLst2.TabIndex = 11;
            this.btnDeleteAllLst2.Text = "حذف الكل";
            this.btnDeleteAllLst2.UseVisualStyleBackColor = true;
            this.btnDeleteAllLst2.Click += new System.EventHandler(this.btnDeleteAllLst2_Click);
            // 
            // rodReverseLst2
            // 
            this.rodReverseLst2.AutoSize = true;
            this.rodReverseLst2.Location = new System.Drawing.Point(105, 86);
            this.rodReverseLst2.Name = "rodReverseLst2";
            this.rodReverseLst2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rodReverseLst2.Size = new System.Drawing.Size(97, 20);
            this.rodReverseLst2.TabIndex = 6;
            this.rodReverseLst2.TabStop = true;
            this.rodReverseLst2.Text = "عكس العناصر";
            this.rodReverseLst2.UseVisualStyleBackColor = true;
            this.rodReverseLst2.CheckedChanged += new System.EventHandler(this.rodReverseLst2_CheckedChanged);
            // 
            // rdoSortAllLst2
            // 
            this.rdoSortAllLst2.AutoSize = true;
            this.rdoSortAllLst2.Location = new System.Drawing.Point(44, 39);
            this.rdoSortAllLst2.Name = "rdoSortAllLst2";
            this.rdoSortAllLst2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoSortAllLst2.Size = new System.Drawing.Size(158, 20);
            this.rdoSortAllLst2.TabIndex = 5;
            this.rdoSortAllLst2.TabStop = true;
            this.rdoSortAllLst2.Text = "ترتيب العناصر كامل تنازليا";
            this.rdoSortAllLst2.UseVisualStyleBackColor = true;
            this.rdoSortAllLst2.CheckedChanged += new System.EventHandler(this.rdoSortAllLst2_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoSelectAll);
            this.groupBox3.Controls.Add(this.rdoRemoveSelect);
            this.groupBox3.Controls.Add(this.txtDoSelect);
            this.groupBox3.Controls.Add(this.txtRemoveSelect);
            this.groupBox3.Controls.Add(this.txtRemoveSelectByIndex);
            this.groupBox3.Controls.Add(this.txtNumElements);
            this.groupBox3.Controls.Add(this.txtNumSelectElements);
            this.groupBox3.Controls.Add(this.txtNoneSelectElement);
            this.groupBox3.Controls.Add(this.btnNumSelectElements);
            this.groupBox3.Controls.Add(this.btnNumElements);
            this.groupBox3.Controls.Add(this.btnDoSelect);
            this.groupBox3.Controls.Add(this.btnRemoveSelect);
            this.groupBox3.Controls.Add(this.btnRemoveSelectByIndex);
            this.groupBox3.Controls.Add(this.btnNoneSelectElement);
            this.groupBox3.Location = new System.Drawing.Point(18, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(601, 237);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عمليات اضافية على القائمة الاولى ";
            // 
            // rdoSelectAll
            // 
            this.rdoSelectAll.AutoSize = true;
            this.rdoSelectAll.Location = new System.Drawing.Point(368, 108);
            this.rdoSelectAll.Name = "rdoSelectAll";
            this.rdoSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoSelectAll.Size = new System.Drawing.Size(151, 20);
            this.rdoSelectAll.TabIndex = 25;
            this.rdoSelectAll.TabStop = true;
            this.rdoSelectAll.Text = "التظليل على جميع العناصر";
            this.rdoSelectAll.UseVisualStyleBackColor = true;
            this.rdoSelectAll.CheckedChanged += new System.EventHandler(this.rdoSelectAll_CheckedChanged);
            // 
            // rdoRemoveSelect
            // 
            this.rdoRemoveSelect.AutoSize = true;
            this.rdoRemoveSelect.Location = new System.Drawing.Point(70, 108);
            this.rdoRemoveSelect.Name = "rdoRemoveSelect";
            this.rdoRemoveSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoRemoveSelect.Size = new System.Drawing.Size(175, 20);
            this.rdoRemoveSelect.TabIndex = 24;
            this.rdoRemoveSelect.TabStop = true;
            this.rdoRemoveSelect.Text = "إزالة التظليل على جميع العناصر";
            this.rdoRemoveSelect.UseVisualStyleBackColor = true;
            this.rdoRemoveSelect.CheckedChanged += new System.EventHandler(this.rdoRemoveSelect_CheckedChanged);
            // 
            // txtDoSelect
            // 
            this.txtDoSelect.Location = new System.Drawing.Point(18, 20);
            this.txtDoSelect.Name = "txtDoSelect";
            this.txtDoSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDoSelect.Size = new System.Drawing.Size(278, 22);
            this.txtDoSelect.TabIndex = 23;
            this.txtDoSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemoveSelect
            // 
            this.txtRemoveSelect.Location = new System.Drawing.Point(18, 49);
            this.txtRemoveSelect.Name = "txtRemoveSelect";
            this.txtRemoveSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRemoveSelect.Size = new System.Drawing.Size(278, 22);
            this.txtRemoveSelect.TabIndex = 22;
            this.txtRemoveSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemoveSelectByIndex
            // 
            this.txtRemoveSelectByIndex.Location = new System.Drawing.Point(18, 78);
            this.txtRemoveSelectByIndex.Name = "txtRemoveSelectByIndex";
            this.txtRemoveSelectByIndex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRemoveSelectByIndex.Size = new System.Drawing.Size(278, 22);
            this.txtRemoveSelectByIndex.TabIndex = 21;
            this.txtRemoveSelectByIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumElements
            // 
            this.txtNumElements.Location = new System.Drawing.Point(18, 139);
            this.txtNumElements.Name = "txtNumElements";
            this.txtNumElements.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumElements.Size = new System.Drawing.Size(278, 22);
            this.txtNumElements.TabIndex = 20;
            this.txtNumElements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumSelectElements
            // 
            this.txtNumSelectElements.Location = new System.Drawing.Point(18, 173);
            this.txtNumSelectElements.Name = "txtNumSelectElements";
            this.txtNumSelectElements.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumSelectElements.Size = new System.Drawing.Size(278, 22);
            this.txtNumSelectElements.TabIndex = 19;
            this.txtNumSelectElements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoneSelectElement
            // 
            this.txtNoneSelectElement.Location = new System.Drawing.Point(18, 207);
            this.txtNoneSelectElement.Name = "txtNoneSelectElement";
            this.txtNoneSelectElement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNoneSelectElement.Size = new System.Drawing.Size(278, 22);
            this.txtNoneSelectElement.TabIndex = 18;
            this.txtNoneSelectElement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNumSelectElements
            // 
            this.btnNumSelectElements.Location = new System.Drawing.Point(304, 170);
            this.btnNumSelectElements.Name = "btnNumSelectElements";
            this.btnNumSelectElements.Size = new System.Drawing.Size(278, 29);
            this.btnNumSelectElements.TabIndex = 17;
            this.btnNumSelectElements.Text = "عدد العناصر المظللة";
            this.btnNumSelectElements.UseVisualStyleBackColor = true;
            this.btnNumSelectElements.Click += new System.EventHandler(this.btnNumSelectElements_Click);
            // 
            // btnNumElements
            // 
            this.btnNumElements.Location = new System.Drawing.Point(304, 136);
            this.btnNumElements.Name = "btnNumElements";
            this.btnNumElements.Size = new System.Drawing.Size(278, 29);
            this.btnNumElements.TabIndex = 16;
            this.btnNumElements.Text = "عدد العناصر";
            this.btnNumElements.UseVisualStyleBackColor = true;
            this.btnNumElements.Click += new System.EventHandler(this.btnNumElements_Click);
            // 
            // btnDoSelect
            // 
            this.btnDoSelect.Location = new System.Drawing.Point(304, 17);
            this.btnDoSelect.Name = "btnDoSelect";
            this.btnDoSelect.Size = new System.Drawing.Size(278, 29);
            this.btnDoSelect.TabIndex = 15;
            this.btnDoSelect.Text = "عمل تظليل على العنصر";
            this.btnDoSelect.UseVisualStyleBackColor = true;
            this.btnDoSelect.Click += new System.EventHandler(this.btnDoSelect_Click);
            // 
            // btnRemoveSelect
            // 
            this.btnRemoveSelect.Location = new System.Drawing.Point(304, 46);
            this.btnRemoveSelect.Name = "btnRemoveSelect";
            this.btnRemoveSelect.Size = new System.Drawing.Size(278, 29);
            this.btnRemoveSelect.TabIndex = 14;
            this.btnRemoveSelect.Text = "إزالة تظليل عن العنصر";
            this.btnRemoveSelect.UseVisualStyleBackColor = true;
            this.btnRemoveSelect.Click += new System.EventHandler(this.btnRemoveSelect_Click);
            // 
            // btnRemoveSelectByIndex
            // 
            this.btnRemoveSelectByIndex.Location = new System.Drawing.Point(304, 75);
            this.btnRemoveSelectByIndex.Name = "btnRemoveSelectByIndex";
            this.btnRemoveSelectByIndex.Size = new System.Drawing.Size(278, 29);
            this.btnRemoveSelectByIndex.TabIndex = 13;
            this.btnRemoveSelectByIndex.Text = "إزالة التظليل عن العنصر بالاندكس";
            this.btnRemoveSelectByIndex.UseVisualStyleBackColor = true;
            this.btnRemoveSelectByIndex.Click += new System.EventHandler(this.btnRemoveSelectByIndex_Click);
            // 
            // btnNoneSelectElement
            // 
            this.btnNoneSelectElement.Location = new System.Drawing.Point(304, 204);
            this.btnNoneSelectElement.Name = "btnNoneSelectElement";
            this.btnNoneSelectElement.Size = new System.Drawing.Size(278, 29);
            this.btnNoneSelectElement.TabIndex = 12;
            this.btnNoneSelectElement.Text = "عدد العناصر الغير مظللة";
            this.btnNoneSelectElement.UseVisualStyleBackColor = true;
            this.btnNoneSelectElement.Click += new System.EventHandler(this.btnNoneSelectElement_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(17, 694);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(444, 694);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Go TO Form2   >>>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 728);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOpenAll);
            this.Controls.Add(this.btnMoveAll);
            this.Controls.Add(this.btnMoveSelect);
            this.Controls.Add(this.rdoPrime);
            this.Controls.Add(this.rdoOdd);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdoEven);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddNum);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAddNum;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rdoEven;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RadioButton rdoOdd;
        private System.Windows.Forms.RadioButton rdoPrime;
        private System.Windows.Forms.Button btnMoveSelect;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.Button btnOpenAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteSelectElementLst1;
        private System.Windows.Forms.Button btnDeleteAllLst1;
        private System.Windows.Forms.RadioButton rdoSortAllLst1;
        private System.Windows.Forms.RadioButton rdoSortSelectElement;
        private System.Windows.Forms.RadioButton rodReverseLst1;
        private System.Windows.Forms.RadioButton rdoMoveReverse;
        private System.Windows.Forms.Button btnDeleteSelectElementLst2;
        private System.Windows.Forms.Button btnDeleteAllLst2;
        private System.Windows.Forms.RadioButton rodReverseLst2;
        private System.Windows.Forms.RadioButton rdoSortAllLst2;
        private System.Windows.Forms.RadioButton rdoSelectAll;
        private System.Windows.Forms.RadioButton rdoRemoveSelect;
        private System.Windows.Forms.TextBox txtDoSelect;
        private System.Windows.Forms.TextBox txtRemoveSelect;
        private System.Windows.Forms.TextBox txtRemoveSelectByIndex;
        private System.Windows.Forms.TextBox txtNumElements;
        private System.Windows.Forms.TextBox txtNumSelectElements;
        private System.Windows.Forms.TextBox txtNoneSelectElement;
        private System.Windows.Forms.Button btnNumSelectElements;
        private System.Windows.Forms.Button btnNumElements;
        private System.Windows.Forms.Button btnDoSelect;
        private System.Windows.Forms.Button btnRemoveSelect;
        private System.Windows.Forms.Button btnRemoveSelectByIndex;
        private System.Windows.Forms.Button btnNoneSelectElement;
        private System.Windows.Forms.Button button1;
    }
}

