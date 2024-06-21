namespace Calci
{
    partial class Calci
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
            txtTotal = new TextBox();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button1 = new Button();
            Calculator = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(12, 45);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(368, 60);
            txtTotal.TabIndex = 0;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // btn2
            // 
            btn2.Location = new Point(113, 220);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 30);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(206, 220);
            btn3.Name = "btn3";
            btn3.Size = new Size(84, 30);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 171);
            btn4.Name = "btn4";
            btn4.Size = new Size(81, 28);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(113, 171);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 28);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(206, 171);
            btn6.Name = "btn6";
            btn6.Size = new Size(84, 28);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 121);
            btn7.Name = "btn7";
            btn7.Size = new Size(81, 31);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(113, 121);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 31);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(206, 121);
            btn9.Name = "btn9";
            btn9.Size = new Size(84, 31);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(113, 268);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 29);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // button11
            // 
            button11.Location = new Point(305, 220);
            button11.Name = "button11";
            button11.Size = new Size(75, 30);
            button11.TabIndex = 11;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(305, 171);
            button12.Name = "button12";
            button12.Size = new Size(75, 28);
            button12.TabIndex = 12;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(305, 121);
            button13.Name = "button13";
            button13.Size = new Size(75, 31);
            button13.TabIndex = 13;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(12, 268);
            button14.Name = "button14";
            button14.Size = new Size(84, 29);
            button14.TabIndex = 14;
            button14.Text = "/";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(206, 268);
            button15.Name = "button15";
            button15.Size = new Size(84, 29);
            button15.TabIndex = 15;
            button15.Text = "clear";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(305, 268);
            button16.Name = "button16";
            button16.Size = new Size(75, 29);
            button16.TabIndex = 16;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 220);
            button1.Name = "button1";
            button1.Size = new Size(81, 30);
            button1.TabIndex = 18;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Calculator
            // 
            Calculator.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Calculator.ForeColor = Color.DarkGreen;
            Calculator.Location = new Point(113, 334);
            Calculator.Name = "Calculator";
            Calculator.Size = new Size(144, 42);
            Calculator.TabIndex = 19;
            Calculator.Text = "Calculator";
            Calculator.UseVisualStyleBackColor = true;
            // 
            // Calci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(396, 413);
            Controls.Add(Calculator);
            Controls.Add(button1);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(txtTotal);
            ForeColor = Color.DarkBlue;
            Name = "Calci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button1;
        private Button Calculator;
    }
}
