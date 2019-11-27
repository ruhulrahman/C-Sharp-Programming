using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Interest_Calculator
{
    public partial class Form1 : Form
    {
        private float year;
        private float balance, interestRate;
        private float totalInterest, totalInterestWithCapital, totalCycleInterest=0, totalCycleInterestWithCapital;
        private string bankList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Init();
            if(bankNamecomboBox.Text == "Sonali")
            {
                interestRate = percent(8);
            }else if (bankNamecomboBox.Text == "Brack")
            {
                interestRate = percent(5);
            }else if (bankNamecomboBox.Text == "DBBL")
            {
                interestRate = percent(7);
            }else if (bankNamecomboBox.Text == "HSBC")
            {
                interestRate = percent(6);
            }
                       
            totalInterest = balance * year * interestRate;
            totalInterestWithCapital = balance + totalInterest;
            totalInterestWithCapBox.Text = totalInterestWithCapital.ToString();
            output(totalInterest);

            float CI;
            float q = 1 + interestRate;
            CI = (float) balance * (float) Math.Pow(q,year);
            totalCycleInterest = CI - balance;

            totalCycleInterestBox.Text = totalCycleInterest.ToString();
            totalCycleInterestWIthCapBox.Text = CI.ToString();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Ruhul14.02");
        }

        private void output(float totalInterest)
        {
            interestBox.Text = totalInterest.ToString();
        }

        private float percent(float percentAmount)
        {
            float result;
            result = percentAmount / 100;
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bankNamecomboBox.Items.Add("Sonali");
            bankNamecomboBox.Items.Add("Brack");
            bankNamecomboBox.Items.Add("DBBL");
            bankNamecomboBox.Items.Add("HSBC");
        }

        private void Init()
        {
            year = float.Parse(YearBox.Text);
            balance = float.Parse(balanceBox.Text);
            bankList = bankNamecomboBox.Text;
        }

        
    }
}
