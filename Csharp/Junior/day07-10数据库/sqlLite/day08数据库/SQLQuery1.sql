--create database SqlDemos
--bgo
--use sqldemos
--go

---创建表，给列赋默认值
--create table UserInfo
--(
--	Id  int identity(1,1) primary key not null,
--	Name nvarchar(32) default('sss') null
--)

---给数据库的表添加一列
--alter table 表名 add  列名  类型  null
--alter table UserInfo add [Address] nvarchar(32) null

--alter table UserInfo add DelFlag smallint null

--数据接库的表删除一个列
--alter table UserInfo drop constraint DF_UserInfo_DelFlag
--go
--alter table UserInfo drop column DelFlag
--go

--修改一个列
--alter table UserInfo alter Column [Address] nvarchar(64) null

--代码的方式：给列添加默认值约束
--alter table 表名  add constraint 约束的名字  default(0) for DelFlag
--alter table UserInfo add constraint DF_UserInfo_DelFlag default(0) for DelFlag

--添加数据
--insert into UserInfo([Address]) values(N'火星中关村2')
--select * from UserInfo

--create Table  Product
--(
--	ProId int identity(1,1) not null,
--	ProName nvarchar(32) null,
--	ProCreateOn DateTime default(getdate()) null
--)

--给表创建一个主键
--alter table Product add constraint PK_Product_ProId primary key(ProId)

--给表创建一个唯一约束
--alter table product add constraint UQ_Product_ProName Unique(ProName)

--alter table Product drop constraint UQ_Product_ProName
--- Unique


--select getdate()

--alter table 表明 add/drop  constraint 约束名  Unique(列名)/Primary key(列）

--alter table Product add CountNumber int null
--要求  countnumber 必须在0  10000之间
--alter table Product add constraint CK_Product_CountNumber Check(CountNumber>0 and CountNumber<10000)


----订单表：一个订单中可以包含多个商品
--create table OrderInfo
--(
--	OrderId int identity(1,1) primary key not null,
--	OrderInfoDes nvarchar(64) null,
--	DelFlag smallint default(0)  null
--)
--go
----分类表 和商品：  一个产品只能属于一个分类，一个分类可以包含多个商品。
--Create table Category
--(
--	CatId int identity primary key not null,
--	CatName nvarchar(32) null,
--	ParentCatId int null,
--	DelFlag smallint default(0) null
--)
--go


--在商品表中添加  分类的外键列
--alter table Product add CategoryId int  null

--添加外键关系
--alter table SqlDemos.dbo.Product add constraint FK_Product_Category foreign key(CategoryId)
--references Category(CatId)


--select p.*,p.ProCreateOn,proName as 产品名 from Product as p

--Select 查询
--select 1000*0.1+10+2009 as 钱啊--别名可在列的加 as 别名   

--select 钱啊=123*1333

--select 1000*0.1+10+2009 钱啊

--select 'sss',*  from Product 

--select count(*) from Product
--count(*) ：找表中最短的列进行统计行数数
--count(1) count(2) count('ss') 对常数列进行统计行数

--select getdate()

--select @@VERSION
--select @@CPU_BUSY
--select @@ERROR


--聚合函数
 --use AdventureWorksLT2008
 --go

 --select * from SalesLT.Customer
 --use ItcastDb

 --select * from tblScore

 --select avg(score1) as 成绩1,avg(score2) as 成绩2 from tblScore

 --select sum(score1) as 成绩1,sum(score2) as 成绩2 from tblScore
 --select max(score1),min(score1) from tblScore

 --select * from tblScore order by score1 desc,score2 desc
 --把成绩1 前三名的数据查询出来
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
--distinct只能紧跟这select后面，而且是对后面的所有的列都进行去重复操作
--select distinct  title,MiddleName from [SalesLT].[Customer]
--	order by Title,MiddleName

--select * from SalesLT.Customer
--	where 
--	CustomerID<100 and Title<>'Ms.' or MiddleName='N.'

--select * from SalesLT.Customer 
--	--where CustomerID>20 and CustomerID<50
--	where CustomerID between 20 and 50

--要求：把所有 FirstName中 以 Jac开头的 数据都查询出来。
--select * from SalesLT.Customer 
	--where FirstName like 'Jac%'
	--where CompanyName like '%''%'--两个单引号表示一个单引号
	--where CompanyName like '%[0-9]%'
	--where CompanyName like '%[[]%' --escape '\'

--查询为middlename 是null的数据
--select * from SalesLT.Customer  where MiddleName is not null


---------------------下午-----------------------------------
--select * from SalesLT.Customer
--use [AdventureWorksLT2008]
--select   --第五步：此时只能把分组的信息给查询出来。
--	Title,
--	MiddleName,
--	count(*) as 个数,
--	sum(customerId) 
--  from --第一步：找到表
--	SalesLT.Customer
--  where  --第二步：对原始表数据进行过滤
--	MiddleName is not null
--  group by   --第三步：对这个表分组
--	Title,MiddleName
--  having 
--	count(*) >10  --第四步：对分组后的数据进行过滤
--  order by 
--	count(*) asc --最后一步

	--只要用了GroupBy   select后面只能跟 group by后面的字段或者是聚合函数。



----------类型转换---------------
--select * from SalesLT.Customer

--select CustomerId+Title from SalesLT.Customer

--类型转换
	-->  Convert(目标类型，转换的表达式，格式规范)
	-->  Cast（表达 as 类型）

--select Convert(nvarchar(32), CustomerId)+Title from SalesLT.Customer

--select cast(CustomerId as nvarchar(32))+Title from SalesLT.Customer

--use [ItcastDB]

--select * from  [dbo].[tblStudent]
----快速创建表的方式。  
--select * into tblStudent2 from tblStudent
--where stuid>5

--select * from  [dbo].[tblStudent2]

-- 把[tblStudent2]和 [tblStudent] 两个表的数据联合起来
--select stuId, stuName, stuSex, stuBirthdate, stuPhone
-- from dbo.tblStudent
-- union all
-- --union  会进行去重操作，效率非常低。
-- select stuId, stuName, stuSex, stuBirthdate, stuPhone
-- from dbo.tblStudent2

--select * from tblStudent2

--set Identity_Insert tblStudent2 on
--go
--insert into tblStudent2(stuId,stuName) values(112,'sss')

----批量向一个已经存在的表中添加  数据
--insert into tblStudent2(stuId, stuName, stuSex, stuBirthdate, stuPhone) select stuId, stuName, stuSex, stuBirthdate, stuPhone from tblStudent where stuid<5
--go
--set Identity_Insert tblStudent2 off

-----------日期函数---------------------
--获取当前日期
--select getdate()
--dateadd(单位，个数，日期)
--select DATEADD(day,1,'2015-3-1')

-----***************
--select DATEDIFF(MONTH,'2015-5-1','2015-5-9')

--select  datepart(MONTH,'2014-4-3')
--select year('2014-5-6')

------字符串函数

--select LOWER(stuName) from tblStudent

--select ASCII('a')

--select LEFT('123456',4)

--select Right('123456',4)

--select datalength(N'1234')
--select RTRIM('    123  ')

--use [SqlDemos]
-------表连接查询---
--select * from Product 

--select * from Category

--select P.*,C.* from Product as P
--join Category as C on P.CategoryId=C.CatId


--把所有的订单查询出来，然后要求把用户的信息显示,而且要把商品的信息也显示
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




-----------最后的练习
--CREATE TABLE [CallRecords]
--(
--	[Id] [int] NOT NULL identity(1,1),
--	[CallerNumber] [nvarchar](50), --三位数字，呼叫中心员工编号（工号）
--	[TelNum] [varchar](50),
--	[StartDateTime] [datetime] NULL,
--	[EndDateTime] [datetime] NULL  --结束时间要大于开始时间,默认当前时间
--)

----主键约束
--alter table [CallRecords]
--add constraint PK_CallRecords primary key(id)

----检查约束
--alter table [CallRecords]
--add constraint CK_CallRecords check(CallerNumber like '[0-9][0-9][0-9]')   

--alter table [CallRecords]
--add constraint CK_CallRecords_EndDateTime check(EndDateTime > StartDateTime)

----默认约束
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
----查询通话时间最长的5条记录
--select top 5 Id,CallerNumber,datediff(second,startdatetime,enddatetime) as dutime
--from CallRecords
--order by  dutime desc

----查询以0开头的通话总时,以秒为计算单位

--select 
--	sum(datediff(second,startdatetime,enddatetime))
--from CallRecords
--where TelNum like '0%'


----查询2010年7月通话总时长最多的前两个呼叫员的编号

--select
--	 top 2
--	 CallerNumber,
--	 sum(datediff(second,startdatetime,enddatetime)) as 时长,
--	 count(*) as 电话数
--from 
--	CallRecords
--where
--	 datediff(month,'2010-7-1',startdatetime)=0
--group by
--	 CallerNumber 
--order by 时长 desc

----查询2010年7月拨打电话次数最多的前两个呼叫员的编号









