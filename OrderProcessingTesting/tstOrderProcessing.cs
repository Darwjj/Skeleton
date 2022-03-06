using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderProcessingTesting
{
    [TestClass]
    public class tstOrderProcessing
    {
        //good test data
        private string nDescription = "Some Description";

        [TestMethod]
        public void InstanceOK()
        {
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            Assert.IsNotNull(AOrderProcessing);
        }

        [TestMethod]
        public void OrderDescriptionOK()
        {
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            string TestData = nDescription;
            AOrderProcessing.OrderDescription = TestData;
            Assert.AreEqual(AOrderProcessing.OrderDescription, TestData);
        }

        [TestMethod]
        public void ValidOK()
        {
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            string Error = "";
            string TestData = nDescription;
            Error = AOrderProcessing.Valid(nDescription);
            Assert.AreEqual(Error, "Description cannot be more than 50 characters");
        }

        [TestMethod]
        public void MinLessOne()
        {
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            string Error = "";
            string TestData = "";
            Error = AOrderProcessing.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MaxPlusOne()
        {
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = AOrderProcessing.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AOrderProcessing.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrderProcessing.OrderDate, TestData);
        }

        [TestMethod]

        public void OrderAvailableOK()

        {
            //create an instance of the class we want to create
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AOrderProcessing.OrderAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrderProcessing.OrderAvailable, TestData);

        }

        [TestMethod]
        public void OrderIdOK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AOrderProcessing.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrderProcessing.OrderId, TestData);
        }

        [TestMethod]

        public void PriceOK()
        {
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();

            Double TestData = 1;

            AOrderProcessing.Price = (double)(decimal)TestData;

            Assert.AreEqual(AOrderProcessing.Price, TestData);
        }

        [TestMethod]

        public void OrderStatusOK()

        {
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();


            string TestData = "Ready";


            AOrderProcessing.OrderStatus = TestData;


            Assert.AreEqual(AOrderProcessing.OrderStatus, TestData);

        }









    }
}


