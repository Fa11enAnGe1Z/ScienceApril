namespace Calculator
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
            num1 = new Button();
            num3 = new Button();
            panel1 = new Panel();
            btnClear = new Button();
            btnDot = new Button();
            btnReplace = new Button();
            numZero = new Button();
            btnSeparation = new Button();
            btnEqually = new Button();
            btnMultiplication = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            num9 = new Button();
            num8 = new Button();
            num7 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            num2 = new Button();
            tbAnswer = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            num1.Location = new Point(1, 166);
            num1.Margin = new Padding(1);
            num1.Name = "num1";
            num1.Size = new Size(87, 53);
            num1.TabIndex = 1;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // num3
            // 
            num3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            num3.Location = new Point(179, 165);
            num3.Margin = new Padding(1);
            num3.Name = "num3";
            num3.Size = new Size(87, 53);
            num3.TabIndex = 2;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDot);
            panel1.Controls.Add(btnReplace);
            panel1.Controls.Add(numZero);
            panel1.Controls.Add(btnSeparation);
            panel1.Controls.Add(btnEqually);
            panel1.Controls.Add(btnMultiplication);
            panel1.Controls.Add(btnMinus);
            panel1.Controls.Add(btnPlus);
            panel1.Controls.Add(num9);
            panel1.Controls.Add(num8);
            panel1.Controls.Add(num7);
            panel1.Controls.Add(num6);
            panel1.Controls.Add(num5);
            panel1.Controls.Add(num4);
            panel1.Controls.Add(num2);
            panel1.Controls.Add(num1);
            panel1.Controls.Add(num3);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 279);
            panel1.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnClear.Location = new Point(179, 0);
            btnClear.Margin = new Padding(1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 53);
            btnClear.TabIndex = 18;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnDot.Location = new Point(1, 220);
            btnDot.Margin = new Padding(1);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(87, 53);
            btnDot.TabIndex = 17;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnReplace
            // 
            btnReplace.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnReplace.Location = new Point(1, 0);
            btnReplace.Margin = new Padding(1);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(176, 53);
            btnReplace.TabIndex = 16;
            btnReplace.Text = "+/-";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // numZero
            // 
            numZero.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            numZero.Location = new Point(90, 221);
            numZero.Margin = new Padding(1);
            numZero.Name = "numZero";
            numZero.Size = new Size(87, 53);
            numZero.TabIndex = 15;
            numZero.Text = "0";
            numZero.UseVisualStyleBackColor = true;
            numZero.Click += numZero_Click;
            // 
            // btnSeparation
            // 
            btnSeparation.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnSeparation.Location = new Point(268, 0);
            btnSeparation.Margin = new Padding(1);
            btnSeparation.Name = "btnSeparation";
            btnSeparation.Size = new Size(87, 53);
            btnSeparation.TabIndex = 14;
            btnSeparation.Text = "/";
            btnSeparation.UseVisualStyleBackColor = true;
            btnSeparation.Click += btnSeparation_Click;
            // 
            // btnEqually
            // 
            btnEqually.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnEqually.Location = new Point(179, 220);
            btnEqually.Margin = new Padding(1);
            btnEqually.Name = "btnEqually";
            btnEqually.Size = new Size(176, 53);
            btnEqually.TabIndex = 13;
            btnEqually.Text = "=";
            btnEqually.UseVisualStyleBackColor = true;
            btnEqually.Click += btnEqually_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnMultiplication.Location = new Point(268, 55);
            btnMultiplication.Margin = new Padding(1);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(87, 53);
            btnMultiplication.TabIndex = 12;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnMinus.Location = new Point(268, 110);
            btnMinus.Margin = new Padding(1);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(87, 53);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnPlus.Location = new Point(268, 165);
            btnPlus.Margin = new Padding(1);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(87, 53);
            btnPlus.TabIndex = 10;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // num9
            // 
            num9.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            num9.Location = new Point(179, 55);
            num9.Margin = new Padding(1);
            num9.Name = "num9";
            num9.Size = new Size(87, 53);
            num9.TabIndex = 9;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num9_Click;
            // 
            // num8
            // 
            num8.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            num8.Location = new Point(90, 56);
            num8.Margin = new Padding(1);
            num8.Name = "num8";
            num8.Size = new Size(87, 53);
            num8.TabIndex = 8;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += num8_Click;
            // 
            // num7
            // 
            num7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            num7.Location = new Point(1, 56);
            num7.Margin = new Padding(1);
            num7.Name = "num7";
            num7.Size = new Size(87, 53);
            num7.TabIndex = 7;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += num7_Click;
            // 
            // num6
            // 
            num6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            num6.Location = new Point(179, 110);
            num6.Margin = new Padding(1);
            num6.Name = "num6";
            num6.Size = new Size(87, 53);
            num6.TabIndex = 6;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num6_Click;
            // 
            // num5
            // 
            num5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            num5.Location = new Point(90, 111);
            num5.Margin = new Padding(1);
            num5.Name = "num5";
            num5.Size = new Size(87, 53);
            num5.TabIndex = 5;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += num5_Click;
            // 
            // num4
            // 
            num4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            num4.Location = new Point(1, 111);
            num4.Margin = new Padding(1);
            num4.Name = "num4";
            num4.Size = new Size(87, 53);
            num4.TabIndex = 4;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += num4_Click;
            // 
            // num2
            // 
            num2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            num2.Location = new Point(90, 166);
            num2.Margin = new Padding(1);
            num2.Name = "num2";
            num2.Size = new Size(87, 53);
            num2.TabIndex = 3;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num2_Click;
            // 
            // tbAnswer
            // 
            tbAnswer.BackColor = SystemColors.ControlDarkDark;
            tbAnswer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbAnswer.ForeColor = SystemColors.Window;
            tbAnswer.Location = new Point(12, 8);
            tbAnswer.Name = "tbAnswer";
            tbAnswer.ReadOnly = true;
            tbAnswer.Size = new Size(359, 35);
            tbAnswer.TabIndex = 4;
            tbAnswer.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(379, 335);
            Controls.Add(tbAnswer);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Калькулятор";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button num1;
        private Button num3;
        private Panel panel1;
        private Button num2;
        private Button num9;
        private Button num8;
        private Button num7;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button btnSeparation;
        private Button btnEqually;
        private Button btnMultiplication;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnClear;
        private Button btnDot;
        private Button btnReplace;
        private Button numZero;
        private TextBox tbAnswer;
    }
}
