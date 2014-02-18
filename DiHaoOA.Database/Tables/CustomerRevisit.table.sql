﻿CREATE TABLE [dbo].[CustomerRevisit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RevisitContent] [nvarchar](max) NULL,
	[RevisitDateTime] [datetime] NULL,
	[CustomerOrderId] [int] NULL,
 CONSTRAINT [PK_CustomerRevisit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[CustomerRevisit]  WITH CHECK ADD  CONSTRAINT [FK_CustomerRevisit_Customer] FOREIGN KEY([CustomerOrderId])
REFERENCES [dbo].[CustomerOrder] ([OrderId])
GO

ALTER TABLE [dbo].[CustomerRevisit] CHECK CONSTRAINT [FK_CustomerRevisit_Customer]
GO