--create database SqlDemos
--bgo
--use sqldemos
--go

---���������и�Ĭ��ֵ
--create table UserInfo
--(
--	Id  int identity(1,1) primary key not null,
--	Name nvarchar(32) default('sss') null
--)

---�����ݿ�ı����һ��
--alter table ���� add  ����  ����  null
--alter table UserInfo add [Address] nvarchar(32) null

--alter table UserInfo add DelFlag smallint null

--���ݽӿ�ı�ɾ��һ����
--alter table UserInfo drop constraint DF_UserInfo_DelFlag
--go
--alter table UserInfo drop column DelFlag
--go

--�޸�һ����
--alter table UserInfo alter Column [Address] nvarchar(64) null

--����ķ�ʽ���������Ĭ��ֵԼ��
--alter table ����  add constraint Լ��������  default(0) for DelFlag
--alter table UserInfo add constraint DF_UserInfo_DelFlag default(0) for DelFlag

--�������
--insert into UserInfo([Address]) values(N'�����йش�2')
--select * from UserInfo

--create Table  Product
--(
--	ProId int identity(1,1) not null,
--	ProName nvarchar(32) null,
--	ProCreateOn DateTime default(getdate()) null
--)

--������һ������
--alter table Product add constraint PK_Product_ProId primary key(ProId)

--������һ��ΨһԼ��
--alter table product add constraint UQ_Product_ProName Unique(ProName)

--alter table Product drop constraint UQ_Product_ProName
--- Unique


--select getdate()

--alter table ���� add/drop  constraint Լ����  Unique(����)/Primary key(�У�

--alter table Product add CountNumber int null
--Ҫ��  countnumber ������0  10000֮��
--alter table Product add constraint CK_Product_CountNumber Check(CountNumber>0 and CountNumber<10000)


----������һ�������п��԰��������Ʒ
--create table OrderInfo
--(
--	OrderId int identity(1,1) primary key not null,
--	OrderInfoDes nvarchar(64) null,
--	DelFlag smallint default(0)  null
--)
--go
----����� ����Ʒ��  һ����Ʒֻ������һ�����࣬һ��������԰��������Ʒ��
--Create table Category
--(
--	CatId int identity primary key not null,
--	CatName nvarchar(32) null,
--	ParentCatId int null,
--	DelFlag smallint default(0) null
--)
--go


--����Ʒ�������  ����������
--alter table Product add CategoryId int  null

--��������ϵ
--alter table SqlDemos.dbo.Product add constraint FK_Product_Category foreign key(CategoryId)
--references Category(CatId)


--select p.*,p.ProCreateOn,proName as ��Ʒ�� from Product as p

--Select ��ѯ
--select 1000*0.1+10+2009 as Ǯ��--���������еļ� as ����   

--select Ǯ��=123*1333

--select 1000*0.1+10+2009 Ǯ��

--select 'sss',*  from Product 

--select count(*) from Product
--count(*) ���ұ�����̵��н���ͳ��������
--count(1) count(2) count('ss') �Գ����н���ͳ������

--select getdate()

--select @@VERSION
--select @@CPU_BUSY
--select @@ERROR


--�ۺϺ���
 --use AdventureWorksLT2008
 --go

 --select * from SalesLT.Customer
 --use ItcastDb

 --select * from tblScore

 --select avg(score1) as �ɼ�1,avg(score2) as �ɼ�2 from tblScore

 --select sum(score1) as �ɼ�1,sum(score2) as �ɼ�2 from tblScore
 --select max(score1),min(score1) from tblScore

 --select * from tblScore order by score1 desc,score2 desc
 --�ѳɼ�1 ǰ���������ݲ�ѯ����
 --select 
 --top 3 
	--* ,
	--StuId as Demo
 --from 
	--tblScore 
 --order by 
	--score1 desc
--select * from tblScore
--select distinct   score1 from tblScore order by score1

--use [AdventureWorksLT2008]
--distinctֻ�ܽ�����select���棬�����ǶԺ�������е��ж�����ȥ�ظ�����
--select distinct  title,MiddleName from [SalesLT].[Customer]
--	order by Title,MiddleName

--select * from SalesLT.Customer
--	where 
--	CustomerID<100 and Title<>'Ms.' or MiddleName='N.'

--select * from SalesLT.Customer 
--	--where CustomerID>20 and CustomerID<50
--	where CustomerID between 20 and 50

--Ҫ�󣺰����� FirstName�� �� Jac��ͷ�� ���ݶ���ѯ������
--select * from SalesLT.Customer 
	--where FirstName like 'Jac%'
	--where CompanyName like '%''%'--���������ű�ʾһ��������
	--where CompanyName like '%[0-9]%'
	--where CompanyName like '%[[]%' --escape '\'

--��ѯΪmiddlename ��null������
--select * from SalesLT.Customer  where MiddleName is not null


---------------------����-----------------------------------
--select * from SalesLT.Customer
--use [AdventureWorksLT2008]
--select   --���岽����ʱֻ�ܰѷ������Ϣ����ѯ������
--	Title,
--	MiddleName,
--	count(*) as ����,
--	sum(customerId) 
--  from --��һ�����ҵ���
--	SalesLT.Customer
--  where  --�ڶ�������ԭʼ�����ݽ��й���
--	MiddleName is not null
--  group by   --������������������
--	Title,MiddleName
--  having 
--	count(*) >10  --���Ĳ����Է��������ݽ��й���
--  order by 
--	count(*) asc --���һ��

	--ֻҪ����GroupBy   select����ֻ�ܸ� group by������ֶλ����ǾۺϺ�����



----------����ת��---------------
--select * from SalesLT.Customer

--select CustomerId+Title from SalesLT.Customer

--����ת��
	-->  Convert(Ŀ�����ͣ�ת���ı��ʽ����ʽ�淶)
	-->  Cast����� as ���ͣ�

--select Convert(nvarchar(32), CustomerId)+Title from SalesLT.Customer

--select cast(CustomerId as nvarchar(32))+Title from SalesLT.Customer

--use [ItcastDB]

--select * from  [dbo].[tblStudent]
----���ٴ�����ķ�ʽ��  
--select * into tblStudent2 from tblStudent
--where stuid>5

--select * from  [dbo].[tblStudent2]

-- ��[tblStudent2]�� [tblStudent] �������������������
--select stuId, stuName, stuSex, stuBirthdate, stuPhone
-- from dbo.tblStudent
-- union all
-- --union  �����ȥ�ز�����Ч�ʷǳ��͡�
-- select stuId, stuName, stuSex, stuBirthdate, stuPhone
-- from dbo.tblStudent2

--select * from tblStudent2

--set Identity_Insert tblStudent2 on
--go
--insert into tblStudent2(stuId,stuName) values(112,'sss')

----������һ���Ѿ����ڵı������  ����
--insert into tblStudent2(stuId, stuName, stuSex, stuBirthdate, stuPhone) select stuId, stuName, stuSex, stuBirthdate, stuPhone from tblStudent where stuid<5
--go
--set Identity_Insert tblStudent2 off

-----------���ں���---------------------
--��ȡ��ǰ����
--select getdate()
--dateadd(��λ������������)
--select DATEADD(day,1,'2015-3-1')

-----***************
--select DATEDIFF(MONTH,'2015-5-1','2015-5-9')

--select  datepart(MONTH,'2014-4-3')
--select year('2014-5-6')

------�ַ�������

--select LOWER(stuName) from tblStudent

--select ASCII('a')

--select LEFT('123456',4)

--select Right('123456',4)

--select datalength(N'1234')
--select RTRIM('    123  ')

--use [SqlDemos]
-------�����Ӳ�ѯ---
--select * from Product 

--select * from Category

--select P.*,C.* from Product as P
--join Category as C on P.CategoryId=C.CatId


--�����еĶ�����ѯ������Ȼ��Ҫ����û�����Ϣ��ʾ,����Ҫ����Ʒ����ϢҲ��ʾ
--use [AdventureWorksLT2008]
--select
--	 O.*,C.FirstName
--from 
--	SalesLT.SalesOrderHeader as O
--join 
--	SalesLt.Customer as C 
--on 
--	O.CustomerID=C.CustomerID




--select 
--	H.*,D.ProductID,P.Name
--from 
--	SalesLT.SalesOrderHeader as H
--join
--	 SalesLT.SalesOrderDetail as D
--on
--	 H.SalesOrderID = D.SalesOrderID
--join SalesLT.Product as P
--on  D.ProductID=P.ProductID




-----------������ϰ
--CREATE TABLE [CallRecords]
--(
--	[Id] [int] NOT NULL identity(1,1),
--	[CallerNumber] [nvarchar](50), --��λ���֣���������Ա����ţ����ţ�
--	[TelNum] [varchar](50),
--	[StartDateTime] [datetime] NULL,
--	[EndDateTime] [datetime] NULL  --����ʱ��Ҫ���ڿ�ʼʱ��,Ĭ�ϵ�ǰʱ��
--)

----����Լ��
--alter table [CallRecords]
--add constraint PK_CallRecords primary key(id)

----���Լ��
--alter table [CallRecords]
--add constraint CK_CallRecords check(CallerNumber like '[0-9][0-9][0-9]')   

--alter table [CallRecords]
--add constraint CK_CallRecords_EndDateTime check(EndDateTime > StartDateTime)

----Ĭ��Լ��
--alter table [CallRecords]
--add constraint DF_CallRecords default(getdate()) for EndDateTime



--INSERT [dbo].[CallRecords] ([CallerNumber], [TelNum], [StartDateTime], [EndDateTime]) VALUES ('001', '0208888888', CAST(0x00009DAF00A4CB80 AS DateTime), CAST(0x00009DAF00A62E94 AS DateTime));
--INSERT [dbo].[CallRecords] ([CallerNumber], [TelNum], [StartDateTime], [EndDateTime]) VALUES ('001', '0208888888', CAST(0x00009DB000D63BC0 AS DateTime), CAST(0x00009DB000D68DC8 AS DateTime));
--INSERT [dbo].[CallRecords] ([CallerNumber], [TelNum], [StartDateTime], [EndDateTime]) VALUES ('001', '89898989', CAST(0x00009DB000E85C60 AS DateTime), CAST(0x00009DB000E92F50 AS DateTime));
--INSERT [dbo].[CallRecords] ([CallerNumber], [TelNum], [StartDateTime], [EndDateTime]) VALUES ('002', '98987676', CAST(0x00009DB2015BB7A0 AS DateTime), CAST(0x00009DB2015C4DA0 AS DateTime));
--INSERT [dbo].[CallRecords] ([CallerNumber], [TelNum], [StartDateTime], [EndDateTime]) VALUES ('002', '02188839389', CAST(0x00009DA4014C9C70 AS DateTime), CAST(0x00009DA4014E0308 AS DateTime));
--INSERT [dbo].[CallRecords] ([CallerNumber], [TelNum], [StartDateTime], [EndDateTime]) VALUES ('001', '767676766', CAST(0x00009DB400DAA0C0 AS DateTime), CAST(0x00009DB400DD5FE0 AS DateTime));
--INSERT [dbo].[CallRecords] ([CallerNumber], [TelNum], [StartDateTime], [EndDateTime]) VALUES ('003', '0227864656', CAST(0x00009DB200B9AB40 AS DateTime), CAST(0x00009DB200B9FC1C AS DateTime));
--INSERT [dbo].[CallRecords] ([CallerNumber], [TelNum], [StartDateTime], [EndDateTime]) VALUES ('003', '676765777', CAST(0x00009DB8014042B8 AS DateTime), CAST(0x00009DB80141804C AS DateTime));
--INSERT [dbo].[CallRecords] ([CallerNumber], [TelNum], [StartDateTime], [EndDateTime]) VALUES ('001', '89977653', CAST(0x00009D9A00FB9898 AS DateTime), CAST(0x00009D9A00FE6118 AS DateTime));
--INSERT [dbo].[CallRecords] ([CallerNumber], [TelNum], [StartDateTime], [EndDateTime]) VALUES ('004', '400400400', CAST(0x00009D9A00FB9898 AS DateTime), CAST(0x00009D9A00FE6118 AS DateTime));

/**/
select * from dbo.CallRecords
----��ѯͨ��ʱ�����5����¼
--select top 5 Id,CallerNumber,datediff(second,startdatetime,enddatetime) as dutime
--from CallRecords
--order by  dutime desc

----��ѯ��0��ͷ��ͨ����ʱ,����Ϊ���㵥λ

--select 
--	sum(datediff(second,startdatetime,enddatetime))
--from CallRecords
--where TelNum like '0%'


----��ѯ2010��7��ͨ����ʱ������ǰ��������Ա�ı��

--select
--	 top 2
--	 CallerNumber,
--	 sum(datediff(second,startdatetime,enddatetime)) as ʱ��,
--	 count(*) as �绰��
--from 
--	CallRecords
--where
--	 datediff(month,'2010-7-1',startdatetime)=0
--group by
--	 CallerNumber 
--order by ʱ�� desc

----��ѯ2010��7�²���绰��������ǰ��������Ա�ı��









