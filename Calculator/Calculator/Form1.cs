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
        private Boolean ButtonEaual, Buttonadd, ButtonSub, ButtonMul, ButtonDiv;
        private Boolean ButtonPlusMinus;
        private double firstNum, secondNum, result;
        private int Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9, Button0;
        private double total1 = 0, total2 = 0;
        private void Button8_Click(object sender, EventArgs e)
        {
            resultBox.Text += button8.Text;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            resultBox.Text += button9.Text;
        }

        private void ButtonSub_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(resultBox.Text);
            resultBox.Clear();
            ButtonSub = true;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            resultBox.Text += button0.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            resultBox.Text += button6.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            resultBox.Text += button5.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            resultBox.Text += button4.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            resultBox.Text += button3.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            resultBox.Text += button2.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            resultBox.Text += button1.Text;
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
        }

        
        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {

        }

       

        private void Buttonadd_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(resultBox.Text);
            resultBox.Clear();
            Buttonadd = true;
        }

        

        private void ButtonEaual_Click(object sender, EventArgs e)
        {
            if (Buttonadd == true)
            {
                total2 = total1 + double.Parse(resultBox.Text);
                resultBox.Text = total2.ToString();
                total1 = 0;
            }else if (ButtonSub == true)
            {
                total2 = total1 - double.Parse(resultBox.Text);
                resultBox.Text = total2.ToString();
                total1 = 0;
            }
            
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/Ruhul14.02");
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            resultBox.Text += button1.Text;
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
