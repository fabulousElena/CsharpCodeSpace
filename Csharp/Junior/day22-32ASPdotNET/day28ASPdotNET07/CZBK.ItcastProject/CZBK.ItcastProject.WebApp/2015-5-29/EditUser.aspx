<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_5_29.EditUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     用户名:<input type="text" name="txtName" value="<%=EditUserInfo.UserName %>" /><br />
        密码:<input type="text" name="txtPwd" value="<%=EditUserInfo.UserPass %>" /><br />
        邮箱:<input type="text" name="txtMail" value="<%=EditUserInfo.Email %>" /><br />
        <input type="hidden" name="txtId" value="<%=EditUserInfo.Id %>" />
        <input type="hidden" name="txtRegTime" value="<%=EditUserInfo.RegTime %>" />
        <input type="submit" value="编辑用户" />
    </div>
    </form>
</body>
</html>
