<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EXFile_XML1.aspx.cs" Inherits="BaiTap.Demo.EXFile_XML1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/Site.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>XML</h2>
            <div class ="form-group">
                <asp:Label ID="Label1" runat="server" Text="Mã số: " CssClass="form-lable text-right col-left" Width="25%"></asp:Label>
                <asp:TextBox ID="txtMaSo" runat="server" CssClass="form-control text-left col-right" Width="75%"></asp:TextBox>
            </div>
                        <div class ="form-group">
                <asp:Label ID="Label2" runat="server" Text="Họ tên: " CssClass="form-lable text-right col-left" Width="25%"></asp:Label>
                <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control text-left col-right" Width="75%"></asp:TextBox>
            </div>
            <div class="text-left">
            <asp:Label ID="lblKetQua" runat="server" Text=""></asp:Label>
            </div>
            <div class="text-right">
                <asp:Button ID="btnTaoMoi" runat="server" Text="Tạo Mới" OnClick="btnTaoMoi_Click" />
                <asp:Button ID="btnDoc" runat="server" Text="Đọc" OnClick="btnDoc_Click" />
                <asp:Button ID="btnThemNode" runat="server" Text="Thêm Node" OnClick="btnThemNode_Click" />
                <asp:Button ID="btnXuatDanhSach" runat="server" Text="Xuất Danh Sách" OnClick="btnXuatDanhSach_Click" />
            </div>
            <div class="text-center">
                <asp:GridView ID="gridViewSinhVien" runat="server">
                </asp:GridView>
            </div>
        </div>        
    </form>
</body>
</html>
