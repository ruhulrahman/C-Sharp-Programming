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
        ArrayList productNameList = new ArrayList();
        ArrayList priceList = new ArrayList();
        ArrayList quantityList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 0;
            for(int i=0; i<3; i++)
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "1";
                dataGridView1.Rows[n].Cells[1].Value = "Rice";
                dataGridView1.Rows[n].Cells[2].Value = "50";
                dataGridView1.Rows[n].Cells[3].Value = "3";
                dataGridView1.Rows[n].Cells[4].Value = "150";
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "2";
                dataGridView1.Rows[n].Cells[1].Value = "Dal";
                dataGridView1.Rows[n].Cells[2].Value = "100";
                dataGridView1.Rows[n].Cells[3].Value = "2";
                dataGridView1.Rows[n].Cells[4].Value = "200";
            }

            dataGridView1.Rows[n].Cells[0].Value = "";
            dataGridView1.Rows[n].Cells[1].Value = "";
            dataGridView1.Rows[n].Cells[2].Value = "";
            dataGridView1.Rows[n].Cells[3].Value = "Total Cost: ";
            dataGridView1.Rows[n].Cells[4].Value = "450";

            dataGridView1.Rows[n].DefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.White;
            

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
            //productNameList.Add(productNameBox.Text);
            //priceList.Add(priceBox.Text);
            //quantityList.Add(quantityBox.Text);
            Product products = new Product(productNameBox.Text, int.Parse(priceBox.Text), int.Parse(quantityBox.Text));
            productNameList.Add(products);
            ShowData();

            productNameBox.Clear();
            priceBox.Clear();
            quantityBox.Clear();
        }

        private void ShowData()
        {
            int i = 0;
            foreach (string item in productNameList)
            {
                //listItemBox.Items.Add(item);
                dataGridView1.Rows.Add(i++, item, priceList, quantityList);
            }
        }
    }
}
