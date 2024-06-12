USE [PtthK22CNT4Lesson07Db]
GO
/****** Object:  Table [dbo].[PtthKhoa]    Script Date: 6/12/2024 2:44:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtthKhoa](
	[PtthMaKH] [nchar](10) NOT NULL,
	[PtthTenKh] [nvarchar](50) NULL,
	[PtthTrangthai] [bit] NULL,
 CONSTRAINT [PK_PtthKhoa] PRIMARY KEY CLUSTERED 
(
	[PtthMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PtthSinhVien]    Script Date: 6/12/2024 2:44:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtthSinhVien](
	[PtthMaSV] [nchar](10) NOT NULL,
	[PtthHoSV] [nvarchar](50) NULL,
	[PtthTenSV] [nvarchar](50) NULL,
	[PtthPhai] [bit] NULL,
	[PtthEmail] [nvarchar](50) NULL,
	[PtthPhone] [nvarchar](50) NULL,
	[PtthMaKH] [nchar](10) NULL,
	[PtthTrangthai] [bit] NULL,
 CONSTRAINT [PK_PtthSinhVien] PRIMARY KEY CLUSTERED 
(
	[PtthMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PtthSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_PtthSinhVien_PtthKhoa] FOREIGN KEY([PtthMaKH])
REFERENCES [dbo].[PtthKhoa] ([PtthMaKH])
GO
ALTER TABLE [dbo].[PtthSinhVien] CHECK CONSTRAINT [FK_PtthSinhVien_PtthKhoa]
GO
