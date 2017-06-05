using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemID)
        {
            this.OrderItemID = orderItemID;
        }

        public int OrderItemID { get; private set; }
        public int OrderQuantiy { get; set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }

        public OrderItem Retrieve(int orderItemID)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (OrderQuantiy <= 0)
                isValid = false;
            if (ProductID <= 0)
                isValid = false;
            if (PurchasePrice == null)
                isValid = false;

            return isValid;
        }
    }
}
