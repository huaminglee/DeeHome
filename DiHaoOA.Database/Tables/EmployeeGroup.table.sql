CREATE TABLE [dbo].[EmployeeGroup](
	[GroupId] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](max) NULL,
	[Department] [nvarchar](50) NULL,
	[LeaderId] [nvarchar](50) NULL,
 CONSTRAINT [PK_EmployeeGroup] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[EmployeeGroup]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeGroup_Employee] FOREIGN KEY([LeaderId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO

ALTER TABLE [dbo].[EmployeeGroup] CHECK CONSTRAINT [FK_EmployeeGroup_Employee]
GO