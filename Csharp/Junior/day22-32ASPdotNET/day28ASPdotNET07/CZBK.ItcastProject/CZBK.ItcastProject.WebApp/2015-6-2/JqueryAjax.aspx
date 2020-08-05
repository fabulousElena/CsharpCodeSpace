<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JqueryAjax.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_6_2.JqueryAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../Js/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btnGet").click(function(){
                $.get("GetDate.ashx", { "name": "lisi", "pwd": "123" }, function (data) {
                    alert(data)
                });

            });

            $("#btnPost").click(function () {
                $.post("ShowDate.aspx", { "name": "lisi", "pwd": "123" }, function (data) {
                    alert(data)
                })
            });


            $("#btnAjax").click(function () {
                $.ajax({
                    type: "POST",
                    url: "GetDate.ashx",
                    data: "name=John&location=Boston",
                    success: function (msg) {
                        alert("Data Saved: " + msg);
                    }
                });

            });


        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input type="button" value="GET获取数据" id="btnGet" />
        <input type="button" value="POST获取数据" id="btnPost" />
        <input type="button" value="AJAX获取数据" id="btnAjax" />
    </div>
    </form>
</body>
</html>
