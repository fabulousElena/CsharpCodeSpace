<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_5_31.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        window.onload = function () {
            var validateCode = document.getElementById("validateCode");
            validateCode.onclick = function () {
                document.getElementById("imgCode").src = "ValidateImageCode.ashx?d=" + new Date().getMilliseconds();
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        用户名:<input type="text" name="txtName" value="<%=UserName%>"  /><br />
        密码;<input type="password" name="txtPwd" /><br />
        验证码:<input type="text" name="txtCode" /><img src="ValidateImageCode.ashx" id="imgCode" /> <a href="javascript:void(0)" id="validateCode"> 看不清</a><br />
        <input type="submit" value="登录" /><span style="font-size:14px;color:red"><%=Msg %></span>
    </div>
    </form>
</body>
</html>
