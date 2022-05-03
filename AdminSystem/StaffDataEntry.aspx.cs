using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 Staff_ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        Staff_ID = Convert.ToInt32(Session["Staff_ID"]);
        if (IsPostBack == false)
        {
            if (Staff_ID != -1)
            {
                DisplayStaffs();
            }
        }
    }

    void DisplayStaffs()
    {
        clsStaffCollection AStaff = new clsStaffCollection();
        AStaff.ThisStaff.Find(Staff_ID);

        txtStaff_ID.Text = AStaff.ThisStaff.Staff_ID.ToString();
        txtStaffFullName.Text = AStaff.ThisStaff.Staff_FullName;
        ddlStaffGender.Text = AStaff.ThisStaff.Staff_Gender.ToString();
        txtStaffRole.Text = AStaff.ThisStaff.Staff_Role;
        txtStaffStartDate.Text = AStaff.ThisStaff.Staff_StartDate.ToString();
        txtStaffSalary.Text = AStaff.ThisStaff.Staff_Salary.ToString();

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();

        string Staff_FullName = txtStaffFullName.Text;
        string Staff_Role = txtStaffRole.Text;
        string Staff_HireDate = txtStaffStartDate.Text;
        string Staff_Salary = txtStaffSalary.Text;
        String Staff_Gender = ddlStaffGender.SelectedValue;


        string Error = "";



        Error = AStaff.Valid(Staff_FullName, Staff_Role, Staff_HireDate);
        if (Error == "")
        {
            AStaff.Staff_ID = Staff_ID;
            //captures the staff full name
            AStaff.Staff_FullName = Staff_FullName;
            //captures the staff full name
            AStaff.Staff_Role = Staff_Role;
            //capture the staff hire date
            AStaff.Staff_StartDate = Convert.ToDateTime(Staff_HireDate);

            AStaff.Staff_Gender = Convert.ToBoolean(Staff_Gender);

            AStaff.Staff_Salary = Convert.ToDouble(Staff_Salary);

            clsStaffCollection StaffList = new clsStaffCollection();
            if (Staff_ID == -1)
            {
                StaffList.ThisStaff = AStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(Staff_ID);
                StaffList.ThisStaff = AStaff;

                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
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
        Staff_ID = Convert.ToInt32(txtStaff_ID.Text);
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}