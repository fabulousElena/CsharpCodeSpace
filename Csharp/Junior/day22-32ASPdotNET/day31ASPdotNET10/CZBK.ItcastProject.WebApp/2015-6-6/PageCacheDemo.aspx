<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageCacheDemo.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_6_6.PageCacheDemo" %>
<%@ OutputCache Duration="5" VaryByParam="*" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
  <a href="ShOWDetail.aspx?id=196">用户详细信息</a>

 <a href="ShOWDetail.aspx?id=197">用户详细信息</a>
    </div>
        
    </form>
</body>
</html>
