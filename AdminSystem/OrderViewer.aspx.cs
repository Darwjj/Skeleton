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
        //create a new instance of the class
        clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
        //get the data from the session object
        AOrderProcessing = (clsOrderProcessing)Session["AOrderProcessing"];
        //display the order number on the page
        Response.Write("Id" + " = " + AOrderProcessing.OrderNo + "<br><br>");
        Response.Write("Date" + " = " + AOrderProcessing.DateAdded + "<br><br>");
        Response.Write("Description" + " = " + AOrderProcessing.OrderDescription + "<br><br>");
        Response.Write("Price" + " = " + AOrderProcessing.Price + "<br><br>");
        Response.Write("Status" + " = " + AOrderProcessing.OrderStatus + "<br><br>");
        Response.Write("Available" + " = " + AOrderProcessing.OrderAvailable + "<br><br>");

    }
}