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
INSERT [dbo].[Employee]  VALUES ('swbjl800001', 'swbjl800001', 'jl800001', 'Marketing', '15502106467',3,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800002', 'swb800002', '800002','Marketing', '15502106461',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800003', 'swb800003', '800003','Marketing', '15502106462',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800004', 'swb800004', '800004','Marketing', '15502106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800005', 'swb800005', '800005','Marketing', '15502106464',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800006', 'swb800006', '800006','Marketing', '15502106465',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800007', 'swb800007', '800007','Marketing', '15502106466',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800008', 'swb800008', '800008','Marketing', '15502106467',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800009', 'swb800009', '800009','Marketing', '15502106468',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800010', 'swb800010', '800010','Marketing', '15502106413',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800011', 'swb800011', '800011','Marketing', '15502106423',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800012', 'swb800012', '800012','Marketing', '15502106443',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800013', 'swb800013', '800013','Marketing', '15502106453',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800014', 'swb800014', '800014','Marketing', '15502106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800015', 'swb800015', '800015','Marketing', '15502106743',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800016', 'swb800016', '800016','Marketing', '13502106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800017', 'swb800017', '800017','Marketing', '15302106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800018', 'swb800018', '800018','Marketing', '15802106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800019', 'swb800019', '800019','Marketing', '15500106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800020', 'swb800020', '800020','Marketing', '15572106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800021', 'swb800021', '800021','Marketing', '15502106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800022', 'swb800022', '800022','Marketing', '15002106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800023', 'swb800023', '800023','Marketing', '13102106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800024', 'swb800024', '800024','Marketing', '15507106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800025', 'swb800025', '800025','Marketing', '15542106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800026', 'swb800026', '800026','Marketing', '15502108563',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800027', 'swb800027', '800027','Marketing', '15502103463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800028', 'swb800028', '800028','Marketing', '15502206463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800029', 'swb800029', '800029','Marketing', '15503106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800030', 'swb800030', '800030','Marketing', '15509106463',1,1,null)
INSERT [dbo].[Employee]  VALUES ('swb800031', 'swb800031', '800031','Marketing', '15502108863',1,1,null)

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
