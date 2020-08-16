<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MainMaster.Master" AutoEventWireup="true" CodeBehind="FindPwd.aspx.cs" Inherits="BookShop.Web.Member.FindPwd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <script type="text/javascript">
        $(function () {
            $("#btnFindPwd").click(function () {
                findPwd();
            });
        });
        function findPwd() {
            var userName = $("#txtName").val();
            var userMail = $("#txtMail").val();
            if (userName != "" && userMail != "") {
                $.post("/ashx/FindPwd.ashx", { "name": userName, "mail": userMail }, function (data) {

                });
            } else {
                alert("用户名邮箱不能为空");
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table>
        <tr><td>用户名</td><td><input type="text" id="txtName" /></td></tr>
          <tr><td>邮箱</td><td><input type="text" id="txtMail" /></td></tr>
          <tr><td colspan="2"><input type="button" value="找回密码" id="btnFindPwd" /></td></tr>
    </table>
</asp:Content>
