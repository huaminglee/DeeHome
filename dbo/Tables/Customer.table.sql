
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
	[AppointDateTime] [datetime] NULL,
	[ProviderType] [nvarchar](50) NULL,
	[CustomerType] [nvarchar](50) NULL,
	[Comments] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
)