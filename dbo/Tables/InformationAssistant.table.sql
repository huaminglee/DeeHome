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
 CONSTRAINT [PK_InformationAssistant] PRIMARY KEY CLUSTERED 
(
	[InformationAssistantId] ASC
),
 CONSTRAINT [UQ__Informat__11075D341DE57479] UNIQUE NONCLUSTERED 
(
	[InformationAssistantName] ASC
),
 CONSTRAINT [UQ__Informat__85FB4E381B0907CE] UNIQUE NONCLUSTERED 
(
	[PhoneNumber] ASC
)
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[InformationAssistant]  WITH CHECK ADD  CONSTRAINT [FK_InformationAssistant_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO

ALTER TABLE [dbo].[InformationAssistant] CHECK CONSTRAINT [FK_InformationAssistant_Order]
GO

ALTER TABLE [dbo].[InformationAssistant]  WITH CHECK ADD  CONSTRAINT [ck_Level] CHECK  (([InformationLevel]='?' OR [InformationLevel]='?' OR [InformationLevel]='?' OR [InformationLevel]='?'))
GO

ALTER TABLE [dbo].[InformationAssistant] CHECK CONSTRAINT [ck_Level]
GO


