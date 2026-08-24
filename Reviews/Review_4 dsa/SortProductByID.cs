using System;
using System.Collections.Generic;

namespace DSA_Test
{
    public class SortProductByID
    {
        public LinkedList<Node> SortById(
            LinkedList<Node> cart)
        {
            if (cart == null || cart.Count <= 1)
            {
                return cart;
            }

            LinkedListNode<Node> current = cart.First;

            while (current != null)
            {
                LinkedListNode<Node> next = current.Next;

                while (next != null)
                {
                    if (current.Value.data > next.Value.data)
                    {
                        Node temp = current.Value;

                        current.Value = next.Value;
                        next.Value = temp;
                    }

                    next = next.Next;
                }

                current = current.Next;
            }

            return cart;
        }

        public List<Ecommerce> SortByPrice(
            List<Ecommerce> products)
        {
            for (int i = 0; i < products.Count - 1; i++)
            {
                for (int j = 0; j < products.Count - i - 1; j++)
                {
                    if (products[j].price > products[j + 1].price)
                    {
                        Ecommerce temp = products[j];

                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }

            return products;
        }

        public List<Ecommerce> SortByRating(
            List<Ecommerce> products)
        {
            for (int i = 0; i < products.Count - 1; i++)
            {
                for (int j = 0; j < products.Count - i - 1; j++)
                {
                    if (products[j].rating < products[j + 1].rating)
                    {
                        Ecommerce temp = products[j];

                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }

            return products;
        }

        // Catalog must already be sorted by SKU
        public Ecommerce BinarySearchBySKU(
            List<Ecommerce> products,
            string sku)
        {
            int left = 0;
            int right = products.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                int result = String.Compare(
                    products[mid].SKU,
                    sku,
                    StringComparison.Ordinal);

                if (result == 0)
                {
                    return products[mid];
                }

                if (result < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return null;
        }
    }
}