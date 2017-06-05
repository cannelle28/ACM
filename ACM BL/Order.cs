using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderID)
        {
            this.OrderID = orderID;
        }

        public int OrderID { get; set; }
        public DateTimeOffset? OrderDate { get; set; }  // track date, time, timezone

        public Order Retrieve(int orderID)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null)
                isValid = false;
            return isValid;
        }


    }
}
