
namespace Third_Lab
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstX = new System.Windows.Forms.TextBox();
            this.firstY = new System.Windows.Forms.TextBox();
            this.actionBox = new System.Windows.Forms.ComboBox();
            this.firstZ = new System.Windows.Forms.TextBox();
            this.vector1 = new System.Windows.Forms.Label();
            this.firstXLabel = new System.Windows.Forms.Label();
            this.firstYLabel = new System.Windows.Forms.Label();
            this.firstZLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vecor2 = new System.Windows.Forms.Label();
            this.secondZ = new System.Windows.Forms.TextBox();
            this.secondY = new System.Windows.Forms.TextBox();
            this.secondX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resultZ = new System.Windows.Forms.TextBox();
            this.resultY = new System.Windows.Forms.TextBox();
            this.resultX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.scalarProduct = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstX
            // 
            this.firstX.Location = new System.Drawing.Point(36, 50);
            this.firstX.Name = "firstX";
            this.firstX.Size = new System.Drawing.Size(74, 20);
            this.firstX.TabIndex = 0;
            // 
            // firstY
            // 
            this.firstY.Location = new System.Drawing.Point(36, 76);
            this.firstY.Name = "firstY";
            this.firstY.Size = new System.Drawing.Size(74, 20);
            this.firstY.TabIndex = 1;
            // 
            // actionBox
            // 
            this.actionBox.FormattingEnabled = true;
            this.actionBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*"});
            this.actionBox.Location = new System.Drawing.Point(116, 75);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(31, 21);
            this.actionBox.TabIndex = 2;
            this.actionBox.Text = "+";
            // 
            // firstZ
            // 
            this.firstZ.Location = new System.Drawing.Point(36, 102);
            this.firstZ.Name = "firstZ";
            this.firstZ.Size = new System.Drawing.Size(74, 20);
            this.firstZ.TabIndex = 3;
            // 
            // vector1
            // 
            this.vector1.AutoSize = true;
            this.vector1.Location = new System.Drawing.Point(48, 34);
            this.vector1.Name = "vector1";
            this.vector1.Size = new System.Drawing.Size(52, 13);
            this.vector1.TabIndex = 4;
            this.vector1.Text = "Вектор 1";
            // 
            // firstXLabel
            // 
            this.firstXLabel.AutoSize = true;
            this.firstXLabel.Location = new System.Drawing.Point(13, 53);
            this.firstXLabel.Name = "firstXLabel";
            this.firstXLabel.Size = new System.Drawing.Size(17, 13);
            this.firstXLabel.TabIndex = 5;
            this.firstXLabel.Text = "X:";
            // 
            // firstYLabel
            // 
            this.firstYLabel.AutoSize = true;
            this.firstYLabel.Location = new System.Drawing.Point(13, 79);
            this.firstYLabel.Name = "firstYLabel";
            this.firstYLabel.Size = new System.Drawing.Size(17, 13);
            this.firstYLabel.TabIndex = 6;
            this.firstYLabel.Text = "Y:";
            // 
            // firstZLabel
            // 
            this.firstZLabel.AutoSize = true;
            this.firstZLabel.Location = new System.Drawing.Point(13, 105);
            this.firstZLabel.Name = "firstZLabel";
            this.firstZLabel.Size = new System.Drawing.Size(17, 13);
            this.firstZLabel.TabIndex = 7;
            this.firstZLabel.Text = "Z:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Основные действия над векторами:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Z:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "X:";
            // 
            // vecor2
            // 
            this.vecor2.AutoSize = true;
            this.vecor2.Location = new System.Drawing.Point(193, 34);
            this.vecor2.Name = "vecor2";
            this.vecor2.Size = new System.Drawing.Size(52, 13);
            this.vecor2.TabIndex = 12;
            this.vecor2.Text = "Вектор 2";
            // 
            // secondZ
            // 
            this.secondZ.Location = new System.Drawing.Point(181, 102);
            this.secondZ.Name = "secondZ";
            this.secondZ.Size = new System.Drawing.Size(74, 20);
            this.secondZ.TabIndex = 11;
            // 
            // secondY
            // 
            this.secondY.Location = new System.Drawing.Point(181, 76);
            this.secondY.Name = "secondY";
            this.secondY.Size = new System.Drawing.Size(74, 20);
            this.secondY.TabIndex = 10;
            // 
            // secondX
            // 
            this.secondX.Location = new System.Drawing.Point(181, 50);
            this.secondX.Name = "secondX";
            this.secondX.Size = new System.Drawing.Size(74, 20);
            this.secondX.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Z:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Вектор 3";
            // 
            // resultZ
            // 
            this.resultZ.Location = new System.Drawing.Point(304, 102);
            this.resultZ.Name = "resultZ";
            this.resultZ.ReadOnly = true;
            this.resultZ.Size = new System.Drawing.Size(74, 20);
            this.resultZ.TabIndex = 19;
            // 
            // resultY
            // 
            this.resultY.Location = new System.Drawing.Point(304, 76);
            this.resultY.Name = "resultY";
            this.resultY.ReadOnly = true;
            this.resultY.Size = new System.Drawing.Size(74, 20);
            this.resultY.TabIndex = 18;
            // 
            // resultX
            // 
            this.resultX.Location = new System.Drawing.Point(304, 50);
            this.resultX.Name = "resultX";
            this.resultX.ReadOnly = true;
            this.resultX.Size = new System.Drawing.Size(74, 20);
            this.resultX.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Расчёт скалярного произведения:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(230, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "=";
            // 
            // scalarProduct
            // 
            this.scalarProduct.Location = new System.Drawing.Point(249, 154);
            this.scalarProduct.Name = "scalarProduct";
            this.scalarProduct.ReadOnly = true;
            this.scalarProduct.Size = new System.Drawing.Size(74, 20);
            this.scalarProduct.TabIndex = 41;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(249, 183);
            this.length.Name = "length";
            this.length.ReadOnly = true;
            this.length.Size = new System.Drawing.Size(74, 20);
            this.length.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "=";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(128, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Длина вектора 1:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 220);
            this.Controls.Add(this.length);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.scalarProduct);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resultZ);
            this.Controls.Add(this.resultY);
            this.Controls.Add(this.resultX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vecor2);
            this.Controls.Add(this.secondZ);
            this.Controls.Add(this.secondY);
            this.Controls.Add(this.secondX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstZLabel);
            this.Controls.Add(this.firstYLabel);
            this.Controls.Add(this.firstXLabel);
            this.Controls.Add(this.vector1);
            this.Controls.Add(this.firstZ);
            this.Controls.Add(this.actionBox);
            this.Controls.Add(this.firstY);
            this.Controls.Add(this.firstX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Вектора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstX;
        private System.Windows.Forms.TextBox firstY;
        private System.Windows.Forms.ComboBox actionBox;
        private System.Windows.Forms.TextBox firstZ;
        private System.Windows.Forms.Label vector1;
        private System.Windows.Forms.Label firstXLabel;
        private System.Windows.Forms.Label firstYLabel;
        private System.Windows.Forms.Label firstZLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label vecor2;
        private System.Windows.Forms.TextBox secondZ;
        private System.Windows.Forms.TextBox secondY;
        private System.Windows.Forms.TextBox secondX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox resultZ;
        private System.Windows.Forms.TextBox resultY;
        private System.Windows.Forms.TextBox resultX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox scalarProduct;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

