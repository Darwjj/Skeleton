using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of a clsAddress
        clsAddress ASupplier = new clsAddress();
        //capture the supplier address
        ASupplier.ASupplierAddress = txtASupplierAddress.Text;
        ASupplier.ASupplierID = txtASupplierID.Text;
        ASupplier.ASupplierName = txtASupplierName.Text;
        ASupplier.Email = txtEmail.Text;
        ASupplier.DateOfRegister= txtDateOfRegister.Text;
        ASupplier.ASupplierAvailability = txtASupplierAvailability.Text;

        //store the address in the session object
        Session["ASupplier"] = ASupplier;
        //navigate to the viewer page
        Response.Redirect("SupplierViewer.aspx");
    }
}