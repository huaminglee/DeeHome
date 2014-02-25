/*
Deployment script for DiHaoOA
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DiHaoOA"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
USE [master]
GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL
    AND DATABASEPROPERTYEX(N'$(DatabaseName)','Status') <> N'ONLINE')
BEGIN
    RAISERROR(N'The state of the target database, %s, is not set to ONLINE. To deploy to this database, its state must be set to ONLINE.', 16, 127,N'$(DatabaseName)') WITH NOWAIT
    RETURN
END

GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [DiHaoOA], FILENAME = N'$(DefaultDataPath)DiHaoOA.mdf')
    LOG ON (NAME = [DiHaoOA_log], FILENAME = N'$(DefaultLogPath)DiHaoOA_log.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
EXECUTE sp_dbcmptlevel [$(DatabaseName)], 100;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
USE [$(DatabaseName)]
GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

GO
PRINT N'Creating [dbo].[Customer]...';


GO
CREATE TABLE [dbo].[Customer] (
    [CustomerId]             INT            NOT NULL,
    [CompanyName]            NVARCHAR (500) NULL,
    [ContactPerson]          NVARCHAR (50)  NULL,
    [ContactPersonNumber]    NVARCHAR (50)  NULL,
    [ContactPerson2]         NVARCHAR (50)  NULL,
    [ContactPerson2Number]   NVARCHAR (50)  NULL,
    [ContactPerson3]         NVARCHAR (50)  NULL,
    [ContactPerson3Number]   NVARCHAR (50)  NULL,
    [City]                   NVARCHAR (50)  NULL,
    [UsableArea]             NVARCHAR (50)  NULL,
    [Email]                  NVARCHAR (50)  NULL,
    [DecorationAddress]      NVARCHAR (500) NULL,
    [RidePath]               NVARCHAR (500) NULL,
    [AppointDateTime]        NVARCHAR (500) NULL,
    [ProviderType]           NVARCHAR (50)  NULL,
    [CustomerType]           NVARCHAR (50)  NULL,
    [Comments]               NVARCHAR (MAX) NULL,
    [InformationAssistantId] INT            NULL,
    [EmployeeId]             NVARCHAR (50)  NULL,
    [WorkPlace]              NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[CustomerOrder]...';


GO
CREATE TABLE [dbo].[CustomerOrder] (
    [OrderId]        INT            IDENTITY (1, 1) NOT NULL,
    [OrderNumber]    INT            NOT NULL,
    [RecordDate]     DATETIME       NULL,
    [DesignerId]     NVARCHAR (50)  NULL,
    [OrderStatus]    NVARCHAR (50)  NULL,
    [CustomerId]     INT            NULL,
    [Description]    NVARCHAR (MAX) NULL,
    [AllocationDate] DATETIME       NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([OrderId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY],
    CONSTRAINT [Unique_Order] UNIQUE NONCLUSTERED ([OrderNumber] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[CustomerRevisit]...';


GO
CREATE TABLE [dbo].[CustomerRevisit] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [RevisitContent]  NVARCHAR (MAX) NULL,
    [RevisitDateTime] DATETIME       NULL,
    [CustomerOrderId] INT            NULL,
    CONSTRAINT [PK_CustomerRevisit] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[Employee]...';


GO
CREATE TABLE [dbo].[Employee] (
    [EmployeeId]  NVARCHAR (50)  NOT NULL,
    [Name]        NVARCHAR (500) NULL,
    [Password]    NVARCHAR (50)  NULL,
    [Department]  NVARCHAR (500) NULL,
    [PhoneNumber] NVARCHAR (50)  NULL,
    [RoleId]      INT            NULL,
    [IsActive]    BIT            NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([EmployeeId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[InformationAssistant]...';


GO
CREATE TABLE [dbo].[InformationAssistant] (
    [InformationAssistantId]   INT            NOT NULL,
    [InformationAssistantName] NVARCHAR (50)  NULL,
    [PhoneNumber]              NVARCHAR (50)  NULL,
    [Type]                     NVARCHAR (50)  NULL,
    [Company]                  NVARCHAR (500) NULL,
    [City]                     NVARCHAR (50)  NULL,
    [InformationLevel]         NVARCHAR (50)  NULL,
    [ReVisitTime]              NVARCHAR (50)  NULL,
    [OrderId]                  INT            NULL,
    [Address]                  NVARCHAR (500) NULL,
    [ReVisistPeriod]           NVARCHAR (50)  NULL,
    [IsVisit]                  BIT            NULL,
    [HandSet]                  NVARCHAR (50)  NULL,
    [EmployeeId]               NVARCHAR (50)  NULL,
    [VisitDateTime]            DATETIME       NULL,
    [RecordDate]               DATETIME       NULL,
    CONSTRAINT [PK_InformationAssistant] PRIMARY KEY CLUSTERED ([InformationAssistantId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY],
    CONSTRAINT [UQ__Informat__85FB4E381B0907CE] UNIQUE NONCLUSTERED ([PhoneNumber] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[Revisit]...';


GO
CREATE TABLE [dbo].[Revisit] (
    [ID]                     INT            IDENTITY (1, 1) NOT NULL,
    [RevisitContent]         NVARCHAR (MAX) NULL,
    [RevisitDateTime]        DATETIME       NULL,
    [InformationAssistantId] INT            NULL,
    CONSTRAINT [PK_Revisit] PRIMARY KEY CLUSTERED ([ID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[SecurityActivities]...';


GO
CREATE TABLE [dbo].[SecurityActivities] (
    [Id]       INT           NOT NULL,
    [Activity] NVARCHAR (50) NULL,
    CONSTRAINT [PK_SecurityActivities] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[SecurityRoles]...';


GO
CREATE TABLE [dbo].[SecurityRoles] (
    [Id]        INT           NOT NULL,
    [Role]      NVARCHAR (50) NULL,
    [ActivitId] INT           NULL,
    CONSTRAINT [PK_SecurityRoles] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating FK_Customer_Employee...';


GO
ALTER TABLE [dbo].[Customer] WITH NOCHECK
    ADD CONSTRAINT [FK_Customer_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([EmployeeId]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_Customer_InformationAssistant...';


GO
ALTER TABLE [dbo].[Customer] WITH NOCHECK
    ADD CONSTRAINT [FK_Customer_InformationAssistant] FOREIGN KEY ([InformationAssistantId]) REFERENCES [dbo].[InformationAssistant] ([InformationAssistantId]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_CustomerOrder_Employee...';


GO
ALTER TABLE [dbo].[CustomerOrder] WITH NOCHECK
    ADD CONSTRAINT [FK_CustomerOrder_Employee] FOREIGN KEY ([DesignerId]) REFERENCES [dbo].[Employee] ([EmployeeId]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_CustomerRevisit_Customer...';


GO
ALTER TABLE [dbo].[CustomerRevisit] WITH NOCHECK
    ADD CONSTRAINT [FK_CustomerRevisit_Customer] FOREIGN KEY ([CustomerOrderId]) REFERENCES [dbo].[CustomerOrder] ([OrderId]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_Employee_SecurityRoles...';


GO
ALTER TABLE [dbo].[Employee] WITH NOCHECK
    ADD CONSTRAINT [FK_Employee_SecurityRoles] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[SecurityRoles] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_InformationAssistant_InformationAssistant...';


GO
ALTER TABLE [dbo].[InformationAssistant] WITH NOCHECK
    ADD CONSTRAINT [FK_InformationAssistant_InformationAssistant] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([EmployeeId]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_Revisit_InformationAssistant...';


GO
ALTER TABLE [dbo].[Revisit] WITH NOCHECK
    ADD CONSTRAINT [FK_Revisit_InformationAssistant] FOREIGN KEY ([InformationAssistantId]) REFERENCES [dbo].[InformationAssistant] ([InformationAssistantId]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating FK_SecurityRoles_SecurityActivities...';


GO
ALTER TABLE [dbo].[SecurityRoles] WITH NOCHECK
    ADD CONSTRAINT [FK_SecurityRoles_SecurityActivities] FOREIGN KEY ([ActivitId]) REFERENCES [dbo].[SecurityActivities] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
PRINT N'Creating [dbo].[pro_AllCustomersPaging]...';


GO
Create procedure [dbo].[pro_AllCustomersPaging]
@pageIndex int,
@pageSize int,
@input nvarchar(500),
@BlackEmployeeId nvarchar(50),
@TotalRecords int output
as
begin
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select * from(
select Row_Number() over(order by o.OrderId desc) rowNumber,
	  'False' as IsSelected,
	  o.OrderId,
	  c.CustomerId,
	  o.OrderNumber as orderNumber,
	  o.OrderStatus as OrderStatus,
	  c.CompanyName,
	  o.RecordDate as RecordDate,
	  c.DecorationAddress as decorateAddress,
      i.InformationAssistantName as InformationAssistantName,
	  e.Name as BAName,
	  d.Name as DesignerName,
	  c.City as city
from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	left outer join Employee d on d.EmployeeId = o.DesignerId
	left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	left outer join Employee e on e.EmployeeId = c.EmployeeId
where e.EmployeeId != @BlackEmployeeId
   and (o.OrderNumber like '%'+@input+'%'
   or c.CompanyName like '%'+@input+'%'
   or o.RecordDate like '%'+@input+'%'
   or o.OrderStatus like '%'+@input+'%'
   or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
   or c.DecorationAddress like '%'+@input+'%'
   or i.InformationAssistantName like '%'+@input+'%'
   or e.Name like '%'+@input+'%'
   or c.City like '%'+@input+'%'
   or c.ContactPersonNumber like '%'+@input+'%' 
   or c.ContactPerson2Number like '%'+@input+'%' 
   or c.ContactPerson3Number like '%'+@input+'%' 
   or @input='')
  )as tempTable
where rowNumber between @startRow and @lastRow

select @TotalRecords = count(*) 
from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	left outer join Employee d on d.EmployeeId = o.DesignerId
	left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	left outer join Employee e on e.EmployeeId = c.EmployeeId
where e.EmployeeId != @BlackEmployeeId
   and (o.OrderNumber like '%'+@input+'%'
   or c.CompanyName like '%'+@input+'%'
   or o.RecordDate like '%'+@input+'%'
   or o.OrderNumber like '%'+@input+'%'
   or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
   or c.DecorationAddress like '%'+@input+'%'
   or i.InformationAssistantName like '%'+@input+'%'
   or e.Name like '%'+@input+'%'
   or c.City like '%'+@input+'%'
   or c.ContactPersonNumber like '%'+@input+'%' 
   or c.ContactPerson2Number like '%'+@input+'%' 
   or c.ContactPerson3Number like '%'+@input+'%' 
   or @input='')
end
return @TotalRecords
GO
PRINT N'Creating [dbo].[pro_AllListPaging]...';


GO
create	procedure [dbo].[pro_AllListPaging]
@pageIndex int,
@pageSize int,
@InformationLevel nvarchar(50),
@input nvarchar(500),
@EmployeeId nvarchar(500)
as
declare @startRow int
declare @lastRow int
declare @sql nvarchar(max)
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select * from 
(
select Row_Number() over(order by VisitDateTime) rowNumber ,
	   InformationAssistantId as gridColumnIndex,
       InformationAssistantName as gridColumnName,
       i.PhoneNumber as gridColumnPhone,Type as gridColumnType,
       Company as gridColumnCompany,City as gridColumnCity,
       InformationLevel as gridColumnLevel,
       InformationAssistantName as gridColumnInformationAssistant,
       e.Name as EmployeeName,
       datediff(hour,getdate(),VisitDateTime) as gridColumnleftRevisitTime,
       VisitDateTime 
       From InformationAssistant i left outer join Employee e
       on i.EmployeeId = e.EmployeeId
       where (InformationLevel = @InformationLevel 
       or @InformationLevel = 'InforAllList')
       and i.EmployeeId = @EmployeeId
       and (InformationAssistantName like '%'+@input+'%' 
       or i.PhoneNumber like  '%'+@input+'%'
       or [Type] like '%'+@input+'%'
       or Company like '%'+@input+'%'
       or City like '%'+@input+'%'
       or InformationLevel like '%'+@input+'%'
       or ReVisitTime like '%'+@input+'%'
       or e.Name like '%'+@input+'%'
       or InformationAssistantName like '%'+@input+'%'
       or @input = '')
) as tempTable
where rowNumber between @startRow and @lastRow
order by gridColumnleftRevisitTime,VisitDateTime
GO
PRINT N'Creating [dbo].[pro_AllListPagingForManager]...';


GO
create	procedure [dbo].[pro_AllListPagingForManager]
@pageIndex int,
@pageSize int,
@input nvarchar(max),
@BlackEmployeeId nvarchar(50),
@TotalRecords int output
as
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select * from 
(
select Row_Number() over(order by InformationAssistantId) rowNumber ,
       'False' as IsSelected,
	   InformationAssistantId as gridColumnIndex,
       InformationAssistantName as gridColumnName,
	   i.PhoneNumber as IaPhoneNumber,
       [Type] as gridColumnType,
       Company as gridColumnCompany,City as gridColumnCity,
       InformationLevel as gridColumnLevel,
       InformationAssistantName as gridColumnInformationAssistant,
       e.Name as EmployeeName
      From InformationAssistant i, Employee e
      where i.EmployeeId = e.EmployeeId
      and i.EmployeeId != @BlackEmployeeId
      and (InformationAssistantName like '%'+@input+'%'
      or [Type] like '%'+@input+'%'
      or Company like '%'+@input+'%'
      or InformationLevel like '%'+@input+'%'
      or InformationAssistantName like '%'+@input+'%'
      or e.Name like '%'+@input+'%'
      or @input = '')
) as tempTable
where rowNumber between @startRow and @lastRow


select @TotalRecords = count(*) 
      From InformationAssistant i, Employee e
      where i.EmployeeId = e.EmployeeId
      and i.EmployeeId != @BlackEmployeeId
      and (InformationAssistantName like '%'+@input+'%'
      or [Type] like '%'+@input+'%'
      or Company like '%'+@input+'%'
      or InformationLevel like '%'+@input+'%'
      or InformationAssistantName like '%'+@input+'%'
      or e.Name like '%'+@input+'%'
      or @input = '')
return @TotalRecords
GO
PRINT N'Creating [dbo].[pro_ApprovalListForMarketingManager]...';


GO
Create procedure [dbo].[pro_ApprovalListForMarketingManager]
@pageIndex int,
@pageSize int,
@input nvarchar(500),
@BlackEmployeeId nvarchar(50),
@TotalRecords int output
as
begin
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select * from(
select Row_Number() over(order by o.OrderId desc) rowNumber,
	  o.OrderId,
	  c.CustomerId,
	  o.OrderNumber as orderNumber,
	  o.OrderStatus as OrderStatus,
	  c.CompanyName,
	  o.RecordDate as RecordDate,
	  c.DecorationAddress as decorateAddress,
      i.InformationAssistantName as InformationAssistantName,
	  e.Name as BAName,
	  d.Name as DesignerName,
	  c.City as city
from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	left outer join Employee d on d.EmployeeId = o.DesignerId
	left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	left outer join Employee e on e.EmployeeId = c.EmployeeId
where e.EmployeeId != @BlackEmployeeId
   and o.OrderStatus = N'已提交'
   and (o.OrderNumber like '%'+@input+'%'
   or c.CompanyName like '%'+@input+'%'
   or o.RecordDate like '%'+@input+'%'
   or o.OrderStatus like '%'+@input+'%'
   or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
   or c.DecorationAddress like '%'+@input+'%'
   or i.InformationAssistantName like '%'+@input+'%'
   or e.Name like '%'+@input+'%'
   or c.City like '%'+@input+'%'
   or c.ContactPersonNumber like '%'+@input+'%' 
   or c.ContactPerson2Number like '%'+@input+'%' 
   or c.ContactPerson3Number like '%'+@input+'%' 
   or @input='')
  )as tempTable
where rowNumber between @startRow and @lastRow

select @TotalRecords = count(*) 
from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	left outer join Employee d on d.EmployeeId = o.DesignerId
	left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	left outer join Employee e on e.EmployeeId = c.EmployeeId
where e.EmployeeId != @BlackEmployeeId
   and o.OrderStatus = N'已提交'
   and (o.OrderNumber like '%'+@input+'%'
   or c.CompanyName like '%'+@input+'%'
   or o.RecordDate like '%'+@input+'%'
   or o.OrderNumber like '%'+@input+'%'
   or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
   or c.DecorationAddress like '%'+@input+'%'
   or i.InformationAssistantName like '%'+@input+'%'
   or e.Name like '%'+@input+'%'
   or c.City like '%'+@input+'%'
   or c.ContactPersonNumber like '%'+@input+'%' 
   or c.ContactPerson2Number like '%'+@input+'%' 
   or c.ContactPerson3Number like '%'+@input+'%' 
   or @input='')
end
return @TotalRecords
GO
PRINT N'Creating [dbo].[pro_DeletedCustomersPaging]...';


GO
Create procedure [dbo].[pro_DeletedCustomersPaging]
@pageIndex int,
@pageSize int,
@input nvarchar(500),
@BlackEmployeeId nvarchar(50),
@TotalRecords int output
as
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select * from(
select Row_Number() over(order by o.OrderId desc) rowNumber,
	  'False' as IsSelected,
	  o.OrderId,
	  c.CustomerId,
	  o.OrderNumber as orderNumber,
	  o.OrderStatus as OrderStatus,
	  c.CompanyName,
	  o.RecordDate as RecordDate,
	  c.DecorationAddress as decorateAddress,
      i.InformationAssistantName as InformationAssistantName,
	  e.Name as BAName,
	  d.Name as DesignerName,
	  c.City as city
from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	left outer join Employee d on d.EmployeeId = o.DesignerId
	left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	left outer join Employee e on e.EmployeeId = c.EmployeeId
where e.EmployeeId = @BlackEmployeeId
   and (o.OrderNumber like '%'+@input+'%'
   or c.CompanyName like '%'+@input+'%'
   or o.RecordDate like '%'+@input+'%'
   or o.OrderNumber like '%'+@input+'%'
   or o.OrderStatus like '%'+@input+'%'
   or c.DecorationAddress like '%'+@input+'%'
   or i.InformationAssistantName like '%'+@input+'%'
   or e.Name like '%'+@input+'%'
   or c.City like '%'+@input+'%'
   or c.ContactPersonNumber like '%'+@input+'%' 
   or c.ContactPerson2Number like '%'+@input+'%' 
   or c.ContactPerson3Number like '%'+@input+'%' 
   or @input='')
  )as tempTable
where rowNumber between @startRow and @lastRow

select @TotalRecords = count(*) 
from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	left outer join Employee d on d.EmployeeId = o.DesignerId
	left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	left outer join Employee e on e.EmployeeId = c.EmployeeId
where e.EmployeeId = @BlackEmployeeId
   and (o.OrderNumber like '%'+@input+'%'
   or c.CompanyName like '%'+@input+'%'
   or o.RecordDate like '%'+@input+'%'
   or o.OrderNumber like '%'+@input+'%'
   or c.DecorationAddress like '%'+@input+'%'
   or i.InformationAssistantName like '%'+@input+'%'
   or e.Name like '%'+@input+'%'
   or c.City like '%'+@input+'%'
   or c.ContactPersonNumber like '%'+@input+'%' 
   or c.ContactPerson2Number like '%'+@input+'%' 
   or c.ContactPerson3Number like '%'+@input+'%' 
   or @input='')
return @TotalRecords
GO
PRINT N'Creating [dbo].[pro_DeletedIAListPaging]...';


GO
create	procedure [dbo].[pro_DeletedIAListPaging]
@pageIndex int,
@pageSize int,
@input nvarchar(max),
@BlackEmployeeId nvarchar(50),
@TotalRecords int output
as
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select * from 
(
select Row_Number() over(order by InformationAssistantId) rowNumber ,
       'False' as IsSelected,
	   InformationAssistantId as gridColumnIndex,
       InformationAssistantName as gridColumnName,
	   i.PhoneNumber as IaPhoneNumber,
       [Type] as gridColumnType,
       Company as gridColumnCompany,City as gridColumnCity,
       InformationLevel as gridColumnLevel,
       InformationAssistantName as gridColumnInformationAssistant,
       e.Name as EmployeeName
      From InformationAssistant i, Employee e
      where i.EmployeeId = e.EmployeeId
      and i.EmployeeId = @BlackEmployeeId
      and (InformationAssistantName like '%'+@input+'%'
      or [Type] like '%'+@input+'%'
      or Company like '%'+@input+'%'
      or InformationLevel like '%'+@input+'%'
      or InformationAssistantName like '%'+@input+'%'
      or e.Name like '%'+@input+'%'
      or @input = '')
) as tempTable
where rowNumber between @startRow and @lastRow


select @TotalRecords = count(*)
      From InformationAssistant i, Employee e
      where i.EmployeeId = e.EmployeeId
      and i.EmployeeId = @BlackEmployeeId
      and (InformationAssistantName like '%'+@input+'%'
      or [Type] like '%'+@input+'%'
      or Company like '%'+@input+'%'
      or InformationLevel like '%'+@input+'%'
      or InformationAssistantName like '%'+@input+'%'
      or e.Name like '%'+@input+'%'
      or @input = '')
return @TotalRecords
GO
PRINT N'Creating [dbo].[pro_GetOrderByOrderStatus]...';


GO
Create procedure [dbo].[pro_GetOrderByOrderStatus]
@pageIndex int,
@pageSize int,
@orderStatus nvarchar(50),
@input nvarchar(500),
@BlackEmployeeId nvarchar(50),
@TotalRecords int output
as
begin
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select * from(
select Row_Number() over(order by o.OrderId desc) rowNumber,
	  o.OrderId,
	  c.CustomerId,
	  o.OrderNumber as orderNumber,
	  o.OrderStatus as OrderStatus,
	  c.CompanyName,
	  o.RecordDate as RecordDate,
	  c.DecorationAddress as decorateAddress,
      i.InformationAssistantName as InformationAssistantName,
	  e.Name as BAName,
	  d.Name as DesignerName,
	  c.City as city
from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	left outer join Employee d on d.EmployeeId = o.DesignerId
	left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	left outer join Employee e on e.EmployeeId = c.EmployeeId
where e.EmployeeId != @BlackEmployeeId
   and o.OrderStatus = @orderStatus
   and (o.OrderNumber like '%'+@input+'%'
   or c.CompanyName like '%'+@input+'%'
   or o.RecordDate like '%'+@input+'%'
   or o.OrderStatus like '%'+@input+'%'
   or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
   or c.DecorationAddress like '%'+@input+'%'
   or i.InformationAssistantName like '%'+@input+'%'
   or e.Name like '%'+@input+'%'
   or c.City like '%'+@input+'%'
   or c.ContactPersonNumber like '%'+@input+'%' 
   or c.ContactPerson2Number like '%'+@input+'%' 
   or c.ContactPerson3Number like '%'+@input+'%' 
   or @input='')
  )as tempTable
where rowNumber between @startRow and @lastRow

select @TotalRecords = count(*) 
from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	left outer join Employee d on d.EmployeeId = o.DesignerId
	left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	left outer join Employee e on e.EmployeeId = c.EmployeeId
where e.EmployeeId != @BlackEmployeeId
   and o.OrderStatus = @orderStatus
   and (o.OrderNumber like '%'+@input+'%'
   or c.CompanyName like '%'+@input+'%'
   or o.RecordDate like '%'+@input+'%'
   or o.OrderNumber like '%'+@input+'%'
   or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
   or c.DecorationAddress like '%'+@input+'%'
   or i.InformationAssistantName like '%'+@input+'%'
   or e.Name like '%'+@input+'%'
   or c.City like '%'+@input+'%'
   or c.ContactPersonNumber like '%'+@input+'%' 
   or c.ContactPerson2Number like '%'+@input+'%' 
   or c.ContactPerson3Number like '%'+@input+'%' 
   or @input='')
end
return @TotalRecords
GO
PRINT N'Creating [dbo].[pro_OrdersPaging]...';


GO
Create procedure [dbo].[pro_OrdersPaging]
@pageIndex int,
@pageSize int,
@orderStatus nvarchar(50),
@input nvarchar(500),
@EmployeeId nvarchar(50)
as
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select * from(
select Row_Number() over(order by o.OrderId desc) rowNumber,
	  o.OrderId,
	  c.CustomerId,
	  o.OrderNumber as orderNumber,
	  o.OrderStatus orderStatus,
	  c.CompanyName,
	  o.RecordDate as RecordDate,
	  c.DecorationAddress as decorateAddress,
      i.InformationAssistantName as InformationAssistantName,
	  e.Name as BAName,
	  d.Name as DesignerName,
	  c.City as city
from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	left outer join Employee d on d.EmployeeId = o.DesignerId
	left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	left outer join Employee e on e.EmployeeId = c.EmployeeId
where o.orderStatus = @orderStatus
   and  c.EmployeeId = @EmployeeId
   and (o.OrderNumber like '%'+@input+'%'
   or c.CompanyName like '%'+@input+'%'
   or o.RecordDate like '%'+@input+'%'
   or o.OrderStatus like '%'+@input+'%'
   or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
   or c.DecorationAddress like '%'+@input+'%'
   or i.InformationAssistantName like '%'+@input+'%'
   or e.Name like '%'+@input+'%'
   or c.City like '%'+@input+'%'
   or c.ContactPersonNumber like '%'+@input+'%' 
   or c.ContactPerson2Number like '%'+@input+'%' 
   or c.ContactPerson3Number like '%'+@input+'%' 
   or @input='')
  )as tempTable
where rowNumber between @startRow and @lastRow
GO
PRINT N'Creating [dbo].[pro_UnSubordinateCustomersPaging]...';


GO
Create procedure [dbo].[pro_UnSubordinateCustomersPaging]
@pageIndex int,
@pageSize int,
@input nvarchar(500),
@BlackEmployeeId nvarchar(50),
@TotalRecords int output
as
begin
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select * from(
select Row_Number() over(order by o.OrderId desc) rowNumber,
	  'False' as IsSelected,
	  o.OrderId,
	  c.CustomerId,
	  o.OrderNumber as orderNumber,
	  o.OrderStatus as OrderStatus,
	  c.CompanyName,
	  o.RecordDate as RecordDate,
	  c.DecorationAddress as decorateAddress,
      i.InformationAssistantName as InformationAssistantName,
	  e.Name as BAName,
	  d.Name as DesignerName,
	  c.City as city
from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	left outer join Employee d on d.EmployeeId = o.DesignerId
	left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	left outer join Employee e on e.EmployeeId = c.EmployeeId
where e.EmployeeId != @BlackEmployeeId
   and c.InformationAssistantId is null
   and (o.OrderNumber like '%'+@input+'%'
   or c.CompanyName like '%'+@input+'%'
   or o.RecordDate like '%'+@input+'%'
   or o.OrderNumber like '%'+@input+'%'
   or o.OrderStatus like '%'+@input+'%'
   or c.DecorationAddress like '%'+@input+'%'
   or i.InformationAssistantName like '%'+@input+'%'
   or e.Name like '%'+@input+'%'
   or c.City like '%'+@input+'%'
   or @input='')
  )as tempTable
where rowNumber between @startRow and @lastRow

select @TotalRecords = count(*) 
from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	left outer join Employee d on d.EmployeeId = o.DesignerId
	left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	left outer join Employee e on e.EmployeeId = c.EmployeeId
where e.EmployeeId != @BlackEmployeeId
   and c.InformationAssistantId is null
   and (o.OrderNumber like '%'+@input+'%'
   or c.CompanyName like '%'+@input+'%'
   or o.RecordDate like '%'+@input+'%'
   or o.OrderNumber like '%'+@input+'%'
   or c.DecorationAddress like '%'+@input+'%'
   or i.InformationAssistantName like '%'+@input+'%'
   or e.Name like '%'+@input+'%'
   or c.City like '%'+@input+'%'
   or @input='')
end
return @TotalRecords
GO
PRINT N'Creating [dbo].[pro_UnSubordinateMessengerList]...';


GO
create procedure [dbo].[pro_UnSubordinateMessengerList]
@pageIndex int,
@pageSize int
as
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize
select gridColumnInformationAssistantId,gridColumnName,gridColumnPhone,gridColumnType
	   ,gridColumnCompany,gridColumnCity,gridColumnLevel from(
	select Row_number() over(order by InformationAssistantId) rowNumber,
			InformationAssistantId as gridColumnInformationAssistantId,
			InformationAssistantName as gridColumnName,
			PhoneNumber as gridColumnPhone,
			[Type] as gridColumnType,
			Company as gridColumnCompany,
			City as gridColumnCity,
			InformationLevel as gridColumnLevel
			From InformationAssistant
			where EmployeeId is null
			) as tempTable
where rowNumber between @startRow and @lastRow
GO
PRINT N'Creating [dbo].[pro_VisitContentPaging]...';


GO
create	procedure [dbo].[pro_VisitContentPaging]
@pageIndex int,
@pageSize int,
@EmployeeId nvarchar(50),
@TotalRecords int output
as
declare @startRow int
declare @lastRow int
set @startRow = (@pageIndex -1)*@pageSize + 1
set @lastRow = @pageIndex * @pageSize

select * from (
Select Row_Number() over(order by RevisitDateTime) rowNumber ,
[RevisitContent] as RevisitContent,
[RevisitDateTime] as RevisitTime
from Revisit r,InformationAssistant i
where r.InformationAssistantId = i.InformationAssistantId
and i.EmployeeId = @EmployeeId
and CONVERT(varchar(100), r.RevisitDateTime, 111)=CONVERT(varchar(100), getdate(), 111)
) as tempTable
where rowNumber between @startRow and @lastRow
order by RevisitTime desc

select @TotalRecords=count(*) 
from Revisit r,InformationAssistant i
where r.InformationAssistantId = i.InformationAssistantId
and i.EmployeeId = @EmployeeId
and CONVERT(varchar(100), r.RevisitDateTime, 111)=CONVERT(varchar(100), getdate(), 111)
return @TotalRecords
GO
-- Refactoring step to update target server with deployed transaction logs
CREATE TABLE  [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
GO
sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
GO

GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
-- =============================================
-- Script Template
-- =============================================
Insert into SecurityActivities values(1,'SalesManActivity')
Insert into SecurityActivities values(2,'DesignerActivity')
Insert into SecurityActivities values(3,'SalesManManagerActivity')
Insert into SecurityActivities values(4,'DesignerManagerActivity')
Insert into SecurityActivities values(5,'GeneralManagerActivity')
Insert into SecurityActivities values(6,'DesignerLeaderActivity')
-- =============================================
-- 
-- =============================================

Insert into SecurityRoles values(1,'SalesMan',1)
Insert into SecurityRoles values(2,'Designer',2)
Insert into SecurityRoles values(3,'SalesManManager',3)
Insert into SecurityRoles values(4,'DesignerManager',4)
Insert into SecurityRoles values(5,'GeneralManager',5)
Insert into SecurityRoles values(6,'DesignerLeader',6)
-- =============================================
-- Script Template
-- =============================================
USE [DiHaoOA]
GO
INSERT [dbo].[Employee]  VALUES ('swbjl800001', 'swbjl800001', 'jl800001', 'Marketing', '15502106467',3,1)
INSERT [dbo].[Employee]  VALUES ('swb800002', 'swb800002', '800002','Marketing', '15502106461',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800003', 'swb800003', '800003','Marketing', '15502106462',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800004', 'swb800004', '800004','Marketing', '15502106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800005', 'swb800005', '800005','Marketing', '15502106464',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800006', 'swb800006', '800006','Marketing', '15502106465',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800007', 'swb800007', '800007','Marketing', '15502106466',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800008', 'swb800008', '800008','Marketing', '15502106467',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800009', 'swb800009', '800009','Marketing', '15502106468',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800010', 'swb800010', '800010','Marketing', '15502106413',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800011', 'swb800011', '800011','Marketing', '15502106423',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800012', 'swb800012', '800012','Marketing', '15502106443',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800013', 'swb800013', '800013','Marketing', '15502106453',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800014', 'swb800014', '800014','Marketing', '15502106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800015', 'swb800015', '800015','Marketing', '15502106743',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800016', 'swb800016', '800016','Marketing', '13502106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800017', 'swb800017', '800017','Marketing', '15302106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800018', 'swb800018', '800018','Marketing', '15802106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800019', 'swb800019', '800019','Marketing', '15500106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800020', 'swb800020', '800020','Marketing', '15572106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800021', 'swb800021', '800021','Marketing', '15502106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800022', 'swb800022', '800022','Marketing', '15002106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800023', 'swb800023', '800023','Marketing', '13102106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800024', 'swb800024', '800024','Marketing', '15507106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800025', 'swb800025', '800025','Marketing', '15542106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800026', 'swb800026', '800026','Marketing', '15502108563',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800027', 'swb800027', '800027','Marketing', '15502103463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800028', 'swb800028', '800028','Marketing', '15502206463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800029', 'swb800029', '800029','Marketing', '15503106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800030', 'swb800030', '800030','Marketing', '15509106463',1,1)
INSERT [dbo].[Employee]  VALUES ('swb800031', 'swb800031', '800031','Marketing', '15502108863',1,1)

-- =============================================
-- Initial InformationAssistant
-- =============================================
insert into InformationAssistant values(1,'Aaron','15502104451','Intermediary','DiHao','Chendu','Copper',11,null,null,null,null,null,'swb800002',GETDATE(),GETDATE()),
									   (2,'Alen','15502104672','Intermediary','DiHao','Chendu','Copper',11,null,null,null,null,null,'swb800002',GETDATE(),GETDATE()),
									   (3,'Eric','15502104783','Intermediary','DiHao','Chendu','Copper',11,null,null,null,null,null,'swb800002',GETDATE(),GETDATE()),
									   (4,'Tom','12341784','Intermediary','DiHao','Chendu','Iron',11,null,null,null,null,null,'swb800002',GETDATE(),GETDATE()),
									   (5,'Edi','153543785','Intermediary','DiHao','Chendu','Iron',11,null,null,null,null,null,'swb800002',GETDATE(),GETDATE()),
									   (6,'Lucy','98766786','Intermediary','DiHao','Chendu','Iron',11,null,null,null,null,null,'swb800002',GETDATE(),GETDATE()),
									   (7,'LiLy','12646787','Intermediary','DiHao','Chendu','Iron',11,null,null,null,null,null,'swb800002',GETDATE(),GETDATE()),
									   (8,'Tomson','12341788','Intermediary','DiHao','Chendu','Iron',11,null,null,null,null,null,'swb800002',GETDATE(),GETDATE()),
									   (9,'Tim','123409789','Intermediary','DiHao','Chendu','Iron',11,null,null,null,null,null,'swb800002',GETDATE(),GETDATE()),
									   (10,'Ada','1237680','Intermediary','DiHao','Chendu','Silver',11,null,null,null,null,null,'swb800003',GETDATE(),GETDATE()),
									   (11,'wang','1286811','Intermediary','DiHao','Chendu','Silver',11,null,null,null,null,null,'swb800003',GETDATE(),GETDATE()),
									   (12,'Field','1012','Intermediary','DiHao','Chendu','Silver',11,null,null,null,null,null,'swb800003',GETDATE(),GETDATE()),
									   (13,'Berton','567575813','Intermediary','DiHao','Chendu','Silver',11,null,null,null,null,null,'swb800003',GETDATE(),GETDATE()),
									   (14,'Alice','1535353514','Intermediary','DiHao','Chendu','Silver',11,null,null,null,null,null,'swb800003',GETDATE(),GETDATE()),
									   (15,'Deborah','1345345815','Intermediary','DiHao','Chendu','Silver',11,null,null,null,null,null,'swb800003',GETDATE(),GETDATE())

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Customer] WITH CHECK CHECK CONSTRAINT [FK_Customer_Employee];

ALTER TABLE [dbo].[Customer] WITH CHECK CHECK CONSTRAINT [FK_Customer_InformationAssistant];

ALTER TABLE [dbo].[CustomerOrder] WITH CHECK CHECK CONSTRAINT [FK_CustomerOrder_Employee];

ALTER TABLE [dbo].[CustomerRevisit] WITH CHECK CHECK CONSTRAINT [FK_CustomerRevisit_Customer];

ALTER TABLE [dbo].[Employee] WITH CHECK CHECK CONSTRAINT [FK_Employee_SecurityRoles];

ALTER TABLE [dbo].[InformationAssistant] WITH CHECK CHECK CONSTRAINT [FK_InformationAssistant_InformationAssistant];

ALTER TABLE [dbo].[Revisit] WITH CHECK CHECK CONSTRAINT [FK_Revisit_InformationAssistant];

ALTER TABLE [dbo].[SecurityRoles] WITH CHECK CHECK CONSTRAINT [FK_SecurityRoles_SecurityActivities];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        DECLARE @VarDecimalSupported AS BIT;
        SELECT @VarDecimalSupported = 0;
        IF ((ServerProperty(N'EngineEdition') = 3)
            AND (((@@microsoftversion / power(2, 24) = 9)
                  AND (@@microsoftversion & 0xffff >= 3024))
                 OR ((@@microsoftversion / power(2, 24) = 10)
                     AND (@@microsoftversion & 0xffff >= 1600))))
            SELECT @VarDecimalSupported = 1;
        IF (@VarDecimalSupported > 0)
            BEGIN
                EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
            END
    END


GO
