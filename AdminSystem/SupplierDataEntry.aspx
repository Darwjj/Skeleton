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
        <br />
        &nbsp;
        <br />
        <asp:Label ID="lblASupplierID" runat="server" Text="ASupplierID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="txtASupplierID" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />
        <br />
        <asp:Label ID="lblASupplierName" runat="server" Text="ASupplierName"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtASupplierName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblASupplierAddress" runat="server" Text="ASupplierAddress"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="txtASupplierAddress" runat="server" OnTextChanged="txtASupplierAddress_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDateOfRegister" runat="server" Text="DateOfRegister"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDateOfRegister" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkASupplierAvailability" runat="server" Text="Available" OnCheckedChanged="chkASupplierAvailability_CheckedChanged" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" style="height: 26px" />
&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
