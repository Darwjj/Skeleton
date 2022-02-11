using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public void DescriptionOK()
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
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MinLessOne()
        {
            clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
            string Error = "";
            string TestData = nDescription;
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
    }
}
