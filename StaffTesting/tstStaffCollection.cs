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

    }
}
