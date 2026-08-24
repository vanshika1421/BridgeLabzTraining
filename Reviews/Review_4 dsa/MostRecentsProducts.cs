using System;
using System.Collections.Generic;

namespace DSA_Test
{
    public class MostRecentsProducts : Ecommerce
    {
        private int maxSize;

        public MostRecentsProducts(
            int productId,
            string productName,
            int quantity,
            double price)
            : base(productId, productName, quantity, price)
        {
            maxSize = 5;
        }

        public MostRecentsProducts(int maxSize)
            : base(0, "", 0, 0)
        {
            this.maxSize = maxSize;
        }

        public String getLatestViewedProduct(Stack<Node> stack)
        {
            if (stack.Count > 0)
            {
                return stack.Peek().productName;
            }

            return "No recently viewed items";
        }

        public void AddViewdProducts(
            Stack<Node> stack,
            Node product)
        {
            if (maxSize <= 0)
                return;

            if (stack.Count >= maxSize)
            {
                Stack<Node> temp = new Stack<Node>();

                while (stack.Count > 1)
                {
                    temp.Push(stack.Pop());
                }

                // Remove oldest item
                stack.Pop();

                while (temp.Count > 0)
                {
                    stack.Push(temp.Pop());
                }
            }

            stack.Push(product);
        }
    }
}