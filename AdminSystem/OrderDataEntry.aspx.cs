﻿using System;
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
        //create a new instance of clsOrderProcessing
        clsOrderProcessing AOrderProcessing = new clsOrderProcessing();
        //capture the number of the order
        AOrderProcessing.OrderNo = textOrderId.Text;
        AOrderProcessing.DateAdded = textOrderDate.Text;
        AOrderProcessing.OrderDescription = textOrderDescription.Text;
        AOrderProcessing.OrderAvailable = textOrderAvailable.Text;
        AOrderProcessing.OrderStatus = textOrderStatus.Text;
        AOrderProcessing.Price = textPrice.Text;
        //store number of orders in the session object
        Session["AOrderProcessing"] = AOrderProcessing;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextOrderDate_TextChanged(object sender, EventArgs e)
    {

    }
}