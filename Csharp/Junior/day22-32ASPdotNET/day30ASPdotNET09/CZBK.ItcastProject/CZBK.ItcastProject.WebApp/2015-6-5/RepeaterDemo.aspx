<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterDemo.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_6_5.RepeaterDemo" EnableViewState="false" %>
<%@ Import Namespace="CZBK.ItcastProject.Common" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
    <div>
      <%--      <ItemTemplate>就是一个foreach.--%>
     
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <HeaderTemplate>
                   <table>
                <tr><th>编号</th><th>用户名</th><th>密码</th><th>邮箱</th><th>时间</th><th>删除</th><th>详细</th><th>编辑</th></tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("Id") %></td>
                       <td><%#Eval("UserName") %></td>
                     <td><%#Eval("UserPass") %></td>
                     <td><%#Eval("Email") %></td>
                     <td><%#Eval("RegTime") %></td>
                    <td><asp:Button ID="BtnDeleteInfo" CommandName="BtnDeleteUser" runat="server" Text="删除"  CommandArgument='<%#Eval("Id")%>'/></td>
                    
                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate>
                  <tr style="background-color:gray">
                    <td><%#Eval("Id") %></td>
                       <td><%#Eval("UserName") %></td>
                     <td><%#Eval("UserPass") %></td>
                     <td><%#Eval("Email") %></td>
                     <td><%#Eval("RegTime") %></td>
                      <td><asp:Button ID="BtnDeleteInfo" CommandName="BtnDeleteUser" runat="server" Text="删除"  CommandArgument='<%#Eval("Id")%>'/></td>
                </tr>
            </AlternatingItemTemplate>
            <SeparatorTemplate>
                <tr>
                    <td colspan="6"><hr /></td>
                </tr>
            </SeparatorTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>

            <%=PageBarHelper.GetPagaBar(PageIndex,PageCount)%>



    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
