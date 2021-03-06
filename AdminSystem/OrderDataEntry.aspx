<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderId" runat="server" Text="Order Id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textOrderId" runat="server" Height="25px" Width="141px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <p>
                <asp:Label ID="lblOrderDescription" runat="server" Text="Order Description"></asp:Label>
&nbsp;<asp:TextBox ID="textOrderDescription" runat="server" Height="25px" Width="141px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            </p>
&nbsp;<asp:Label ID="lblOrderDate" runat="server" Text="Order Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textOrderDate" runat="server" Height="25px" Width="141px" OnTextChanged="TextOrderDate_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textPrice" runat="server" Height="25px" Width="141px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderStatus" runat="server" Text="Order Status"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textOrderStatus" runat="server" Height="25px" Width="141px"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
