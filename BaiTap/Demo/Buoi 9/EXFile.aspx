<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EXFile.aspx.cs" Inherits="BaiTap.Demo.EXFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>làm việc với FILE</h3>
            <div>
            <asp:TextBox ID="txtNoidung" runat="server" TextMode="MultiLine" Rows="5" Width="600px"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnGhi" runat="server" Text="1-Ghi" OnClick="btnGhi_Click" />
                <asp:Button ID="btnDoc" runat="server" Text="2-Đọc" OnClick="btnDoc_Click" />
                <asp:Button ID="btnXoaNoiDung" runat="server" Text="3-Xóa nội dung" OnClick="btnXoaNoiDung_Click" />
                <asp:Button ID="btnDocTheoDong" runat="server" Text="4-Đọc theo dòng" OnClick="btnDocTheoDong_Click" />
            </div>
            <div>
                <asp:Button ID="btnDemo" runat="server" Text="Demo" OnClick="btnDemo_Click" />
            </div>
            <div>
                <asp:FileUpload ID="FileUpload1" runat="server" Width="598px" />
                <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
            </div>
        </div>
    </form>
</body>
</html>
