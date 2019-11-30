using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Mangement
{
    class DiscountClass
    {
        private int id;
        private int productId;
        private double discountRate;
        private int discountPrice;

        public int Id { get => id; set => id = value; }
        public int ProductId { get => productId; set => productId = value; }
        public double DiscountRate { get => discountRate; set => discountRate = value; }
        public int DiscountPrice { get => discountPrice; set => discountPrice = value; }
    }
}
