<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainLayout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmployeePortal.Account.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildPage" runat="server">
    <div class="form-group">
        <label for="exampleInputEmail1">Email address</label>
        <input runat="server" type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
        <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
    </div>
    <div class="form-group">
        <label for="exampleInputPassword">Password</label>
        <input type="password" runat="server" class="form-control" id="exampleInputPassword" placeholder="Password">
    </div>
    <asp:Button ID="btnLogin" CssClass="btn btn-primary" runat="server" OnClick="btnLogin_Click" Text="Submit"></asp:Button>

</asp:Content>
