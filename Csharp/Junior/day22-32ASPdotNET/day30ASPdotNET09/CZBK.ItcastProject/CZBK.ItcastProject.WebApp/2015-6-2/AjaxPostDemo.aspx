<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxPostDemo.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_6_2.AjaxPostDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../Js/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btnPost").click(function () {
                var xhr;
                if (XMLHttpRequest) {
                    xhr = new XMLHttpRequest();
                } else {
                    xhr = new ActiveXObject("Microsoft.XMLHTTP");
                }
                xhr.open("post", "GetDate.ashx", true);
                xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
                xhr.send("name=zhangsan&pwd=123");
                xhr.onreadystatechange = function () {
                    if (xhr.readyState == 4) {
                        if (xhr.status == 200) {
                            alert(xhr.responseText);
                        }
                    }
                  }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server" >
    <div>
    <input type="button" value="获取数据" id="btnPost" />
        
    </div>
    </form>
</body>
</html>
