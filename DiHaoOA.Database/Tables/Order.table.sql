CREATE TABLE [dbo].[CustomerOrder](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[RecordDate] [datetime] NULL,
	[DesignerId] [nvarchar](50) NULL,
	[OrderStatus] [nvarchar](50) NULL,
	[CustomerId] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[AllocationDate] [datetime] NULL,
	[SubmittedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [Unique_Order] UNIQUE NONCLUSTERED 
(
	[OrderNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[CustomerOrder]  WITH CHECK ADD  CONSTRAINT [FK_CustomerOrder_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO

ALTER TABLE [dbo].[CustomerOrder] CHECK CONSTRAINT [FK_CustomerOrder_Customer]
GO

ALTER TABLE [dbo].[CustomerOrder]  WITH CHECK ADD  CONSTRAINT [FK_CustomerOrder_Employee] FOREIGN KEY([DesignerId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO

ALTER TABLE [dbo].[CustomerOrder] CHECK CONSTRAINT [FK_CustomerOrder_Employee]
GO
