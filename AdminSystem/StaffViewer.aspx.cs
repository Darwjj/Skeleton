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
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the staff Id for this entry
        Response.Write(AStaff.Staff_ID + "<br>");
        Response.Write(AStaff.Staff_FullName + "<br>");
        Response.Write(AStaff.Staff_Gender + "<br>");
        Response.Write(AStaff.Staff_Role + "<br>");
        Response.Write(AStaff.Staff_Salary + "<br>");
        Response.Write(AStaff.Staff_StartDate + "<br>");


    }
}
