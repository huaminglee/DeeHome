CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] NOT NULL,
	[CompanyName] [nvarchar](500) NULL,
	[ContactPerson] [nvarchar](50) NULL,
	[ContactPersonNumber] [nvarchar](50) NULL,
	[ContactPerson2] [nvarchar](50) NULL,
	[ContactPerson2Number] [nvarchar](50) NULL,
	[ContactPerson3] [nvarchar](50) NULL,
	[ContactPerson3Number] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[UsableArea] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[DecorationAddress] [nvarchar](500) NULL,
	[RidePath] [nvarchar](500) NULL,
	[AppointDateTime] [nvarchar](500) NULL,
	[ProviderType] [nvarchar](50) NULL,
	[CustomerType] [nvarchar](50) NULL,
	[Comments] [nvarchar](max) NULL,
	[InformationAssistantId] [int] NULL,
	[EmployeeId] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO

ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_Employee]
GO

ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_InformationAssistant] FOREIGN KEY([InformationAssistantId])
REFERENCES [dbo].[InformationAssistant] ([InformationAssistantId])
GO

ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_InformationAssistant]
GO