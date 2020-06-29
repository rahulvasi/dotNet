﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace ACM.BL
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName 
        { 
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int InstanceCount { get; set; }

        // Constructor without parameters
        public Customer()
        {

        }

        // Constructor with parameters
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        // Retrieve one customer
        public Customer Retrieve(int customerId)
        {

            return new Customer();
        }

        // Validate the customer data
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
