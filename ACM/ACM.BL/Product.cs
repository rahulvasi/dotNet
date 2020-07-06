using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName {
            get
            {
                return StringHandler.InsertSpaces(ProductName);
            }
            set
            {
                this.ProductName = value;
            }
        }

        public string Log() =>
            $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";
        public override string ToString() => ProductName;

        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        // Validate the product data
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
