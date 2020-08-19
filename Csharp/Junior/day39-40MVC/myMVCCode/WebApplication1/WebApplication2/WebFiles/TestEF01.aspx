<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestEF01.aspx.cs" Inherits="WebApplication2.WebFiles.TestEF01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" Style="height: 34px" />
            </div>
            <div>
                <asp:Button ID="Button2" runat="server" Text="查询" OnClick="Button2_Click" />
            </div>
            <div>
                <asp:Button ID="Button3" runat="server" Text="删除" OnClick="Button3_Click" />
            </div>
            <div>
                <asp:Button ID="Button4" runat="server" Text="更新" OnClick="Button4_Click" />
            </div>
        </div>
        <hr/>
        <div>
            <asp:Button ID="Button5" runat="server" Text="添加" OnClick="Button5_Click" />
        </div>
    </form>
</body>
</html>
