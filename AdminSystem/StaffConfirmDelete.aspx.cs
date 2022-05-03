using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 Staff_ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        Staff_ID = Convert.ToInt32(Session["Staff_ID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();

        Staff.ThisStaff.Find(Staff_ID);

        Staff.Delete();

        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}