using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SupplierTesting
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instances of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //test to see that exists
            Assert.IsNotNull(ASupplier);
        }
        [TestMethod]
        public void ActiveSupplierOk()
        {

            //create an instances of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data
            Boolean TestData = true;
            //assign the data to the supplier
            ASupplier.TestData = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.TestData, TestData);
        }
        [TestMethod]
        public void DateRegisteredSupplierOk()
        {

            //create an instances of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the supplier
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the supplier
            ASupplier.DateRegistered = TestData;

            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.DateRegistered, TestData);
        }
        [TestMethod]
        public void ASupplierNameOk()
        {

            //create an instances of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //create some test data to assign to the supplier
            string name = "David";
            //assign the data to the supplier
            ASupplier.Name = name;

            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.Name, name);
        }
        [TestMethod]
        public void ASupplierAddressOk()
        {

            //create an instances of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the supplier
            string Address = "Leicester";
            //assign the data to the supplier
            ASupplier.Address = Address;

            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.Address, Address);
        }
        [TestMethod]
        public void ASupplierIdOk()
        {

            //create an instances of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the supplier
            int Id = 12;
            //assign the data to the supplier
            ASupplier.Id = Id;
            Assert.AreEqual(ASupplier.Id, Id);
        }
        [TestMethod]
        public void ASupplierEmailOk()
        {
            //create an instances of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the supplier
            string Email = "David@gmail.com";
            //assign the data to the supplier
            ASupplier.Email = Email;
            Assert.AreEqual(ASupplier.Email, Email);
        }
    }
}
