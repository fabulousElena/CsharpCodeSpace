--取数据类型的长度
select DATALENGTH (birthday) from [dbo].[UserInfo]

--字符长度
select len (birthday) from [dbo].[UserInfo]

--创建一个guid
select NEWID()