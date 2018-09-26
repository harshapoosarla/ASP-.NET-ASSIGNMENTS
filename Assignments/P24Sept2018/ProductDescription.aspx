<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDescription.aspx.cs" Inherits="P24Sept2018.ProductDescription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 290px">
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="200px" Width="200px" />
        <br />
        <br />
            <asp:Label ID="ProductName" runat="server" Text="ProductName"></asp:Label>
        <br />
        <br />
            <asp:Label ID="ProductPrice" runat="server" Text="ProductPrice"></asp:Label>
        <br />
        <br />
            <asp:Label ID="Description" runat="server" Text="Description"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add to Cart" ToolTip="click to add item to cart" OnClick="Button1_Click" />
    
        </div>
        </form>
</body>
</html>
