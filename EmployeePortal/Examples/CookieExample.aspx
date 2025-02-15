<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainLayout.Master"
    AutoEventWireup="true" CodeBehind="CookieExample.aspx.cs"
    Inherits="EmployeePortal.Examples.CookieExample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildPage" runat="server">
    <form runat="server" id="cookieexampleform">
        Enter Name
        <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
        <br />
        <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
    </form>

</asp:Content>
