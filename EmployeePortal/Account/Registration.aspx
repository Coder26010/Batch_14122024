<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainLayout.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="EmployeePortal.Account.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildPage" runat="server">

    <div class="form-group">
        <label for="exampleInputFullName">Full Name</label>
        <input runat="server" class="form-control" id="exampleInputFullName" aria-describedby="fullNameHelp" placeholder="Enter Full Name">
        <small id="fullNameHelp" class="form-text text-muted">We'll never share your name with anyone else.</small>
    </div>
    <div class="form-group">
        <label for="exampleInputEmail1">Email address</label>
        <input runat="server" type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
        <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
    </div>
    <div class="form-group">
        <label for="exampleInputPassword">Password</label>
        <input type="password" runat="server" class="form-control" id="exampleInputPassword" placeholder="Password">
    </div>
    <asp:Button CssClass="btn btn-primary" runat="server" OnClick="Unnamed_Click" Text="Submit"></asp:Button>

</asp:Content>
