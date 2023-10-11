using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        double firstValue, secondValue, thirdValue;
        double result;
        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDouble(textBox1.Text);
            result = (sender as Button).Text[0];
            textBox1.Clear();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDouble(textBox1.Text);
            result = (sender as Button).Text[0];
            textBox1.Clear();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDouble(textBox1.Text);
            result = (sender as Button).Text[0];
            textBox1.Clear();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            firstValue = Convert.ToDouble(textBox1.Text);
            result = (sender as Button).Text[0];
            textBox1.Clear();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else textBox1.Text = '-' + textBox1.Text;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            secondValue = Convert.ToDouble(textBox1.Text);
            switch (result)
            {
                case '+':
                    thirdValue = (firstValue + secondValue);
                    break;
                case '-':
                    thirdValue = (firstValue - secondValue);
                    break;
                case '*':
                    thirdValue =  (firstValue * secondValue);
                    break;
                case '÷':
                    thirdValue = (firstValue / secondValue);
                    if (secondValue == 0)
                    {
                        MessageBox.Show("Ошибка.Данное действие сделать невозможно!");
                        textBox1.Text = "error";
                    }
                    break;

            }
            textBox1.Text = Convert.ToString(thirdValue);
        }
    }
}
