CREATE TABLE [dbo].[SecurityRoles](
	[Id] [int] NOT NULL,
	[Role] [nvarchar](50) NULL,
	[ActivitId] [int] NULL,
 CONSTRAINT [PK_SecurityRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SecurityRoles]  WITH CHECK ADD  CONSTRAINT [FK_SecurityRoles_SecurityActivities] FOREIGN KEY([ActivitId])
REFERENCES [dbo].[SecurityActivities] ([Id])
GO

ALTER TABLE [dbo].[SecurityRoles] CHECK CONSTRAINT [FK_SecurityRoles_SecurityActivities]
GO
