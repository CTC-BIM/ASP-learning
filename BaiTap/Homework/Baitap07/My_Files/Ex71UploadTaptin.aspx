<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ex71UploadTaptin.aspx.cs" Inherits="BaiTap.Homework.Baitap07.My_Files.Ex71UploadTaptin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>7.1 Upload Tập tin</title>
    <link href="../../../Content/bootstrap.css" rel="stylesheet" />
    <link href="../../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 class="text-center" style="background-color:#F04F26;color:#FFFFFF; border:#F04F26">Upload file</h2>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Chọn tập tin cần load:" CssClass="form-lable text-right col-xs-5" Width="40%"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-lable text-left col-xs-7" Width="40%" />
                </div>
            <div class="form-group" style="align-content:flex-end">
                <asp:Button ID="btnUpload" runat="server" Text="Upload lên Host" OnClick="btnUpload_Click" />
            </div>
            <div class="form-group col-lg-12">
                <asp:Label ID="lblKetQua" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
