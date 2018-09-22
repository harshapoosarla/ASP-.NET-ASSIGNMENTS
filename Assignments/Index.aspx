<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Assignments.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 849px;
            height: 693px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            text-align: right;
            width: 401px;
        }
        .auto-style4 {
            text-align: right;
            width: 401px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            width: 439px;
        }
        .auto-style8 {
            width: 401px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="background-color: #66FFFF">
            <h1 style="align-content:center" class="auto-style6">Registration Form</h1>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">First Name:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Last Name:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Age:</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Mobile Number:</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">DOB:</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Gender:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem Value="Male"></asp:ListItem>
                            <asp:ListItem Value="Female"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Country:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                            <asp:ListItem Value="INDIA"></asp:ListItem>
                            <asp:ListItem Value="USA"></asp:ListItem>
                            <asp:ListItem Value="Pakisthan"></asp:ListItem>
                            <asp:ListItem Value="UK"></asp:ListItem>
                            <asp:ListItem Value="CANNADA"></asp:ListItem>
                            <asp:ListItem Value="SRI LANKA"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                    </td>
                    <td class="auto-style7">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" ToolTip="click to submit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
