using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Test_Frameword

{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.StockId = 1;
            TestItem.ProductCategory = "Soft Drinks";
            TestItem.Quantity = 2;
            TestItem.Date = DateTime.Now.Date;
            TestItem.ProductName = "Coke";
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }



        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStock AllStock = new clsStock();
            clsStock TestStock = new clsStock();
            TestStock.Available = true;
            TestStock.StockId = 1;
            TestStock.ProductCategory = "Soft Drinks";
            TestStock.Quantity = 2;
            TestStock.Date = DateTime.Now.Date;
            TestStock.ProductName = "Coke";
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStock AllStock = new clsStock();
            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.StockId = 1;
            TestItem.ProductCategory = "Soft Drinks";
            TestItem.Quantity = 2;
            TestItem.Date = DateTime.Now.Date;
            TestItem.ProductName = "Coke";
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }



        // ================================================   Create Add Method  ===============================

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.StockId = 1;
            TestItem.ProductCategory = "Soft Drinks";
            TestItem.Quantity = 12;
            TestItem.Date = Convert.ToDateTime("12/12/2021");
            TestItem.ProductName = "Coke";
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockId = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance fof the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.StockId = 2;
            TestItem.ProductCategory = "Desserts";
            TestItem.Quantity = 5;
            TestItem.Date = Convert.ToDateTime("01/01/2022");
            TestItem.ProductName = "Chocolate brownie";
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();

            TestItem.StockId = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            //modify the data

            TestItem.Available = true;
            TestItem.StockId = PrimaryKey;
            TestItem.ProductCategory = "Desserts";
            TestItem.Quantity = 5;
            TestItem.Date = Convert.ToDateTime("01/01/2022");
            TestItem.ProductName = "white brownie";


            AllStock.ThisStock = TestItem;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance fof the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.StockId = PrimaryKey;
            TestItem.ProductCategory = "Starters";
            TestItem.Quantity = 3;
            TestItem.Date = Convert.ToDateTime("02/01/2022");
            TestItem.ProductName = "The ultimate 'cheese cake'";

            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockId = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByStock_NameMethodOK()
        {
            //create an instance fof the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportbyProductName("");
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);

        }
        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportbyProductName("Pepsi");
            Assert.AreEqual(0, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportbyProductName("Veggie Mild");
            if (FilteredStock.Count == 2) {
                if (FilteredStock.StockList[0].StockId != 5) {
                    OK = false;
                }
                if (FilteredStock.StockList[1].StockId != 2011) {
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

