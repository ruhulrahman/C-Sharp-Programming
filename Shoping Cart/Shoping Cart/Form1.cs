using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Shoping_Cart
{
    public partial class Form1 : Form
    {
        ArrayList alproduct = new ArrayList();

        //private Product product = new Product();

        int sum = 0;


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {            
            
            //dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.White;            

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/Ruhul14.02");
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {            
            if(productNameBox.Text == "" || priceBox.Text =="" || quantityBox.Text =="")
            {
                MessageBox.Show("Please fill these fields");
            }

            string proName = productNameBox.Text;
            int price = Convert.ToInt32(priceBox.Text);
            int qty = int.Parse(quantityBox.Text);
            sum = 0;
            alproduct.Add(new Product(proName, price, qty));

                        
            ShowData();
            
            productNameBox.Clear();
            priceBox.Clear();
            quantityBox.Clear();

        }


        private void ShowData()
        {
            int i = 1;
            int n;
            
            int vat, totalWithoutVat;
            


            n = dataGridView1.Rows.Add();
            
            if (alproduct != null)
            {
                
                foreach (Product item in alproduct)
                {                    
                    dataGridView1.Rows[n].Cells[0].Value = i++;
                    dataGridView1.Rows[n].Cells[1].Value = item.ProductName;
                    dataGridView1.Rows[n].Cells[2].Value = item.Price;
                    dataGridView1.Rows[n].Cells[3].Value = item.Quantity;
                    dataGridView1.Rows[n].Cells[4].Value = item.Price * item.Quantity;

                    sum = sum + item.Price * item.Quantity;
                }
            }






        }

        private void ShowTotalItemCost_Click(object sender, EventArgs e)
        {
            int n;

            n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = "";
            dataGridView1.Rows[n].Cells[1].Value = "";
            dataGridView1.Rows[n].Cells[2].Value = "";
            dataGridView1.Rows[n].Cells[3].Value = "Total Cost: ";
            dataGridView1.Rows[n].Cells[4].Value = sum;
        }
    }
}
