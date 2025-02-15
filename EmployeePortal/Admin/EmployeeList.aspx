<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainLayout.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="EmployeePortal.Admin.EmployeeList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildPage" runat="server">
    <form runat="server" id="EmployeeListForm">
        <p>All employee under department Id : 
            <asp:Label runat="server" ID="lblDeptId"></asp:Label>
        </p>
        <div class="row">
            <div class="col-6 offset-3">
                <table class="table">
                    <thead>
                        <tr>
                            <th>Employee Code</th>
                            <th>Full Name</th>
                            <th>Contant No.</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td colspan="3" class="text-center text-danger">There is no record!
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </form>
</asp:Content>
