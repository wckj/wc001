if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pro_Bill]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[pro_Bill]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pro_videoconfig]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[pro_videoconfig]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_L_Modify]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_L_Modify]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_Bill]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_Bill]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_C_Alias]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_C_Alias]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_C_Bill]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_C_Bill]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_C_Select]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_C_Select]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_C_Stat]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_C_Stat]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_C_StatSelect]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_C_StatSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_C_Weight]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_C_Weight]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_DC_Base]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_DC_Base]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_DC_Plan]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_DC_Plan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_DC_Power]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_DC_Power]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_DC_RolePower]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_DC_RolePower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_DL_Maintenance]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_DL_Maintenance]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_DL_Run]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_DL_Run]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_DL_Weight]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_DL_Weight]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_D_Card_Temp]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_D_Card_Temp]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_D_Cubety]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_D_Cubety]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_D_Saver]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_D_Saver]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_D_Saver_D]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_D_Saver_D]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_D_Saver_Temp]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_D_Saver_Temp]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_D_User]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_D_User]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_D_UserRole]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_D_UserRole]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[V_D_Base]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[V_D_Base]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[C_ASAlias]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[C_ASAlias]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[C_Alias]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[C_Alias]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[C_Bill]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[C_Bill]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[C_Function]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[C_Function]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[C_Select]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[C_Select]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[C_Stat]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[C_Stat]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[C_StatSelect]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[C_StatSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[C_WeiWay]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[C_WeiWay]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[C_Weight]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[C_Weight]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DC_Base]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DC_Base]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DC_BaseInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DC_BaseInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DC_LoadoMeter]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DC_LoadoMeter]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DC_Power]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DC_Power]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DC_RolePower]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DC_RolePower]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DC_Unit]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DC_Unit]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DL_Maintenance]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DL_Maintenance]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DL_Run]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DL_Run]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DL_Weight]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DL_Weight]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_Base]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_Base]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_Bill]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_Bill]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_CarCode]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_CarCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_Card]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_Card]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_CountWay]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_CountWay]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_Cubety]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_Cubety]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_Plan]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_Plan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_Plan_Add]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_Plan_Add]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_Saver]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_Saver]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_Saver_Image]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_Saver_Image]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_SelectProject]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_SelectProject]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_StatProject]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_StatProject]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_StatProjectItem]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_StatProjectItem]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_Type]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_Type]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_User]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_User]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_UserRole]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_UserRole]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[D_Video]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[D_Video]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LC_Main]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LC_Main]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[L_Modify]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[L_Modify]
GO

CREATE TABLE [dbo].[C_ASAlias] (
	[ID] [int] NULL ,
	[AS] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[C_Alias] (
	[ID] [bigint] NOT NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[RuleName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[DBName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[DataType] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[State] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[C_Bill] (
	[ID] [int] NOT NULL ,
	[AS] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[C_Function] (
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Fun] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[C_Select] (
	[ID] [bigint] NOT NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[AS] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Place] [int] NULL ,
	[Show] [bit] NOT NULL ,
	[Wight] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Align] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Print] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[C_Stat] (
	[ID] [bigint] NOT NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[AS] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Show] [bit] NOT NULL ,
	[Place] [int] NULL ,
	[Wight] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Align] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Print] [bit] NOT NULL ,
	[DataType] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Fun] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[C_StatSelect] (
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[AS] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Place] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[C_WeiWay] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[C_Weight] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[AS] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Save] [bit] NOT NULL ,
	[Show] [bit] NOT NULL ,
	[Time] [int] NULL ,
	[X] [int] NULL ,
	[Y] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DC_Base] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[AS] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Flag] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Rank] [decimal](10, 3) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DC_BaseInfo] (
	[Id] [int] NULL ,
	[Company] [varchar] (255) COLLATE Chinese_PRC_CI_AS NULL ,
	[Address] [varchar] (255) COLLATE Chinese_PRC_CI_AS NULL ,
	[Tel] [varchar] (255) COLLATE Chinese_PRC_CI_AS NULL ,
	[PrintTitle] [varchar] (255) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DC_LoadoMeter] (
	[Id] [bigint] NULL ,
	[TableNum] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Ip] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Port] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Remark] [varchar] (255) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DC_Power] (
	[ID] [bigint] NOT NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[ParentCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[RuleName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Rank] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DC_RolePower] (
	[RoleCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[PowerCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DC_Unit] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[EName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Way] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[ParentCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Rank] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DL_Maintenance] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[SaverCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[WorkCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[DT] [datetime] NULL ,
	[OperCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[TableNum] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DL_Run] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Work] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[InTime] [datetime] NULL ,
	[OutTime] [datetime] NULL ,
	[OperCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[TableNum] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DL_Weight] (
	[ID] [bigint] NOT NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Weight] [int] NULL ,
	[Datetime] [datetime] NULL ,
	[OperCode] [int] NULL ,
	[TableCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[IP] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Image1] [image] NULL ,
	[Image2] [image] NULL ,
	[Image3] [image] NULL ,
	[Image4] [image] NULL ,
	[Curve] [image] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_Base] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[CodeID] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Rem] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[ParentCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Rank] [decimal](10, 3) NULL ,
	[Used] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_Bill] (
	[Id] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[BillName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[PrintTitle] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Preview] [bit] NULL ,
	[PrintMend] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_CarCode] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[CarCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Tare] [decimal](18, 2) NULL ,
	[Driver] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Used] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_Card] (
	[ID] [bigint] NOT NULL ,
	[Card] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Type] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Item] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Specs] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Place] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[CarCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[Tare] [decimal](18, 2) NOT NULL ,
	[Send] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Accept] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Carry] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Model] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Driver] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Spare] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[State] [bit] NOT NULL ,
	[Plan_Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[CardType] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_CountWay] (
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_Cubety] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Cubety] [decimal](18, 3) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_Plan] (
	[ID] [bigint] NOT NULL ,
	[Plan_Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Plan_Type] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Plan_Item] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Plan_Specs] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Plan_Send] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Plan_Accept] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Plan_Num] [decimal](18, 2) NULL ,
	[Plan_SpareNum] [decimal](18, 2) NULL ,
	[Plan_Money] [decimal](18, 2) NULL ,
	[Plan_SpareMoney] [decimal](18, 2) NULL ,
	[Begin_Time] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[End_Time] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Remark] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Plan_CountWay] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Plan_Used] [bit] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_Plan_Add] (
	[Plan_Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Add_Count] [decimal](18, 3) NULL ,
	[Add_Time] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_Saver] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[CarCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Item] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Specs] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Place] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Send] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Accept] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Carry] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Model] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Driver] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Spare] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Gross] [decimal](18, 2) NULL ,
	[Tare] [decimal](18, 2) NULL ,
	[Net] [decimal](18, 2) NULL ,
	[EndNet] [decimal](18, 2) NULL ,
	[Impurity] [decimal](18, 2) NULL ,
	[ImpurityRate] [decimal](18, 2) NULL ,
	[DeductWei] [decimal](18, 2) NULL ,
	[DeductRate] [decimal](18, 2) NULL ,
	[Cube] [decimal](18, 2) NULL ,
	[InhereWei] [decimal](18, 2) NULL ,
	[DifferWei] [decimal](18, 2) NULL ,
	[Price] [decimal](18, 2) NULL ,
	[Money] [decimal](18, 2) NULL ,
	[Type] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[CardCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Card] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[G_Oper] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[T_Oper] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[G_Table] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[T_Table] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[G_Time] [datetime] NULL ,
	[T_Time] [datetime] NULL ,
	[N_Time] [datetime] NULL ,
	[WeiWay] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Used] [bit] NOT NULL ,
	[Verify] [bit] NOT NULL ,
	[Print] [bigint] NULL ,
	[State] [bit] NOT NULL ,
	[Plan_Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Updata_Time] [datetime] NULL ,
	[Updata_Oper] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Cubety] [decimal](18, 3) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_Saver_Image] (
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[G_Image1] [image] NULL ,
	[G_Image2] [image] NULL ,
	[G_Image3] [image] NULL ,
	[G_Image4] [image] NULL ,
	[T_Image1] [image] NULL ,
	[T_Image2] [image] NULL ,
	[T_Image3] [image] NULL ,
	[T_Image4] [image] NULL ,
	[G_Curve] [image] NULL ,
	[T_Curve] [image] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_SelectProject] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Type] [int] NULL ,
	[State] [int] NULL ,
	[Verify] [int] NULL ,
	[Used] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_StatProject] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Type] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Flag] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Month] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Day] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[BeginTime] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[EndTime] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[SataType] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_StatProjectItem] (
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[StatCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Place] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_Type] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Flag] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_User] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Uid] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Role] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Pwd] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Used] [bit] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_UserRole] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[ParentCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Rank] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[D_Video] (
	[VIDEO_name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[VIDEO_table] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[VIDEO_Standard] [int] NULL ,
	[VIDEO_Source] [int] NULL ,
	[VIDEO_Brightness] [int] NULL ,
	[VIDEO_Contrast] [int] NULL ,
	[VIDEO_Hue] [int] NULL ,
	[VIDEO_Saturation] [int] NULL ,
	[VIDEO_Suality] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[LC_Main] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Name] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[L_Modify] (
	[ID] [bigint] NULL ,
	[Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[CarCode] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Item] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Specs] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Place] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Send] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Accept] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Carry] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Model] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Driver] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Spare] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[G_Oper] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[T_Oper] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Gross] [decimal](10, 2) NULL ,
	[Tare] [decimal](10, 2) NULL ,
	[Net] [decimal](18, 2) NULL ,
	[EndNet] [decimal](10, 2) NULL ,
	[Impurity] [decimal](10, 2) NULL ,
	[ImpurityRate] [decimal](10, 2) NULL ,
	[DeductWei] [decimal](10, 2) NULL ,
	[DeductRate] [decimal](10, 2) NULL ,
	[Cube] [decimal](10, 2) NULL ,
	[InhereWei] [decimal](10, 2) NULL ,
	[DifferWei] [decimal](10, 2) NULL ,
	[Price] [decimal](10, 2) NULL ,
	[Money] [decimal](10, 2) NULL ,
	[Type] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Card] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[G_Table] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[T_Table] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Plan_Code] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[Used] [bit] NULL ,
	[Cubety] [decimal](18, 3) NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[C_ASAlias] ADD 
	CONSTRAINT [DF_C_ASAlias_ID] DEFAULT (0) FOR [ID]
GO

ALTER TABLE [dbo].[C_Alias] ADD 
	CONSTRAINT [DF_C_Alias_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_C_Alias_State] DEFAULT (0) FOR [State]
GO

ALTER TABLE [dbo].[C_Bill] ADD 
	CONSTRAINT [DF_C_Bill_ID] DEFAULT (0) FOR [ID]
GO

ALTER TABLE [dbo].[C_Select] ADD 
	CONSTRAINT [DF_C_Select_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_C_Select_Place] DEFAULT (0) FOR [Place],
	CONSTRAINT [DF_C_Select_Show] DEFAULT (0) FOR [Show],
	CONSTRAINT [DF_C_Select_Print] DEFAULT (0) FOR [Print]
GO

ALTER TABLE [dbo].[C_Stat] ADD 
	CONSTRAINT [DF_C_Stat_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_C_Stat_Show] DEFAULT (0) FOR [Show],
	CONSTRAINT [DF_C_Stat_Place] DEFAULT (0) FOR [Place],
	CONSTRAINT [DF_C_Stat_Print] DEFAULT (0) FOR [Print]
GO

ALTER TABLE [dbo].[C_StatSelect] ADD 
	CONSTRAINT [DF_C_StatSelect_Place] DEFAULT (0) FOR [Place]
GO

ALTER TABLE [dbo].[C_WeiWay] ADD 
	CONSTRAINT [DF_C_WeiWay_ID] DEFAULT (0) FOR [ID]
GO

ALTER TABLE [dbo].[C_Weight] ADD 
	CONSTRAINT [DF_C_Weight_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_C_Weight_Save] DEFAULT (0) FOR [Save],
	CONSTRAINT [DF_C_Weight_Show] DEFAULT (0) FOR [Show],
	CONSTRAINT [DF_C_Weight_Time] DEFAULT (0) FOR [Time],
	CONSTRAINT [DF_C_Weight_X] DEFAULT (0) FOR [X],
	CONSTRAINT [DF_C_Weight_Y] DEFAULT (0) FOR [Y]
GO

ALTER TABLE [dbo].[DC_Base] ADD 
	CONSTRAINT [DF_DC_Base_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_DC_Base_Rank] DEFAULT (0) FOR [Rank]
GO

ALTER TABLE [dbo].[DC_BaseInfo] ADD 
	CONSTRAINT [DF_DC_BaseInfo_Id] DEFAULT (0) FOR [Id]
GO

ALTER TABLE [dbo].[DC_LoadoMeter] ADD 
	CONSTRAINT [DF_DC_LoadoMeter_Id] DEFAULT (0) FOR [Id]
GO

ALTER TABLE [dbo].[DC_Power] ADD 
	CONSTRAINT [DF_DC_Power_ID] DEFAULT (0) FOR [ID]
GO

ALTER TABLE [dbo].[DC_Unit] ADD 
	CONSTRAINT [DF_DC_Unit_ID] DEFAULT (0) FOR [ID]
GO

ALTER TABLE [dbo].[DL_Maintenance] ADD 
	CONSTRAINT [DF_DL_Maintenance_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_DL_Maintenance_DT] DEFAULT (getdate()) FOR [DT]
GO

ALTER TABLE [dbo].[DL_Run] ADD 
	CONSTRAINT [DF_DL_Run_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_DL_Run_InTime] DEFAULT (getdate()) FOR [InTime],
	CONSTRAINT [DF_DL_Run_OutTime] DEFAULT (getdate()) FOR [OutTime]
GO

ALTER TABLE [dbo].[DL_Weight] ADD 
	CONSTRAINT [DF_DL_Weight_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_DL_Weight_Weight] DEFAULT (0) FOR [Weight],
	CONSTRAINT [DF_DL_Weight_Datetime] DEFAULT (getdate()) FOR [Datetime],
	CONSTRAINT [DF_DL_Weight_OperCode] DEFAULT (0) FOR [OperCode]
GO

ALTER TABLE [dbo].[D_Base] ADD 
	CONSTRAINT [DF_D_Base_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_D_Base_Rank] DEFAULT (0) FOR [Rank],
	CONSTRAINT [DF_D_Base_Used] DEFAULT (1) FOR [Used]
GO

ALTER TABLE [dbo].[D_CarCode] ADD 
	CONSTRAINT [DF_D_CarCode_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_D_CarCode_Tare] DEFAULT (0) FOR [Tare],
	CONSTRAINT [DF_D_CarCode_Used] DEFAULT (1) FOR [Used]
GO

ALTER TABLE [dbo].[D_Card] ADD 
	CONSTRAINT [DF_D_Card_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_D_Card_Tare] DEFAULT (0) FOR [Tare],
	CONSTRAINT [DF_D_Card_State] DEFAULT (0) FOR [State]
GO

ALTER TABLE [dbo].[D_Cubety] ADD 
	CONSTRAINT [DF_D_Cubety_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_D_Cubety_Cubety] DEFAULT (0) FOR [Cubety]
GO

ALTER TABLE [dbo].[D_Plan] ADD 
	CONSTRAINT [DF_D_Plan_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_D_Plan_Plan_Num] DEFAULT (0) FOR [Plan_Num],
	CONSTRAINT [DF_D_Plan_Plan_SpareNum] DEFAULT (0) FOR [Plan_SpareNum],
	CONSTRAINT [DF_D_Plan_Plan_Money] DEFAULT (0) FOR [Plan_Money],
	CONSTRAINT [DF_D_Plan_Plan_SpareMoney] DEFAULT (0) FOR [Plan_SpareMoney],
	CONSTRAINT [DF_D_Plan_Plan_Used] DEFAULT (0) FOR [Plan_Used]
GO

ALTER TABLE [dbo].[D_Plan_Add] ADD 
	CONSTRAINT [DF_D_Plan_Add_Add_Time] DEFAULT (getdate()) FOR [Add_Time]
GO

ALTER TABLE [dbo].[D_Saver] ADD 
	CONSTRAINT [DF_D_Saver_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_D_Saver_Gross] DEFAULT (0) FOR [Gross],
	CONSTRAINT [DF_D_Saver_Tare] DEFAULT (0) FOR [Tare],
	CONSTRAINT [DF_D_Saver_Net] DEFAULT (0) FOR [Net],
	CONSTRAINT [DF_D_Saver_EndNet] DEFAULT (0) FOR [EndNet],
	CONSTRAINT [DF_D_Saver_Impurity] DEFAULT (0) FOR [Impurity],
	CONSTRAINT [DF_D_Saver_ImpurityRate] DEFAULT (0) FOR [ImpurityRate],
	CONSTRAINT [DF_D_Saver_DeductWei] DEFAULT (0) FOR [DeductWei],
	CONSTRAINT [DF_D_Saver_DeductRate] DEFAULT (0) FOR [DeductRate],
	CONSTRAINT [DF_D_Saver_Cube] DEFAULT (0) FOR [Cube],
	CONSTRAINT [DF_D_Saver_InhereWei] DEFAULT (0) FOR [InhereWei],
	CONSTRAINT [DF_D_Saver_DifferWei] DEFAULT (0) FOR [DifferWei],
	CONSTRAINT [DF_D_Saver_Price] DEFAULT (0) FOR [Price],
	CONSTRAINT [DF_D_Saver_Money] DEFAULT (0) FOR [Money],
	CONSTRAINT [DF_D_Saver_N_Time] DEFAULT (getdate()) FOR [N_Time],
	CONSTRAINT [DF_D_Saver_Used] DEFAULT (0) FOR [Used],
	CONSTRAINT [DF_D_Saver_Verify] DEFAULT (0) FOR [Verify],
	CONSTRAINT [DF_D_Saver_Print] DEFAULT (0) FOR [Print],
	CONSTRAINT [DF_D_Saver_State] DEFAULT (0) FOR [State],
	CONSTRAINT [DF_D_Saver_Cubety] DEFAULT (0) FOR [Cubety]
GO

ALTER TABLE [dbo].[D_SelectProject] ADD 
	CONSTRAINT [DF_D_SelectProject_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_D_SelectProject_Type] DEFAULT (0) FOR [Type],
	CONSTRAINT [DF_D_SelectProject_State] DEFAULT (0) FOR [State],
	CONSTRAINT [DF_D_SelectProject_Verify] DEFAULT (0) FOR [Verify],
	CONSTRAINT [DF_D_SelectProject_Used] DEFAULT (0) FOR [Used]
GO

ALTER TABLE [dbo].[D_StatProject] ADD 
	CONSTRAINT [DF_D_StatProject_ID] DEFAULT (0) FOR [ID]
GO

ALTER TABLE [dbo].[D_StatProjectItem] ADD 
	CONSTRAINT [DF_D_StatProjectItem_Place] DEFAULT (0) FOR [Place]
GO

ALTER TABLE [dbo].[D_Type] ADD 
	CONSTRAINT [DF_D_Type_ID] DEFAULT (0) FOR [ID]
GO

ALTER TABLE [dbo].[D_User] ADD 
	CONSTRAINT [DF_D_User_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_D_User_Used] DEFAULT (0) FOR [Used]
GO

ALTER TABLE [dbo].[D_UserRole] ADD 
	CONSTRAINT [DF_D_UserRole_ID] DEFAULT (0) FOR [ID]
GO

ALTER TABLE [dbo].[D_Video] ADD 
	CONSTRAINT [DF_D_Video_VIDEO_Standard] DEFAULT (0) FOR [VIDEO_Standard],
	CONSTRAINT [DF_D_Video_VIDEO_Source] DEFAULT (0) FOR [VIDEO_Source],
	CONSTRAINT [DF_D_Video_VIDEO_Brightness] DEFAULT (0) FOR [VIDEO_Brightness],
	CONSTRAINT [DF_D_Video_VIDEO_Contrast] DEFAULT (0) FOR [VIDEO_Contrast],
	CONSTRAINT [DF_D_Video_VIDEO_Hue] DEFAULT (0) FOR [VIDEO_Hue],
	CONSTRAINT [DF_D_Video_VIDEO_Saturation] DEFAULT (0) FOR [VIDEO_Saturation],
	CONSTRAINT [DF_D_Video_VIDEO_Suality] DEFAULT (0) FOR [VIDEO_Suality]
GO

ALTER TABLE [dbo].[LC_Main] ADD 
	CONSTRAINT [DF_LC_Main_ID] DEFAULT (0) FOR [ID]
GO

ALTER TABLE [dbo].[L_Modify] ADD 
	CONSTRAINT [DF_L_Modify_ID] DEFAULT (0) FOR [ID],
	CONSTRAINT [DF_L_Modify_Gross] DEFAULT (0) FOR [Gross],
	CONSTRAINT [DF_L_Modify_Tare] DEFAULT (0) FOR [Tare],
	CONSTRAINT [DF_L_Modify_Net] DEFAULT (0) FOR [Net],
	CONSTRAINT [DF_L_Modify_EndNet] DEFAULT (0) FOR [EndNet],
	CONSTRAINT [DF_L_Modify_Impurity] DEFAULT (0) FOR [Impurity],
	CONSTRAINT [DF_L_Modify_ImpurityRate] DEFAULT (0) FOR [ImpurityRate],
	CONSTRAINT [DF_L_Modify_DeductWei] DEFAULT (0) FOR [DeductWei],
	CONSTRAINT [DF_L_Modify_DeductRate] DEFAULT (0) FOR [DeductRate],
	CONSTRAINT [DF_L_Modify_Cube] DEFAULT (0) FOR [Cube],
	CONSTRAINT [DF_L_Modify_InhereWei] DEFAULT (0) FOR [InhereWei],
	CONSTRAINT [DF_L_Modify_DifferWei] DEFAULT (0) FOR [DifferWei],
	CONSTRAINT [DF_L_Modify_Price] DEFAULT (0) FOR [Price],
	CONSTRAINT [DF_L_Modify_Money] DEFAULT (0) FOR [Money],
	CONSTRAINT [DF_L_Modify_Used] DEFAULT (0) FOR [Used],
	CONSTRAINT [DF_L_Modify_Cubety] DEFAULT (0) FOR [Cubety]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.V_D_Base
AS
SELECT dbo.D_Base.ID, dbo.D_Base.Code, dbo.D_Base.Name, dbo.D_Base.Rem, 
      dbo.DC_Base.Flag, dbo.D_Base.Rank, dbo.D_Base.Used
FROM dbo.D_Base LEFT OUTER JOIN
      dbo.DC_Base ON dbo.D_Base.ParentCode = dbo.DC_Base.Code
WHERE (dbo.D_Base.Used = 1)

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_Bill   
AS   
SELECT A.Id, A.Code, A.BillName, A.PrintTitle, B.Name, A.Preview, A.PrintMend   
FROM dbo.D_Bill A INNER JOIN   
      dbo.D_Type B ON A.Code = B.Code   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
CREATE VIEW dbo.V_C_Alias  
AS  
SELECT TOP 100 PERCENT dbo.C_ASAlias.[AS] AS Code, dbo.C_Alias.Name,   
      dbo.C_Alias.RuleName, dbo.C_Alias.DBName, dbo.C_Alias.DataType,   
      dbo.C_Alias.State, dbo.C_Alias.ID  
FROM dbo.C_ASAlias LEFT OUTER JOIN  
      dbo.C_Alias ON dbo.C_ASAlias.[AS] = dbo.C_Alias.Code  
ORDER BY dbo.C_Alias.ID  
  
  

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_C_Bill   
AS   
SELECT TOP 100 PERCENT dbo.C_Bill.ID, dbo.C_Bill.[AS], dbo.C_Alias.Name,    
      dbo.C_Alias.RuleName, dbo.C_Alias.DBName   
FROM dbo.C_Bill LEFT OUTER JOIN   
      dbo.C_Alias ON dbo.C_Bill.[AS] = dbo.C_Alias.Code   
WHERE (dbo.C_Alias.State = 1)   
ORDER BY dbo.C_Bill.ID   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_C_Select   
AS   
SELECT dbo.C_Select.ID, dbo.C_Select.[AS], dbo.C_Alias.Name, dbo.C_Alias.RuleName,    
      dbo.C_Alias.DBName, dbo.C_Select.Place, dbo.C_Select.Show, dbo.C_Select.Wight,    
      dbo.C_Select.Align, dbo.C_Select.[Print], dbo.C_Alias.State   
FROM dbo.C_Select LEFT OUTER JOIN   
      dbo.C_Alias ON dbo.C_Select.[AS] = dbo.C_Alias.Code   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_C_Stat   
AS   
SELECT dbo.C_Stat.ID, dbo.C_Stat.[AS], dbo.C_Alias.Name, dbo.C_Alias.RuleName,    
      dbo.C_Alias.DBName, dbo.C_Alias.DataType, dbo.C_Stat.Place, dbo.C_Stat.Wight,    
      dbo.C_Stat.Align, dbo.C_Stat.[Print], dbo.C_Stat.Fun, dbo.C_Alias.State,    
      dbo.C_Stat.Show   
FROM dbo.C_Stat LEFT OUTER JOIN   
      dbo.C_Alias ON dbo.C_Stat.[AS] = dbo.C_Alias.Code   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_C_StatSelect   
AS   
SELECT dbo.C_StatSelect.Code, dbo.C_Alias.Name, dbo.C_Alias.RuleName,    
      dbo.C_Alias.DBName, dbo.C_Alias.DataType, dbo.C_StatSelect.Place   
FROM dbo.C_StatSelect LEFT OUTER JOIN   
      dbo.C_Alias ON dbo.C_StatSelect.[AS] = dbo.C_Alias.Code   
WHERE (dbo.C_Alias.State = 1)   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_C_Weight   
AS   
SELECT TOP 100 PERCENT dbo.C_Weight.ID, dbo.C_Weight.Code AS Code,    
      dbo.C_Alias.Code AS AsCode, dbo.C_Alias.Name, dbo.C_Alias.RuleName,    
      dbo.C_Alias.DBName, dbo.C_Alias.DataType, dbo.C_Weight.[Save],    
      dbo.C_Weight.Show, dbo.C_Weight.[Time], dbo.C_Weight.X, dbo.C_Weight.Y,    
      dbo.C_Alias.State   
FROM dbo.C_Weight LEFT OUTER JOIN   
      dbo.C_Alias ON dbo.C_Weight.[AS] = dbo.C_Alias.Code   
ORDER BY dbo.C_Weight.ID   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_DC_Base   
AS   
SELECT dbo.DC_Base.ID, dbo.DC_Base.Code, dbo.C_Alias.Name, dbo.DC_Base.Flag,    
      dbo.DC_Base.Rank   
FROM dbo.DC_Base LEFT OUTER JOIN   
      dbo.C_Alias ON dbo.DC_Base.[AS] = dbo.C_Alias.Code   
WHERE (dbo.C_Alias.State = 1)   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_DC_Plan   
AS   
SELECT Item.Name AS Plan_Item, Specs.Name AS Plan_Specs, Send.Name AS Plan_Send,    
      Accept.Name AS Plan_Accept, dbo.D_Type.Name AS Plan_Type, dbo.D_Plan.ID,    
      dbo.D_Plan.Plan_Code, dbo.D_Plan.Plan_Num, dbo.D_Plan.Plan_SpareNum,    
      dbo.D_Plan.Begin_Time, dbo.D_Plan.End_Time, dbo.D_Plan.Remark,    
      dbo.D_CountWay.Name AS Plan_CountWay, dbo.D_Plan.Plan_Money,    
      dbo.D_Plan.Plan_SpareMoney, dbo.D_Plan.Plan_Used   
FROM dbo.D_Plan LEFT OUTER JOIN   
      dbo.D_Base Item ON dbo.D_Plan.Plan_Item = Item.Code LEFT OUTER JOIN   
      dbo.D_Base Specs ON dbo.D_Plan.Plan_Specs = Specs.Code LEFT OUTER JOIN   
      dbo.D_Base Send ON dbo.D_Plan.Plan_Send = Send.Code LEFT OUTER JOIN   
      dbo.D_Base Accept ON dbo.D_Plan.Plan_Accept = Accept.Code LEFT OUTER JOIN   
      dbo.D_CountWay ON    
      dbo.D_Plan.Plan_CountWay = dbo.D_CountWay.Code LEFT OUTER JOIN   
      dbo.D_Type ON dbo.D_Plan.Plan_Type = dbo.D_Type.Code   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_DC_Power   
AS   
SELECT ID, Code, Name, ParentCode, RuleName   
FROM dbo.DC_Power A   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_DC_RolePower   
AS   
SELECT dbo.DC_RolePower.RoleCode, dbo.DC_RolePower.PowerCode,    
      dbo.DC_Power.RuleName   
FROM dbo.DC_RolePower LEFT OUTER JOIN   
      dbo.DC_Power ON dbo.DC_RolePower.PowerCode = dbo.DC_Power.Code   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_DL_Maintenance   
AS   
SELECT dbo.DL_Maintenance.ID, dbo.DL_Maintenance.Code,    
      dbo.DL_Maintenance.SaverCode, dbo.DL_Maintenance.WorkCode,    
      dbo.LC_Main.Name AS WorkName, dbo.DL_Maintenance.DT,    
      dbo.D_User.Name AS UserName, dbo.DC_LoadoMeter.Name   
FROM dbo.DL_Maintenance INNER JOIN   
      dbo.LC_Main ON dbo.DL_Maintenance.WorkCode = dbo.LC_Main.Code INNER JOIN   
      dbo.D_User ON dbo.DL_Maintenance.OperCode = dbo.D_User.Code INNER JOIN   
      dbo.DC_LoadoMeter ON    
      dbo.DL_Maintenance.TableNum = dbo.DC_LoadoMeter.TableNum   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_DL_Run   
AS   
SELECT dbo.DL_Run.ID, dbo.DL_Run.Code, dbo.DL_Run.[Work], dbo.DL_Run.InTime,    
      dbo.DL_Run.OutTime, dbo.D_User.Name, dbo.DL_Run.TableNum   
FROM dbo.DL_Run INNER JOIN   
      dbo.D_User ON dbo.DL_Run.OperCode = dbo.D_User.Code   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_DL_Weight   
AS   
SELECT dbo.DL_Weight.ID, dbo.DL_Weight.Code, dbo.DL_Weight.Weight,    
      dbo.DL_Weight.Datetime, dbo.D_User.Name, dbo.DL_Weight.TableCode,    
      dbo.DL_Weight.IP   
FROM dbo.DL_Weight LEFT OUTER JOIN   
      dbo.D_User ON dbo.DL_Weight.OperCode = dbo.D_User.ID   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.V_D_Card_Temp
AS
SELECT dbo.D_Card.ID, dbo.D_Card.Card, dbo.D_Type.Name AS Type, 
      dbo.D_Card.CarCode, dbo.D_Card.Tare, Item.Name AS Item, Specs.Name AS Specs, 
      Place.Name AS Place, Send.Name AS Send, Accept.Name AS Accept, 
      Carry.Name AS Carry, Model.Name AS Model, Driver.Name AS Driver, 
      Spare.Name AS Spare, dbo.D_Card.State, dbo.D_Card.CardType
FROM dbo.D_Card LEFT OUTER JOIN
      dbo.D_Base Item ON dbo.D_Card.Item = Item.Code LEFT OUTER JOIN
      dbo.D_Base Accept ON dbo.D_Card.Accept = Accept.Code LEFT OUTER JOIN
      dbo.D_Base Send ON dbo.D_Card.Send = Send.Code LEFT OUTER JOIN
      dbo.D_Base Carry ON dbo.D_Card.Carry = Carry.Code LEFT OUTER JOIN
      dbo.D_Base Driver ON dbo.D_Card.Driver = Driver.Code LEFT OUTER JOIN
      dbo.D_Base Model ON dbo.D_Card.Model = Model.Code LEFT OUTER JOIN
      dbo.D_Base Spare ON dbo.D_Card.Spare = Spare.Code LEFT OUTER JOIN
      dbo.D_Base Place ON dbo.D_Card.Place = Place.Code LEFT OUTER JOIN
      dbo.D_Base Specs ON dbo.D_Card.Specs = Specs.Code LEFT OUTER JOIN
      dbo.D_Type ON dbo.D_Card.Type = dbo.D_Type.Code

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.V_D_Cubety
AS
SELECT dbo.D_Cubety.ID, dbo.D_Base.Name AS Code, dbo.D_Cubety.Cubety
FROM dbo.D_Base INNER JOIN
      dbo.D_Cubety ON dbo.D_Base.Code = dbo.D_Cubety.Code

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.V_D_Saver
AS
SELECT Saver.ID, Saver.Code, Saver.CarCode, Item.Name AS Item, Specs.Name AS Specs, 
      Place.Name AS Place, Send.Name AS Send, Accept.Name AS Accept, 
      Carry.Name AS Carry, Model.Name AS Model, Driver.Name AS Driver, 
      Spare.Name AS Spare, Saver.Gross, Saver.Tare, Saver.Net, Saver.EndNet, 
      Saver.Impurity, Saver.ImpurityRate, Saver.DeductWei, Saver.DeductRate, 
      Saver.Cube, Saver.InhereWei, Saver.DifferWei, Saver.Price, Saver.Money, 
      dbo.D_Type.Name AS Type, Saver.Card, G_Oper.Name AS G_Oper, 
      T_Oper.Name AS T_Oper, Saver.G_Time, Saver.T_Time, Saver.N_Time, Saver.Used, 
      Saver.Verify, Saver.State, Saver.[Print], G_Table.Name AS G_Table, 
      T_Table.Name AS T_Table, dbo.C_WeiWay.Name AS WeiWay, Saver.Plan_Code, 
      Saver.Updata_Time, Updata_Oper.Name AS Updata_Oper, Saver.Cubety
FROM dbo.D_Saver Saver LEFT OUTER JOIN
      dbo.D_Base Item ON Saver.Item = Item.Code LEFT OUTER JOIN
      dbo.D_Base Specs ON Saver.Specs = Specs.Code LEFT OUTER JOIN
      dbo.D_Base Place ON Saver.Place = Place.Code LEFT OUTER JOIN
      dbo.D_Base Send ON Saver.Send = Send.Code LEFT OUTER JOIN
      dbo.D_Base Accept ON Saver.Accept = Accept.Code LEFT OUTER JOIN
      dbo.D_Base Carry ON Saver.Carry = Carry.Code LEFT OUTER JOIN
      dbo.D_Base Model ON Saver.Model = Model.Code LEFT OUTER JOIN
      dbo.D_Base Driver ON Saver.Driver = Driver.Code LEFT OUTER JOIN
      dbo.D_Base Spare ON Saver.Spare = Spare.Code LEFT OUTER JOIN
      dbo.D_Type ON Saver.Type = dbo.D_Type.Code LEFT OUTER JOIN
      dbo.D_User G_Oper ON Saver.G_Oper = G_Oper.Code LEFT OUTER JOIN
      dbo.D_User T_Oper ON Saver.T_Oper = T_Oper.Code LEFT OUTER JOIN
      dbo.D_User Updata_Oper ON 
      Saver.Updata_Oper = Updata_Oper.Code LEFT OUTER JOIN
      dbo.C_WeiWay ON Saver.WeiWay = dbo.C_WeiWay.Code LEFT OUTER JOIN
      dbo.DC_LoadoMeter G_Table ON 
      Saver.G_Table = G_Table.TableNum LEFT OUTER JOIN
      dbo.DC_LoadoMeter T_Table ON Saver.T_Table = T_Table.TableNum

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.V_D_Saver_D
AS
SELECT Saver.ID, Saver.Code, Saver.CarCode, Item.Name AS Item, Specs.Name AS Specs, 
      Place.Name AS Place, Send.Name AS Send, Accept.Name AS Accept, 
      Carry.Name AS Carry, Model.Name AS Model, Driver.Name AS Driver, 
      Spare.Name AS Spare, Saver.Gross, Saver.Tare, Saver.Net, Saver.EndNet, 
      Saver.Impurity, Saver.ImpurityRate, Saver.DeductWei, Saver.DeductRate, 
      Saver.Cube, Saver.InhereWei, Saver.DifferWei, Saver.Price, Saver.Money, 
      dbo.D_Type.Name AS Type, Saver.Card, G_Oper.Name AS G_Oper, 
      T_Oper.Name AS T_Oper, Saver.G_Time, Saver.T_Time, Saver.N_Time, Saver.Used, 
      Saver.Verify, Saver.State, Saver.[Print], Saver.G_Table, Saver.T_Table, 
      dbo.C_WeiWay.Name AS WeiWay, Saver.Plan_Code, Saver.Cubety
FROM dbo.D_Saver Saver LEFT OUTER JOIN
      dbo.D_Base Item ON Saver.Item = Item.Code LEFT OUTER JOIN
      dbo.D_Base Specs ON Saver.Specs = Specs.Code LEFT OUTER JOIN
      dbo.D_Base Place ON Saver.Place = Place.Code LEFT OUTER JOIN
      dbo.D_Base Send ON Saver.Send = Send.Code LEFT OUTER JOIN
      dbo.D_Base Accept ON Saver.Accept = Accept.Code LEFT OUTER JOIN
      dbo.D_Base Carry ON Saver.Carry = Carry.Code LEFT OUTER JOIN
      dbo.D_Base Model ON Saver.Model = Model.Code LEFT OUTER JOIN
      dbo.D_Base Driver ON Saver.Driver = Driver.Code LEFT OUTER JOIN
      dbo.D_Base Spare ON Saver.Spare = Spare.Code LEFT OUTER JOIN
      dbo.D_Type ON Saver.Type = dbo.D_Type.Code LEFT OUTER JOIN
      dbo.D_User G_Oper ON Saver.G_Oper = G_Oper.Code LEFT OUTER JOIN
      dbo.D_User T_Oper ON Saver.T_Oper = T_Oper.Code LEFT OUTER JOIN
      dbo.C_WeiWay ON Saver.WeiWay = dbo.C_WeiWay.Code

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.V_D_Saver_Temp
AS
SELECT Saver.ID, Saver.Code, Saver.CarCode, Item.Name AS Item, Specs.Name AS Specs, 
      Place.Name AS Place, Send.Name AS Send, Accept.Name AS Accept, 
      Carry.Name AS Carry, Model.Name AS Model, Driver.Name AS Driver, 
      Spare.Name AS Spare, Saver.Gross, Saver.Tare, dbo.D_Type.Name AS Type, 
      Saver.Card, G_Oper.Name AS G_Oper, T_Oper.Name AS T_Oper, Saver.G_Time, 
      Saver.T_Time, Saver.State, Saver.Plan_Code, Saver.Cube, Saver.InhereWei, 
      Saver.DifferWei, Saver.CardCode, Saver.Used, Saver.Cubety
FROM dbo.D_Saver Saver LEFT OUTER JOIN
      dbo.D_Base Item ON Saver.Item = Item.Code LEFT OUTER JOIN
      dbo.D_Base Specs ON Saver.Specs = Specs.Code LEFT OUTER JOIN
      dbo.D_Base Place ON Saver.Place = Place.Code LEFT OUTER JOIN
      dbo.D_Base Send ON Saver.Send = Send.Code LEFT OUTER JOIN
      dbo.D_Base Accept ON Saver.Accept = Accept.Code LEFT OUTER JOIN
      dbo.D_Base Carry ON Saver.Carry = Carry.Code LEFT OUTER JOIN
      dbo.D_Base Model ON Saver.Model = Model.Code LEFT OUTER JOIN
      dbo.D_Base Driver ON Saver.Driver = Driver.Code LEFT OUTER JOIN
      dbo.D_Base Spare ON Saver.Spare = Spare.Code LEFT OUTER JOIN
      dbo.D_Type ON Saver.Type = dbo.D_Type.Code LEFT OUTER JOIN
      dbo.D_User G_Oper ON Saver.G_Oper = G_Oper.Code LEFT OUTER JOIN
      dbo.D_User T_Oper ON Saver.T_Oper = T_Oper.Code
WHERE (Saver.State = 0) AND (Saver.Used = 0)

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_D_User   
AS   
SELECT A.ID, A.Code, A.Name, A.Uid, A.Pwd, A.Role, A.Used, B.Name AS RoleName   
FROM dbo.D_User A LEFT OUTER JOIN   
      dbo.D_UserRole B ON A.Role = B.Code   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

 
 
  
  
   
   
CREATE VIEW dbo.V_D_UserRole   
AS   
SELECT ID, Code, Name, ParentCode   
FROM dbo.D_UserRole A   

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.V_L_Modify
AS
SELECT dbo.V_DL_Maintenance.ID, dbo.V_DL_Maintenance.WorkCode, 
      dbo.V_DL_Maintenance.WorkName, dbo.V_DL_Maintenance.DT, 
      dbo.V_DL_Maintenance.UserName, Item.Name AS Item, Specs.Name AS Specs, 
      Place.Name AS Place, Send.Name AS Send, Accept.Name AS Accept, 
      Carry.Name AS Carry, Model.Name AS Model, Driver.Name AS Driver, 
      Spare.Name AS Spare, dbo.L_Modify.Gross, dbo.L_Modify.Net, 
      dbo.L_Modify.Impurity, dbo.L_Modify.Cube, dbo.L_Modify.Price, 
      dbo.L_Modify.Money, dbo.D_Type.Name AS Type, dbo.L_Modify.Tare, 
      dbo.L_Modify.EndNet, dbo.L_Modify.DeductWei, dbo.L_Modify.DeductRate, 
      dbo.L_Modify.InhereWei, dbo.L_Modify.DifferWei, dbo.L_Modify.Card, 
      dbo.L_Modify.ImpurityRate, G_Oper.Name AS G_Oper, T_Oper.Name AS T_Oper, 
      dbo.L_Modify.Code, dbo.L_Modify.CarCode, G_Table.Name AS G_Table, 
      T_Table.Name AS T_Table, dbo.V_DL_Maintenance.Name, dbo.L_Modify.Plan_Code, 
      dbo.L_Modify.Used, dbo.L_Modify.Cubety
FROM dbo.V_DL_Maintenance LEFT OUTER JOIN
      dbo.L_Modify ON dbo.V_DL_Maintenance.ID = dbo.L_Modify.ID LEFT OUTER JOIN
      dbo.D_Base Item ON dbo.L_Modify.Item = Item.Code LEFT OUTER JOIN
      dbo.D_Base Specs ON dbo.L_Modify.Specs = Specs.Code LEFT OUTER JOIN
      dbo.D_Base Place ON dbo.L_Modify.Place = Place.Code LEFT OUTER JOIN
      dbo.D_Base Send ON dbo.L_Modify.Send = Send.Code LEFT OUTER JOIN
      dbo.D_Base Accept ON dbo.L_Modify.Accept = Accept.Code LEFT OUTER JOIN
      dbo.D_Base Carry ON dbo.L_Modify.Carry = Carry.Code LEFT OUTER JOIN
      dbo.D_Base Model ON dbo.L_Modify.Model = Model.Code LEFT OUTER JOIN
      dbo.D_Base Driver ON dbo.L_Modify.Driver = Driver.Code LEFT OUTER JOIN
      dbo.D_Base Spare ON dbo.L_Modify.Spare = Spare.Code LEFT OUTER JOIN
      dbo.D_Type ON dbo.L_Modify.Type = dbo.D_Type.Code LEFT OUTER JOIN
      dbo.D_User G_Oper ON dbo.L_Modify.G_Oper = G_Oper.Code LEFT OUTER JOIN
      dbo.D_User T_Oper ON dbo.L_Modify.T_Oper = T_Oper.Code LEFT OUTER JOIN
      dbo.DC_LoadoMeter G_Table ON 
      dbo.L_Modify.G_Table = G_Table.TableNum LEFT OUTER JOIN
      dbo.DC_LoadoMeter T_Table ON dbo.L_Modify.T_Table = T_Table.TableNum

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

 
 
CREATE PROCEDURE pro_Bill 
@Code varchar(50) 
AS 
Declare @DBName varchar(20),@Name varchar(20),@Sql Varchar(8000) 
 
Declare tmpCur Cursor For Select DBName,[Name] From V_C_Bill  
Open tmpCur  
Fetch Next From tmpCur Into @DBName,@Name 
While @@Fetch_Status=0  
Begin  
	if @Sql is null 
	begin 
		set @Sql=','+@DBName+' as '+@Name 
	end 
	else 
	begin 
		set @Sql=@Sql+','+@DBName+' as '+@Name 
	end 
	--select @DBName,@Name 
	Fetch Next From tmpCur Into  @DBName,@Name 
End  
Close tmpCur  
DealLocate tmpCur  
if   CharIndex(',',@Sql)=1    
    set   @Sql=stuff(@Sql,1,1,'') 
select @Sql
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

 
 
CREATE PROCEDURE pro_videoconfig   
@VIDEOname char(10),@VIDEOtable varchar(50),@VIDEOStandard int,@VIDEOSource int,@VIDEOBrightness int,@VIDEOContrast int ,@VIDEOHue int, 
@VIDEOSaturation int, @VIDEOSuality int  
AS  
DECLARE @name char(10)  
select @name=video_name from D_video where video_name=@VIDEOname and video_table=@VIDEOtable  
if @name is null  
	insert into D_video (VIDEO_name,VIDEO_table,VIDEO_Standard,VIDEO_Source,VIDEO_Brightness,VIDEO_Contrast,VIDEO_Hue,VIDEO_Saturation,VIDEO_Suality) 
 	values(@VIDEOname,@VIDEOtable,@VIDEOStandard,@VIDEOSource,@VIDEOBrightness,@VIDEOContrast ,@VIDEOHue,@VIDEOSaturation,@VIDEOSuality) 
else 
 	update D_video set VIDEO_Standard=@VIDEOStandard,VIDEO_Source=@VIDEOSource,VIDEO_Brightness=@VIDEOBrightness,VIDEO_Contrast=@VIDEOContrast,  
	VIDEO_Hue=@VIDEOHue,VIDEO_Saturation=@VIDEOSaturation,VIDEO_Suality=@VIDEOSuality 
	where video_name=@VIDEOname and VIDEO_table=@VIDEOtable
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

