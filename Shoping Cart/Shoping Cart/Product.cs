using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoping_Cart
{
    class Product
    {
        private string productName;
        private int price;
        private int quantity;

        public Product()
        {

        }

        public Product(string productName, int price, int quantity)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

    }
}
