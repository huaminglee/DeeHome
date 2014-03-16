CREATE TABLE [dbo].[Revisit](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RevisitContent] [nvarchar](max) NULL,
	[RevisitDateTime] [datetime] NULL,
	[InformationAssistantId] [int] NULL,
 CONSTRAINT [PK_Revisit] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Revisit]  WITH CHECK ADD  CONSTRAINT [FK_Revisit_InformationAssistant] FOREIGN KEY([InformationAssistantId])
REFERENCES [dbo].[InformationAssistant] ([InformationAssistantId])
GO

ALTER TABLE [dbo].[Revisit] CHECK CONSTRAINT [FK_Revisit_InformationAssistant]
GO
