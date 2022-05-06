using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace ClassLibrary
{
    public class clsSupplier


    {
        private Int32 mASupplierID;

        public Int32 ASupplierID {
            get {

                return mASupplierID;
            }
            set {

                mASupplierID = value;
            }

        }


        private string mEmail;

        public string Email {
            get {

                return mEmail;
            }
            set {

                mEmail = value;
            }


        }

        private string mASupplierName;
  
        public string ASupplierName {
            get {
 
                return mASupplierName;
            }
            set {
     
                mASupplierName = value;
            }

        }

        private DateTime mDateOfRegister;
        public DateTime DateOfRegister {
            get {
                return mDateOfRegister;
            }
            set {
                mDateOfRegister = value;
            }

        }

        private string mASupplierAddress;
        public string ASupplierAddress {
            get {
                return mASupplierAddress;
            }
            set {
                mASupplierAddress = value;
            }


        }

        private bool mASupplierAvailability;
        public bool ASupplierAvailability {
            get {
                return mASupplierAvailability;
            }
            set {
                mASupplierAvailability = value;
            }

        }


        public bool Find(Int32 ASupplierID)

        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ASupplierID", ASupplierID);
            DB.Execute("sproc_tblSupplier_SelectbySupplierID");


            if (DB.Count == 1) {
                mASupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["ASupplierID"]);
                mASupplierName = Convert.ToString(DB.DataTable.Rows[0]["ASupplierName"]);
                mASupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["ASupplierAddress"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDateOfRegister = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfRegister"]);
                mASupplierAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["ASupplierAvailability"]);

                return true;
            }

            else {

                return false;
            }
        }


        public string Valid(string ASupplierName, string ASupplierAddress, string Email, string DateOfRegister)
        {
            String Error = "";
            DateTime DateTemp;


            if (ASupplierName.Length == 0) {
                Error = Error + "The Supplier Name may not be blank : ";


            }


            if (ASupplierName.Length > 50) {
                Error = Error + "The ASupplierName cannot be longer than 50 characters : ";


            }


            if (ASupplierAddress.Length == 0) {
                Error = Error + "The ASupplierAddress may not be blank : ";


            }


            if (ASupplierAddress.Length > 50) {
                Error = Error + "The ASupplierAddress cannot be longer than 50 characters : ";


            }




            if (Email.Length < 0) {
                Error = Error + "The Email is too short : ";


            }


            if (Email.Length > 50) {
                Error = Error + "The Email is too long : ";


            }


            try {
                DateTemp = Convert.ToDateTime(DateOfRegister);

                if (DateTemp > DateTime.Now.Date) {
                    Error = Error + "The DateOfRegister cannot be in the future : ";
                }
            }
            catch {
                Error = Error + "The DateOfRegister was not a valid date: ";
            }


            return Error;
        }
    }
}
