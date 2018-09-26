<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="P24Sept2018.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<asp:TextBox ID="TextBox1" runat="server" Width="156px"></asp:TextBox>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
<br />
<asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
<br />
    <%--<img alt="apple phone" src="Content/iphone.jpg" style="width: 500px; height: 500px" />
    <img alt="ipad pro" src="Content/ipad.jpg" style="width: 500px; height: 500px" />
    <img alt="apple watch" src="Content/watch.jpg" style="width: 500px; height: 500px" />
    <img alt="apple airpods" src="Content/airpods.jpg" style="width: 500px; height: 500px" />--%>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
</asp:Content>
