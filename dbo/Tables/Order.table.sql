CREATE TABLE [dbo].[Order](
	[OrderId] [int] NOT NULL,
	[OrderNumber] [nvarchar](50) NULL,
	[RecordDate] [datetime] NULL,
	[InformationAssistantId] [int] NULL,
	[DesignerId] [int] NULL,
	[OrderStatus] [nvarchar](50) NULL,
	[CustomerId] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)
) 

GO

ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO

ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO


