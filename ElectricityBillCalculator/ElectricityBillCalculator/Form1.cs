using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricityBillCalculator
{
    public partial class Form1 : Form
    {
        private Boolean residential, commercial, industrial;
        private float peakHour, offPeakHour, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            input();

            if(radioButtonResident.Checked == true)
            {
                result = peakHour * 10;
                output(result);
            }else if(radioButtonCommercial.Checked == true)
            {
                if (peakHour <= 800)
                {
                    result = peakHour * 50;
                    output(result);
                }
                else
                {
                    result = peakHour * 50;
                    float extraHour = peakHour - 800;
                    double extraBill = extraHour * 70.042;
                    result = result + Convert.ToSingle(extraBill);
                    output(result);
                }
                
            }else if(radioButtonIndustrial.Checked == true)
            {
                float peakTotalBill, offPeakTotalBill;

                if (peakHour <= 800)
                {
                    peakTotalBill = peakHour * 70;
                    output(result);
                }
                else
                {
                    result = peakHour * 70;
                    float extraHour = peakHour - 800;
                    double extraBill = extraHour * 70.062;
                    peakTotalBill = result + Convert.ToSingle(extraBill);
                }

                if (offPeakHour <= 800)
                {
                    offPeakTotalBill = offPeakHour * 35;
                }
                else
                {
                    result = peakHour * 35;
                    float extraHour = peakHour - 800;
                    double extraBill = extraHour * 35.025;
                    offPeakTotalBill = result + Convert.ToSingle(extraBill);
                }

                result = peakTotalBill + offPeakTotalBill;

                output(result);

            }
        }

        private void input()
        {
            peakHour = float.Parse(peakHourBox.Text);
            offPeakHour = float.Parse(offPeakHourBox.Text);
        }
        private void output(float result)
        {
            resultBox.Text = result.ToString();
        }
    }
}
