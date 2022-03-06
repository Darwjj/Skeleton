using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderProcessingTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AOrderProcessing.Find(OrderId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AOrderProcessing.Find(OrderId);
            //check the address no
            if (AOrderProcessing.OrderId != 21) {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TesOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AOrderProcessing.Find(OrderId);
            //check the property
            if (AOrderProcessing.OrderDate != Convert.ToDateTime("16/09/2015")) {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDescriptionFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AOrderProcessing.Find(OrderId);
            //check the property
            if (AOrderProcessing.OrderDescription != "Test Description") {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderAvailableFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AOrderProcessing.Find(OrderId);
            //check the property
            if (AOrderProcessing.OrderAvailable != true) {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AOrderProcessing.Find(OrderId);
            //check the property
            if (AOrderProcessing.Price != 1.0) {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AOrderProcessing.Find(OrderId);
            //check the property
            if (AOrderProcessing.OrderStatus != "Test Status") {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
