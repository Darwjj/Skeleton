using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member ThisStaff
        clsStaff mThisStaff = new clsStaff();
        public List<clsStaff> StaffList {
            get {
                //return the private data
                return mStaffList;
            }

            set {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count {
            get {
                //return the private data
                return mStaffList.Count;
            }

            set {
                //we shall do this later
            }
        }

        public clsStaff ThisStaff {
            get {
                //return the private data
                return mThisStaff;
            }

            set {
                //set the private data
                mThisStaff = value;
            }
        }

        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are recoreds to process
            while (Index < RecordCount) {
                //create a blank full name
                clsStaff Staff = new clsStaff();
                //read in the fields from the current record
                Staff.Staff_Role = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Role"]);
                Staff.Staff_StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Staff_StartDate"]);
                Staff.Staff_FullName = Convert.ToString(DB.DataTable.Rows[Index]["Staff_FullName"]);
                Staff.Staff_Gender = Convert.ToBoolean(DB.DataTable.Rows[Index]["Staff_Gender"]);
                Staff.Staff_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_ID"]);
                Staff.Staff_Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["Staff_Salary"]);
                //add the record to the private data member
                mStaffList.Add(Staff);
                //point at the next record
                Index++;
            }
        }
    }

}