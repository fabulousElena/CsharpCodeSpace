<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_6_2.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../Js/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#msg").css("display","none");
            $("#txtUserName").blur(function () {
                var userName = $(this).val();
                if (userName != "") {
                    $.post("CheckUserName.ashx", { "name":  userName }, function (data) {
                        $("#msg").css("display", "block");
                        $("#msg").text(data);

                    });
                } else {
                    alert("用户名不能为空!!");
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    用户名:<input type="text" name="txtName" id="txtUserName" /><span id="msg" style="font-size:14px;color:red"></span><br />
    密码:<input type="password" name="txtPWD" /><br />
        <input type="submit" value="注册" />
    </div>
    </form>
</body>
</html>
