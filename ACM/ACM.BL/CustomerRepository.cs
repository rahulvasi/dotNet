using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        // Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "vasireddi.rahul@gmail.com";
                customer.FirstName = "Rahul";
                customer.LastName = "Vasireddi";
            }
            return customer;
        }

        // Saves the current customer
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
