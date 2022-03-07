using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("OrderProcessingTesting")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("OrderProcessingTesting")]
[assembly: AssemblyCopyright("Copyright ©  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("af5dedba-8ec4-4191-86fd-4d9a43152e3a")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

namespace OrderProcessingTesting
{
    class clsOrderProcessing
    {
        private Int32 mOrderId;
        public Int32 OrderId 
         {
            get 
            {
                //this line of code sent data out of the structure
                return mOrderId;
            }
            set 
            {
                //this line of code allows data into the structure
                mOrderId = value;
            }
        }
        private string mOrderDescription;
        public string OrderDescription 
        {
            get 
            {
                return mOrderDescription;

            }
            set 
            {
                mOrderDescription = value;

            }
        }
        private DateTime mOrderDate;
        public DateTime OrderDate 
            {

            get 
            {
                return mOrderDate;

            }

            set 
            {
                mOrderDate = value;

            }
        }

        private Boolean mOrderAvailable;
        public bool OrderAvailable 
        {
            get 
            {
                return mOrderAvailable;
            }

            set 
            {
                mOrderAvailable = value;
            }
        }
        private Double mPrice;
        public double Price 
        {
            get 
            {
                return mPrice;
            }
            set 
            {
                mPrice = value;
            }

        }
        private string mOrderStatus;
        public string OrderStatus 
        {
            get 
            {
                return mOrderStatus;
            }
            set 
            {
                mOrderStatus = value;
            }
        }

        public bool Find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrderProcessing_FilterByOrderId");
            if (DB.Count == 1) 
            {
                //set the private data members to the test data value
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderDescription = Convert.ToString(DB.DataTable.Rows[0]["OrderDescription"]);
                mOrderAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderAvailable"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);

                //always return true
                return true;
            }
            else 
            {
                return false;

            }
        }

        internal string Valid(string nDescription)
        {
            {
                if (nDescription.Length < 1) {
                    return "Description cannot be blank";
                }
                if (nDescription.Length > 1) {

                    return "Description cannot be more than 50 characters";
                }
                else {

                    return "";
                }
            }
        }
    }
}
