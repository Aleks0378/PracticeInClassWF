namespace Lesson_06._11_Task_2
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
            components = new System.ComponentModel.Container();
            toolStrip1 = new ToolStrip();
            timeToolStripLabel = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripProgressBar1 = new ToolStripProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { timeToolStripLabel, toolStripSeparator1, toolStripProgressBar1 });
            toolStrip1.Location = new Point(0, 84);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(468, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // timeToolStripLabel
            // 
            timeToolStripLabel.Name = "timeToolStripLabel";
            timeToolStripLabel.Size = new Size(111, 22);
            timeToolStripLabel.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.AutoSize = false;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(250, 22);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 109);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel timeToolStripLabel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}