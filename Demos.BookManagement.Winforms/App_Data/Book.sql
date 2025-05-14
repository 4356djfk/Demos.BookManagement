

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Title] [nvarchar](100) NOT NULL,
	[Author] [nvarchar](100) NOT NULL,
	[Press] [nvarchar](100) NOT NULL,
	[Isbn] [nvarchar](20) NOT NULL,
	[Price] [float] NOT NULL,
)

GO

SET IDENTITY_INSERT [dbo].[Book] ON
GO
INSERT [dbo].[Book] ([Id], [Title], [Author], [Press], [Isbn], [Price]) VALUES (1, N'原子核物理', N'卢希庭', N'原子能出版社', N'9787502221881', 48)
GO
INSERT [dbo].[Book] ([Id], [Title], [Author], [Press], [Isbn], [Price]) VALUES (2, N'ASP.NET MVC框架揭秘', N'蒋金楠', N'电子工业出版社', N'9787121190490', 89)
GO
INSERT [dbo].[Book] ([Id], [Title], [Author], [Press], [Isbn], [Price]) VALUES (3, N'Microsoft.Silverlight.5.Data.and.Services.Cookbook', N'Gill Cleeren, Kevin Dockx', N'Packt', N'9781849683500', 53.99)
GO
SET IDENTITY_INSERT [dbo].[Book] OFF
GO

