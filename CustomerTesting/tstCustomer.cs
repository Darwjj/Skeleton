
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace CustomerTesting
{
    [TestClass]
    public class UnitTest1
    {
        private string TestString = "Some Test String";
        string CustomerDob = new DateTime(1960, 01, 01).ToString();
        private decimal TestDec = 123;
        private int Testint = 456;

        public object CustomerId { get; private set; }

        [TestMethod]
        public void InstanceOK()

        {
            clsCustomer Customer = new clsCustomer();

           // Assert.IsNotNull(AnCustomer);

        }

        //Testing CustomerDescription property

        [TestMethod]

        public void CustomerDescriptionPropertyOK()

        {
            clsCustomer AnCustomer = new clsCustomer();

            string TestData = TestString;

            AnCustomer.CustomerDescription = TestData;

            Assert.AreEqual(AnCustomer.CustomerDescription, TestData);

        }

        //Testing CustomerID property

        [TestMethod]

        public void CustomerIDPropertyOK()

        {

            clsCustomer Customer = new clsCustomer();

            string TestData = TestString;

           // Customer.CustomerID = TestData;

            Assert.AreEqual(Customer.CustomerID, TestData);

        }



        //Testing Customer Gender property

        [TestMethod]

        public void Customer_GenderPropertyOK()

        {

            clsCustomer Customer = new clsCustomer();

            Boolean TestData = true;

            Customer.Marketting = TestData;

            Assert.AreEqual(Customer.Marketting, TestData);

        }



        //Testing ProductCost property

        [TestMethod]

        public void Customer_ProductCostPropertyOK()

        {

            clsCustomer Customer = new clsCustomer();

            decimal TestData = TestDec;

            Customer.ProductCost = TestData;

            Assert.AreEqual(Customer.ProductCost, TestData);

        }



        //Testing CustomerContact property

        [TestMethod]

        public void Customer_CustomerContactPropertyOK()

        {

            clsCustomer Customer = new clsCustomer();

            int TestData = Testint;

            Customer.CustomerContact = TestData;

            Assert.AreEqual(Customer.CustomerContact, TestData);

        }

        //Testing CustomerDOB property

        [TestMethod]

        public void Customer_CustomerDOBPropertyOK()

        {

            clsCustomer Customer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;

            Customer.CustomerDob = TestData;

            Assert.AreEqual(Customer.CustomerDob, TestData);

        }

        //new code week - 23

        [TestMethod]

        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        
            }
        }








