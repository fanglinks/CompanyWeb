USE [bjhksj]
GO

------------------------------创建数据库实现------------------

CREATE TABLE [dbo].[HKSJ_Services](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[Context] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

go

insert into HKSJ_Services values('第九组','<p>北京华科世佳软件开发有限公司地处国家计算机应用软件研发腹地——北京市
海淀区上地信息产业基地，具有明显的人才优势、技术优势和环境优势。我公司在2004年12月通过了
北京市科委的软件企业认证和北京市软件行业协会软件产品的认定。</p>
<p>北京华科世佳软件开发有限公司自成立以来，一直致力于房地产业管理类软件的研发，公司始终以为客户创造一
流产品为目标，锻造品质、精益求精、力臻完美。从产品的研发到售后服务，</p>
<p>我们始终站在用户的角度去考虑问题，逐步形成了华科软件“简洁易用”的鲜明特点，深受广大用户的欢迎。</p>
<p>我公司与房地产事业有着深厚的情结，公司内的数位专家均有多年从事房地产权属管理、金融管理、
房地产测绘的实际工作经验，对房管工作的要求、流程十分熟悉，为公司产品的适用性、易用性、及功能的全面性提供了保障。</p>')
 
 --------------Main表分页的详细分页-------------------
 create proc [dbo].[p_GetPageMain]
(
@pageIndex int,  --当前请求的页码
@pageSize int,    --一页的数量
@totalCount int output --输出多少条数据
)
as
--动态拼接SQL语句
declare @sql nvarchar(2000)
set @sql='select top '+CAST(@pageSize as nvarchar(16))+' * from HKSJ_Main where ID	not in
(
	select top '+CAST((@pageIndex-1)*@pageSize as nvarchar(20))+' ID  from HKSJ_Main order by ID
)
 order by ID';
 exec (@sql)
 select @totalCount=count(0) from HKSJ_Main


 --------------RelationShip表分页存储过程--------
create proc [dbo].[p_GetPageRelationShip]
(
@pageIndex int,  --当前请求的页码
@pageSize int,    --一页的数量
@totalCount int output --输出多少条数据
)
as
--动态拼接SQL语句
declare @sql nvarchar(2000)
set @sql='select top '+CAST(@pageSize as nvarchar(16))+' * from HKSJ_Relationship where ID	not in
(
	select top '+CAST((@pageIndex-1)*@pageSize as nvarchar(20))+' ID  from HKSJ_Relationship order by ID
)
 order by ID';
 exec (@sql)
 select @totalCount=count(0) from HKSJ_Relationship

 ---------------User表的分页存储过程------------

create proc [dbo].[p_GetPageUSERS]
(
@pageIndex int,  --当前请求的页码
@pageSize int,    --一页的数量
@totalCount int output --输出多少条数据
)
as
--动态拼接SQL语句
declare @sql nvarchar(2000)
set @sql='select top '+CAST(@pageSize as nvarchar(16))+' * from HKSJ_USERS where ID	not in
(
	select top '+CAST((@pageIndex-1)*@pageSize as nvarchar(20))+' ID  from HKSJ_USERS order by ID
)
 order by ID';
 exec (@sql)
 select @totalCount=count(0) from HKSJ_USERS