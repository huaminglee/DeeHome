CREATE TABLE [dbo].[Employee](
	[EmployeeId] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Password] [nvarchar](50) NULL,
	[Department] [nvarchar](500) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[RoleId] [int] NULL,
	[IsActive] [bit] NULL,
	[GroupId] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Employee]  WITH NOCHECK ADD  CONSTRAINT [FK_Employee_SecurityRoles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[SecurityRoles] ([Id])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_SecurityRoles]
GO