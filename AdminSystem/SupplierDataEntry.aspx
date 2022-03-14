<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="188px" Width="262px"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="lblSupplierID" runat="server" Text="SupplierID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSupplierID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierName" runat="server" Text="SupplierName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierAddress" runat="server" Text="SupplierAddress"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtASupplierAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateOfRegister" runat="server" Text="DateOfRegister"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="txtDateOfRegister" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
