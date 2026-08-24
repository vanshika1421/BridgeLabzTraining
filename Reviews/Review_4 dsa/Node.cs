using System;

namespace DSA_Test
{
    public class Node
    {
        public int data;
        public string productName;

        public int quantity;
        public double price;
        public double rating;
        public string SKU;

        public Node prev;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.SKU = data.ToString();
            this.quantity = 1;
        }

        public Node(string name)
        {
            productName = name;
            quantity = 1;
        }

        public Node(string sku, string name, double price, double rating)
        {
            SKU = sku;
            productName = name;
            this.price = price;
            this.rating = rating;
            quantity = 1;

            if (sku.StartsWith("SKU"))
            {
                int.TryParse(sku.Substring(3), out data);
            }
        }
    }
}