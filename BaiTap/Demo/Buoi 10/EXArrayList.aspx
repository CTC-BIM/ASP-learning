<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EXArrayList.aspx.cs" Inherits="BaiTap.Demo.Buoi_10.EXArrayList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Array list</h3>
            <div class="form-group">
                <asp:Button ID="btnAdd" runat="server" Text="1-Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnAddRange" runat="server" Text="1-AddRange" OnClick="btnAddRange_Click" />
                <asp:Button ID="btnInsert" runat="server" Text="3-Insert" OnClick="btnInsert_Click" />
                <asp:Button ID="btnRemove" runat="server" Text="4-Remove" OnClick="btnRemove_Click" />
                <asp:Button ID="btnTimKiem" runat="server" Text="5-Tìm kiếm" OnClick="btnTimKiem_Click" />
                <asp:Button ID="btnSapXep" runat="server" Text="6-Sắp xếp" OnClick="btnSapXep_Click" />
                <asp:Button ID="btnDuyet" runat="server" Text="7-For" OnClick="btnDuyet_Click" />
                <asp:Button ID="btnWhile" runat="server" Text="8-While" OnClick="btnWhile_Click" />
            </div>
            <div>
                <asp:Label ID="lblKetQua" runat="server" Text=""></asp:Label>
            </div>
        <div>
            <asp:Label ID="lblKetQua2" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblKetQua3" runat="server" Text=""></asp:Label>
        </div>
                    <div>
            <asp:Label ID="lblKetqua4" runat="server" Text=""></asp:Label>
        </div>
        </div>
    </form>
</body>
</html>
