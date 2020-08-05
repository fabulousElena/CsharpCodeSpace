<%@ Page Title="" Language="C#" MasterPageFile="~/2015-6-5/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_6_5.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function showResult() {
            document.getElementById(<%=TextBox1.ClientID%>).value;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   aspx页面 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</asp:Content>
