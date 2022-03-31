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
        string Staff_FullName = txtStaffFullName.Text;
        string Staff_Role = txtStaffRole.Text;
        string Staff_StartDate = txtStaffStartDate.Text;
        string Error = "";



        Error = AStaff.Valid(Staff_FullName, Staff_Role, Staff_StartDate);
        if (Error == "")
        {
            //captures the staff full name
            AStaff.Staff_FullName = Staff_FullName;
            //captures the staff full name
            AStaff.Staff_Role = Staff_Role;
            //capture the staff hire date
            AStaff.Staff_StartDate = Convert.ToDateTime(Staff_StartDate);
            Session["AStaff"] = AStaff;
            //redirects to staff viewer page.
            Response.Write("StaffViewer.aspx");
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
    

protected void btn_Find_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 Staff_ID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Staff_ID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(Staff_ID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in te form
            txtStaffFullName.Text = AStaff.Staff_FullName;
            ddlStaffGender.SelectedValue = AStaff.Staff_Gender.ToString();
            txtStaffRole.Text = AStaff.Staff_Role;
            txtStaffStartDate.Text = AStaff.Staff_StartDate.ToString();
            txtStaffSalary.Text = AStaff.Staff_Salary.ToString();
        }
        else
        {
            txtStaffFullName.Text = "";
            txtStaffRole.Text = "";
            txtStaffSalary.Text = "";
            txtStaffStartDate.Text = "";

            lblError.Text = "Error: This ID does not exist!";
            lblError.Visible = true;
        }
    }
}