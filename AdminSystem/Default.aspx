<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:ListBox ID="tstOrder" runat="server" Height="230px" Width="236px"></asp:ListBox>
        </div>
        <asp:Label ID="lblOrderNumber" runat="server" Text="Please enter your Order Number"></asp:Label>
        <p>
            <asp:TextBox ID="textOrderNumber" runat="server" Width="214px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btmApply" runat="server" Text="Apply" />
            <asp:Button ID="btmDisplay" runat="server" Text="Display All" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btmAdd" runat="server" Text="Add" />
            <asp:Button ID="btmEdit" runat="server" Text="Edit" />
            <asp:Button ID="btmDelete" runat="server" Text="Delete" />
        </p>
    </form>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
