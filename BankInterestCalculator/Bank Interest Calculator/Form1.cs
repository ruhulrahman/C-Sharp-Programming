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
        private float totalInterest;
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
            output(totalInterest);
        }

        private void output(float totalInterest)
        {
            resultBox.Text = totalInterest.ToString();
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
