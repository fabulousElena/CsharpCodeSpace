<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.RoomType.Show" Title="��ʾҳ" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		TypeId
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTypeId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TypeName
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTypeName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddBed
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddBed" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BedPrice
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBedPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
