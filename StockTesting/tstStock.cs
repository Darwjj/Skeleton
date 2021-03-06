using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StockTesting;


namespace StockTesting
{
    [TestClass]
    public class tstStock
    {



        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }



        [TestMethod]
        public void StockIdPropertyOK()
        {

            clsStock AStock = new clsStock();

            Int32 StockId = 1;
            AStock.StockId = StockId;

            Assert.AreEqual(AStock.StockId, StockId);

        }



        [TestMethod]

        public void ProductCatogeryPropertyOK()
        {

            clsStock AStock = new clsStock();

            string ProductCategory = "Starters";
            AStock.ProductCategory = ProductCategory;

            Assert.AreEqual(AStock.ProductCategory, ProductCategory);

        }



        [TestMethod]
        public void QuantityPropertyOK()
        {

            clsStock AStock = new clsStock();

            Int32 Quantity = 3;
            AStock.Quantity = Quantity;

            Assert.AreEqual(AStock.Quantity, Quantity);

        }


        [TestMethod]
        public void DatePropertyOK()
        {

            clsStock AStock = new clsStock();
            DateTime Date = Convert.ToDateTime("02/01/2022");
            AStock.Date = Date;
            Assert.AreEqual(AStock.Date, Date);

        }


        [TestMethod]
        public void AvailablePropertyOK()
        {

            clsStock AStock = new clsStock();

            Boolean TestData = true;
            AStock.Available = TestData;
            Assert.AreEqual(AStock.Available, TestData);

        }

        [TestMethod]
        public void ProductNamePropertyOK()
        {

            clsStock AStock = new clsStock();

            string ProductName = "The ultimate 'cheese cake'";
            AStock.ProductName = ProductName;

            Assert.AreEqual(AStock.ProductName, ProductName);

        }


       
        //==================================    Find and Found method            ============================



        [TestMethod]
        public void FindMethodOk()
        {

            clsStock AStock = new clsStock();

            Boolean Found = false;

            Int32 StockId = 1;
            Found = AStock.Find(StockId);

            Assert.IsTrue(Found);

        }

        //===========================================
    

        [TestMethod]
        public void TestStockIdFound()
        {

            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 1;

            Found = AStock.Find(StockId);

            if (AStock.StockId != 1) {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        //=================================================
        

        [TestMethod]
        public void TestProductCategoryFound()
        {

            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 1;

            Found = AStock.Find(StockId);

            if (AStock.ProductCategory != "Soft Drinks") {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        //=================================================
    

        [TestMethod]
        public void TestQuantityFound()
        {

            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 1;

            Found = AStock.Find(StockId);

            if (AStock.Quantity != 2) {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        //=================================================

        [TestMethod]
        public void TestDateFound()
        {

            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 1;

            Found = AStock.Find(StockId);

            if (AStock.Date != Convert.ToDateTime("12/12/2021")) {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        //=================================================
   
        [TestMethod]
        public void TestAvailableFound()
        {

            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 1;

            Found = AStock.Find(StockId);

            if (AStock.Available != true) {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        //=================================================
 
        [TestMethod]
        public void TestProductNameFound()
        {

            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockId = 1;

            Found = AStock.Find(StockId);

            if (AStock.ProductName != "Coke") {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}

