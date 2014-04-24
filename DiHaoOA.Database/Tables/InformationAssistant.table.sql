CREATE TABLE [dbo].[InformationAssistant](
	[InformationAssistantId] [int] NOT NULL,
	[InformationAssistantName] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[Company] [nvarchar](500) NULL,
	[City] [nvarchar](50) NULL,
	[InformationLevel] [nvarchar](50) NULL,
	[ReVisitTime] [nvarchar](50) NULL,
	[OrderId] [int] NULL,
	[Address] [nvarchar](500) NULL,
	[ReVisistPeriod] [nvarchar](50) NULL,
	[IsVisit] [bit] NULL,
	[HandSet] [nvarchar](50) NULL,
	[EmployeeId] [nvarchar](50) NULL,
	[VisitDateTime] [datetime] NULL,
	[RecordDate] [datetime] NULL,
 CONSTRAINT [PK_InformationAssistant] PRIMARY KEY CLUSTERED 
(
	[InformationAssistantId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Informat__85FB4E381B0907CE] UNIQUE NONCLUSTERED 
(
	[PhoneNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[InformationAssistant]  WITH CHECK ADD  CONSTRAINT [FK_InformationAssistant_InformationAssistant] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO

ALTER TABLE [dbo].[InformationAssistant] CHECK CONSTRAINT [FK_InformationAssistant_InformationAssistant]
GO
