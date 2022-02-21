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
            AOrderProcessing.Description = TestData;
            Assert.AreEqual(AOrderProcessing.Description, TestData);
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
        public void DateAddedOrderK()
        {
            //create an instance of the class we want to create
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AOrderProcessing.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AOrderProcessing.DateAdded, TestData);
        }

    }
}


