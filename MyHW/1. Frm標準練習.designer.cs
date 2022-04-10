
namespace WindowsFormsApp1
{
    partial class Frm標準練習
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
            this.btnLotto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnString = new System.Windows.Forms.Button();
            this.btnFindC = new System.Windows.Forms.Button();
            this.buttonString = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNinetyNine = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMix = new System.Windows.Forms.Button();
            this.btnOddandEven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLotto
            // 
            this.btnLotto.Location = new System.Drawing.Point(951, 106);
            this.btnLotto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLotto.Name = "btnLotto";
            this.btnLotto.Size = new System.Drawing.Size(204, 37);
            this.btnLotto.TabIndex = 104;
            this.btnLotto.Text = "int[] 樂透 6個號碼不重複";
            this.btnLotto.UseVisualStyleBackColor = true;
            this.btnLotto.Click += new System.EventHandler(this.btnLotto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(165, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 33);
            this.label7.TabIndex = 101;
            this.label7.Text = "Result:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(39, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 33);
            this.btnClear.TabIndex = 100;
            this.btnClear.Text = "清空結果欄";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(164, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 34);
            this.label5.TabIndex = 99;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(92, 32);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 25);
            this.txtInput.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 97;
            this.label6.Text = "Number:";
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(504, 73);
            this.btnString.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(156, 27);
            this.btnString.TabIndex = 96;
            this.btnString.Text = "100 的 二進位是多少 ?";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnFindC
            // 
            this.btnFindC.Location = new System.Drawing.Point(666, 106);
            this.btnFindC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindC.Name = "btnFindC";
            this.btnFindC.Size = new System.Drawing.Size(279, 45);
            this.btnFindC.TabIndex = 95;
            this.btnFindC.Text = "string[] 名字有 “C” or “c” 字樣有幾個 ";
            this.btnFindC.UseVisualStyleBackColor = true;
            this.btnFindC.Click += new System.EventHandler(this.btnFindC_Click);
            // 
            // buttonString
            // 
            this.buttonString.Location = new System.Drawing.Point(666, 73);
            this.buttonString.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonString.Name = "buttonString";
            this.buttonString.Size = new System.Drawing.Size(279, 27);
            this.buttonString.TabIndex = 94;
            this.buttonString.Text = "string[] 最長名字 ?";
            this.buttonString.UseVisualStyleBackColor = true;
            this.buttonString.Click += new System.EventHandler(this.buttonString_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Location = new System.Drawing.Point(171, 226);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(97, 42);
            this.lblResult.TabIndex = 93;
            this.lblResult.Text = "結果";
            // 
            // btnNinetyNine
            // 
            this.btnNinetyNine.Location = new System.Drawing.Point(504, 32);
            this.btnNinetyNine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNinetyNine.Name = "btnNinetyNine";
            this.btnNinetyNine.Size = new System.Drawing.Size(156, 28);
            this.btnNinetyNine.TabIndex = 92;
            this.btnNinetyNine.Text = "九九乘法表";
            this.btnNinetyNine.UseVisualStyleBackColor = true;
            this.btnNinetyNine.Click += new System.EventHandler(this.btnNinetyNine_Click);
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDo.Location = new System.Drawing.Point(416, 119);
            this.btnDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 32);
            this.btnDo.TabIndex = 91;
            this.btnDo.Text = "do";
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnWhile.Location = new System.Drawing.Point(416, 72);
            this.btnWhile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 32);
            this.btnWhile.TabIndex = 90;
            this.btnWhile.Text = "while";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFor.Location = new System.Drawing.Point(416, 32);
            this.btnFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(75, 30);
            this.btnFor.TabIndex = 89;
            this.btnFor.Text = "for";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(222, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 88;
            this.label3.Text = "Step:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(237, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 87;
            this.label2.Text = "to:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(226, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 86;
            this.label1.Text = "from:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox3.Location = new System.Drawing.Point(281, 120);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 85;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Location = new System.Drawing.Point(281, 72);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 84;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(281, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 83;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(666, 32);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(279, 28);
            this.btnStatistics.TabIndex = 78;
            this.btnStatistics.Text = "int[] 統計 奇數 有幾個 , 偶數有幾個";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Location = new System.Drawing.Point(952, 71);
            this.btnMaxMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(203, 29);
            this.btnMaxMin.TabIndex = 77;
            this.btnMaxMin.Text = " MAX()   / Min ( int[] )";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(952, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 28);
            this.button3.TabIndex = 76;
            this.button3.Text = "Max (params int[] )";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMix
            // 
            this.btnMix.Location = new System.Drawing.Point(39, 123);
            this.btnMix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(155, 28);
            this.btnMix.TabIndex = 74;
            this.btnMix.Text = "3 個數的最大值";
            this.btnMix.UseVisualStyleBackColor = true;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // btnOddandEven
            // 
            this.btnOddandEven.Location = new System.Drawing.Point(39, 92);
            this.btnOddandEven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOddandEven.Name = "btnOddandEven";
            this.btnOddandEven.Size = new System.Drawing.Size(155, 27);
            this.btnOddandEven.TabIndex = 73;
            this.btnOddandEven.Text = "Odd or Even";
            this.btnOddandEven.UseVisualStyleBackColor = true;
            this.btnOddandEven.Click += new System.EventHandler(this.btnOddandEven_Click);
            // 
            // Frm標準練習
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 683);
            this.Controls.Add(this.btnLotto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnFindC);
            this.Controls.Add(this.buttonString);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnNinetyNine);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.btnOddandEven);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm標準練習";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLotto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnFindC;
        private System.Windows.Forms.Button buttonString;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNinetyNine;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnOddandEven;
    }
}