﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="EmployeePortal.Admin.Department" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/css/bootstrap.css" rel="stylesheet" />
    <link href="../Content/toastr/toastr.css" rel="stylesheet" />

    <script src="../Content/jquery/jquery.min.js"></script>
    <script src="../Content/toastr/toastr.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-6 offset-3 mt-5">
                    <asp:HiddenField runat="server" ID="hdfDepartmentId" />
                    <table class="table">
                        <tr>
                            <th>Department Code</th>
                            <td>
                                <asp:TextBox ID="txtDepartmentCode" runat="server"
                                    CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <th>Department Name</th>
                            <td>
                                <asp:TextBox ID="txtDepartmentName" runat="server"
                                    CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <th>Department Description</th>
                            <td>
                                <asp:TextBox ID="txtDepartmentDescription"
                                    TextMode="MultiLine"
                                    Rows="3" Columns="50"
                                    runat="server"
                                    CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnSubmit" Text="Submit" runat="server"
                                    OnClick="btnSubmit_Click"
                                    CssClass="btn btn-primary" />
                            </td>
                        </tr>
                    </table>
                    <%--  <asp:Label runat="server" ID="lblmsg"></asp:Label>--%>
                </div>
            </div>

            <hr />
            <div class="row mb-2">
                <div class="col-md-8 offset-2">
                    <div class="ms-auto">
                        <nav aria-label="Page navigation example">
                            <ul class="pagination">

                                <asp:Repeater runat="server" ID="rptPager">
                                    <ItemTemplate>
                                        <li class="page-item">
                                            <asp:HyperLink runat="server" Text='<%# Eval("PageNo") %>'
                                                CssClass="page-link"
                                                NavigateUrl='<%# Eval("PageUrl") %>'>

                                            </asp:HyperLink>
                                           <%-- <a class="page-link" href="#">
                                                <asp:Label runat="server" Text='<%# Eval("PageNo") %>'></asp:Label>
                                            </a>--%>
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>

                                <%-- <li class="page-item">
                                    <a class="page-link" href="#" aria-label="Previous">
                                        <span aria-hidden="true">&laquo;</span>
                                    </a>
                                </li>
                                <li class="page-item"><a class="page-link" href="#">1</a></li>
                                <li class="page-item"><a class="page-link" href="#">2</a></li>
                                <li class="page-item"><a class="page-link" href="#">3</a></li>
                                <li class="page-item">
                                    <a class="page-link" href="#" aria-label="Next">
                                        <span aria-hidden="true">&raquo;</span>
                                    </a>
                                </li>--%>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-8 offset-2">
                    <asp:GridView runat="server" ID="GridDepartment"
                        CssClass="table table-striped" AutoGenerateColumns="false"
                        OnRowDeleting="GridDepartment_RowDeleting"
                        OnSelectedIndexChanged="GridDepartment_SelectedIndexChanged"
                        DataKeyNames="SystemNumber">

                        <Columns>
                            <asp:BoundField HeaderText="Department Code" DataField="Dcode" />
                            <asp:BoundField HeaderText="Department Name" DataField="Name" />
                            <asp:BoundField HeaderText="Created DateTime" DataField="CreateDateTime" />
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button runat="server" Text="Remove" CommandName="delete"
                                        OnClientClick="return confirm('are your sure want to permanently removed this record?')"
                                        CssClass="btn btn-sm btn-danger" />

                                    <asp:Button runat="server" Text="Edit" CommandName="select"
                                        CssClass="btn btn-sm btn-primary" />

                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
