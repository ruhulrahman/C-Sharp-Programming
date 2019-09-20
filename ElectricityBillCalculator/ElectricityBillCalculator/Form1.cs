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
        private double peakHour, offPeakHour, result, peakTotalBill, offPeakTotalBill;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (peakHourBox.Text == "")
            {
                peakHour = 0.0;
            }
            else
            {
                peakHour = double.Parse(peakHourBox.Text);
            }


            if (offPeakHourBox.Text == "")
            {
                offPeakHour = 0.0;
            }
            else
            {
                offPeakHour = double.Parse(offPeakHourBox.Text);
            }


            if (radioButtonResident.Checked == true)
            {
                peakTotalBill = peakHour * 0.053;
                offPeakTotalBill = offPeakHour * 0.053;

                if (peakHourBox.Text == "")
                {
                    peakTotalBill = 0.0;
                }
                else if(peakTotalBill >= 1 && peakTotalBill <= 10)
                {
                    peakTotalBill = 10.0;
                }
                else
                {
                    peakTotalBill = peakHour * 0.053;
                }

                if (offPeakHourBox.Text == "")
                {
                    offPeakTotalBill = 0.0;
                }
                else if (offPeakTotalBill < 10)
                {
                    offPeakTotalBill = 10.0;
                }
                else
                {
                    offPeakTotalBill = offPeakHour * 0.053;
                }

                result = peakTotalBill + offPeakTotalBill;

                output(result);

            }else if(radioButtonCommercial.Checked == true)
            {
                if (peakHourBox.Text == "")
                {
                    peakTotalBill = 0.0;
                }
                else if (peakHour <= 800)
                {
                    peakTotalBill = 50;
                }
                else
                {
                    double extraHour = peakHour - 800;
                    double extraBill = extraHour * 0.042;
                    peakTotalBill = 50 + Convert.ToSingle(extraBill);
                }

                if (offPeakHourBox.Text == "")
                {
                    offPeakTotalBill = 0.0;
                }
                else if (offPeakHour <= 800)
                {
                    offPeakTotalBill = 50;
                }
                else
                {
                    double extraHour = peakHour - 800;
                    double extraBill = extraHour * 0.042;
                    peakTotalBill = 50 + Convert.ToSingle(extraBill);
                }

                result = peakTotalBill + offPeakTotalBill;

                output(result);

            }
            else if(radioButtonIndustrial.Checked == true)
            {


                if (peakHourBox.Text == "")
                {
                    peakTotalBill = 0.0;
                }
                else if (peakHour <= 800)
                {
                    peakTotalBill = 70.0;
                }
                else
                {
                    double extraHour = peakHour - 800;
                    double extraBill = extraHour * 0.062;
                    peakTotalBill = 70 + Convert.ToSingle(extraBill);
                }

                if (offPeakHourBox.Text == "")
                {
                    offPeakTotalBill = 0.0;
                }
                else if (offPeakHour <= 800)
                {
                    offPeakTotalBill = 35.0;
                }
                else
                {
                    double extraHour = peakHour - 800;
                    double extraBill = extraHour * 0.025;
                    offPeakTotalBill = 35 + Convert.ToSingle(extraBill);
                }

                result = peakTotalBill + offPeakTotalBill;

                output(result);

            }
        }

        private void output(double result)
        {
            resultBox.Text = result.ToString();
        }
    }
}
