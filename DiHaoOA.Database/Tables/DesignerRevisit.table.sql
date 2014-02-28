CREATE TABLE [dbo].[DesigerRevisit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RevisitContent] [nvarchar](max) NULL,
	[RevisitDateTime] [datetime] NULL,
	[OrderId] [int] NULL,
 CONSTRAINT [PK_DesigerRevisit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[DesigerRevisit]  WITH CHECK ADD  CONSTRAINT [FK_DesigerRevisit_CustomerOrder1] FOREIGN KEY([OrderId])
REFERENCES [dbo].[CustomerOrder] ([OrderId])
GO

ALTER TABLE [dbo].[DesigerRevisit] CHECK CONSTRAINT [FK_DesigerRevisit_CustomerOrder1]
GO