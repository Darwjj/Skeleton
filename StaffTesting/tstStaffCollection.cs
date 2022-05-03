using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace StaffTesting
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an istance of the class we want to create 
            clsStaffCollection Staffs = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(Staffs);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection Staffs = new clsStaffCollection();
            //create some test data to assign to property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_FullName = "Kirtan Patel";
            TestItem.Staff_Gender = true;
            TestItem.Staff_Role = "Chef";
            TestItem.Staff_StartDate = Convert.ToDateTime("16/01/2022");
            TestItem.Staff_Salary = 14000;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Staffs.StaffList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(Staffs.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection Staffs = new clsStaffCollection();
            //create some test data to assign to property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Staff_ID = 1;
            TestStaff.Staff_FullName = "Kirtan Patel";
            TestStaff.Staff_Gender = true;
            TestStaff.Staff_Role = "Chef";
            TestStaff.Staff_StartDate = Convert.ToDateTime("16/01/2022");
            TestStaff.Staff_Salary = 14000;
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection Staffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Staff_ID = 1;
            TestItem.Staff_FullName = "Kirtan Patel";
            TestItem.Staff_Gender = true;
            TestItem.Staff_Role = "Chef";
            TestItem.Staff_StartDate = Convert.ToDateTime("16/01/2022");
            TestItem.Staff_Salary = 14000;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Staffs.StaffList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(Staffs.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection Staffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Staff_ID = 21;
            TestItem.Staff_FullName = "Kirtan Patel";
            TestItem.Staff_Gender = true;
            TestItem.Staff_Role = "Chef";
            TestItem.Staff_StartDate = Convert.ToDateTime("16/01/2022");
            TestItem.Staff_Salary = 14000;
            //set ThisStaff to test data
            Staffs.ThisStaff = TestItem;
            //set the primary key of the test data
            TestItem.Staff_ID = PrimaryKey;
            //find the record
            Staffs.ThisStaff.Find(PrimaryKey);
            //Test to see that the two value are the same
            Assert.AreEqual(Staffs.ThisStaff, TestItem);
        }

        //======================UpdateMethod===========================================
        [TestMethod]
        public void UpdateMethod()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.Staff_ID = 20;
            TestItem.Staff_FullName = "John Cena";
            TestItem.Staff_Gender = true;
            TestItem.Staff_StartDate = Convert.ToDateTime("03/02/2022");
            TestItem.Staff_Role = "Janitor";
            TestItem.Staff_Salary = 9000;
            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();

            TestItem.Staff_ID = PrimaryKey;
            


            TestItem.Staff_FullName = "John Cena";
            TestItem.Staff_Gender = true;
            TestItem.Staff_StartDate = Convert.ToDateTime("03/02/2022");
            TestItem.Staff_Role = "Janitor";
            TestItem.Staff_Salary = 10000;

            AllStaffs.ThisStaff = TestItem;
            AllStaffs.Update();

            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }
      

        //======================DeleteMethod===========================================

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();

            Int32 PrimaryKey = 0;

            TestItem.Staff_ID = 6;
            TestItem.Staff_FullName = "queen harley";
            TestItem.Staff_Gender = false;
            TestItem.Staff_StartDate = Convert.ToDateTime("08/06/2021");
            TestItem.Staff_Role = "Admin";
            TestItem.Staff_Salary = 20000;

            AllStaffs.ThisStaff = TestItem;

            PrimaryKey = AllStaffs.Add();

            TestItem.Staff_ID = PrimaryKey;

            AllStaffs.ThisStaff.Find(PrimaryKey);
            AllStaffs.Delete();

            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }

        //======================ReportByFullNameMethod===========================================

        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaffCollection FilteredStaffs = new clsStaffCollection();

            FilteredStaffs.ReportByFullName("");

            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);

        }

        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByFullName("xxx xxx");
            Assert.AreEqual(0, FilteredStaff.Count);
        }


        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;

            FilteredStaff.ReportByFullName("Bob smith");
            if (FilteredStaff.Count == 2) {
                if (FilteredStaff.StaffList[0].Staff_ID != 3) {
                    OK = false;
                }
                if (FilteredStaff.StaffList[1].Staff_ID != 17) {
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
