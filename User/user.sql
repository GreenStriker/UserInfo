USE [user]
GO
/****** Object:  Table [dbo].[District]    Script Date: 7/15/2019 9:27:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[District](
	[DistrictId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DivitionId] [int] NOT NULL,
 CONSTRAINT [PK_District] PRIMARY KEY CLUSTERED 
(
	[DistrictId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Divition]    Script Date: 7/15/2019 9:27:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Divition](
	[DivitionId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Divition] PRIMARY KEY CLUSTERED 
(
	[DivitionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 7/15/2019 9:27:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FristName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Mobile] [int] NOT NULL,
	[GenderId] [int] NOT NULL,
	[DivitionId] [int] NOT NULL,
	[DistrictId] [int] NOT NULL,
	[PresentAddress] [nvarchar](500) NOT NULL,
	[LastEducationalQulification] [nvarchar](500) NOT NULL,
	[Occupation] [nvarchar](500) NOT NULL,
	[DateOFBirth] [datetime] NOT NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[District] ON 

INSERT [dbo].[District] ([DistrictId], [Name], [DivitionId]) VALUES (10, N'kushtia', 9)
INSERT [dbo].[District] ([DistrictId], [Name], [DivitionId]) VALUES (11, N'canada', 9)
INSERT [dbo].[District] ([DistrictId], [Name], [DivitionId]) VALUES (12, N'reza', 10)
INSERT [dbo].[District] ([DistrictId], [Name], [DivitionId]) VALUES (13, N'Rangpur', 10)
INSERT [dbo].[District] ([DistrictId], [Name], [DivitionId]) VALUES (14, N'Dinajpur', 10)
INSERT [dbo].[District] ([DistrictId], [Name], [DivitionId]) VALUES (15, N'Rajshahi', 11)
INSERT [dbo].[District] ([DistrictId], [Name], [DivitionId]) VALUES (16, N'nator', 11)
INSERT [dbo].[District] ([DistrictId], [Name], [DivitionId]) VALUES (17, N'chapai', 11)
SET IDENTITY_INSERT [dbo].[District] OFF
SET IDENTITY_INSERT [dbo].[Divition] ON 

INSERT [dbo].[Divition] ([DivitionId], [Name]) VALUES (9, N'Dhaka')
INSERT [dbo].[Divition] ([DivitionId], [Name]) VALUES (10, N'Rangpur')
INSERT [dbo].[Divition] ([DivitionId], [Name]) VALUES (11, N'Rajshahi')
SET IDENTITY_INSERT [dbo].[Divition] OFF
SET IDENTITY_INSERT [dbo].[UserInfo] ON 

INSERT [dbo].[UserInfo] ([UserId], [FristName], [LastName], [UserName], [Email], [Mobile], [GenderId], [DivitionId], [DistrictId], [PresentAddress], [LastEducationalQulification], [Occupation], [DateOFBirth]) VALUES (2, N'Md', N'Rahman', N'Moukh', N'moukh@gmail.com', 1990648999, 1, 9, 10, N'dfsdfsdfd', N'dsfsdfdsfsdf', N'dfdfsdfdsf', CAST(N'2012-12-12T00:00:00.000' AS DateTime))
INSERT [dbo].[UserInfo] ([UserId], [FristName], [LastName], [UserName], [Email], [Mobile], [GenderId], [DivitionId], [DistrictId], [PresentAddress], [LastEducationalQulification], [Occupation], [DateOFBirth]) VALUES (12, N'moukh', N'ksdkasdksa', N'sdsdsd', N'mustafiz.rahman1645@bracits.com', 0, 0, 9, 10, N'sdsdsd', N'asdass', N'sasasas', CAST(N'2012-12-12T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[UserInfo] OFF
ALTER TABLE [dbo].[District]  WITH CHECK ADD  CONSTRAINT [FK_District_Divition] FOREIGN KEY([DivitionId])
REFERENCES [dbo].[Divition] ([DivitionId])
GO
ALTER TABLE [dbo].[District] CHECK CONSTRAINT [FK_District_Divition]
GO
ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_District] FOREIGN KEY([DistrictId])
REFERENCES [dbo].[District] ([DistrictId])
GO
ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_District]
GO
ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_Divition] FOREIGN KEY([DivitionId])
REFERENCES [dbo].[Divition] ([DivitionId])
GO
ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_Divition]
GO
