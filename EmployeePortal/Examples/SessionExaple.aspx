<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainLayout.Master" AutoEventWireup="true" CodeBehind="SessionExaple.aspx.cs" Inherits="EmployeePortal.Examples.SessionExaple" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildPage" runat="server">

        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button runat="server" ID="btnSubmit" Text="Submit"
            OnClick="btnSubmit_Click" />
  
</asp:Content>
