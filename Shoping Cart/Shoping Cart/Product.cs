using System;

namespace Shoping_Cart
{
    class Product
    {
        string productName;
        int price;
        int quantity;

        public Product()
        {

        }

        public Product(string productName, int price, int quantity)
        {
            ProductName = productName ?? throw new ArgumentNullException(nameof(productName));
            Price = price;
            Quantity = quantity;
        }



        public string ProductName { get => productName; set => productName = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
