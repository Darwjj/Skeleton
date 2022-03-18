using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaff_ID;
        public int Staff_ID {
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
        public bool Staff_Gender {
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


        public bool Find(int staff_ID)
        {
            mStaff_ID = 1;
            mStaff_FullName = "Kirtan Patel";
            mStaff_Gender = true;
            mStaff_Role = "Chef";
            mStaff_StartDate = Convert.ToDateTime("16/01/2022");
            mStaff_Salary = 14000.0000;

            return true;
        }


    }


}
