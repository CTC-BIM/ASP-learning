<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhCV_Dientich.aspx.cs" Inherits="BaiTap.Homework.Baitap05.TinhCV_Dientich" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính Chu vi và diện tích</title>
    <link href="../../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-Content">
            <h3>Tính chu vi và diện tích</h3>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Chọn hình: " Width="25%" CssClass="form-control col-left text-center"></asp:Label>
                <asp:RadioButton ID="rbtnVuong" GroupName="LoaiHinh" runat="server" Text="Hình Vuông" Checked="True" AutoPostBack="True" OnCheckedChanged="rbtnVuong_CheckedChanged"/>
                <asp:RadioButton ID="rbtnChuNhat" GroupName="LoaiHinh" runat="server" Text="Hình Chữ Nhật" AutoPostBack="True" OnCheckedChanged="rbtnChuNhat_CheckedChanged" />
            </div>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Cạnh: " Width="25%" CssClass="form-control col-left text-center"></asp:Label>
                        <asp:TextBox ID="txtCanh" runat="server" CssClass="form-control text-left" Width="74%"></asp:TextBox>
                    </div>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Chiều dài: " Width="25%" CssClass="form-control col-left text-center"></asp:Label>
                        <asp:TextBox ID="txtChieuDai" runat="server" CssClass="form-control text-left" Width="74%"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Chiều rộng: " Width="25%" CssClass="form-control col-left text-center"></asp:Label>
                        <asp:TextBox ID="txtChieuRong" runat="server" CssClass="form-control text-left" Width="74%"></asp:TextBox>
                    </div>
                </asp:View>
            </asp:MultiView>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Kết quả: " Width="25%" CssClass="form-control col-left text-center"></asp:Label>
                <asp:TextBox ID="txtKetQua" runat="server" CssClass="form-control text-left" Width="74%" Rows="4" TextMode="MultiLine" Height="100px" ReadOnly="True" Wrap="False"></asp:TextBox>
            </div>
            <div class="form-group text-right">
                <asp:Button ID="btnTinh" runat="server" Text="Tính" OnClick="btnTinh_Click" />
                <asp:Button ID="btnTiep" runat="server" Text="Tiếp" OnClick="btnTiep_Click" />
            </div>
        </div>
    </form>
</body>
</html>
