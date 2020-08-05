<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerDemo.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_5_30.ServerDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        主页面内容
    <%--<%
        Server.Execute("Child.aspx");
         %>--%>

       <%-- <hr />--%>
       <%-- SEO
        蜘蛛爬虫.
        <iframe src="Child.aspx" frameborder="0"></iframe>--%>
   
<%--        <%Server.Transfer("Child.aspx");%>--%>
      


          <!--与Response.Redirect的区别。Transfer：服务端跳转，不会向浏览器返回任何内容，所以地址栏中的URL地址不变。-->

        <%=Server.HtmlEncode("<font color='red'></font>")%>

        <a href="aa.aspx?a=<%=Server.UrlEncode("") %>"></a>
    </div>
    </form>
</body>
</html>
