<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListViewDemo.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_6_5.ListViewDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1" InsertItemPosition="LastItem" DataKeyNames="Id">
        <AlternatingItemTemplate>
            <tr style="background-color: #FFFFFF;color: #284775;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                </td>
                <td>
                    <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                </td>
                <td>
                    <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                </td>
                <td>
                    <asp:Label ID="UserPassLabel" runat="server" Text='<%# Eval("UserPass") %>' />
                </td>
                <td>
                    <asp:Label ID="RegTimeLabel" runat="server" Text='<%# Eval("RegTime") %>' />
                </td>
                <td>
                    <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="background-color: #999999;">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="取消" />
                </td>
                <td>
                    <asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UserNameTextBox" runat="server" Text='<%# Bind("UserName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UserPassTextBox" runat="server" Text='<%# Bind("UserPass") %>' />
                </td>
                <td>
                    <asp:TextBox ID="RegTimeTextBox" runat="server" Text='<%# Bind("RegTime") %>' />
                </td>
                <td>
                    <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table id="Table1" runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>未返回数据。</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="插入" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="清除" />
                </td>
                <td>
                    <asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UserNameTextBox" runat="server" Text='<%# Bind("UserName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="UserPassTextBox" runat="server" Text='<%# Bind("UserPass") %>' />
                </td>
                <td>
                    <asp:TextBox ID="RegTimeTextBox" runat="server" Text='<%# Bind("RegTime") %>' />
                </td>
                <td>
                    <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="background-color: #E0FFFF;color: #333333;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                </td>
                <td>
                    <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                </td>
                <td>
                    <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                </td>
                <td>
                    <asp:Label ID="UserPassLabel" runat="server" Text='<%# Eval("UserPass") %>' />
                </td>
                <td>
                    <asp:Label ID="RegTimeLabel" runat="server" Text='<%# Eval("RegTime") %>' />
                </td>
                <td>
                    <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table id="Table2" runat="server">
                <tr id="Tr1" runat="server">
                    <td id="Td1" runat="server">
                        <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr id="Tr2" runat="server" style="background-color: #E0FFFF;color: #333333;">
                                <th id="Th1" runat="server"></th>
                                <th id="Th2" runat="server">Id</th>
                                <th id="Th3" runat="server">用户名</th>
                                <th id="Th4" runat="server">UserPass</th>
                                <th id="Th5" runat="server">RegTime</th>
                                <th id="Th6" runat="server">Email</th>
                            </tr>
                            <tr id="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr id="Tr3" runat="server">
                    <td id="Td2" runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
                       
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="background-color: #E2DED6;font-weight: bold;color: #333333;">
                <td>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                </td>
                <td>
                    <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                </td>
                <td>
                    <asp:Label ID="UserNameLabel" runat="server" Text='<%# Eval("UserName") %>' />
                </td>
                <td>
                    <asp:Label ID="UserPassLabel" runat="server" Text='<%# Eval("UserPass") %>' />
                </td>
                <td>
                    <asp:Label ID="RegTimeLabel" runat="server" Text='<%# Eval("RegTime") %>' />
                </td>
                <td>
                    <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
         <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                            </Fields>
                        </asp:DataPager>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="CZBK.ItcastProject.Model.UserInfo" DeleteMethod="DeleteUserInfo" InsertMethod="AddUserInfo" SelectMethod="GetPageListView" TypeName="CZBK.ItcastProject.BLL.UserInfoService" UpdateMethod="EditUserInfo" EnablePaging="True" SelectCountMethod="GetRecordCount" CacheDuration="8" EnableCaching="True"></asp:ObjectDataSource>
    </div>
    </form>
  
</body>
</html>
