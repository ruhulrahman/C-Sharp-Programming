using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Mangement
{
    class SellClass
    {
        private int id;
        private int productId;
        private int productQty;
        private double discountPrice;
        private double totalPrice;
        private string date;
        private int userId;

        public int Id { get => id; set => id = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int ProductQty { get => productQty; set => productQty = value; }
        public string Date { get => date; set => date = value; }
        public double DiscountPrice { get => discountPrice; set => discountPrice = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
