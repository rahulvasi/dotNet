using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;    
        }

        // Validate the order data
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
