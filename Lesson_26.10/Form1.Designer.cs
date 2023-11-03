namespace Lesson_26._10
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
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            SumNumeric = new NumericUpDown();
            label1 = new Label();
            EnterButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SumNumeric).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 49);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(97, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Coca-cola";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton8);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(140, 346);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 171);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Seven-Up";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 210);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(100, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Gaz-Water";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 90);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(64, 24);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "Soda";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 251);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(64, 24);
            radioButton7.TabIndex = 5;
            radioButton7.TabStop = true;
            radioButton7.Text = "Pepsi";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(6, 131);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(65, 24);
            radioButton8.TabIndex = 4;
            radioButton8.TabStop = true;
            radioButton8.Text = "Fanta";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // SumNumeric
            // 
            SumNumeric.Location = new Point(173, 61);
            SumNumeric.Name = "SumNumeric";
            SumNumeric.Size = new Size(151, 27);
            SumNumeric.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 23);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 3;
            label1.Text = "Введите сумму";
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(173, 112);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(151, 29);
            EnterButton.TabIndex = 4;
            EnterButton.TabStop = false;
            EnterButton.Text = "Enter";
            EnterButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 386);
            Controls.Add(EnterButton);
            Controls.Add(label1);
            Controls.Add(SumNumeric);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SumNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton2;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private NumericUpDown SumNumeric;
        private Label label1;
        private Button EnterButton;
    }
}