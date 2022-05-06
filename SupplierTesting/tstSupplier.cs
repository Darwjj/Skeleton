using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace SupplierTesting
{
    [TestClass]
    public class tstSupplier
 

    {
        string ASupplierName = "Alexa";
        string ASupplierAddress = "Manchester";
        string DateOfRegister = DateTime.Now.Date.ToString();
        string Email = "Alexa2@gmail.com";

        public int ASupplierID { get; private set; }

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
            ASupplier.ASupplierAvailability = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.ASupplierAvailability, TestData);
        }
        [TestMethod]
        public void DateRegisteredSupplierOk()
        {

            //create an instances of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the supplier
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the supplier
            ASupplier.DateOfRegister = TestData;

            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.DateOfRegister, TestData);
        }
        [TestMethod]
        public void ASupplierNameOk()
        {

            //create an instances of the class we want to create
            clsSupplier ASupplier = new clsSupplier();

            //create some test data to assign to the supplier
            string name = "David";
            //assign the data to the supplier
            ASupplier.ASupplierName = name;

            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.ASupplierName, name);
        }
        [TestMethod]
        public void ASupplierAddressOk()
        {

            //create an instances of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the supplier
            string Address = "Leicester";
            //assign the data to the supplier
            ASupplier.ASupplierAddress = Address;

            //test to see if the two values are the same
            Assert.AreEqual(ASupplier.ASupplierAddress, Address);
        }
        [TestMethod]
        public void ASupplierIdOk()
        {

            //create an instances of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the supplier
            int Id = 12;
            //assign the data to the supplier
            ASupplier.ASupplierID= Id;
            Assert.AreEqual(ASupplier.ASupplierID, Id);
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

        //======= Find method===========
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of a class
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ASupplierID = 4;
            //invoke the method
            Found = ASupplier.Find(ASupplierID);
            //test to see the result is correct
            Assert.IsTrue(Found);

        }
        //ref back
        [TestMethod]
        public void TestASupplierIDFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ASupplierID = 4;
            Found = ASupplier.Find(ASupplierID);
            //check the supplier ID
            if(ASupplier.ASupplierID !=4) {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestASupplierNameFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ASupplierID = 4;
            Found = ASupplier.Find(ASupplierID);

            //check for supplier
            if(ASupplier.ASupplierName != "David") {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //
        [TestMethod]
        public void TestASupplierAddressFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ASupplierID = 2;
            Found = ASupplier.Find(ASupplierID);
            if(ASupplier.ASupplierAddress != "Manchester") {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ASupplierID = 2;
            Found = ASupplier.Find(ASupplierID);
            if(ASupplier.Email != "Alexa2@gmail.com") {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDateOfRegisterFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ASupplierID = 2;
            Found = ASupplier.Find(ASupplierID);
            if(ASupplier.DateOfRegister != Convert.ToDateTime("01/02/2005")) {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestASupplierAvailabilityFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ASupplierID = 2;
            Found = ASupplier.Find(ASupplierID);
            if(ASupplier.ASupplierAvailability != true) {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //========================================validation=========================================
       
        //test for valid method
       [TestMethod]
       public void ValidMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            Error = ASupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreEqual(Error, "");

        }
        //==========ASupplierName validation test=========
        [TestMethod]
        public void ASupplierNameMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierName = "";    //should trigger an error
            Error = ASupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierNameMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierName = "a";
            Error = ASupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierNameMinPlusOne()
        {

            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierName = "aa"; //this should be ok
            
            Error = ASupplier.Valid( ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierNameMaxLessOne()
        {

            clsSupplier ASupplier = new clsSupplier();

            String Error = "";
            string ASupplierName = ""; //this should be ok  ref back
            ASupplierName = ASupplierName.PadRight(49, 'a');
            Error = ASupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierNameMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierName = "";
            ASupplierName = ASupplierName.PadRight(50,'a');
            Error = ASupplier.Valid( ASupplierName, ASupplierAddress, Email, DateOfRegister);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierNameMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierName = "";
            ASupplierName = ASupplierName.PadRight(25, 'a');
            Error = ASupplier.Valid( ASupplierName,ASupplierAddress, Email, DateOfRegister);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierNameMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierName = "";
            ASupplierName = ASupplierName.PadRight(51, 'a');
            Error = ASupplier.Valid( ASupplierName, ASupplierAddress, Email, DateOfRegister) ;

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierNameExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierName = "";
            ASupplierName = ASupplierName.PadRight(500, 'a'); //this should fail
            Error = ASupplier.Valid( ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreNotEqual(Error, "");
        }
        //*******ASupplierAddress validation testing*************//

        [TestMethod]
        public void ASupplierAddressMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierAddress = "";
            Error = ASupplier.Valid( ASupplierName,ASupplierAddress, Email, DateOfRegister);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierAddressMin()
        {

            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierAddress = "a";
            Error = ASupplier.Valid( ASupplierName,ASupplierAddress, Email, DateOfRegister);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierAddressMinPlusOne()
        {

            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierAddress = "aa";          //ref back 
            Error = ASupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierAddressMaxLessOne()
        {

            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierAddress = "";
            ASupplierAddress = ASupplierAddress.PadRight(49, 'a');
            Error = ASupplier.Valid( ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierAddressMax()
        {

            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierAddress = "";
            ASupplierAddress = ASupplierAddress.PadRight(50, 'a');
            Error = ASupplier.Valid( ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierAddressMaxPlusOne()
        {

            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierAddress = "";
            ASupplierAddress = ASupplierAddress.PadRight(500, 'a');
            Error = ASupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierAddressMid()
        {

            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierAddress = "";         
            ASupplierAddress = ASupplierAddress.PadRight(25, 'a');
            Error = ASupplier.Valid( ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ASupplierAddressExtrem() {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string ASupplierAddress = "";
            ASupplierAddress = ASupplierAddress.PadRight(500, 'a');
            Error = ASupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreNotEqual(Error, "");
        
        }
        //======= DateOfRegister validation testing========
      

       
        [TestMethod]
        public void DateOfRegisterExtremeMax()
        {
  
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateOfRegister = TestDate.ToString();
            Error = AnSupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOfRegisterLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateOfRegister = TestDate.ToString();
            Error = AnSupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateOfRegisterMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOfRegister = TestDate.ToString();
            Error = AnSupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateOfRegisterMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateOfRegister = TestDate.ToString();
            Error = AnSupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void DateOfRegisterInvalidData()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string DateOfRegister = "This is not a vaid date!"; 
            ASupplierName = ASupplierName.PadRight(500, 'q'); 
            Error = AnSupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreNotEqual(Error, "");
        }


    [TestMethod]
        public void EmailMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Email = "Q";
            Error = AnSupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
            Assert.AreEqual(Error, "");
        }


     

    }
}
