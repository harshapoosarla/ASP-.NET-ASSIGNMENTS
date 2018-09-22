<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="displayData.aspx.cs" Inherits="P21Sept2018_RegistrationValidation.displayData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 165px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Details" ToolTip="click to add more details" />
        </div>
    </form>
</body>
</html>
