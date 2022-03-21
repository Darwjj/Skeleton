using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private string AnCustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instance of the class
        //clsCustomer AnCustomerID = new clsCustomer();

        //get the data from the session object
      //  AnCustomerID = (clsCustomer)Session["AnCustomerID"];

        //Display the customer id on the page
          Response.Write(AnCustomerID.CustomerID);

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {

        // create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the customer ID
        AnCustomer.CustomerID = txtCustomerID.Text;
        //store the address in the session object 
        Session["AnCustomerID"] = AnCustomerID;
        //Navigate to the viewer page
        Response.Redirect("CustomerData.aspx");
    }

    private class clsCustomerID
    {
    }

    internal class clsAddress
    {
    }
}