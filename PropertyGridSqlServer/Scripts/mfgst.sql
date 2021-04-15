USE [master]
GO
/****** Object:  Database [mfgst]    Script Date: 4/15/2021 7:15:43 AM ******/
CREATE DATABASE [mfgst]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mfgst', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\mfgst.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mfgst_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\mfgst_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [mfgst] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mfgst].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mfgst] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mfgst] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mfgst] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mfgst] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mfgst] SET ARITHABORT OFF 
GO
ALTER DATABASE [mfgst] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mfgst] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mfgst] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mfgst] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mfgst] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mfgst] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mfgst] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mfgst] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mfgst] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mfgst] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mfgst] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mfgst] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mfgst] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mfgst] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mfgst] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mfgst] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mfgst] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mfgst] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [mfgst] SET  MULTI_USER 
GO
ALTER DATABASE [mfgst] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mfgst] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mfgst] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mfgst] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [mfgst] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [mfgst] SET QUERY_STORE = OFF
GO
USE [mfgst]
GO
/****** Object:  Table [dbo].[AppProperties]    Script Date: 4/15/2021 7:15:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppProperties](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Value] [varchar](max) NOT NULL,
 CONSTRAINT [PK_AppProperties_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AppProperties] ON 
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (1, N'_AllowNegativeStock', N'True')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (2, N'_BackgroundImage', N'..\..\Resources\chesskingbw.jpg')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (3, N'_bag_packet_qty', N'False')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (4, N'_BillDateEditable', N'True')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (5, N'_BillDateWithoutTime', N'True')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (6, N'_BillItemsOnOaItems', N'False')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (7, N'_Billno_OnSave', N'False')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (8, N'_CodeGroupInterVal', N'25')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (9, N'_CommonFilePath', N'\\192.168.100.3\erpfiles')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (10, N'_GRNno_OnSave', N'False')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (11, N'_IssueSlip_OnSave', N'False')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (12, N'_Mahindra_Ac', N'2-252')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (13, N'_mail_port', N'587')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (14, N'_mail_server', N'smtp.gmail.com')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (15, N'_MdiFixedImage', N'False')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (16, N'_MdiImage', N'..\..\Resources\ChesskingBW.jpg')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (17, N'_MdiImageLayout', N'Center')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (18, N'_MdiSlideTimer', N'10000')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (19, N'_OA_OnSave', N'False')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (20, N'_OC_OnSave', N'False')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (21, N'_Password', N'Mfpl@2021')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (22, N'_PdiIdentityKey', N'jaiho')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (23, N'_PosDefaultQty', N'1')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (24, N'_Purchase_OnGrn', N'False')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (25, N'_Purchase_po', N'True')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (26, N'_pvno_OnSave', N'False')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (27, N'_QcOnGrn', N'True')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (28, N'_s_cashgl', N'1')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (29, N'_s_creditorgl', N'3')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (30, N'_s_debtorgl', N'2')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (31, N'_s_drivergl', N'15')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (32, N'_SaleGrnLinq', N'Not_Applicable')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (33, N'_SalePackingDetailes', N'False')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (34, N'_SaleRateFromGRN', N'False')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (35, N'_SalesLinkedToProduction', N'Not_Applicable')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (36, N'_SeePastDataOf', N'Week')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (37, N'_ServerReportPath', N'http://server/reportserver')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (38, N'_SlideShowImageFolder', N'C:\Users\Sushil\Pictures')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (39, N'_UserName', N'API_MFPL')
GO
INSERT [dbo].[AppProperties] ([Id], [Name], [Value]) VALUES (40, N'_WeeklyOff', N'Sunday')
GO
SET IDENTITY_INSERT [dbo].[AppProperties] OFF
GO
USE [master]
GO
ALTER DATABASE [mfgst] SET  READ_WRITE 
GO
