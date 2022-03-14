using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsAddress ASupplier = new clsAddress();
        //get the data from the session object
        ASupplier = (clsAddress)Session["ASupplier"];
        //display the supplier address for this entry
        Response.Write(ASupplier.ASupplierAddress);
        Response.Write(ASupplier.ASupplierName);
        Response.Write(ASupplier.ASupplierID);
        Response.Write(ASupplier.Email);
        Response.Write(ASupplier.ASupplierAvailability);
        Response.Write(ASupplier.DateOfRegister);



    }
}