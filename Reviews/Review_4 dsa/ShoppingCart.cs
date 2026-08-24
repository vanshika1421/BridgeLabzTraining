using System;
using System.Collections.Generic;

namespace DSA_Test
{
    public class ShoppingCart : Ecommerce
    {
        public int productId;
        public string productName;
        public int quantity;
        public double price;

        public ShoppingCart(
            int productId,
            string productName,
            int quantity,
            double price)
            : base(productId, productName, quantity, price)
        {
        }

        public Node Head;

        public int data;

        public LinkedList<Node> Additems(
            LinkedList<Node> cart,
            int productId)
        {
            Node newNode = new Node(productId);

            newNode.productName = "Product " + productId;
            newNode.quantity = 1;

            cart.AddFirst(newNode);

            Head = newNode;

            return cart;
        }

        public LinkedList<Node> Additems(
            LinkedList<Node> cart,
            Node product)
        {
            cart.AddFirst(product);

            Head = product;

            return cart;
        }

        public void RemoveItem(
    LinkedList<Node> cart,
    int productId)
        {
            LinkedListNode<Node> current = cart.First;

            while (current != null)
            {
                if (current.Value.data == productId)
                {
                    cart.Remove(current);

                    Head = cart.First != null ? cart.First.Value: null;

                    return;
                }

                current = current.Next;
            }
        
        }

        public int increaseQuantity(int quantity, int q)
        {
            return quantity + q;
        }

        public int decreaseQuantity(int quantity, int q)
        {
            int result = quantity - q;

            if (result < 0)
                result = 0;

            return result;
        }

        // Increase quantity of a cart product
        public bool IncreaseItemQuantity(
            LinkedList<Node> cart,
            int productId,
            int amount)
        {
            foreach (Node node in cart)
            {
                if (node.data == productId)
                {
                    node.quantity += amount;
                    return true;
                }
            }

            return false;
        }

        // Decrease quantity and remove when quantity becomes zero
        public bool DecreaseItemQuantity(
            LinkedList<Node> cart,
            int productId,
            int amount)
        {
            foreach (Node node in cart)
            {
                if (node.data == productId)
                {
                    node.quantity -= amount;

                    if (node.quantity <= 0)
                    {
                        cart.Remove(node);

                        Head = cart.First != null
                            ? cart.First.Value
                            : null;
                    }

                    return true;
                }
            }

            return false;
        }

        // Move item one position up
        public bool MoveUp(
            LinkedList<Node> cart,
            int productId)
        {
            LinkedListNode<Node> current = cart.First;

            while (current != null)
            {
                if (current.Value.data == productId)
                {
                    if (current.Previous == null)
                        return false;

                    Node temp = current.Value;

                    current.Value = current.Previous.Value;
                    current.Previous.Value = temp;

                    Head = cart.First.Value;

                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        // Move item one position down
        public bool MoveDown(
            LinkedList<Node> cart,
            int productId)
        {
            LinkedListNode<Node> current = cart.First;

            while (current != null)
            {
                if (current.Value.data == productId)
                {
                    if (current.Next == null)
                        return false;

                    Node temp = current.Value;

                    current.Value = current.Next.Value;
                    current.Next.Value = temp;

                    Head = cart.First.Value;

                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void Display(LinkedList<Node> cart)
        {
            if (cart == null || cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
                return;
            }

            foreach (Node node in cart)
            {
                Console.WriteLine(
                    node.data + " " +
                    node.productName + " Quantity: " +
                    node.quantity);
            }
        }

        public double BillCalcultion(
            int quantity,
            double price)
        {
            return quantity * price;
        }

        public double CalculateTotal(
            LinkedList<Node> cart)
        {
            double total = 0;

            foreach (Node node in cart)
            {
                total += node.quantity * node.price;
            }

            return total;
        }
    }
}