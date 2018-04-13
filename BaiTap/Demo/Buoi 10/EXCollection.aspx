<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EXCollection.aspx.cs" Inherits="BaiTap.Demo.Buoi_10.EXCollection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Hastable</h3>
            <div class="form-group">
                <asp:Button ID="btnHashtable" runat="server" Text="1-hastable" OnClick="btnHashtable_Click" />
                <asp:Button ID="btnSortList" runat="server" Text="2-SortList" OnClick="btnSortList_Click" />
            </div>

            <div>
                <asp:Label ID="lblKetQUA" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
