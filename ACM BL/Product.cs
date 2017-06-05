using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productID)
        {
            this.ProductID = productID;
        }

        public int ProductID { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
        public Decimal? CurrentPrice { get; set; }

        public Product Retrieve(int productID)
        {
            return new Product();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
                isValid = false;
            if (CurrentPrice == null)
                isValid = false;

            return isValid;
        }
    }
}
