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
        //create a new instance of clsSupplier
        
        clsSupplier ASupplier = new clsSupplier();
        //get data from the session object
        ASupplier = (clsSupplier)Session["ASupplier"];
        //display the supplier ID for this entry

        Response.Write(ASupplier.ASupplierID + "<br>");

        //display the supplier name

        Response.Write(ASupplier.ASupplierName + "<br>");

        //display the supplier address

        Response.Write(ASupplier.ASupplierAddress + "<br>");

        //display the supplier email

        Response.Write(ASupplier.Email + "<br>");

        //display the supplier date of register

        Response.Write(ASupplier.DateOfRegister + "<br>");


    }
}