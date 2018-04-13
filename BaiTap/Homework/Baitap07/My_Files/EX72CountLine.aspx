<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EX72CountLine.aspx.cs" Inherits="BaiTap.Homework.Baitap07.My_Files.EX72CountLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>7.2 Đếm số dòng trong tập tin văn bản</title>
    <link href="../../../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .Tieude{
            background-color:#F04F26;
            color:#FFFFFF;
            border-color:#F04F26;
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="form-group Tieude">
                <asp:Label ID="Label1" runat="server" Text="Đếm số dòng trong tập tin văn bản"></asp:Label>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Chọn tập tin: " CssClass="form-lable text-right col-lg-3"></asp:Label>
                <asp:FileUpload ID="fUL1" runat="server" CssClass="form-control col-lg-5" />
                <asp:Button ID="btnReadAndCount" runat="server" Text="Đọc và Đếm số dòng" cssClass="col-4" OnClick="btnReadAndCount_Click"/>
            </div>
            <div>
                <asp:Label ID="lblKetQua" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
