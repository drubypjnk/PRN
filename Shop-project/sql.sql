USE [master]
GO
/****** Object:  Database [Shop_PRN]    Script Date: 13/7/2022 12:52:30 PM ******/
CREATE DATABASE [Shop_PRN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Shop_PRN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Shop_PRN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Shop_PRN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Shop_PRN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Shop_PRN] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Shop_PRN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Shop_PRN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Shop_PRN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Shop_PRN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Shop_PRN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Shop_PRN] SET ARITHABORT OFF 
GO
ALTER DATABASE [Shop_PRN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Shop_PRN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Shop_PRN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Shop_PRN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Shop_PRN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Shop_PRN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Shop_PRN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Shop_PRN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Shop_PRN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Shop_PRN] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Shop_PRN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Shop_PRN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Shop_PRN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Shop_PRN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Shop_PRN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Shop_PRN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Shop_PRN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Shop_PRN] SET RECOVERY FULL 
GO
ALTER DATABASE [Shop_PRN] SET  MULTI_USER 
GO
ALTER DATABASE [Shop_PRN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Shop_PRN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Shop_PRN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Shop_PRN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Shop_PRN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Shop_PRN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Shop_PRN', N'ON'
GO
ALTER DATABASE [Shop_PRN] SET QUERY_STORE = OFF
GO
USE [Shop_PRN]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 13/7/2022 12:52:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [varchar](100) NOT NULL,
	[password] [varchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[gender] [bit] NULL,
	[address] [varchar](50) NULL,
	[mobile] [varchar](11) NULL,
	[dob] [datetime] NULL,
	[avartar] [text] NULL,
	[email] [varchar](50) NULL,
	[City] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 13/7/2022 12:52:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [nvarchar](50) NULL,
	[images] [ntext] NULL,
 CONSTRAINT [PK__categori__D54EE9B433D61256] PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_details]    Script Date: 13/7/2022 12:52:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_details](
	[order_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[quantity] [int] NULL,
	[price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC,
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 13/7/2022 12:52:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](100) NULL,
	[order_date] [datetime] NULL,
	[require_date] [datetime] NULL,
	[shiped_date] [datetime] NULL,
	[freight] [money] NULL,
	[ship_name] [nvarchar](255) NULL,
	[ship_address] [nvarchar](255) NULL,
	[ship_gender] [bit] NULL,
	[ship_mobile] [varchar](50) NULL,
	[status] [int] NULL,
	[total_price] [money] NULL,
	[ship_city] [varchar](50) NULL,
 CONSTRAINT [PK__orders__4659622902362D3E] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 13/7/2022 12:52:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[category_id] [int] NULL,
	[product_name] [nvarchar](250) NULL,
	[brand] [nvarchar](250) NULL,
	[origin] [nvarchar](250) NULL,
	[thumbnail] [nvarchar](250) NULL,
	[describe] [ntext] NULL,
	[original_price] [money] NULL,
	[sale_price] [money] NULL,
	[unit_in_stock] [int] NULL,
	[unit_on_order] [int] NULL,
	[feature] [bit] NULL,
 CONSTRAINT [PK__product__47027DF58C7D188D] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Account] ([username], [password], [name], [gender], [address], [mobile], [dob], [avartar], [email], [City]) VALUES (N'dung', N'123', N'Bùi Anh Dũng', 1, N'45-An Duong-H?i Phòng', N'0783332391', CAST(N'2001-01-01T00:00:00.000' AS DateTime), N'', NULL, N'H?i Phòng')
GO
SET IDENTITY_INSERT [dbo].[categories] ON 

INSERT [dbo].[categories] ([category_id], [category_name], [images]) VALUES (1, N'Thời trang Nam', NULL)
INSERT [dbo].[categories] ([category_id], [category_name], [images]) VALUES (2, N'Thời trang nữ', NULL)
INSERT [dbo].[categories] ([category_id], [category_name], [images]) VALUES (3, N'Phụ Kiện', NULL)
SET IDENTITY_INSERT [dbo].[categories] OFF
GO
INSERT [dbo].[order_details] ([order_id], [product_id], [quantity], [price]) VALUES (61, 8, 2, 39.0000)
INSERT [dbo].[order_details] ([order_id], [product_id], [quantity], [price]) VALUES (62, 2, 2, 200000.0000)
INSERT [dbo].[order_details] ([order_id], [product_id], [quantity], [price]) VALUES (62, 5, 1, 99000.0000)
INSERT [dbo].[order_details] ([order_id], [product_id], [quantity], [price]) VALUES (62, 6, 3, 35000.0000)
INSERT [dbo].[order_details] ([order_id], [product_id], [quantity], [price]) VALUES (1006, 1, 1, 159000.0000)
INSERT [dbo].[order_details] ([order_id], [product_id], [quantity], [price]) VALUES (1007, 1, 1, 159000.0000)
INSERT [dbo].[order_details] ([order_id], [product_id], [quantity], [price]) VALUES (1008, 3, 1, 79000.0000)
INSERT [dbo].[order_details] ([order_id], [product_id], [quantity], [price]) VALUES (1009, 2, 1, 200000.0000)
INSERT [dbo].[order_details] ([order_id], [product_id], [quantity], [price]) VALUES (1010, 2, 1, 200000.0000)
INSERT [dbo].[order_details] ([order_id], [product_id], [quantity], [price]) VALUES (1010, 8, 1, 39000.0000)
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (50, N'dung', CAST(N'2022-07-13T04:40:07.133' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 200.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (51, N'dung', CAST(N'2022-07-13T04:40:09.133' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 200.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (52, N'dung', CAST(N'2022-07-13T04:40:20.350' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 200.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (53, N'dung', CAST(N'2022-07-13T04:42:10.420' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 83.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (54, N'dung', CAST(N'2022-07-13T04:43:19.577' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 238.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (55, N'dung', CAST(N'2022-07-13T04:44:16.910' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 239.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (58, N'dung', CAST(N'2022-07-13T04:57:53.327' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 79.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (59, N'dung', CAST(N'2022-07-13T04:58:04.997' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 79.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (60, N'dung', CAST(N'2022-07-13T04:59:02.587' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 159.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (61, N'dung', CAST(N'2022-07-13T04:59:44.543' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 78.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (62, N'dung', CAST(N'2022-07-13T05:06:31.517' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 604000.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (1006, N'dung', CAST(N'2022-07-13T11:17:30.463' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 159000.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (1007, N'dung', CAST(N'2022-07-13T11:17:28.483' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 159000.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (1008, N'dung', CAST(N'2022-07-13T12:44:37.163' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 79000.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (1009, N'dung', CAST(N'2022-07-13T12:46:57.950' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 200000.0000, N'H?i Phòng')
INSERT [dbo].[orders] ([order_id], [username], [order_date], [require_date], [shiped_date], [freight], [ship_name], [ship_address], [ship_gender], [ship_mobile], [status], [total_price], [ship_city]) VALUES (1010, N'dung', CAST(N'2022-07-13T12:48:59.670' AS DateTime), NULL, NULL, 0.0000, N'Bùi Anh Dũng,', N'Đại Học FPT', NULL, N'078332391', 1, 239000.0000, N'H?i Phòng')
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (1, 1, N'ÁO GIÓ 2 MẶT 2 LỚP - THOÁNG MÁT THÍCH HỢP CHO NAM NỮ', N'birdybag', N'Việt Nam', N'https://cf.shopee.vn/file/45ca7930256356bff2a2d3cbd9226549', N'HÔNG TIN SẢN PHẨM:
- Áo Gió 2 Mặt Uniplus với chất liệu Dù 2 lớp giữ ấm có cơ thể khi trời lạnh, vừa lại giúp bạn có thể chống nắng, chống bụi, chống gió, chống tia UV cực tốt và chống mưa (nhẹ), rất tiện lợi nhé!!!', 199000.0000, 159000.0000, 99, 101, NULL)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (2, 1, N'Áo sơ mi BIRDY Bandana', N'birdybag', N'Việt Nam', N'https://cf.shopee.vn/file/7d41c8e545fac98dda65a59b0838efc0', N'THÔNG TIN SẢN PHẨM:

- Chất liệu: Cotton

- Hoạ tiết: comic 

Size: S/M/L/XL

Fix : 45-95kg', 300000.0000, 200000.0000, 98, 202, 1)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (3, 1, N'Quần lót BOXER nam vải thun lụa Icy tự nhiên 100% thoáng khí,co giãn cao cấp - HAPPYHOW', N'
HappyHow', N'Việt Nam', N'https://cf.shopee.vn/file/5bb6c2bb91c4e031c591f269d523c50d', N'MÔ TẢ SẢN PHẨM
*Quần lót Boxer Nam HAPPYHOW rất được khách hàng ưa chuộng vì đây là mẫu mới xuất hiện tại Việt Nam, khi vừa xuất hiện nó đã làm mưa làm gió vì chất lượng mang tới đáp ứng yêu cầu khách hàng.', 99000.0000, 79000.0000, 99, 201, NULL)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (4, 1, N'Mũ lưỡi trai ❤️ Nón kết thêu chữ Memorie phong cách Ulzzang form unisex nam nữ N01', N'HP Fashion', N'Việt Nam', N'https://cf.shopee.vn/file/b2612c1a8242069aced2f2f26b592f38', N'Mũ lưỡi trai ❤️ Nón kết thêu chữ Memorie phong cách Ulzzang form unisex nam nữ N01

❤️ Chính sách CAM KẾT từ HP Fashion:
1. Hàng chính hãng HP - Bảo hành 3 năm tất cả sản phẩm, lỗi 1 đổi 1 theo chính sách HP Fashion.', 58000.0000, 35000.0000, 100, 200, NULL)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (5, 1, N'Áo thun Unisex N7 Basic Tee phông trơn nam nữ tay lỡ oversize form rộng 12 màu', N'Unisex', N'Việt Nam', N'https://cf.shopee.vn/file/1d33bcd9977a02c305fa241575bad7de', N'Thông tin sản phẩm Áo thun Unisex N7 Basic Tee phông trơn nam nữ tay lỡ oversize form rộng 12 màu:
- Hàng chuẩn N7 sản xuất, tem mác chuẩn chính hãng.
- Chất liệu: thun cotton 100%, co giãn 4 chiều, vải mềm, vải mịn, thoáng mát, không xù lông.
- Đường may chuẩn chỉnh, tỉ mỉ, chắc chắn.
- Mặc ở nhà, mặc đi chơi hoặc khi vận động thể thao. Phù hợp khi mix đồ với nhiều loại.
- Thiết kế hiện đại, trẻ trung, năng động. Dễ phối đồ', 145000.0000, 99000.0000, 100, 150, NULL)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (6, 2, N'Quần Black Funoff Short Biker Short Dáng Ngắn Nữ Nâng Mông Mùa Hè Năng Động', N'Unisex', N'Việt Nam', N'https://cf.shopee.vn/file/552a8e0c73bb5ae92c806bd8a53be101', N'Quần Black Funoff Short - Biker short Dáng Ngắn Nữ Nâng Mông Mùa Hè Năng Động
Tên hàng hóa: Quần Black Funoff Short - Biker short Dáng Ngắn Nữ Nâng Mông Mùa Hè Năng Động
Tên và địa chỉ của tổ chức/cá nhân chịu trách nhiệm về sản phẩm: Xưởng May Nam Anh
Xuất xứ của sản phẩm: Việt Nam
XƯỞNG MAY NAM ANH RA MẪU HOT THỂ THAO NĂNG ĐỘNG NÂNG MÔNG TÔN DÁNG 
🟠 Chiếc Funoff Short là phiên bản cải tiến đặc biệt của biker short 
🔹Vẫn là em quần siêu năng động và thoải mái khi đi gym, yoga, phối style quần áo. Nhưng ở bản cải tiến này chất vải thun gân dày dặn hơn. Quần ngắn hơn tạo sự năng động, khoẻ khoắn và có đôi chút sexy
👉 Size S, M, L
• S  eo 60 - 65 mông 82 - 86 dài 32cm  (40-46kg)
• M    eo 65 - 70 mông 87 - 92 dài 32cm (46-52kg)
• L   eo 71 - 75  mông 93 - 98 dài 32cm   (52-57kg)
• XL eo 76 - 80 mông 98 - 102 dài 33cm  (57-62kg)', 50000.0000, 35000.0000, 100, 278, NULL)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (7, 2, N'Quần short đũi_quần đùi đũi dáng váy siêu hot_m068', N'Unisex', N'Trung Quốc', N'https://cf.shopee.vn/file/0cd3b5012e56f4c964baad8168cceaf7', N'S:40-47kg
M:48-52kg
L:53-56kg
Xl : 56-61kg
Bảng size chỉ mang tính chất tương đối nếu eo mông to hoặc nhỏ thì tăng giảm size giúp shop nha❤️❤️❤️
Mùa hè mà mặc em đũi thì bao xinh và mát luôn ạ
Mặc nhẹ như k mặc mà rất thời trang khách nhé
Quần có 4 size S M L Xl
3 màu: đen trắng be ạ
#quần_đùi_đũi
#quần_đũi
#đùi
#quần_đùi
#short_đũi', 75000.0000, 44000.0000, 100, 190, NULL)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (8, 2, N'Quần short unisex_quần đùi đũi chun thêu siêu Hot', N'HP Fashion', N'Trung Quốc', N'https://cf.shopee.vn/file/9018013eab0004acb2b3381e69a14bec', N'Quần short unisex_quần đùi chun thêu siêu Hot

S:40-47kg
M:48-52kg
L:53-57kg
Bảng size chỉ mang tính chất tương đối nếu eo mông to hoặc nhỏ thì tăng giảm size giúp shop nha❤️❤️❤️
Mùa hè mà mặc em đũi thì bao xinh và mát luôn ạ
Mặc nhẹ như k mặc mà rất thời trang khách nhé
Quần có 3 size S M L
2 màu: đen trắng 
#quần_đùi_đũi
#quần_đũi
#đùi
#quần_đùi
#short_đũi
#quần_ống_rộng #quần #đũi
#quanshort #quanshortnu
#shortnu', 60000.0000, 39000.0000, 99, 929, NULL)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (9, 2, N'Quần legging nữ lửng Choobe vải thun cao cấp biker nữ đùi ngố đồ mặc nhà dáng ôm bó lưng thun tập gym yoga bigsize Q29', N'
HappyHow', N'Trung Quốc', N'https://cf.shopee.vn/file/426fb227f9c459ad8c38f92b00648bfc', N'Quần legging nữ lửng Choobe vải thun cao cấp biker nữ đùi ngố đồ mặc nhà dáng ôm bó lưng thun tập gym yoga bigsize Q29', 145000.0000, 79000.0000, 100, 289, NULL)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (10, 2, N'Chân váy tennis ngắn xếp ly thời trang nữ', N'birdybag', N'Trung Quốc', N'https://cf.shopee.vn/file/d7a52ae26880d2a8262627a6053d5958', N'➤➤➤Mô tả sản Phẩm➤➤➤ 
✪ Chất Liệu Vải : Vải tuyết mưa, không bai không xù , mềm mại 
✪ Kiểu Dáng : chân váy ngắn
✪ Sản Xuất : Sản xuất trực tiếp tại xưởng - hàng Việt Nam Xuất Khẩu 
✪ Size : S M L  
✪ Màu sắc : đen, trắng
➤➤➤Shop CAM KẾT➤➤➤ 
✔Về sản phẩm: Shop cam kết cả về CHẤT LIỆU cũng như HÌNH DÁNG ( đúng với những gì được nêu bật trong phần mô tả sản phẩm). 
✔Về giá cả : Shop sản xuất với số lượng nhiều và trực tiếp nên chi phí sẽ là RẺ NHẤT và CHẤT LƯỢNG nhất nhé
✔Về dịch vụ: Shop sẽ cố gắng trả lời hết những thắc mắc xoay quanh sản phẩm, bảo hành toàn bộ sản phẩm nha
✔Thời gian chuẩn bị hàng: Hàng có sẵn tại xưởng, Giao hàng tận nơi trên toàn quốc, Nhận hàng nhanh chóng tại nhà.
✔Shop luôn luôn cập nhật những mẫu mã mới , đa dạng', 65000.0000, 60000.0000, 100, 24, NULL)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (11, 2, N'Quần Short Nữ gập gấu siêu hot năng động phù hợp giới trẻ', N'birdybag', N'Trung Quốc', N'https://cf.shopee.vn/file/dc0be68641ee9e70262681f294449832', N'Quần Short Nữ gập gấu siêu hot năng động phù hợp giới trẻ_Combo tặng quà
Quần shorts siêu đẹp đang Hot hit thị trường ạ. 
Đầu năm mới shop em cho ra mắt mẫu siêu ưng luôn ạ... 
Chất tuyết mưa mặc tôn dáng 
Size S M L Xl
S dưới 45kg
M:45-49kg
L:50-54kg
Xl :55-58kg
——————————
QUẦN SHORTS NỮ
#quần_short_nữ #quanshorts #quanshort #short #shorts #quần_short #quần_shorts #quanshortnu #quandui #quanduidep #đùi #quần_đùi #capcao #shortcapcao #quần ', 90000.0000, 48000.0000, 100, 534, NULL)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (12, 2, N'Áo croptop Polo nữ tay ngắn form rộng MADELA 100% cotton , Croptop nữ cổ bẻ ngắn tay form rộng- ACTN01', N'birdybag', N'Trung Quốc', N'https://cf.shopee.vn/file/610511670592b59df9691e98b8904184', N'Áo croptop nữ có cổ polo tay ngắn MADELA, Croptop nữ kiểu cổ đức HOT TREND - ACTN01
#croptop #croptopnu #croptop_nu
#croptopkieu #croptop_kieu

CROPTOP loại có cổ (polo) chuẩn đẹp, mềm, mặc lên cực kỳ dễ chịu và thoải mái. Sản phẩm CROPTOP NỮ được MADELA tự sản xuất, đảm bảo chất lượng với giá thành rẻ nhất.

ÁO CROPTOP KIỂU ngắn tay có cổ này bạn có thể kết hợp với quần jean, quần ống rộng....đều rất đẹp và cá tính đó!

CROPTOP NỮ POLO NÀY CÓ Thông tin sản như sau:
- Tên sản phẩm: Croptop nữ Madela, Áo croptop kiểu tay ngắn có cổ
- Áo croptop nữ polo tay ngắng được may từ Vải Cotton Thun co giãn 4 chiều với 95% sợi cotton kết hợp 5% sợi Spandex cao cấp
- Áo croptop Madela có 4 mày Màu sắc để mình lựa chọn bao gồm: Đen, Trắng, Xanh và Tím

Thông số sản phẩm áo CROPTOP:
- Croptop  Size M: dưới 45kg
- Croptop  Size L: Từ 45-50kg
-Croptop  Size XL: từ 50-55kg', 70000.0000, 51000.0000, 100, NULL, NULL)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (13, 3, N'(PD 20W)(BH 12 tháng) Sạc Nhanh PD 20W USB-C To (Hỗ Trợ Công Suất Tối Đa IP12,13),Cáp Sạc Nhanh + Củ Sạc Nhanh', N'
airp.mall', N'Trung Quốc', N'https://cf.shopee.vn/file/d2e4f25c1a3d1cde8d817e89ceb46c01', N'Như Anh/Chị đã biết, khi mua IP 11 trở về trước, thì chỉ được tặng kèm bộ sạc 5V 1A (Công suất tối đa chỉ là 5W), 
Trong khi đó, công suất tối đa mà IP 6+,7+ có thể nhận được là 10W ; IP 8 đến IP 11 là 18W ; và IP 12 là 20W
👉 Đây chính là lý do tại sao Anh/Chị cảm thấy bộ sạc 5V 1A đi kèm lại sạc chậm thế

👉 Bộ sạc nhanh IP PD 20W đã giải quyết vấn đề này, Với công suất đầu ra rất lớn 20W
Ngoài ra, với công nghệ mới, bộ sạc PD còn có chất lượng và độ ổn định ,khả năng bảo vệ chống quá áp tốt!

👉 Bộ sạc PD 20W của Shop có chất lượng tốt. Shop bảo hành 12 tháng - Anh/Chị yên tâm dùng nhé

👉 Shop đang có chương trình bán không lợi nhuận lấy 5 sao trong thời gian ngắn - Mong quý khách hàng ủng hộ
Sản phẩm là shop tự chụp, nên chất lượng và kích thước đúng như ảnh nhé', 319000.0000, 200000.0000, 100, 252, NULL)
INSERT [dbo].[product] ([product_id], [category_id], [product_name], [brand], [origin], [thumbnail], [describe], [original_price], [sale_price], [unit_in_stock], [unit_on_order], [feature]) VALUES (14, 3, N'Dây Sạc IP Baseus - Cáp Sạc Nhanh 2.4A Cho IP5 / 6 / 7 / 8 Đến 13 Pro', N'Baseus', N'Trung Quốc', N'https://cf.shopee.vn/file/064806b0b9bf893b57f46cb4c5959aa4', N'ây Sạc IP Baseus - Cáp Sạc Nhanh 2.4A Cho IP5 / 6 / 7 / 8 Đến 13 Pro Max Dài 1m - 2m

THỜI GIAN GIAO HÀNG SIÊU TỐC ĐỘ:
- Đơn giao hỏa tốc: Thời gian từ 1- 2 giờ sau khi xác nhận đơn.
- Đơn giao bình thường: Thời gian từ 1 - 5 ngày sau khi xác nhận đơn.

THÔNG TIN SẢN PHẨM
- Chất liệu: TPE + Dây bện Nylon
- Chiều dài: 1m / 2m
- Đầu ra: 2.4A ( 1m ) & 1.5A ( 2m )
- Tốc độ truyền dữ liệu: 480Mbps
- Tương thích: Các thiết bị IP

TÍNH NĂNG
- Dây sạc IP Baseus hỗ trợ sạc và truyền dữ liệu đồng thời nhanh chóng, tiết kiệm thời gian
- Hỗ trợ sạc nhanh chuẩn 2.4A, truyền dữ liệu tốc độ lên đến 480Mbps
- Đầu cáp được gia cố SR cho khả năng chống uốn cong tốt
- Dây cáp được bọc vải dù siêu bền
- Tương thích với các thiết bị của Apple sử dụng cổng IP
', 129000.0000, 69000.0000, 100, 200, NULL)
SET IDENTITY_INSERT [dbo].[product] OFF
GO
ALTER TABLE [dbo].[order_details]  WITH CHECK ADD  CONSTRAINT [FK__order_det__order__49C3F6B7] FOREIGN KEY([order_id])
REFERENCES [dbo].[orders] ([order_id])
GO
ALTER TABLE [dbo].[order_details] CHECK CONSTRAINT [FK__order_det__order__49C3F6B7]
GO
ALTER TABLE [dbo].[order_details]  WITH CHECK ADD  CONSTRAINT [FK__order_det__produ__4AB81AF0] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([product_id])
GO
ALTER TABLE [dbo].[order_details] CHECK CONSTRAINT [FK__order_det__produ__4AB81AF0]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK__orders__username__4316F928] FOREIGN KEY([username])
REFERENCES [dbo].[Account] ([username])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK__orders__username__4316F928]
GO
USE [master]
GO
ALTER DATABASE [Shop_PRN] SET  READ_WRITE 
GO
