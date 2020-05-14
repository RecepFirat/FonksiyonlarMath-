using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Math.Log10(Convert.ToDouble(textBox1.Text.Trim())).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Math.Sqrt(    Math.Abs(Convert.ToDouble(textBox1.Text.Trim()))).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
       label1.Text=     Math.Exp(Math.Pow(Convert.ToDouble(textBox1.Text.Trim()), Convert.ToDouble(textBox2.Text.Trim()))).ToString();
        }
    }
}
