using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Mangement
{
    class ProductClass
    {
        private int id;
        private string productName;
        private string productModel;
        private string productExpireDate;
        private double productPrice;
        private int productQty;
        private double totalPrice;
        private string date;

        public int Id { get => id; set => id = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductModel { get => productModel; set => productModel = value; }
        public string ProductExpireDate { get => productExpireDate; set => productExpireDate = value; }
        public double ProductPrice { get => productPrice; set => productPrice = value; }
        public int ProductQty { get => productQty; set => productQty = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Date { get => date; set => date = value; }
    }
}
