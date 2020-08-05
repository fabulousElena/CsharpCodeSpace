<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfoList.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_5_29.UserInfoList" %>
<!DOCTYPE html>
<%@ Import Namespace="CZBK.ItcastProject.Model" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        window.onload = function () {
            var datas = document.getElementsByClassName("deletes");
            var dataLength = datas.length;
            for (var i = 0; i < dataLength; i++) {
                datas[i].onclick = function () {
                    if (!confirm("确定要删除吗?")) {
                        return false;
                    }
                }
            }
        };
    </script>
    <link href="../Css/tableStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <a href="AddUserInfo.aspx">添加用户</a>
        <table> <tr><th>编号</th><th>用户名</th><th>密码</th><th>邮箱</th><th>时间</th><th>删除</th><th>详细</th><th>编辑</th></tr>
         <%--   <%=StrHtml%>--%>
            <% foreach(UserInfo userInfo in UserList){%>

            <tr>
                <td><%=userInfo.Id %></td>
                   <td><%=userInfo.UserName %></td>
                   <td><%=userInfo.UserPass %></td>
                   <td><%=userInfo.Email %></td>
                   <td><%=userInfo.RegTime.ToShortDateString() %></td>
                <td><a href="Delete.ashx?id=<%=userInfo.Id %>" class="deletes">删除</a></td>
                <td>详细</td>
                <td><a href="EditUser.aspx?id=<%=userInfo.Id %>">编辑</a> </td>
            </tr>

            <%} %>
        </table>
        <hr />
       
      
    </div>
    </form>
</body>
</html>
