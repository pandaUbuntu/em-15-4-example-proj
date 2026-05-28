using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim().Length != 0 && this.textBox2.Text.Trim().Length != 0)
            {   //Не знав як текстбокс перевести в число, тому використав Double.Parse, якщо є інший спосіб, то підкажіть
                double a = Convert.ToDouble(this.textBox1.Text.Trim());
                double b = Double.Parse(this.textBox2.Text.Trim());
                double riz = a - b;
                MessageBox.Show($"Різниця: {riz}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Ви не ввели текст!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(this.textBox1.Text.Trim());
            double b = Double.Parse(this.textBox2.Text.Trim());
            double sum = a + b;
            MessageBox.Show($"Сума: {sum}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(this.textBox1.Text.Trim());
            double b = Double.Parse(this.textBox2.Text.Trim());
            double dob = a * b;
            MessageBox.Show($"Добуток: {dob}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(this.textBox1.Text.Trim());
            double b = Double.Parse(this.textBox2.Text.Trim());
            double dil = a / b;
            MessageBox.Show($"Частка: {dil}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
