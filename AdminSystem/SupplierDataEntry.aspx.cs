using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 ASupplierID;
    public object txtASupplierAvailability { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supplier to be processed
        ASupplierID = Convert.ToInt32(Session["ASupplierID"]);
        if(IsPostBack ==false)
        {
            //if this is not a new record
            if (ASupplierID != -1)
            {
                //display the current data for the record
                DisplaySupplier();
            }
        }
    }

    private void DisplaySupplier()
    {
        //create an instance of the supplier book
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to update
        SupplierBook.ThisSupplier.Find(ASupplierID);
        //display the data for this record
        txtASupplierID.Text = SupplierBook.ThisSupplier.ASupplierID.ToString();
        txtASupplierName.Text = SupplierBook.ThisSupplier.ASupplierName;
        txtASupplierAddress.Text = SupplierBook.ThisSupplier.ASupplierAddress;
        txtEmail.Text = SupplierBook.ThisSupplier.Email;
        txtDateOfRegister.Text = SupplierBook.ThisSupplier.DateOfRegister.ToString();
        chkASupplierAvailability.Checked = SupplierBook.ThisSupplier.ASupplierAvailability;


    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of a class

        clsSupplier ASupplier = new clsSupplier();
        string ASupplierName = txtASupplierName.Text;
        string ASupplierAddress = txtASupplierAddress.Text;
        string DateOfRegister = txtDateOfRegister.Text;
        string Email = txtEmail.Text;
        string Error = "";

        Error = ASupplier.Valid(ASupplierName, ASupplierAddress, Email, DateOfRegister);
        if (Error =="")
        {
            //capure the supplier ID
            ASupplier.ASupplierID = ASupplierID;
            //capture a supplier name
            ASupplier.ASupplierName = ASupplierName;
            //capture a supplier address
            ASupplier.ASupplierAddress = ASupplierAddress;
            //capture a supplier date of register
            ASupplier.DateOfRegister = Convert.ToDateTime(DateOfRegister);
            //store  the address in the session object
            //capture active
            ASupplier.ASupplierAvailability = chkASupplierAvailability.Checked;
            
            ASupplier.Email = Email;

            //create a new instance of the address collection
            clsSupplierCollection SupplierList = new clsSupplierCollection();
           
            //===updated  as===
            //if this is anew record i.e ASupplierID = -1 then add the data
            if(ASupplierID ==-1)
            {
                //set the ThisSupplier property
                
               SupplierList.ThisSupplier = ASupplier;
                //add the new record
                SupplierList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                SupplierList.ThisSupplier.Find(ASupplierID);
                //set the ThisSupplier property
                SupplierList.ThisSupplier = ASupplier;
                //update the record
                SupplierList.Update();
            }

            //redirect back to the listpage 
           Response.Redirect("SupplierList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void chkASupplierAvailability_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void txtASupplierAddress_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create instance of the address class
        clsSupplier ASupplier = new clsSupplier();
        //variable to store primary key
        Int32 ASupplierID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ASupplierID = Convert.ToInt32(txtASupplierID.Text);
        // find the record
        Found = ASupplier.Find(ASupplierID);
        //if found
        if(Found == true)
        {
            //display the value of the properties in the form
            txtASupplierID.Text = ASupplier.ASupplierID.ToString();
            txtASupplierAddress.Text = ASupplier.ASupplierAddress;
            txtASupplierName.Text = ASupplier.ASupplierName;
            txtDateOfRegister.Text = ASupplier.DateOfRegister.ToString();
            txtEmail.Text = ASupplier.Email;
            txtASupplierAvailability = ASupplier.ASupplierAvailability.ToString();

        }
        else
        {
            txtASupplierAddress.Text = "";
            txtASupplierName.Text = "";
            txtEmail.Text = "";
            txtDateOfRegister.Text = "";
            lblError.Text = "Error:This  ID does not exist!";
            lblError.Visible = true;
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierList.aspx");
    }
}