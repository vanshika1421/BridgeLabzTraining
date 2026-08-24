using System;

namespace DSA_Test
{
    public class Ecommerce
    {
        public int productId;
        public string productName;
        public int quantity;
        public double price;

        // Added for sorting/searching
        public string SKU;
        public double rating;

        public Ecommerce(int productId, string productName, int quantity, double price)
        {
            this.productName = productName;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
            this.SKU = productId.ToString();
            this.rating = 0;
        }

        public Ecommerce(string sku, string productName, double price, double rating)
        {
            this.SKU = sku;
            this.productName = productName;
            this.price = price;
            this.rating = rating;
            this.productId = 0;
            this.quantity = 1;
        }

        public override string ToString()
        {
            return SKU + " - " + productName + " - " + price + " - Rating: " + rating;
        }
    }
}