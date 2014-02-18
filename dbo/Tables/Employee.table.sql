CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Password] [nvarchar](50) NULL,
	[InfomationrAssistantId] [int] NULL,
	[EmployeeTitle] [nvarchar](50) NULL,
	[Department] [nvarchar](500) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[EmployeeNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_InformationAssistant] FOREIGN KEY([InfomationrAssistantId])
REFERENCES [dbo].[InformationAssistant] ([InformationAssistantId])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_InformationAssistant]
GO


