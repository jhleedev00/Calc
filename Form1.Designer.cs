namespace Calculation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel2 = new TableLayoutPanel();
            btnDot = new Button();
            btnZero = new Button();
            btnSign = new Button();
            btnPlus = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMinus = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMulti = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnDivision = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnCrearEntry = new Button();
            btnPercent = new Button();
            btnEqual = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            calcResult = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            operatingPrintLabel = new Label();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(btnDot, 2, 5);
            tableLayoutPanel2.Controls.Add(btnZero, 1, 5);
            tableLayoutPanel2.Controls.Add(btnSign, 0, 5);
            tableLayoutPanel2.Controls.Add(btnPlus, 3, 4);
            tableLayoutPanel2.Controls.Add(btn3, 2, 4);
            tableLayoutPanel2.Controls.Add(btn2, 1, 4);
            tableLayoutPanel2.Controls.Add(btn1, 0, 4);
            tableLayoutPanel2.Controls.Add(btnMinus, 3, 3);
            tableLayoutPanel2.Controls.Add(btn6, 2, 3);
            tableLayoutPanel2.Controls.Add(btn5, 1, 3);
            tableLayoutPanel2.Controls.Add(btn4, 0, 3);
            tableLayoutPanel2.Controls.Add(btnMulti, 3, 2);
            tableLayoutPanel2.Controls.Add(btn9, 2, 2);
            tableLayoutPanel2.Controls.Add(btn8, 1, 2);
            tableLayoutPanel2.Controls.Add(btn7, 0, 2);
            tableLayoutPanel2.Controls.Add(btnDivision, 3, 1);
            tableLayoutPanel2.Controls.Add(button7, 2, 1);
            tableLayoutPanel2.Controls.Add(button6, 1, 1);
            tableLayoutPanel2.Controls.Add(button5, 0, 1);
            tableLayoutPanel2.Controls.Add(btnDelete, 3, 0);
            tableLayoutPanel2.Controls.Add(btnClear, 2, 0);
            tableLayoutPanel2.Controls.Add(btnCrearEntry, 1, 0);
            tableLayoutPanel2.Controls.Add(btnPercent, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEqual, 3, 5);
            tableLayoutPanel2.Location = new Point(-1, 179);
            tableLayoutPanel2.Margin = new Padding(1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(333, 333);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("맑은 고딕", 15.75F);
            btnDot.Location = new Point(169, 276);
            btnDot.Margin = new Padding(3, 1, 3, 1);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(77, 56);
            btnDot.TabIndex = 23;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.Control;
            btnZero.Font = new Font("맑은 고딕", 15.75F);
            btnZero.Location = new Point(86, 276);
            btnZero.Margin = new Padding(3, 1, 3, 1);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(77, 56);
            btnZero.TabIndex = 22;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnSign
            // 
            btnSign.Font = new Font("맑은 고딕", 15.75F);
            btnSign.Location = new Point(3, 276);
            btnSign.Margin = new Padding(3, 1, 3, 1);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(77, 56);
            btnSign.TabIndex = 21;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ButtonFace;
            btnPlus.Font = new Font("맑은 고딕", 15.75F);
            btnPlus.Location = new Point(252, 221);
            btnPlus.Margin = new Padding(3, 1, 3, 1);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(78, 53);
            btnPlus.TabIndex = 20;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("맑은 고딕", 15.75F);
            btn3.Location = new Point(169, 221);
            btn3.Margin = new Padding(3, 1, 3, 1);
            btn3.Name = "btn3";
            btn3.Size = new Size(77, 53);
            btn3.TabIndex = 19;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("맑은 고딕", 15.75F);
            btn2.Location = new Point(86, 221);
            btn2.Margin = new Padding(3, 1, 3, 1);
            btn2.Name = "btn2";
            btn2.Size = new Size(77, 53);
            btn2.TabIndex = 18;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("맑은 고딕", 15.75F);
            btn1.Location = new Point(3, 221);
            btn1.Margin = new Padding(3, 1, 3, 1);
            btn1.Name = "btn1";
            btn1.Size = new Size(77, 53);
            btn1.TabIndex = 17;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ButtonFace;
            btnMinus.Font = new Font("맑은 고딕", 15.75F);
            btnMinus.Location = new Point(252, 166);
            btnMinus.Margin = new Padding(3, 1, 3, 1);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(78, 53);
            btnMinus.TabIndex = 16;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("맑은 고딕", 15.75F);
            btn6.Location = new Point(169, 166);
            btn6.Margin = new Padding(3, 1, 3, 1);
            btn6.Name = "btn6";
            btn6.Size = new Size(77, 53);
            btn6.TabIndex = 15;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("맑은 고딕", 15.75F);
            btn5.Location = new Point(86, 166);
            btn5.Margin = new Padding(3, 1, 3, 1);
            btn5.Name = "btn5";
            btn5.Size = new Size(77, 53);
            btn5.TabIndex = 14;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("맑은 고딕", 15.75F);
            btn4.Location = new Point(3, 166);
            btn4.Margin = new Padding(3, 1, 3, 1);
            btn4.Name = "btn4";
            btn4.Size = new Size(77, 53);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = SystemColors.ButtonFace;
            btnMulti.Font = new Font("맑은 고딕", 15.75F);
            btnMulti.Location = new Point(252, 111);
            btnMulti.Margin = new Padding(3, 1, 3, 1);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(78, 53);
            btnMulti.TabIndex = 12;
            btnMulti.Text = "×";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("맑은 고딕", 15.75F);
            btn9.Location = new Point(169, 111);
            btn9.Margin = new Padding(3, 1, 3, 1);
            btn9.Name = "btn9";
            btn9.Size = new Size(77, 53);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("맑은 고딕", 15.75F);
            btn8.Location = new Point(86, 111);
            btn8.Margin = new Padding(3, 1, 3, 1);
            btn8.Name = "btn8";
            btn8.Size = new Size(77, 53);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("맑은 고딕", 15.75F);
            btn7.Location = new Point(3, 111);
            btn7.Margin = new Padding(3, 1, 3, 1);
            btn7.Name = "btn7";
            btn7.Size = new Size(77, 53);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = SystemColors.ButtonFace;
            btnDivision.Font = new Font("맑은 고딕", 15.75F);
            btnDivision.Location = new Point(252, 56);
            btnDivision.Margin = new Padding(3, 1, 3, 1);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(78, 53);
            btnDivision.TabIndex = 8;
            btnDivision.Text = "÷";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonFace;
            button7.Font = new Font("Cambria", 14.25F);
            button7.Location = new Point(169, 56);
            button7.Margin = new Padding(3, 1, 3, 1);
            button7.Name = "button7";
            button7.Size = new Size(77, 53);
            button7.TabIndex = 7;
            button7.Text = "²√𝑥";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Font = new Font("Cambria", 14.25F);
            button6.Location = new Point(86, 56);
            button6.Margin = new Padding(3, 1, 3, 1);
            button6.Name = "button6";
            button6.Size = new Size(77, 53);
            button6.TabIndex = 6;
            button6.Text = "𝑥²";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Font = new Font("Cambria", 14.25F);
            button5.Location = new Point(3, 56);
            button5.Margin = new Padding(3, 1, 3, 1);
            button5.Name = "button5";
            button5.Size = new Size(77, 53);
            button5.TabIndex = 5;
            button5.Text = "¹/𝑥";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Font = new Font("맑은 고딕", 15.75F);
            btnDelete.Location = new Point(252, 1);
            btnDelete.Margin = new Padding(3, 1, 3, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 53);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "⌫";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ButtonFace;
            btnClear.Font = new Font("맑은 고딕", 15.75F);
            btnClear.Location = new Point(169, 1);
            btnClear.Margin = new Padding(3, 1, 3, 1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(77, 53);
            btnClear.TabIndex = 3;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCrearEntry
            // 
            btnCrearEntry.BackColor = SystemColors.ButtonFace;
            btnCrearEntry.Font = new Font("맑은 고딕", 15.75F);
            btnCrearEntry.Location = new Point(86, 1);
            btnCrearEntry.Margin = new Padding(3, 1, 3, 1);
            btnCrearEntry.Name = "btnCrearEntry";
            btnCrearEntry.Size = new Size(77, 53);
            btnCrearEntry.TabIndex = 2;
            btnCrearEntry.Text = "CE";
            btnCrearEntry.UseVisualStyleBackColor = false;
            btnCrearEntry.Click += btnCrearEntry_Click;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = SystemColors.ButtonFace;
            btnPercent.Font = new Font("맑은 고딕", 15.75F);
            btnPercent.Location = new Point(3, 1);
            btnPercent.Margin = new Padding(3, 1, 3, 1);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(77, 53);
            btnPercent.TabIndex = 1;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.Highlight;
            btnEqual.Font = new Font("맑은 고딕", 15.75F);
            btnEqual.ForeColor = SystemColors.Control;
            btnEqual.Location = new Point(252, 276);
            btnEqual.Margin = new Padding(3, 1, 3, 1);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(78, 56);
            btnEqual.TabIndex = 0;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(calcResult, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 71);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(333, 80);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // calcResult
            // 
            calcResult.AutoSize = true;
            calcResult.Dock = DockStyle.Fill;
            calcResult.Font = new Font("맑은 고딕", 35F);
            calcResult.Location = new Point(3, 0);
            calcResult.Name = "calcResult";
            calcResult.Size = new Size(327, 70);
            calcResult.TabIndex = 0;
            calcResult.TextAlign = ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.Location = new Point(0, 151);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(333, 28);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(operatingPrintLabel, 0, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(333, 71);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // operatingPrintLabel
            // 
            operatingPrintLabel.AllowDrop = true;
            operatingPrintLabel.AutoSize = true;
            operatingPrintLabel.Dock = DockStyle.Fill;
            operatingPrintLabel.Font = new Font("맑은 고딕", 10F);
            operatingPrintLabel.ForeColor = SystemColors.ActiveCaption;
            operatingPrintLabel.Location = new Point(3, 0);
            operatingPrintLabel.Name = "operatingPrintLabel";
            operatingPrintLabel.Size = new Size(327, 71);
            operatingPrintLabel.TabIndex = 1;
            operatingPrintLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 511);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button btnEqual;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnMinus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMulti;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDivision;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button btnDelete;
        private Button btnClear;
        private Button btnCrearEntry;
        private Button btnPercent;
        private Button btnDot;
        private Button btnZero;
        private Button btnSign;
        private Button btnPlus;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label calcResult;
        private TableLayoutPanel tableLayoutPanel4;
        private Label operatingPrintLabel;
    }
}
