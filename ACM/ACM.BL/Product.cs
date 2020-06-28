using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product
    {
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        // Retrieve one product
        public Product Retrieve(int productId)
        {
            return new Product();
        }

        // Saves current product
        public bool Save()
        {
            return true;
        }

        // Validate the product data
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
