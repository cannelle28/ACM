using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM_BL;

namespace ACL.BL_Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // arrange, act, assert

            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins Bilbo";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount++;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount++;

            var c3 = new Customer();
            c2.FirstName = "Rosie";
            Customer.InstanceCount++;

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer();
            customer.EmailAddress = "abcd@defg.com";
            var expected = false;
            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
