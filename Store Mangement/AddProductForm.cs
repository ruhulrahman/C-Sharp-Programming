using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Mangement
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            textBoxTotalPrice.Text = 0.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            string productModel = textBoxProductModel.Text;
            string prodExpireDate = dateTimePickerProdExipire.Text;
            string productCat = comboBoxProductCat.Text;
            int productPrice = Convert.ToInt32(ProductPrice.Value);
            int productQuantity = Convert.ToInt32(quantityBox.Value);
            //int totalPrice = int.Parse(textBoxTotalPrice.Text);

            if (productName == "" || productModel == "" || prodExpireDate == "" || productCat == "" || textBoxTotalPrice.Text == "")
            {
                MessageBox.Show("Please fill these fields");
            }
            else
            {
                int totalPrice = productPrice * productQuantity;
                textBoxTotalPrice.Text = totalPrice.ToString();
            }

        }

        public void Multiply()
        {
            //int price;
            //false(int.TryParse)
            int productPrice = Convert.ToInt32(ProductPrice.Value);
            int productQuantity = Convert.ToInt32(quantityBox.Value);
            int totalPrice = productPrice * productQuantity;
            textBoxTotalPrice.Text = totalPrice.ToString();
        }


        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {
            Multiply();
        }
    }
}
