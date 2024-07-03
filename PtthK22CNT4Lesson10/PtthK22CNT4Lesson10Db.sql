USE [PtthK22CNT4Lesson10]
GO
/****** Object:  Table [dbo].[PtthAccount]    Script Date: 7/3/2024 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtthAccount](
	[PtthID] [int] IDENTITY(1,1) NOT NULL,
	[PtthUserName] [nvarchar](50) NULL,
	[PtthPassword] [nvarchar](50) NULL,
	[PtthFullName] [nvarchar](50) NULL,
	[PtthEmail] [nvarchar](50) NULL,
	[PtthPhone] [nvarchar](50) NULL,
	[PtthActive] [bit] NULL,
 CONSTRAINT [PK_PtthAccount] PRIMARY KEY CLUSTERED 
(
	[PtthID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PtthAccount] ON 

INSERT [dbo].[PtthAccount] ([PtthID], [PtthUserName], [PtthPassword], [PtthFullName], [PtthEmail], [PtthPhone], [PtthActive]) VALUES (1, N'HuyenPham', N'12345@', N'Phạm Thị Thu Huyền', N'huyenphamthithu1202@gmail.com', N'0343649641', 1)
SET IDENTITY_INSERT [dbo].[PtthAccount] OFF
GO
