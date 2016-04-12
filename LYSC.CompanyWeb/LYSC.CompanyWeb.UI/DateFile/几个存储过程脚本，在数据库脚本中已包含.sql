USE [bjhksj]
GO

------------------------------�������ݿ�ʵ��------------------

CREATE TABLE [dbo].[HKSJ_Services](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[Context] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

go

insert into HKSJ_Services values('�ھ���','<p>����������������������޹�˾�ش����Ҽ����Ӧ������з����ء���������
�������ϵ���Ϣ��ҵ���أ��������Ե��˲����ơ��������ƺͻ������ơ��ҹ�˾��2004��12��ͨ����
�����п�ί�������ҵ��֤�ͱ����������ҵЭ�������Ʒ���϶���</p>
<p>����������������������޹�˾�Գ���������һֱ�����ڷ��ز�ҵ������������з�����˾ʼ����Ϊ�ͻ�����һ
����ƷΪĿ�꣬����Ʒ�ʡ������󾫡������������Ӳ�Ʒ���з����ۺ����</p>
<p>����ʼ��վ���û��ĽǶ�ȥ�������⣬���γ��˻��������������á��������ص㣬���ܹ���û��Ļ�ӭ��</p>
<p>�ҹ�˾�뷿�ز���ҵ����������ᣬ��˾�ڵ���λר�Ҿ��ж�����·��ز�Ȩ���������ڹ���
���ز�����ʵ�ʹ������飬�Է��ܹ�����Ҫ������ʮ����Ϥ��Ϊ��˾��Ʒ�������ԡ������ԡ������ܵ�ȫ�����ṩ�˱��ϡ�</p>')
 
 --------------Main���ҳ����ϸ��ҳ-------------------
 create proc [dbo].[p_GetPageMain]
(
@pageIndex int,  --��ǰ�����ҳ��
@pageSize int,    --һҳ������
@totalCount int output --�������������
)
as
--��̬ƴ��SQL���
declare @sql nvarchar(2000)
set @sql='select top '+CAST(@pageSize as nvarchar(16))+' * from HKSJ_Main where ID	not in
(
	select top '+CAST((@pageIndex-1)*@pageSize as nvarchar(20))+' ID  from HKSJ_Main order by ID
)
 order by ID';
 exec (@sql)
 select @totalCount=count(0) from HKSJ_Main


 --------------RelationShip���ҳ�洢����--------
create proc [dbo].[p_GetPageRelationShip]
(
@pageIndex int,  --��ǰ�����ҳ��
@pageSize int,    --һҳ������
@totalCount int output --�������������
)
as
--��̬ƴ��SQL���
declare @sql nvarchar(2000)
set @sql='select top '+CAST(@pageSize as nvarchar(16))+' * from HKSJ_Relationship where ID	not in
(
	select top '+CAST((@pageIndex-1)*@pageSize as nvarchar(20))+' ID  from HKSJ_Relationship order by ID
)
 order by ID';
 exec (@sql)
 select @totalCount=count(0) from HKSJ_Relationship

 ---------------User��ķ�ҳ�洢����------------

create proc [dbo].[p_GetPageUSERS]
(
@pageIndex int,  --��ǰ�����ҳ��
@pageSize int,    --һҳ������
@totalCount int output --�������������
)
as
--��̬ƴ��SQL���
declare @sql nvarchar(2000)
set @sql='select top '+CAST(@pageSize as nvarchar(16))+' * from HKSJ_USERS where ID	not in
(
	select top '+CAST((@pageIndex-1)*@pageSize as nvarchar(20))+' ID  from HKSJ_USERS order by ID
)
 order by ID';
 exec (@sql)
 select @totalCount=count(0) from HKSJ_USERS