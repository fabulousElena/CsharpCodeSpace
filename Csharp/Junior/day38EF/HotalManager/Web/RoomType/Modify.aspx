<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="BookShop.Web.RoomType.Modify" Title="�޸�ҳ" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		TypeId
	��</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblTypeId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TypeName
	��</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTypeName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price
	��</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddBed
	��</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAddBed" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BedPrice
	��</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBedPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	��</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRemark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnUpdate" runat="server" Text="�� �ύ ��" OnClick="btnUpdate_Click" ></asp:Button>
	</div></td></tr>
</table>

</asp:Content>
