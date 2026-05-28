namespace WinFormsApp1
{
    partial class Form3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            textBox1.Location = new Point(185, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            textBox2.Location = new Point(185, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 26);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(80, 47);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(80, 89);
            button2.Name = "button2";
            button2.Size = new Size(80, 30);
            button2.TabIndex = 3;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlDarkDark;
            button3.Location = new Point(305, 47);
            button3.Name = "button3";
            button3.Size = new Size(80, 30);
            button3.TabIndex = 4;
            button3.Text = "x";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Info;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ControlDarkDark;
            button4.Location = new Point(305, 87);
            button4.Name = "button4";
            button4.Size = new Size(80, 30);
            button4.TabIndex = 5;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.Location = new Point(151, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 31);
            label1.TabIndex = 6;
            label1.Text = "Калькулятор";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(425, 166);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}