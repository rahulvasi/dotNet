using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        // Retrieve one order item
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        // Saves the current order item
        public bool Save()
        {
            return true;
        }

        // Validates the order item data
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
