using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1  
{
    public partial class Form2 : Form
    {
        int a = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            this.label1.Text = a.ToString();

        }
    }
}
