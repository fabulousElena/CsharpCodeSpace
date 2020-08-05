<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUserInfo.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_5_29.AddUserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     用户名:<input type="text" name="txtName" /><br />
        密码:<input type="password" name="txtPwd" /><br />
        邮箱:<input type="text" name="txtMail" /><br />
    <%--    <input type="hidden" name="isPostBack" value="aaa" />--%>
        <input type="submit" value="添加用户" />

    </div>

       
    </form>
</body>
</html>
