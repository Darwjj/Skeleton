using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StaffTesting
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]

        public void InstanceOK()

        {

            clsStaff Staff = new clsStaff();

            Assert.IsNotNull(Staff);

        }



        //Testing FullName property

        [TestMethod]

        public void Staff_FullNamePropertyOK()

        {

            clsStaff Staff = new clsStaff();

            String TestData = "Kirtan Patel";

            Staff.Staff_FullName = TestData;

            Assert.AreEqual(Staff.Staff_FullName, TestData);

        }



        //Testing StaffID property

        [TestMethod]

        public void Staff_IDPropertyOK()

        {

            clsStaff Staff = new clsStaff();

            int TestData = 1;

            Staff.Staff_ID = TestData;

            Assert.AreEqual(Staff.Staff_ID, TestData);

        }



        //Testing Staff Gender property

        [TestMethod]

        public void Staff_GenderPropertyOK()

        {

            clsStaff Staff = new clsStaff();

            Boolean TestData = true;

            Staff.Staff_Gender = TestData;

            Assert.AreEqual(Staff.Staff_Gender, TestData);

        }



        //Testing Staff role property

        [TestMethod]

        public void Staff_RolePropertyOK()

        {

            clsStaff Staff = new clsStaff();

            String TestData = "Chef";

            Staff.Staff_Role = TestData;

            Assert.AreEqual(Staff.Staff_Role, TestData);

        }



        //Testing Staff Start Date property

        [TestMethod]

        public void Staff_StartDatePropertyOK()

        {

            clsStaff Staff = new clsStaff();

            DateTime TestData = DateTime.Now.Date;

            Staff.Staff_StartDate = TestData;

            Assert.AreEqual(Staff.Staff_StartDate, TestData);

        }



        //Testing Staff Salary property

        [TestMethod]

        public void Staff_SalaryPropertyOK()

        {

            clsStaff Staff = new clsStaff();

            Double TestData = 14000.0000;

            Staff.Staff_Salary = TestData;

            Assert.AreEqual(Staff.Staff_Salary, TestData);

        }

        [TestMethod]

        public void FindMethodOK()

        {

            clsStaff Staff = new clsStaff();

            Boolean Found = false;
            Int32 Staff_ID = 1;
            Found = Staff.Find(Staff_ID);
            Assert.IsTrue(Found);

        }

        //================================================================

        [TestMethod]

        public void TestStaff_IDNotFound()

        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = Staff.Find(Staff_ID);
            //check the Staff Id
            if (Staff.Staff_ID != 1) {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //======================================================================

        [TestMethod]

        public void TestStaff_FullNameNotFound()

        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = Staff.Find(Staff_ID);
            //check the Staff full name
            if (Staff.Staff_FullName != "Akshat Cala") {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //========================================================================

        [TestMethod]

        public void TestStaff_GenderFound()

        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = Staff.Find(Staff_ID);
            //check the Staff gender
            if (Staff.Staff_Gender != true) {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //========================================================================

        [TestMethod]

        public void TestStaff_RoleFound()

        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = Staff.Find(Staff_ID);
            //check the Staff role
            if (Staff.Staff_Role != "Admin") {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //=============================================================================
        [TestMethod]

        public void TestStaff_StartDateFound()

        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = Staff.Find(Staff_ID);
            //check the staff start date
            if (Staff.Staff_StartDate != Convert.ToDateTime("03/02/2022")) {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //========================================================================

        [TestMethod]

        public void TestStaff_SalaryFound()

        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = Staff.Find(Staff_ID);
            //check the Staff gender
            if (Staff.Staff_Salary != 10000.0000) {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //========================================================================

        string Staff_FullName = "Akshat Cala";
        string Staff_Role = "Manager";
        string Staff_StartDate = DateTime.Now.Date.ToString();



        //test for valid method
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the staff class
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //========================================================================

        //==========================Validation Test for STAFF FULL NAME=======================
        [TestMethod]
        public void Staff_FullNameMinLessOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "";

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreNotEqual(Error, "");
        }
        //========================================================================

        [TestMethod]
        public void Staff_FullNameMin()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "a";

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_FullNameMinPlusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "aa";

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_FullNameMaxMinusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "";

            Staff_FullName = Staff_FullName.PadRight(29, 'a');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_FullNameMax()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "";

            Staff_FullName = Staff_FullName.PadRight(30, 'a');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_FullNameMaxPlusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "";

            Staff_FullName = Staff_FullName.PadRight(31, 'a');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreNotEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_FullNameMid()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "";

            Staff_FullName = Staff_FullName.PadRight(15, 'a');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_FullNameExtreme()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_FullName = "";

            Staff_FullName = Staff_FullName.PadRight(500, 'a');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreNotEqual(Error, "");
        }



        //========================Validation Test for STAFF ROLE================================================

        [TestMethod]
        public void Staff_RoleMinLessOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "";

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreNotEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_RoleMin()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "a";

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_RoleMinPlusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "aa";

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_RoleMaxMinusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "";

            Staff_Role = Staff_Role.PadRight(25, 'a');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_RoleMax()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "";

            Staff_Role = Staff_Role.PadRight(26, 'a');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_RoleMaxPlusOne()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "";

            Staff_Role = Staff_Role.PadRight(27, 'a');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreNotEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_RoleMid()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "";

            Staff_Role = Staff_Role.PadRight(13, 'a');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreEqual(Error, "");
        }

        //========================================================================

        [TestMethod]
        public void Staff_RoleExtreme()
        {
            clsStaff Staff = new clsStaff();

            String Error = "";

            string Staff_Role = "";

            Staff_Role = Staff_Role.PadRight(500, 'a');

            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);

            Assert.AreNotEqual(Error, "");
        }

        //==================Validation Test for STAFF START DATE============================
        [TestMethod]
        public void Staff_StartDateExtremeMin()
        {
            //create an instance of the staff class
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the ate is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date to string variableble
            string Staff_StartDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void Staff_StartDateMinLessOne()
        {
            //create an instance of the staff class
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the ate is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date to string variableble
            string Staff_StartDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void Staff_StartDateMin()
        {
            //create an instance of the staff class
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date to string variableble
            string Staff_StartDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Staff_StartDateMinPlusOne()
        {
            //create an instance of the staff class
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date to string variableble
            string Staff_StartDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Staff_StartDateExtreme()
        {
            //create an instance of the staff class
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(100);
            //convert the date to string variableble
            string Staff_StartDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void Staff_StartDateInvalidData()
        {
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //set the date to a non date value;
            string Staff_StartDate = "this is not a date!";
            //invoke the method
            Error = Staff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

    }
}
