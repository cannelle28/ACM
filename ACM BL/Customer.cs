using System;
using System.Collections.Generic;

namespace ACM_BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerID)
        {
            this.CustomerID = customerID;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerID { get; private set; }
        public string FullName
        {
            get
            {
                return LastName + " " + FirstName;
            }
        }

        public static int InstanceCount { get; set; }

        public Customer Retrieve(int CustomerID)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }


        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
                isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress))
                isValid = false;

            return isValid;
        }
    }
}
