<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="Button1" runat="server" Text="添加客户" OnClick="Button1_Click" />
    </div>
        
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="查询" />
        <p>
            <asp:Button ID="Button3" runat="server" Text="输出某个具体客户的订单号" OnClick="Button3_Click" />
        </p>
        
        <asp:Button ID="Button4" runat="server" Text="输出某个具体订单号对应的用户名" OnClick="Button4_Click" />
        
        <asp:Button ID="Button5" runat="server" Text="删除某个用户（userId=1）下的所有订单" OnClick="Button5_Click" />
        
    </form>
</body>
</html>
