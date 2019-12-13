using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Store_Mangement
{
    public partial class AddProductForm : Form
    {
        enum Category
        {
            Electronics = 1,
            Computers = 2,
            Printers = 3,
            Wires = 4,
        }
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public AddProductForm()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=LAB_612_17;Initial Catalog=Storemanagement;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            textBoxTotalPrice.Text = 0.ToString();
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                comboBoxProductCat.Items.Add(item);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            con.Open();
            com.Connection = con;
            //com.CommandText = "Select * from user_info";
            //SqlDataReader dr = com.ExecuteReader();
            string productName = textBoxProductName.Text;
            string productModel = textBoxProductModel.Text;
            string prodExpireDate = dateTimePickerProdExipire.Text;
            string productCat = comboBoxProductCat.Text;
            int productPrice = Convert.ToInt32(ProductPrice.Value);
            int productQuantity = Convert.ToInt32(quantityBox.Value);
            //int totalPrice = int.Parse(textBoxTotalPrice.Text);

            if (productName == "" || productModel == "" || prodExpireDate == "" || productCat == "" || textBoxTotalPrice.Text == "")
            {
                MessageBox.Show("Please fill the filds");
            }
            else
            {              

                com.CommandText = "@INSERT INTO products (userId, name, userName, email, phone, password) VALUES ('" + productName + "','" + productModel + "','" + prodExpireDate + "','" + productCat + "','" + productPrice + "','" + productQuantity + "')";
                con.Close();
                MessageBox.Show("Producted added successfully");
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
