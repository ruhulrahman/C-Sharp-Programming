using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Mangement
{
    class BuyClass
    {
        private int id;
        private int productId;
        private int productQty;
        private double totalPrice;
        private string date;

        public int Id { get => id; set => id = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int ProductQty { get => productQty; set => productQty = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Date { get => date; set => date = value; }
    }
}
