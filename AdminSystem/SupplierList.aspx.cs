using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    Int32 ASupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ASupplierID = Convert.ToInt32(Session["ASupplierID"]);
        {
            if (IsPostBack == false)
            {
                //update the list box
                DisplaySuppliers();
            }
        }
    }

    void DisplaySuppliers()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "ASupplierID";
        lstSupplierList.DataTextField = "ASupplierName";
        lstSupplierList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ASupplierID"] = -1;
        //redirect to the data entry page
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ASupplierID;
        //if a record has been selected from list
        if(lstSupplierList.SelectedIndex !=-1)
        {
            //get the primary key value of the record to edit
            ASupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object
            Session["ASupplierID"] = ASupplierID;
            //redirect to the edit page
            Response.Redirect("SupplierDataEntry.aspx");

        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";

        } 
     }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 ASupplierID;
        //if a record has been selected from the list
        if(lstSupplierList.SelectedIndex !=-1)
        {
            //get the primary key value of the record to edit

            ASupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data in the session object
            Session["ASupplierID"] = ASupplierID;
            //redirect to the delete page
            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        Suppliers.ReportbyASupplierName(txtFilter.Text);
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set the name of the primary key
        lstSupplierList.DataValueField = "ASupplierID";
        //set the name of the field to display
        lstSupplierList.DataTextField = "ASupplierName";
        //bind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        Suppliers.ReportbyASupplierName("");
        txtFilter.Text = "";
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "ASupplierID";
        lstSupplierList.DataTextField = "ASupplierName";
        lstSupplierList.DataBind();
    }

    protected void lstSupplierList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}