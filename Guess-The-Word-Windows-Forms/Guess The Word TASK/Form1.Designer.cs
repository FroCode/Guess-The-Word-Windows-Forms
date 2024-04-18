namespace Guess_The_Word_Windows_Forms_MOO_ICT
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
            label1 = new Label();
            lblWord = new Label();
            textBox1 = new TextBox();
            lblInfo = new Label();
            lblGussed = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(274, 25);
            label1.Name = "label1";
            label1.Size = new Size(349, 58);
            label1.TabIndex = 0;
            label1.Text = "Guess The Word";
            // 
            // lblWord
            // 
            lblWord.FlatStyle = FlatStyle.System;
            lblWord.Font = new Font("Microsoft JhengHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblWord.ForeColor = Color.AliceBlue;
            lblWord.Location = new Point(274, 157);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(313, 69);
            lblWord.TabIndex = 1;
            lblWord.Text = "label2";
            lblWord.TextAlign = ContentAlignment.MiddleCenter;
            lblWord.Click += lblWord_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(296, 272);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 56);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += KeyIsPressed;
            // 
            // lblInfo
            // 
            lblInfo.BackColor = SystemColors.MenuHighlight;
            lblInfo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.FromArgb(192, 255, 255);
            lblInfo.Location = new Point(286, 359);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(313, 69);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Words: 0 of 0";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGussed
            // 
            lblGussed.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblGussed.ForeColor = Color.Lime;
            lblGussed.Location = new Point(604, 270);
            lblGussed.Name = "lblGussed";
            lblGussed.Size = new Size(313, 63);
            lblGussed.TabIndex = 1;
            lblGussed.Text = "Guessed: 0 times";
            lblGussed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(938, 600);
            Controls.Add(textBox1);
            Controls.Add(lblGussed);
            Controls.Add(lblInfo);
            Controls.Add(lblWord);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(192, 192, 255);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Guess The Word Game MOO ICT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblWord;
        private TextBox textBox1;
        private Label lblInfo;
        private Label lblGussed;
    }
}