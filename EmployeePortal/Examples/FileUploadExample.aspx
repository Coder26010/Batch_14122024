<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadExample.aspx.cs" Inherits="EmployeePortal.Examples.FileUploadExample" %>

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
        <asp:FileUpload runat="server" ID="fileImage" />

        <asp:Button runat="server" Text="Submit" ID="btnSubmit"
            OnClick="btnSubmit_Click" />
    </form>
</body>
</html>
