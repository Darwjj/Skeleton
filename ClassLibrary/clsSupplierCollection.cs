using System;
using System.Collections.Generic;


namespace ClassLibrary{
    public class clsSupplierCollection
{
    List<clsSupplier> mSupplierList = new List<clsSupplier>();
    clsSupplier mThisSupplier = new clsSupplier();
    public List<clsSupplier> SupplierList {
        get {
            return mSupplierList;
        }
        set {
            mSupplierList = value;
        }
    }

    public clsSupplierCollection()
    {
        Int32 Index = 0;
        Int32 RecordCount = 0;
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblSupplier_SelectAll");
        PopulateArray(DB);
        while (Index < RecordCount) {
            clsSupplier AnSupplier = new clsSupplier();
            AnSupplier.ASupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["ASupplierID"]);
            AnSupplier.ASupplierName = Convert.ToString(DB.DataTable.Rows[Index]["ASupplierName"]);
            AnSupplier.ASupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["ASupplierAddress"]);
            AnSupplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
            AnSupplier.DateOfRegister = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfRegister"]);
            AnSupplier.ASupplierAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["ASupplierAvailability"]);
            mSupplierList.Add(AnSupplier);
            Index++;
        }
    }




    public clsSupplier ThisSupplier {
        get {
            return mThisSupplier;
        }
        set {
            mThisSupplier = value;
        }
    }
    public int Count {
        get {

            return mSupplierList.Count;
        }
        set {
        }
    }


    public int Add()
    {

        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@ASupplierName", mThisSupplier.ASupplierName);
        DB.AddParameter("@ASupplierAddress", mThisSupplier.ASupplierAddress);
        DB.AddParameter("@Email", mThisSupplier.Email);
        DB.AddParameter("@DateOfRegister", mThisSupplier.DateOfRegister);
        DB.AddParameter("@ASupplierAvailability", mThisSupplier.ASupplierAvailability);
        return DB.Execute("sproc_tblSupplier_Insert");
    }
    public void Update()
    {
        clsDataConnection DB = new clsDataConnection();

        DB.AddParameter("@ASupplierID", mThisSupplier.ASupplierID);
        DB.AddParameter("@ASupplierName", mThisSupplier.ASupplierName);
        DB.AddParameter("@ASupplierAddress", mThisSupplier.ASupplierAddress);
        DB.AddParameter("@Email", mThisSupplier.Email);
        DB.AddParameter("@DateOfRegister", mThisSupplier.DateOfRegister);
        DB.AddParameter("@ASupplierAvailability", mThisSupplier.ASupplierAvailability);

        DB.Execute("sproc_tblSupplier_Update");
    }

    public void Delete()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@ASupplierID", mThisSupplier.ASupplierID);
        DB.Execute("sproc_tblSupplier_Delete");
    }


    public void ReportbyASupplierName(string ASupplierName)
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@ASupplierName", ASupplierName);
        DB.Execute("sproc_tblSupplier_FilterByASupplierName");
        PopulateArray(DB);
    }
    void PopulateArray(clsDataConnection DB)
    {
        Int32 Index = 0;
        Int32 RecordCount;
        RecordCount = DB.Count;
        mSupplierList = new List<clsSupplier>();


        while (Index < RecordCount) {
            clsSupplier AnSupplier = new clsSupplier();


            AnSupplier.ASupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["ASupplierID"]);
            AnSupplier.ASupplierName = Convert.ToString(DB.DataTable.Rows[Index]["ASupplierName"]);
            AnSupplier.ASupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["ASupplierAddress"]);
            AnSupplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
            AnSupplier.DateOfRegister = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfRegister"]);
            AnSupplier.ASupplierAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["ASupplierAvailability"]);


            mSupplierList.Add(AnSupplier);
            Index++;
        }
    }
}
}