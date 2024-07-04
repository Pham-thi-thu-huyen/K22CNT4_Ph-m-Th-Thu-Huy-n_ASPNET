USE [PtthK22CNT4Lesson11Db]
GO
/****** Object:  Table [dbo].[PtthCategory]    Script Date: 7/4/2024 11:11:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtthCategory](
	[PtthID] [int] NOT NULL,
	[PtthCateName] [nvarchar](50) NULL,
	[PtthStatus] [bit] NULL,
 CONSTRAINT [PK_PtthCategory] PRIMARY KEY CLUSTERED 
(
	[PtthID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PtthProduct]    Script Date: 7/4/2024 11:11:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtthProduct](
	[Ptthid2210900030] [nvarchar](50) NOT NULL,
	[PtthProName] [nvarchar](50) NULL,
	[PtthQty] [int] NULL,
	[PtthPrice] [float] NULL,
	[PtthCateId] [int] NULL,
	[PtthActive] [bit] NULL,
 CONSTRAINT [PK_PtthProduct] PRIMARY KEY CLUSTERED 
(
	[Ptthid2210900030] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PtthCategory] ([PtthID], [PtthCateName], [PtthStatus]) VALUES (1, N'2210900030', 1)
INSERT [dbo].[PtthCategory] ([PtthID], [PtthCateName], [PtthStatus]) VALUES (2, N'Iphone', 0)
GO
INSERT [dbo].[PtthProduct] ([Ptthid2210900030], [PtthProName], [PtthQty], [PtthPrice], [PtthCateId], [PtthActive]) VALUES (N'2210900030', N'Phạm Thị Thu Huyền', 1, 5000000, 1, 1)
INSERT [dbo].[PtthProduct] ([Ptthid2210900030], [PtthProName], [PtthQty], [PtthPrice], [PtthCateId], [PtthActive]) VALUES (N'P001', N'Iphone 15Pro', 1, 20000, 1, 1)
GO
