using System;
using System.Collections.Generic;

namespace DSA_Test
{
    public class Payment
    {
        public PaymentNode AddCustomer(
            Queue<PaymentNode> q,
            PaymentNode n)
        {
            q.Enqueue(n);
            return n;
        }

        public PaymentNode FirstCustomer(
            Queue<PaymentNode> q)
        {
            if (q.Count == 0)
            {
                Console.WriteLine("Checkout queue is empty");
                return null;
            }

            PaymentNode paymentNode = q.Dequeue();

            Console.WriteLine(paymentNode.CustomerName);
            Console.WriteLine(paymentNode.customerId);

            return paymentNode;
        }

        public int QueueSize(Queue<PaymentNode> q)
        {
            return q.Count;
        }
    }
}