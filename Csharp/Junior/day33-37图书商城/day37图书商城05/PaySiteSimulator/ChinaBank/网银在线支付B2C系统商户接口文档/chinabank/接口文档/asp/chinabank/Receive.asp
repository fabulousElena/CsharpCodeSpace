<!--  
 * ====================================================================
 *
 *                 Receive.asp ���������߼���֧���ṩ
 *
 *     ��ҳ��Ϊ֧����ɺ��ȡ���صĲ���������......
 *
 *
 * ====================================================================
-->
<!--#include file="MD5.asp"-->
<%   
'****************************************	' MD5��ԿҪ�������ύҳ��ͬ����Send.asp��� key = "test" ,�޸�""���� test Ϊ������Կ
											' �������û������MD5��Կ���½����Ϊ���ṩ�̻���̨����ַ��https://merchant3.chinabank.com.cn/
	key = "test"							' ��½��������ĵ�����������ҵ���B2C�����ڶ������������С�MD5��Կ���á�
											' ����������һ��16λ���ϵ���Կ����ߣ���Կ���64λ��������16λ�Ѿ��㹻��
'****************************************

' ȡ�÷��ز���ֵ
	v_oid=request("v_oid")                               ' �̻����͵�v_oid�������
	v_pmode=request("v_pmode")                           ' ֧����ʽ���ַ����� 
	v_pstatus=request("v_pstatus")                       ' ֧��״̬ 20��֧���ɹ���;30��֧��ʧ�ܣ�
	v_pstring=request("v_pstring")                       ' ֧�������Ϣ ֧����ɣ���v_pstatus=20ʱ����ʧ��ԭ�򣨵�v_pstatus=30ʱ����
	v_amount=request("v_amount")                         ' ����ʵ��֧�����
	v_moneytype=request("v_moneytype")                   ' ����ʵ��֧������
	remark1=request("remark1")                           ' ��ע�ֶ�1
	remark2=request("remark2")                           ' ��ע�ֶ�2
	v_md5str=request("v_md5str")                         ' ��������ƴ�յ�Md5У�鴮


if request("v_md5str")="" then
	response.Write("v_md5str����ֵ")
	response.end
end if


'md5У��

	text = v_oid&v_pstatus&v_amount&v_moneytype&key

	md5text =Ucase(trim(md5(text)))    '�̻�ƴ�յ�Md5У�鴮

	'if md5text<>v_md5str then		' ��������ƴ�յ�Md5У�鴮 �� �̻�ƴ�յ�Md5У�鴮 ���жԱ�
	'�Ա�ʧ�ܱ�ʾ��Ϣ���������߷��ص���Ϣ

	'  response.write("У��ʧ��,���ݿ���")
   '   response.end
	'else
	'�Աȳɹ���ʾ��Ϣ���������߷��ص���Ϣ

	'  if v_pstatus=20 then

		'֧���ɹ�
		'�˴������̻�ϵͳ���߼����������жϽ��ж�֧��״̬�����¶���״̬�ȵȣ�......

	'  end if

	'end if
%>






<!--
�����Ǵ�ӡ�����н������ݵĽ�����������Ա�ο�
-->
<TABLE width=500 border=0 align="center" cellPadding=0 cellSpacing=0>
		  <TBODY>
			<TR> 
			  <TD vAlign=top align=middle> <div align="left"><B><FONT style="FONT-SIZE:14px">MD5У����:<%=v_md5str%></FONT></B></div></TD>
			</TR>
			<TR> 
			  <TD vAlign=top align=middle> <div align="left"><B><FONT style="FONT-SIZE: 14px">������:<%=v_oid%></FONT></B></div></TD>
			</TR>
			<TR> 
			  <TD vAlign=top align=middle> <div align="left"><B><FONT style="FONT-SIZE: 14px">֧������:<%=v_pmode%></FONT></B></div></TD>
			</TR>
			<TR> 
			  <TD vAlign=top align=middle> <div align="left"><B><FONT style="FONT-SIZE: 14px">֧�����:<%=v_pstring%></FONT></B></div></TD>
			</TR>
			<TR> 
			  <TD vAlign=top align=middle> <div align="left"><B><FONT style="FONT-SIZE: 14px">֧�����:<%=v_amount%></FONT></B></div></TD>
			</TR>
			<TR> 
			  <TD vAlign=top align=middle> <div align="left"><B><FONT style="FONT-SIZE: 14px">֧������:<%=v_moneytype%></FONT></B></div></TD>
			</TR>
		  </TBODY>
		</TABLE>