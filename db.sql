USE [master]
GO
/****** Object:  Database [BizCraft]    Script Date: 1/17/2020 5:20:30 PM ******/
CREATE DATABASE [BizCraft]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BizCraft', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BizCraft.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BizCraft_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BizCraft_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BizCraft] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BizCraft].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BizCraft] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BizCraft] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BizCraft] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BizCraft] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BizCraft] SET ARITHABORT OFF 
GO
ALTER DATABASE [BizCraft] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BizCraft] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BizCraft] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BizCraft] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BizCraft] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BizCraft] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BizCraft] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BizCraft] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BizCraft] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BizCraft] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BizCraft] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BizCraft] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BizCraft] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BizCraft] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BizCraft] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BizCraft] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [BizCraft] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BizCraft] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BizCraft] SET  MULTI_USER 
GO
ALTER DATABASE [BizCraft] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BizCraft] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BizCraft] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BizCraft] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BizCraft] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BizCraft] SET QUERY_STORE = OFF
GO
USE [BizCraft]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1/17/2020 5:20:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 1/17/2020 5:20:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 1/17/2020 5:20:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](300) NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 1/17/2020 5:20:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](300) NULL,
	[Fullname] [nvarchar](100) NOT NULL,
	[Position] [nvarchar](100) NOT NULL,
	[Facelogo] [nvarchar](150) NOT NULL,
	[Twitlogo] [nvarchar](150) NOT NULL,
	[Googlogo] [nvarchar](150) NOT NULL,
	[Linkelogo] [nvarchar](150) NOT NULL,
	[Otherlogo] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Teams] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191020125743_initial', N'2.1.4-rtm-31024')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191020134215_secondary', N'2.1.4-rtm-31024')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191020134513_secondary2', N'2.1.4-rtm-31024')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191023122514_ProductAndCategory', N'2.1.4-rtm-31024')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191023131317_ModifiedProductAndCategory', N'2.1.4-rtm-31024')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191024104527_NextProductAndCategory', N'2.1.4-rtm-31024')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Web Design')
GO
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Development')
GO
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Joomla')
GO
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Worldpress')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([Id], [Image], [CreatedAt], [CategoryId], [Name]) VALUES (1, N'bs.jpg', CAST(N'2019-10-24T14:45:27.0590000' AS DateTime2), 1, N'Startup Business')
GO
INSERT [dbo].[Products] ([Id], [Image], [CreatedAt], [CategoryId], [Name]) VALUES (2, N'bs2.jpg', CAST(N'2019-10-24T14:45:27.0600000' AS DateTime2), 1, N'Easy to Launch')
GO
INSERT [dbo].[Products] ([Id], [Image], [CreatedAt], [CategoryId], [Name]) VALUES (3, N'bs.jpg', CAST(N'2019-10-24T14:45:27.0600000' AS DateTime2), 1, N'Your Business')
GO
INSERT [dbo].[Products] ([Id], [Image], [CreatedAt], [CategoryId], [Name]) VALUES (4, N'gd.jpg', CAST(N'2019-10-24T14:45:27.0600000' AS DateTime2), 1, N'Prego Match')
GO
INSERT [dbo].[Products] ([Id], [Image], [CreatedAt], [CategoryId], [Name]) VALUES (5, N'gd2.jpg', CAST(N'2019-10-24T14:45:27.0600000' AS DateTime2), 1, N'Fashion Brand')
GO
INSERT [dbo].[Products] ([Id], [Image], [CreatedAt], [CategoryId], [Name]) VALUES (6, N'wd.jpg', CAST(N'2019-10-24T14:45:27.0600000' AS DateTime2), 1, N'The Insidage')
GO
INSERT [dbo].[Products] ([Id], [Image], [CreatedAt], [CategoryId], [Name]) VALUES (7, N'wd2.jpg', CAST(N'2019-10-24T14:45:27.0600000' AS DateTime2), 1, N'Light Carpet')
GO
INSERT [dbo].[Products] ([Id], [Image], [CreatedAt], [CategoryId], [Name]) VALUES (8, N'wd3.jpg', CAST(N'2019-10-24T14:45:27.0600000' AS DateTime2), 1, N'Amazing Keyboard')
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 
GO
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Facelogo], [Twitlogo], [Googlogo], [Linkelogo], [Otherlogo]) VALUES (1, N'woman1.jpg', N'<h3>Vosgi Varduhi</h3>', N'<p>Web Designer</p>', N'<i class=''fa fa-facebook''></i>', N'<i class=''fa fa-twitter''></i>', N'<i class=''fa fa-google-plus''></i>', N'<i class=''fa fa-linkedin''></i>', N'<i class=''fa fa-dribbble''></i>')
GO
INSERT [dbo].[Teams] ([Id], [Image], [Fullname], [Position], [Facelogo], [Twitlogo], [Googlogo], [Linkelogo], [Otherlogo]) VALUES (2, N'man1.jpg', N'<h3>Robert Aleska</h3>', N'<p>Developer</p>', N'<i class=''fa fa-facebook''></i>', N'<i class=''fa fa-twitter''></i>', N'<i class=''fa fa-google-plus''></i>', N'<i class=''fa fa-linkedin''></i>', N'<i class=''fa fa-dribbble''></i>')
GO
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 1/17/2020 5:20:32 PM ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT (N'') FOR [Name]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
USE [master]
GO
ALTER DATABASE [BizCraft] SET  READ_WRITE 
GO
