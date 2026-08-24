using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Test
{
    public class PaymentNode
    {
        public String CustomerName;
        public int customerId;
        public PaymentNode(String CustomerName, int CustomerId)
        {
            this.customerId = CustomerId;
            this.CustomerName = CustomerName;
        }
    }
}
