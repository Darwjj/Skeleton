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


            public int Add()
            {
                //add a new record to the database based on the values of ThisCustomer
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@Staff_FullName", mThisStaff.Staff_FullName);
                DB.AddParameter("@Staff_Gender", mThisStaff.Staff_Gender);
                DB.AddParameter("@Staff_Role", mThisStaff.Staff_Role);
                DB.AddParameter("@Staff_StartDate", mThisStaff.Staff_StartDate);
                DB.AddParameter("@Staff_Salary", mThisStaff.Staff_Salary);
                //execute the query returning the primary key value
                return DB.Execute("sproc_tblStaff_Insert");
            }


        //============Update Method ====================================
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Staff_ID", mThisStaff.Staff_ID);
            DB.AddParameter("@Staff_FullName", mThisStaff.Staff_FullName);
            DB.AddParameter("@Staff_Gender", mThisStaff.Staff_Gender);
            DB.AddParameter("@Staff_Role", mThisStaff.Staff_Role);
            DB.AddParameter("@Staff_StartDate", mThisStaff.Staff_StartDate);
            DB.AddParameter("@Staff_Salary", mThisStaff.Staff_Salary);
            DB.Execute("sproc_tblStaff_Update");
        }

        //============Delete Method ====================================
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Staff_ID", mThisStaff.Staff_ID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        //============RportByFullNameMethod ====================================
        public void ReportByFullName(string Staff_FullName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Staff_FullName", Staff_FullName);
            DB.Execute("sproc_tblStaff_FilterByStaffFullName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();



            while (Index < RecordCount) {
                clsStaff Staff = new clsStaff();
                Staff.Staff_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_ID"]);
                Staff.Staff_FullName = Convert.ToString(DB.DataTable.Rows[Index]["Staff_FullName"]);
                Staff.Staff_Gender = Convert.ToBoolean(DB.DataTable.Rows[Index]["Staff_Gender"]);
                Staff.Staff_Role = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Role"]);
                Staff.Staff_StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Staff_StartDate"]);
                Staff.Staff_Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["Staff_Salary"]);

                mStaffList.Add(Staff);
                Index++;


            }
        }

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("Sproc_tblStaff_SelectAll");
            PopulateArray(DB);

        }

    }
}