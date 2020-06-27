using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            var customer = new Customer
            {
                firstName = "Bilbo",
                lastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            // Act
            string actual = customer.fullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            var customer = new Customer();
            customer.lastName = "Baggins";
            string expected = "Baggins";

            // Act
            string actual = customer.fullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            var customer = new Customer();
            customer.firstName = "Bilbo";
            string expected = "Bilbo";

            // Act
            string actual = customer.fullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.firstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.firstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.firstName = "Rosie";
            Customer.InstanceCount += 1;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
