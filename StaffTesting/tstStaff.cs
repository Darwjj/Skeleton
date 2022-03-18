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

            String TestData = "Akshat Cala";

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

            String TestData = "Admin";

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

            Double TestData = 200.03;

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
            if (Staff.Staff_FullName != "Kirtan Patel") {
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
            if (Staff.Staff_Role != "Chef") {
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
            if (Staff.Staff_StartDate != Convert.ToDateTime("16/01/2022")) {
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
            if (Staff.Staff_Salary != 14000.0000) {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
