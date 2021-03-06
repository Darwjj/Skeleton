<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="357px" Width="433px"></asp:ListBox>
            <br />
            <br />
        </div>
        <asp:Button ID="btnAdd" runat="server" Height="29px" OnClick="btnAdd_Click" Text="Add" Width="47px" />
    &nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" height="29px" OnClick="btnEdit_Click" Text="Edit" width="47px" />
        &nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" height="29px" OnClick="btnDelete_Click" Text="Delete" width="55px" />
        <br />
        <br />
        Enter a Staff Name&nbsp;&nbsp;
        <asp:TextBox ID="txtFilter" runat="server" Width="137px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnApply" runat="server" height="29px" OnClick="btnApply_Click" Text="Apply" width="47px" />
&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" height="29px" OnClick="btnClear_Click" Text="Clear" width="47px" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]" ForeColor="Red" Visible="False"></asp:Label>
    </form>
</body>
</html>