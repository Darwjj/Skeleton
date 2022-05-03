<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffId" runat="server" Text="StaffId"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaff_ID" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_Find" runat="server" OnClick="btn_Find_Click" Text="Find" />
        </div>
        <p>
            <asp:Label ID="lblStaffFullName" runat="server" Text="Staff Full Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffFullName" runat="server" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffGender" runat="server" Text="Staff Gender"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlStaffGender" runat="server" width="128px">
                <asp:ListItem Value="false">Female</asp:ListItem>
                <asp:ListItem Value="true">Male</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="lblStaffRole" runat="server" Text="Staff Role"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffRole" runat="server" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffStartDate" runat="server" Text="Staff Start Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffStartDate" runat="server" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffSalary" runat="server" Text="Staff Salary"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffSalary" runat="server" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
