using System;
using System.Collections.Generic;

namespace DSA_Test
{
    public class Checkout : ShoppingCart
    {
        private Queue<PaymentNode> paymentQueue =
            new Queue<PaymentNode>();

        public Checkout(
            int productId,
            string productName,
            int quantity,
            double price)
            : base(productId, productName, quantity, price)
        {
        }

        public void AddPayment(PaymentNode payment)
        {
            paymentQueue.Enqueue(payment);
        }

        public PaymentNode ProcessingPayment()
        {
            if (paymentQueue.Count == 0)
            {
                Console.WriteLine("No payments to process");
                return null;
            }

            PaymentNode payment = paymentQueue.Dequeue();

            Console.WriteLine(
                "Processing payment for " +
                payment.CustomerName);

            return payment;
        }

        public int PendingPayments()
        {
            return paymentQueue.Count;
        }
    }
}