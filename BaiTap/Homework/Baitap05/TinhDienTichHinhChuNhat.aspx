<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhDienTichHinhChuNhat.aspx.cs" Inherits="BaiTap.Homework.Baitap05.TinhDienTichHinhChuNhat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính diện tích hình Chữ Nhật</title>
    <link href="../../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-Content">
            <h3>Tính diện tích Hình Chữ Nhật</h3>

            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Chiều dài: " Width="25%" CssClass="form-control col-left text-center"></asp:Label>
                <asp:TextBox ID="txtChieuDai" runat="server" CssClass="form-control text-left" Width="74%"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Chiều rộng: " Width="25%" CssClass="form-control col-left text-center"></asp:Label>
                <asp:TextBox ID="txtChieuRong" runat="server" CssClass="form-control text-left" Width="74%"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Diện tích: " Width="25%" CssClass="form-control col-left text-center" Enabled="false"></asp:Label>
                <asp:TextBox ID="txtKetqua" runat="server" CssClass="form-control text-left" Width="74%"  Enabled="false" BackColor="#999999"></asp:TextBox>
            </div>

            <div class=" text-right">
                <asp:Button ID="btnTinh" runat="server" Text="Tính" OnClick="btnTinh_Click" />
                <asp:Button ID="btnTiep" runat="server" Text="Tiếp" OnClick="btnTiep_Click" />
            </div>

        </div>
    </form>
</body>
</html>
