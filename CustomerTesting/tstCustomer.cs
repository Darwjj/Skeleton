
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace CustomerTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()

        {
            clsCustomer Customer = new clsCustomer();

            Assert.IsNotNull(Customer);

        }

        //Testing CustomerDescription property

        [TestMethod]

        public void CustomerDescriptionPropertyOK()

        {
            clsCustomer Customer = new clsCustomer();

            string TestData = "Omar patel";

            Customer.CustomerDescription = TestData;

            Assert.AreEqual(Customer.CustomerDescription, TestData);

        }

        //Testing CustomerID property

        [TestMethod]

        public void CustomerIDPropertyOK()

        {

            clsCustomer Customer = new clsCustomer();

            int TestData = 1;

            Customer.CustomerID = TestData;

            Assert.AreEqual(Customer.CustomerID, TestData);

        }



        //Testing Customer Gender property

        [TestMethod]

        public void Customer_GenderPropertyOK()

        {

            clsCustomer Customer = new clsCustomer();

            Boolean TestData = true;

            Customer.Gender = TestData;

            Assert.AreEqual(Customer.Gender, TestData);

        }



        //Testing ProductCost property

        [TestMethod]

        public void Customer_ProductCostPropertyOK()

        {

            clsCustomer Customer = new clsCustomer();

            String TestData = "Admin";

            Customer.ProductCost = TestData;

            Assert.AreEqual(Customer.ProductCost, TestData);

        }



        //Testing CustomerContact property

        [TestMethod]

        public void Customer_CustomerContactPropertyOK()

        {

            clsCustomer Customer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;

            Customer.CustomerContact = TestData;

            Assert.AreEqual(Customer.CustomerContact, TestData);

        }

        //Testing CustomerDOB property

        [TestMethod]

        public void Customer_CustomerDOBPropertyOK()

        {

            clsCustomer Customer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;

           Customer.CustomerDOB = TestData;

            Assert.AreEqual(Customer.CustomerDOB, TestData);

        }
    }
}


      
