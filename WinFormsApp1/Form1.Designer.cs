namespace WinFormsApp1
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
            Записати = new Button();
            Очистити = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Записати
            // 
            Записати.BackColor = SystemColors.ButtonHighlight;
            Записати.Cursor = Cursors.SizeAll;
            Записати.FlatStyle = FlatStyle.System;
            Записати.Font = new Font("Times New Roman", 10.25F, FontStyle.Bold);
            Записати.ForeColor = Color.DarkGreen;
            Записати.Location = new Point(67, 86);
            Записати.Name = "Записати";
            Записати.Size = new Size(75, 23);
            Записати.TabIndex = 0;
            Записати.Text = "Записати";
            Записати.UseVisualStyleBackColor = false;
            Записати.Click += Записати_Click;
            // 
            // Очистити
            // 
            Очистити.BackColor = SystemColors.ButtonHighlight;
            Очистити.Cursor = Cursors.SizeAll;
            Очистити.FlatStyle = FlatStyle.System;
            Очистити.Font = new Font("Times New Roman", 9.25F, FontStyle.Bold);
            Очистити.ForeColor = Color.DarkGreen;
            Очистити.Location = new Point(185, 86);
            Очистити.Name = "Очистити";
            Очистити.Size = new Size(75, 23);
            Очистити.TabIndex = 1;
            Очистити.Text = "Очистити";
            Очистити.UseVisualStyleBackColor = false;
            Очистити.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(112, 38);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Напишіть щось";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 2;
            textBox1.Tag = "";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(326, 200);
            Controls.Add(textBox1);
            Controls.Add(Очистити);
            Controls.Add(Записати);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Записати;
        private Button Очистити;
        private TextBox textBox1;
    }
}
