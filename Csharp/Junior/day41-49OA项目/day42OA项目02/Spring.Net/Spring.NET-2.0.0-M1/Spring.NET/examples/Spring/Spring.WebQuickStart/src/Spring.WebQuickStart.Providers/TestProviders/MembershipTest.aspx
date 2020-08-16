<%@ Page Language="C#" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Profile Provider Test</title>
<SCRIPT runat="server">
private void Page_Load(object sender, System.EventArgs e)
{
    MembershipProvider defaultProvider = Membership.Provider;
    this.TxtDescription.Text = defaultProvider.Description;
    this.TxtName.Text = defaultProvider.Name;
    this.TxtType.Text = defaultProvider.GetType().ToString();
    
    LstAllMembers.Items.Clear();
    foreach (MembershipUser user in Membership.GetAllUsers())
    {
        LstAllMembers.Items.Add(user.UserName);
    }
}
</SCRIPT>
</head>
<body>
    <form id="form1" runat="server">
                    
            <asp:Label ID="LblName" runat="server" Text="Provider Name:"></asp:Label>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LblDescription" runat="server" Text="Provider Description:"></asp:Label>
            <asp:TextBox ID="TxtDescription" runat="server"></asp:TextBox><br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Provider Type:"></asp:Label>
            <asp:TextBox ID="TxtType" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LblAllMembers" runat="server" Text="All members:"></asp:Label><br />
            <asp:ListBox ID="LstAllMembers" runat="server" Height="149px" Width="219px"></asp:ListBox>        
    </form>
</body>
</html>