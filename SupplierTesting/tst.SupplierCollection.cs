using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;




namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier AllSupplier = new clsSupplier();
            Assert.IsNotNull(AllSupplier);
        }
        [TestMethod]
        public void CustomeListOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.ASupplierID = 2;
            TestItem.ASupplierName = "Alexa";
            TestItem.ASupplierAddress = "Manchester";
            TestItem.Email = "fatAlexa@gmail.com";
            TestItem.DateOfRegister = Convert.ToDateTime("01/02/2005");
            TestItem.ASupplierAvailability = true;
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.SupplierList, TestList);
        }


        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.ASupplierID = 2;
            TestSupplier.ASupplierName = "Alexa";
            TestSupplier.ASupplierAddress = "Manchester";
            TestSupplier.Email = "fatAlexa@gmail.com";
            TestSupplier.DateOfRegister = Convert.ToDateTime("01/02/2005");
            TestSupplier.ASupplierAvailability = true;
            AllSupplier.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.ASupplierID = 2;
            TestItem.ASupplierName = "Alexa";
            TestItem.ASupplierAddress = "Manchester";
            TestItem.Email = "fatAlexa@gmail.com";
            TestItem.DateOfRegister = Convert.ToDateTime("01/02/2005");
            TestItem.ASupplierAvailability = true;
            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 Primarykey = 0;
            TestItem.ASupplierID = 2;
            TestItem.ASupplierAvailability = true;
            TestItem.DateOfRegister = Convert.ToDateTime("04/05/2012");
            TestItem.ASupplierName = "Dahlak";
            TestItem.ASupplierAddress = "Coventry";
            TestItem.Email = "Dahlak@gmail.com";



            AllSupplier.ThisSupplier = TestItem;
            Primarykey = AllSupplier.Add();
            TestItem.ASupplierID = Primarykey;
            AllSupplier.ThisSupplier.Find(Primarykey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }
       

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();


            Int32 Primarykey = 0;
            TestItem.ASupplierID = 2;
            TestItem.ASupplierName = "Alexa";
            TestItem.ASupplierAddress = "Manchester";
            TestItem.Email = "Alexa2@gmail.com";
            TestItem.DateOfRegister = Convert.ToDateTime("01/02/2005");
            TestItem.ASupplierAvailability = true;


            AllSupplier.ThisSupplier = TestItem;
            Primarykey = AllSupplier.Add();
            TestItem.ASupplierID = Primarykey;
            AllSupplier.ThisSupplier.Find(Primarykey);
 
            TestItem.ASupplierID = Primarykey;
            TestItem.ASupplierName = "Tom";
            TestItem.ASupplierAddress = "Leicester";
            TestItem.Email = "Tom@gmail.com";
            TestItem.DateOfRegister = Convert.ToDateTime("03/10/2014");
            TestItem.ASupplierAvailability = true;

            AllSupplier.ThisSupplier = TestItem;
            AllSupplier.Update();
            AllSupplier.ThisSupplier.Find(Primarykey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();


            Int32 PrimaryKey = 0;
            TestItem.ASupplierID = 2;
            TestItem.ASupplierName = "Tom";
            TestItem.ASupplierAddress = "Leicester";
            TestItem.Email = "Tom@gmail.com";
            TestItem.DateOfRegister = Convert.ToDateTime("03/10/2014");
            TestItem.ASupplierAvailability = true;


            AllSupplier.ThisSupplier = TestItem;
            PrimaryKey = AllSupplier.Add();
            TestItem.ASupplierID = PrimaryKey;
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            AllSupplier.Delete();
            Boolean Found = AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByASupplierNameMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            FilteredSupplier.ReportbyASupplierName("");
            Assert.AreEqual(AllSupplier.Count, FilteredSupplier.Count);


        }
        [TestMethod]
        public void ReportByASupplierNameNoneFound()
        {
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            FilteredSupplier.ReportbyASupplierName("Jerry");
            Assert.AreEqual(0, FilteredSupplier.Count);
        }
        [TestMethod]
        public void ThisReportbyASupplierNameTestDataFound()
        {
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSupplier.ReportbyASupplierName("Ahmed");
            if (FilteredSupplier.Count == 2) {
                if (FilteredSupplier.SupplierList[0].ASupplierID != 13) {
                    OK = false;
                }
                if (FilteredSupplier.SupplierList[1].ASupplierID != 15) {
                    OK = false;
                }
            }
            else {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }


}

