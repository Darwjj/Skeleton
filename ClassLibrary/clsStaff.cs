
using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaff_ID;
        public Int32 Staff_ID {
            get {
                //this line of code send data out of the property
                return mStaff_ID;

            }
            set {
                //this line of code allows data into the property
                mStaff_ID = value;
            }
        }
        //===========================================================

        //private data member for staff Fullname
        private string mStaff_FullName;
        //public property for staff Full name
        public string Staff_FullName {
            get {
                //return the private data
                return mStaff_FullName;
            }
            set {
                //set the private data
                mStaff_FullName = value;
            }
        }

        //=====================================================================

        //Staff_Gender priavte member variable
        private Boolean mStaff_Gender;

        //public property for staff gender
        public Boolean Staff_Gender {
            get {
                //return the private data
                return mStaff_Gender;
            }

            set {
                //set the private data
                mStaff_Gender = value;
            }

        }

        //===============================================================

        //private data member for Staff role
        private string mStaff_Role;

        //public property for staff role
        public string Staff_Role {
            get {
                //return the private data
                return mStaff_Role;
            }
            set {
                //set th private data
                mStaff_Role = value;
            }
        }

        //===============================================================

        //private data member for staff start date
        private DateTime mStaff_StartDate;
        //public property for staff start date
        public DateTime Staff_StartDate {
            get {
                //return the private data
                return mStaff_StartDate;
            }
            set {
                //set the private data
                mStaff_StartDate = value;
            }
        }

        //=================================================================

        //private data menmber for staff salary
        private double mStaff_Salary;
        //public property for staff salary
        public double Staff_Salary {
            get {
                //return the private data
                return mStaff_Salary;
            }
            set {
                //set the private data
                mStaff_Salary = value;
            }
        }
        //=================================================================


        public bool Find(int Staff_ID)
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Staff_ID", Staff_ID);
            DB.Execute("sproc_tblStaff_FilterByStaffID");

            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1) {

                mStaff_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_ID"]);
                mStaff_FullName = Convert.ToString(DB.DataTable.Rows[0]["Staff_FullName"]);
                mStaff_Gender = Convert.ToBoolean(DB.DataTable.Rows[0]["Staff_Gender"]);
                mStaff_Role = Convert.ToString(DB.DataTable.Rows[0]["Staff_Role"]);
                mStaff_StartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Staff_StartDate"]);
                mStaff_Salary = Convert.ToDouble(DB.DataTable.Rows[0]["Staff_Salary"]);

                //always return true
                return true;
            }
            else {
                return false;
            }
        }

        //=================================================================

        public string Valid(string staff_FullName, string staff_Role, string staff_StartDate)
        {

            string Error = "";
            DateTime DateTemp;
            //===================Validation for STAFF FULL NAME===========================================
            if (staff_FullName.Length == 0) {
                Error = Error + "The Staff Full Name may not be blank : ";
            }

            if (staff_FullName.Length > 30) {
                Error = Error + "The Staff Full Name must be less than 30 : ";
            }
            //==========================VALIDATION FOR STAFF ROLE====================================
            if (staff_Role.Length == 0) {
                Error = Error + "The Staff Role may not be blank : ";
            }

            if (staff_Role.Length > 26) {
                Error = Error + "The Staff Role must be less than 26 : ";
            }
            //==============VALIDATION FOR STAFF HIRE DATE=======================
            try {
                DateTemp = Convert.ToDateTime(staff_StartDate);
                if (DateTemp > DateTime.Now.Date) {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch {
                Error = Error + "The date is not valid : ";
            }


            return Error;
        }



    }

}


        



