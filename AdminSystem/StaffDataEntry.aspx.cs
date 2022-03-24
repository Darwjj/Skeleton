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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture all the attributes
        AStaff.Staff_ID = Convert.ToInt32(txtStaffID.Text); 
        AStaff.Staff_FullName = txtStaffFullName.Text;
        AStaff.Staff_Gender = Convert.ToBoolean(ddlStaffGender.SelectedIndex);
        AStaff.Staff_Role = txtStaffRole.Text;
        AStaff.Staff_StartDate = Convert.ToDateTime(txtStaffStartDate.Text);
        AStaff.Staff_Salary = Convert.ToInt32(txtStaffSalary.Text);
        //store the staff in the session object 
        Session["AStaff"] = AStaff;
        //navigate to viewer page
        Response.Redirect("StaffViewer.aspx");
    }
}