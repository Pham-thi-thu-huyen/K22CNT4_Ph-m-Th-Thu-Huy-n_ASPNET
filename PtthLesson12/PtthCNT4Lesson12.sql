USE [PhamThiThuHuyen_2210900030]
GO
/****** Object:  Table [dbo].[Ptth_MaSach]    Script Date: 7/11/2024 10:24:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ptth_MaSach](
	[Ptth_MaSach] [nchar](10) NOT NULL,
	[Ptth_TenSach] [nvarchar](50) NULL,
	[Ptth_Sotrang] [int] NULL,
	[Ptth_NamXB] [int] NULL,
	[Ptth_MaTG] [nchar](10) NULL,
	[Ptth_TrangThai] [bit] NULL,
 CONSTRAINT [PK_Ptth_MaSach] PRIMARY KEY CLUSTERED 
(
	[Ptth_MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ptth_MaTG]    Script Date: 7/11/2024 10:24:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ptth_MaTG](
	[Ptth_MaTG] [nchar](10) NOT NULL,
	[Ptth_TenTG] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ptth_MaTG] PRIMARY KEY CLUSTERED 
(
	[Ptth_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ptth_MaSach] ([Ptth_MaSach], [Ptth_TenSach], [Ptth_Sotrang], [Ptth_NamXB], [Ptth_MaTG], [Ptth_TrangThai]) VALUES (N'S001      ', N'Phạm Thị Thu Huyền', 20, 2004, N'TG001     ', 1)
INSERT [dbo].[Ptth_MaSach] ([Ptth_MaSach], [Ptth_TenSach], [Ptth_Sotrang], [Ptth_NamXB], [Ptth_MaTG], [Ptth_TrangThai]) VALUES (N'S002      ', N'Nguyễn Thị Trà Mi', 24, 2004, N'Tg002     ', 1)
GO
INSERT [dbo].[Ptth_MaTG] ([Ptth_MaTG], [Ptth_TenTG]) VALUES (N'TG001     ', N'Phạm Thị Thu Huyền')
INSERT [dbo].[Ptth_MaTG] ([Ptth_MaTG], [Ptth_TenTG]) VALUES (N'TG002     ', N'Nguyễn Thị Trà Mi')
GO
