USE [master]
GO
/****** Object:  Database [CafeShopDB]    Script Date: 10/18/2024 5:36:17 PM ******/
CREATE DATABASE [CafeShopDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CafeShopDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CafeShopDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CafeShopDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CafeShopDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CafeShopDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CafeShopDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CafeShopDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CafeShopDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CafeShopDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CafeShopDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CafeShopDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CafeShopDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CafeShopDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CafeShopDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CafeShopDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CafeShopDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CafeShopDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CafeShopDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CafeShopDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CafeShopDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CafeShopDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CafeShopDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CafeShopDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CafeShopDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CafeShopDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CafeShopDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CafeShopDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CafeShopDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CafeShopDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CafeShopDB] SET  MULTI_USER 
GO
ALTER DATABASE [CafeShopDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CafeShopDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CafeShopDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CafeShopDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CafeShopDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CafeShopDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CafeShopDB', N'ON'
GO
ALTER DATABASE [CafeShopDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [CafeShopDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CafeShopDB]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[BillDetailID] [int] IDENTITY(1,1) NOT NULL,
	[BillID] [int] NULL,
	[MenuID] [int] NULL,
	[Quantity] [int] NULL,
	[Price] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[BillDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckin] [datetime] NOT NULL,
	[DateCheckout] [datetime] NULL,
	[TableID] [int] NULL,
	[Discount] [int] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NULL,
	[Status] [bit] NULL,
	[Note] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoryLog]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoryLog](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[LogTable] [varchar](100) NOT NULL,
	[ObjectID] [int] NOT NULL,
	[Parameters] [varchar](500) NOT NULL,
	[LogAction] [varchar](100) NOT NULL,
	[UserID] [int] NOT NULL,
	[LogTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menus]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menus](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [nvarchar](100) NOT NULL,
	[Image] [varchar](500) NULL,
	[Description] [nvarchar](500) NULL,
	[Price] [bigint] NULL,
	[CategoryID] [int] NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[TableID] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](100) NULL,
	[BookingStatus] [bit] NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TableID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BillDetails] ON 

INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (4, 1, 1, 3, 50000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (6, 2, 1, 1, 50000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (7, 1, 3, 1, 35000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (8, 11, 7, 1, 40000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (9, 11, 6, 1, 25000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (10, 6, 5, 2, 25000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (11, 11, 7, 4, 40000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (12, 11, 5, 1, 25000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (13, 11, 5, 1, 25000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (14, 11, 3, 1, 35000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (15, 11, 5, 1, 25000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (16, 11, 6, 1, 25000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (17, 12, 7, 1, 40000)
INSERT [dbo].[BillDetails] ([BillDetailID], [BillID], [MenuID], [Quantity], [Price]) VALUES (18, 12, 3, 1, 35000)
SET IDENTITY_INSERT [dbo].[BillDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Bills] ON 

INSERT [dbo].[Bills] ([BillID], [DateCheckin], [DateCheckout], [TableID], [Discount], [UserID]) VALUES (1, CAST(N'2024-10-18T14:34:53.367' AS DateTime), NULL, 2, 0, 1)
INSERT [dbo].[Bills] ([BillID], [DateCheckin], [DateCheckout], [TableID], [Discount], [UserID]) VALUES (2, CAST(N'2024-10-18T15:47:49.877' AS DateTime), NULL, 4, 0, 1)
INSERT [dbo].[Bills] ([BillID], [DateCheckin], [DateCheckout], [TableID], [Discount], [UserID]) VALUES (6, CAST(N'2024-10-18T17:19:57.053' AS DateTime), NULL, 9, 0, 1)
INSERT [dbo].[Bills] ([BillID], [DateCheckin], [DateCheckout], [TableID], [Discount], [UserID]) VALUES (11, CAST(N'2024-10-18T17:28:18.730' AS DateTime), NULL, 11, 0, 1)
INSERT [dbo].[Bills] ([BillID], [DateCheckin], [DateCheckout], [TableID], [Discount], [UserID]) VALUES (12, CAST(N'2024-10-18T17:32:27.200' AS DateTime), NULL, 8, 0, 1)
SET IDENTITY_INSERT [dbo].[Bills] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Status], [Note]) VALUES (1, N'Sinh tố', 1, NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Status], [Note]) VALUES (2, N'Cafe', 1, NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Status], [Note]) VALUES (3, N'Trà', 1, NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Status], [Note]) VALUES (4, N'Nước ép', 1, NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Status], [Note]) VALUES (5, N'Sữa chua', 1, NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Status], [Note]) VALUES (6, N'Đồ uống đá xay (Blended Drinks)', 1, NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Status], [Note]) VALUES (7, N'Nước giải khát', 1, NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Status], [Note]) VALUES (8, N'Soda', 1, NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Status], [Note]) VALUES (9, N'Điểm tâm sáng', 1, NULL)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[HistoryLog] ON 

INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (1, N'Menus', 26, N'test params', N'INSERT', 1, NULL)
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (2, N'Menus', 27, N'test params', N'INSERT', 1, CAST(N'2024-10-14T15:18:11.763' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (3, N'Menus', 28, N'{"MenuID":0,"MenuName":"Sinh t\u1ED1 xo\u00E0i123","Description":"Smoothie made with mango123","Price":500000,"CategoryID":1,"CategoryName":null}', N'INSERT', 1, CAST(N'2024-10-14T16:30:38.777' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (4, N'Menus', 29, N'{"MenuID":0,"MenuName":"Sinh t\u1ED1 xo\u00E0i123","Description":"Smoothie made with mango123","Price":500000,"CategoryID":1,"CategoryName":null}', N'INSERT', 1, CAST(N'2024-10-14T16:31:45.313' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (5, N'Menus', 30, N'{"MenuID":0,"MenuName":"Sinh t\u1ED1 b\u01A1111","Description":"Smoothie made with avocado","Price":50000,"CategoryID":1,"CategoryName":null}', N'INSERT', 1, CAST(N'2024-10-14T16:32:55.487' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (6, N'Menus', 31, N'{"MenuID":0,"MenuName":"Sinh t\u1ED1 xo\u00E0i111","Description":"Smoothie made with mango","Price":50000,"CategoryID":1,"CategoryName":null}', N'INSERT', 1, CAST(N'2024-10-14T16:35:27.717' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (7, N'Menus', 32, N'{"MenuID":0,"MenuName":"12121","Description":"12121","Price":30000,"CategoryID":8,"CategoryName":null}', N'INSERT', 1, CAST(N'2024-10-14T16:39:19.073' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (8, N'Menus', 33, N'{"MenuID":0,"MenuName":"Tr\u00E0 \u0111en","Description":"Black tea","Price":25000,"CategoryID":3}', N'INSERT', 1, CAST(N'2024-10-14T17:07:18.183' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (9, N'Menus', 34, N'{"MenuID":0,"MenuName":"Tr\u00E0 \u0111en123","Description":"Black tea","Price":25000,"CategoryID":3}', N'INSERT', 1, CAST(N'2024-10-14T17:08:42.703' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (10, N'Menus', 34, N'{"MenuID":34}', N'DELETE', 1, CAST(N'2024-10-14T17:40:33.963' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (11, N'Menus', 33, N'{"MenuID":33}', N'DELETE', 1, CAST(N'2024-10-14T17:41:16.680' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (12, N'Menus', 32, N'{"MenuID":32}', N'DELETE', 1, CAST(N'2024-10-14T17:42:42.780' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (13, N'Menus', 31, N'{"MenuID":31}', N'DELETE', 1, CAST(N'2024-10-14T17:45:08.420' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (14, N'Menus', 30, N'{"MenuID":30}', N'DELETE', 1, CAST(N'2024-10-14T17:45:13.730' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (15, N'Menus', 29, N'{"MenuID":29}', N'DELETE', 1, CAST(N'2024-10-14T17:45:22.640' AS DateTime))
INSERT [dbo].[HistoryLog] ([LogID], [LogTable], [ObjectID], [Parameters], [LogAction], [UserID], [LogTime]) VALUES (16, N'Menus', 28, N'{"MenuID":28}', N'DELETE', 1, CAST(N'2024-10-14T17:45:29.213' AS DateTime))
SET IDENTITY_INSERT [dbo].[HistoryLog] OFF
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (1, N'Sinh tố bơ', N'', N'Smoothie made with avocado', 50000, 1, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (2, N'Sinh tố xoài', N'', N'Smoothie made with mango', 50000, 1, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (3, N'Cà phê sữa đá', N'', N'Vietnamese iced coffee with condensed milk', 35000, 2, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (4, N'Cà phê đen', N'', N'Black coffee', 30000, 2, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (5, N'Trà xanh', N'', N'Green tea', 25000, 3, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (6, N'Trà đen', N'', N'Black tea', 25000, 3, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (7, N'Nước ép cam', N'', N'Fresh orange juice', 40000, 4, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (8, N'Nước ép dứa', N'', N'Pineapple juice', 40000, 4, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (9, N'Sữa chua dâu', N'', N'Yogurt with strawberry', 35000, 5, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (10, N'Sữa chua việt quất', N'', N'Yogurt with blueberry', 35000, 5, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (11, N'Matcha đá xay', N'', N'Blended matcha drink', 45000, 6, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (12, N'Chocolate đá xay', N'', N'Blended chocolate drink', 45000, 6, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (13, N'Coca-Cola', N'', N'Chilled soft drink', 20000, 7, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (14, N'Sprite', N'', N'Chilled soft drink', 20000, 7, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (15, N'Soda chanh', N'', N'Lemon soda', 30000, 8, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (16, N'Soda việt quất', N'', N'Blueberry soda', 30000, 8, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (17, N'Bánh mì ốp la', N'', N'Vietnamese breakfast with bread and fried eggs', 35000, 9, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (18, N'Bánh mì pate', N'', N'Bread with pate', 35000, 9, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (19, N'Đồ uống mẫu', N'', N'', 121212, NULL, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (20, N'Sinh tố thử', N'', N'', 12121, NULL, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (21, N'Nước suối', N'', N'', 10000, NULL, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (22, N'Coca-Cola12121', N'', N'', 20000, NULL, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (23, N'Đồ uống đóng chai', N'', N'', 50000, NULL, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (24, N'Trà đen1', N'', N'', 25000, NULL, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (25, N'Trà xanh123', N'', N'', 25000, NULL, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (26, N'Thực đơn mới', N'', N'', 10000, 1, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (27, N'Thực đơn mới 2', N'', N'', 10000, 1, 1)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (28, N'Sinh tố xoài123', N'', N'Smoothie made with mango123', 500000, 1, 0)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (29, N'Sinh tố xoài123', N'', N'Smoothie made with mango123', 500000, 1, 0)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (30, N'Sinh tố bơ111', N'', N'Smoothie made with avocado', 50000, 1, 0)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (31, N'Sinh tố xoài111', N'', N'Smoothie made with mango', 50000, 1, 0)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (32, N'12121', N'', N'12121', 30000, 8, 0)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (33, N'Trà đen', N'', N'Black tea', 25000, 3, 0)
INSERT [dbo].[Menus] ([MenuID], [MenuName], [Image], [Description], [Price], [CategoryID], [Status]) VALUES (34, N'Trà đen123', N'', N'Black tea', 25000, 3, 0)
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[TableFood] ON 

INSERT [dbo].[TableFood] ([TableID], [TableName], [BookingStatus], [Status]) VALUES (1, N'Bàn 0', 0, 1)
INSERT [dbo].[TableFood] ([TableID], [TableName], [BookingStatus], [Status]) VALUES (2, N'Bàn 1', 1, 1)
INSERT [dbo].[TableFood] ([TableID], [TableName], [BookingStatus], [Status]) VALUES (3, N'Bàn 2', 0, 1)
INSERT [dbo].[TableFood] ([TableID], [TableName], [BookingStatus], [Status]) VALUES (4, N'Bàn 3', 1, 1)
INSERT [dbo].[TableFood] ([TableID], [TableName], [BookingStatus], [Status]) VALUES (5, N'Bàn 4', 0, 1)
INSERT [dbo].[TableFood] ([TableID], [TableName], [BookingStatus], [Status]) VALUES (6, N'Bàn 5', 0, 1)
INSERT [dbo].[TableFood] ([TableID], [TableName], [BookingStatus], [Status]) VALUES (7, N'Bàn 6', 0, 1)
INSERT [dbo].[TableFood] ([TableID], [TableName], [BookingStatus], [Status]) VALUES (8, N'Bàn 7', 1, 1)
INSERT [dbo].[TableFood] ([TableID], [TableName], [BookingStatus], [Status]) VALUES (9, N'Bàn 8', 0, 1)
INSERT [dbo].[TableFood] ([TableID], [TableName], [BookingStatus], [Status]) VALUES (10, N'Bàn 9', 0, 1)
INSERT [dbo].[TableFood] ([TableID], [TableName], [BookingStatus], [Status]) VALUES (11, N'Bàn 10', 1, 1)
SET IDENTITY_INSERT [dbo].[TableFood] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [UserName], [Password], [FullName]) VALUES (1, N'admin', N'$2a$11$YqRzm9BfP1FTTKNgtBUPQO9c.oguPmwzm3Q7gTUJObrPpZW4zPbsK', N'Người quản trị')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Categori__8517B2E0B403E789]    Script Date: 10/18/2024 5:36:17 PM ******/
ALTER TABLE [dbo].[Categories] ADD UNIQUE NONCLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BillDetails] ADD  DEFAULT ((1)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Bills] ADD  DEFAULT (getdate()) FOR [DateCheckin]
GO
ALTER TABLE [dbo].[Bills] ADD  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[Categories] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[HistoryLog] ADD  DEFAULT (getdate()) FOR [LogTime]
GO
ALTER TABLE [dbo].[Menus] ADD  DEFAULT ('') FOR [Image]
GO
ALTER TABLE [dbo].[Menus] ADD  DEFAULT ('') FOR [Description]
GO
ALTER TABLE [dbo].[Menus] ADD  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[Menus] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT ((0)) FOR [BookingStatus]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD FOREIGN KEY([BillID])
REFERENCES [dbo].[Bills] ([BillID])
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD FOREIGN KEY([MenuID])
REFERENCES [dbo].[Menus] ([MenuID])
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD FOREIGN KEY([TableID])
REFERENCES [dbo].[TableFood] ([TableID])
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Menus]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
/****** Object:  StoredProcedure [dbo].[GetUnCheckBillIDByTableID]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetUnCheckBillIDByTableID]
@TableID INT
AS
	SELECT BillID FROM dbo.Bills WHERE TableID = @TableID AND DateCheckout IS NULL

GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteMenu]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DeleteMenu]
	@MenuID INT,
	@UserID INT,
	@Paramerters VARCHAR(500)
AS
BEGIN
	UPDATE Menus
	SET Status = 0
	WHERE MenuID = @MenuID

	INSERT INTO HistoryLog(LogTable, ObjectID, Parameters, LogAction, UserID)
	VALUES('Menus', @MenuID, @Paramerters, 'DELETE', @UserID)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetCategories]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetCategories]
AS
BEGIN
    SELECT CategoryID, CategoryName, Note
    FROM Categories
	WHERE Status = 1
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_GetListTempBillByTableID]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GetListTempBillByTableID]
@TableID INT
AS
	SELECT m.MenuName, bd.Price, bd.Quantity, bd.Price * bd.Quantity AS TotalPrice
	FROM dbo.BillDetails bd, dbo.Bills b, Menus m
	WHERE b.BillID = bd.BillID AND bd.MenuID = m.MenuID AND DateCheckout IS NULL AND b.TableID = @TableID

GO
/****** Object:  StoredProcedure [dbo].[SP_GetMenuByCategoryID]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GetMenuByCategoryID]
@CategoryID INT
as
begin
	SELECT MenuID, MenuName, Price
	FROM Menus
	WHERE Status = 1 and CategoryID = @CategoryID
end
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertBill]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_InsertBill]
@TableID INT,
@MenuID INT,
@Quantity INT,
@Price BIGINT,
@UserID INT
AS
BEGIN TRAN TRXN_InsertBill
BEGIN TRY
	DECLARE @BillID INT
	INSERT dbo.Bills(TableID, UserID) VALUES (@TableID, @UserID)

	SET @BillID = @@IDENTITY;

	INSERT into BillDetails (BillID, MenuID, Quantity, Price) VALUES (@BillID, @MenuID, @Quantity, @Price)
	COMMIT TRAN TRXN_InsertBill
END TRY
BEGIN CATCH
	ROLLBACK TRAN TRXN_InsertBill
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertBillDetail]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_InsertBillDetail]
@BillID int, 
@MenuID int,
@Quantity int,
@Price bigint
as
begin
	SET NOCOUNT ON;
	declare @IsExistBillInfo int
	declare @CurrentQuantity int
	declare @CurrentPrice int

	select @IsExistBillInfo = BillDetailID, @CurrentQuantity = Quantity, @CurrentPrice = Price
	from BillDetails
	where BillID = @BillID and MenuID = @MenuID and Price = @Price

	if (@IsExistBillInfo > 0 and @CurrentPrice = @Price)
	begin 
		declare @NewQuantity int = @CurrentQuantity + @Quantity
		PRINT @NewQuantity
		IF (@NewQuantity > 0)
			update BillDetails 
			set Quantity = @NewQuantity
			where MenuID = @MenuID and BillDetailID = @IsExistBillInfo
		ELSE IF (@NewQuantity <= 0)
			delete BillDetails where BillID = @BillID and MenuID = @MenuID and BillDetailID = @IsExistBillInfo
	end
	else
		IF (@Quantity > 0) 
		BEGIN
			INSERT into BillDetails (BillID, MenuID, Price, Quantity) VALUES (@BillID, @MenuID, @Price, @Quantity)
		END
end
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertMenu]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_InsertMenu]
	@MenuName NVARCHAR(100),
	@Description NVARCHAR(500),
	@Price bigint,
	@CategoryID INT,
	@UserID INT,
	@Paramerters VARCHAR(500)
AS
BEGIN
	DECLARE @MenuID INT
	INSERT INTO Menus(MenuName, Description, Price, CategoryID)
	VALUES(@MenuName, @Description, @Price, @CategoryID)
	
	SET @MenuID = SCOPE_IDENTITY()

	INSERT INTO HistoryLog(LogTable, ObjectID, Parameters, LogAction, UserID)
	VALUES('Menus', @MenuID, @Paramerters, 'INSERT', @UserID)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Login]
@UserName NVARCHAR(50)
as
begin
	SELECT UserID, UserName, Password, FullName
	FROM Users
	WHERE UserName = @UserName
end
GO
/****** Object:  StoredProcedure [dbo].[SP_MenuSearch]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MenuSearch]
@MenuName nvarchar(100)
AS
BEGIN
	SELECT m.MenuID, m.MenuName, m.Description, m.Price, c.CategoryID, c.CategoryName
	FROM Menus m
	LEFT JOIN Categories c ON m.CategoryID = c.CategoryID
	WHERE m.Status = 1
	AND (@MenuName IS NULL OR m.MenuName LIKE '%' + @MenuName + '%')
	ORDER BY m.MenuID DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MergeTable]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MergeTable]
@TableID1 INT, @TableID2 INT
AS
	BEGIN
    DECLARE @UnCheckBillID1 INT = -1;
    DECLARE @UnCheckBillID2 INT = -1;

    SELECT @UnCheckBillID1 = BillID FROM Bills WHERE TableID = @TableID1 AND DateCheckout IS NULL;
    SELECT @UnCheckBillID2 = BillID FROM Bills WHERE TableID = @TableID2 AND DateCheckout IS NULL;

    IF (@UnCheckBillID1 != -1 AND @UnCheckBillID2 != -1)
    BEGIN
        UPDATE BillDetails SET BillID = @UnCheckBillID2 WHERE BillID = @UnCheckBillID1;

        DELETE FROM Bills WHERE BillID = @UnCheckBillID1;

        UPDATE TableFood SET BookingStatus = 0 WHERE TableID = @TableID1;
    END
    ELSE
    BEGIN
        RAISERROR('One or both tables do not have open bills.', 16, 1);
    END
END

GO
/****** Object:  StoredProcedure [dbo].[SP_SwitchTable]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SwitchTable]
@TableID1 INT, @TableID2 INT
AS
BEGIN
	DECLARE @isTable1Null INT = 0
	DECLARE @isTable2Null INT = 0
	SELECT @isTable1Null = BillID FROM Bills WHERE TableID = @TableID1 AND DateCheckout IS NULL
	SELECT @isTable2Null = BillID FROM Bills WHERE TableID = @TableID2 AND DateCheckout IS NULL

	IF (@isTable1Null = 0 AND @isTable2Null > 0)
		BEGIN
			UPDATE dbo.Bills 
			SET TableID = @TableID1 
			WHERE TableID = @isTable2Null

			UPDATE dbo.TableFood 
			SET BookingStatus = 1 
			WHERE TableID = @TableID1

			UPDATE dbo.TableFood 
			SET BookingStatus = 0
			WHERE TableID = @TableID2
        END
	ELSE IF (@isTable1Null > 0 AND @isTable2Null = 0)
		BEGIN
			UPDATE Bills
			SET TableID = @TableID2 
			WHERE BillID = @isTable1Null

			UPDATE TableFood
			SET BookingStatus = 1
			WHERE TableID = @TableID2

			UPDATE TableFood
			SET BookingStatus = 0
			WHERE TableID = @TableID1
        END
    ELSE IF (@isTable1Null > 0 AND @isTable2Null > 0)
		BEGIN
			UPDATE Bills 
			SET TableID = @TableID2 
			WHERE BillID = @isTable1Null

			UPDATE Bills 
			SET TableID = @TableID1 
			WHERE BillID = @isTable2Null
        END
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateMenu]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UpdateMenu]
	@MenuID INT,
	@MenuName NVARCHAR(100),
	@Description NVARCHAR(500),
	@Price bigint,
	@CategoryID INT,
	@UserID INT,
	@Paramerters VARCHAR(500)
AS
BEGIN
	UPDATE Menus
	SET MenuName = @MenuName,
		Description = @Description,
		Price = @Price,
		CategoryID = @CategoryID
	WHERE MenuID = @MenuID

	INSERT INTO HistoryLog(LogTable, ObjectID, Parameters, LogAction, UserID)
	VALUES('Menus', @MenuID, @Paramerters, 'UPDATE', @UserID)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UserSearch]    Script Date: 10/18/2024 5:36:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UserSearch] 
	@Name nvarchar(100) = ''
AS

BEGIN
	SELECT UserID, UserName, FullName
	FROM Users
	WHERE UserName LIKE '%' + @Name + '%' or FullName LIKE N'%' + @Name + '%'
END
GO
USE [master]
GO
ALTER DATABASE [CafeShopDB] SET  READ_WRITE 
GO
