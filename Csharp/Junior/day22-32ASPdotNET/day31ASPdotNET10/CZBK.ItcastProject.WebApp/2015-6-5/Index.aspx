<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CZBK.ItcastProject.WebApp._2015_6_5.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        function show() {
            document.getElementById("TextBox1").value;

        }
    </script>
    <style type="text/css">
        .txt {
        font-size:20px;
        color:red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged" TextMode="Url" Width="112px" AutoPostBack="true"></asp:TextBox>
        <asp:Button ID="Button1"  runat="server" Text="Button" CssClass="txt" OnClick="Button1_Click" />
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label" AssociatedControlID="TextBox1">aaaaa</asp:Label>
        男 <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Sex" />
      女 <asp:RadioButton ID="RadioButton2" runat="server"  GroupName="Sex" />
   

        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <asp:Panel ID="Panel1" runat="server" GroupingText="aaaa">
            dsafasdfsafsadfas
            asfasdf
        </asp:Panel>
        <asp:FileUpload ID="FileUpload1" runat="server" />

        <asp:Button ID="Button2" runat="server" Text="上传" OnClick="Button2_Click"/>


        <input type="text" runat="server" id="txt1" />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                <asp:BoundField DataField="UserPass" HeaderText="UserPass" SortExpression="UserPass" />
                <asp:BoundField DataField="RegTime" HeaderText="RegTime" SortExpression="RegTime" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetList" TypeName="CZBK.ItcastProject.BLL.UserInfoService"></asp:ObjectDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server"  DataTextField="UserName" DataValueField="Id">
            
        </asp:DropDownList>

        <hr />
        <select name="UserInfos">

        </select>

         </form>
    
   
</body>
</html>
