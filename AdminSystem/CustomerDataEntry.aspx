<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID" width="128px"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerID" runat="server" width="128px" TextMode="Number"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Label ID="lblCustomerDescription" runat="server" Text="CustomerDescription"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerDescription" runat="server" width="128px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblProductCost" runat="server" Text="ProductCost" width="128px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtProductCost" runat="server" width="128px"></asp:TextBox>
&nbsp;<p>
            <asp:Label ID="lblCustomerContact" runat="server" Text="CustomerContact" width="128px"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtCustomerContact" runat="server" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerDOB" runat="server" Text="CustomerDOB" width="128px"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerDOB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="Marketting" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Marketting" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" Text="OK" />
            <asp:Button ID="BtnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
