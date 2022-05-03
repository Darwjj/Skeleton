using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaffs();
        }
    }

    void DisplayStaffs()
    {

        clsStaffCollection Staffs = new clsStaffCollection();

        lstStaffList.DataSource = Staffs.StaffList;
        lstStaffList.DataValueField = "Staff_ID";
        lstStaffList.DataTextField = "Staff_FullName";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["Staff_ID"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 Staff_ID;

        if (lstStaffList.SelectedIndex != -1)
        {
            Staff_ID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["Staff_ID"] = Staff_ID;

            Response.Redirect("StaffDataEntry.aspx");
        }
        else//if no records has benn select.
        {

            lblError.Text = "Please select a record to edit from the list";
            lblError.Visible = true;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

        Int32 Staff_ID;

        if (lstStaffList.SelectedIndex != -1)
        {
            Staff_ID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["Staff_ID"] = Staff_ID;

            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else//if no records has benn select.
        {

            lblError.Text = "Please select a record to delete from the list";
            lblError.Visible = true;
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByFullName(txtFilter.Text);


        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "Staff_ID";
        lstStaffList.DataTextField = "Staff_FullName";
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {

        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByFullName("");
        txtFilter.Text = "";

        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "Staff_ID";
        lstStaffList.DataTextField = "Staff_FullName";
        lstStaffList.DataBind();
    }
}