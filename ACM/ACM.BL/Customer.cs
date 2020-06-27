using System;

namespace ACM.BL
{
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public int customerId { get; private set; }
        public string fullName 
        { 
            get
            {
                string fullName = lastName;
                if (!string.IsNullOrWhiteSpace(firstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += firstName;
                }
                return fullName;
            }
                
        }
        public static int InstanceCount { get; set; }
        
    }
}
