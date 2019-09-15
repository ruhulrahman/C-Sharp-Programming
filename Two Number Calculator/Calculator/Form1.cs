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
        private double firstNum, secondNum, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            input();
            result = firstNum + secondNum;
            output(result);
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            input();
            result = firstNum - secondNum;
            output(result);
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            input();
            result = firstNum * secondNum;
            output(result);
        }

        private void Div_Click(object sender, EventArgs e)
        {
            input();
            result = firstNum / secondNum;
            output(result);
        }

        private void output(double result)
        {
            resultBox.Text = result.ToString();
        }

        private void input()
        {
            firstNum = double.Parse(textBox1.Text);
            secondNum = double.Parse(textBox2.Text);
        }
    }
}
