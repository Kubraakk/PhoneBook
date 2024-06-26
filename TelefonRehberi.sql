USE [master]
GO
/****** Object:  Database [TelefonRehberi]    Script Date: 31.01.2024 19:41:15 ******/
CREATE DATABASE [TelefonRehberi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TelefonRehberi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TelefonRehberi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TelefonRehberi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TelefonRehberi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TelefonRehberi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TelefonRehberi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TelefonRehberi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TelefonRehberi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TelefonRehberi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TelefonRehberi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TelefonRehberi] SET ARITHABORT OFF 
GO
ALTER DATABASE [TelefonRehberi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TelefonRehberi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TelefonRehberi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TelefonRehberi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TelefonRehberi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TelefonRehberi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TelefonRehberi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TelefonRehberi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TelefonRehberi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TelefonRehberi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TelefonRehberi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TelefonRehberi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TelefonRehberi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TelefonRehberi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TelefonRehberi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TelefonRehberi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TelefonRehberi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TelefonRehberi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TelefonRehberi] SET  MULTI_USER 
GO
ALTER DATABASE [TelefonRehberi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TelefonRehberi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TelefonRehberi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TelefonRehberi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TelefonRehberi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TelefonRehberi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TelefonRehberi] SET QUERY_STORE = OFF
GO
USE [TelefonRehberi]
GO
/****** Object:  Table [dbo].[Favori]    Script Date: 31.01.2024 19:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Favori](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[kisiID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SonAramalar]    Script Date: 31.01.2024 19:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SonAramalar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[aramaID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TelRehber]    Script Date: 31.01.2024 19:41:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelRehber](
	[tel_id] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](20) NOT NULL,
	[soyad] [nvarchar](20) NOT NULL,
	[tel] [bigint] NOT NULL,
	[tur] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Favori] ON 

INSERT [dbo].[Favori] ([ID], [kisiID]) VALUES (17, 1008)
INSERT [dbo].[Favori] ([ID], [kisiID]) VALUES (23, 8)
SET IDENTITY_INSERT [dbo].[Favori] OFF
GO
SET IDENTITY_INSERT [dbo].[SonAramalar] ON 

INSERT [dbo].[SonAramalar] ([ID], [aramaID]) VALUES (35, NULL)
INSERT [dbo].[SonAramalar] ([ID], [aramaID]) VALUES (36, 1006)
INSERT [dbo].[SonAramalar] ([ID], [aramaID]) VALUES (37, NULL)
INSERT [dbo].[SonAramalar] ([ID], [aramaID]) VALUES (38, 10)
INSERT [dbo].[SonAramalar] ([ID], [aramaID]) VALUES (39, NULL)
INSERT [dbo].[SonAramalar] ([ID], [aramaID]) VALUES (40, NULL)
SET IDENTITY_INSERT [dbo].[SonAramalar] OFF
GO
SET IDENTITY_INSERT [dbo].[TelRehber] ON 

INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (7, N'Fatma', N'Gun', 5234567891, N'Aile')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (8, N'Zehra', N'Gunes', 5234567893, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (9, N'Emre', N'Soyu', 5634567892, N'Okul')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (10, N'Gamze', N'Sak', 5234567891, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (11, N'Emir', N'Sak', 5294567895, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (12, N'Ebru', N'Karal', 5234567896, N'Aile')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (14, N'Ömer', N'Yılmaz', 5234567899, N'Okul')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (15, N'Yeliz', N'Çetin', 5264567894, N'İş')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (16, N'Uraz', N'Kaygır', 5234567893, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (18, N'Buse', N'Er', 5234567891, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (19, N'Fatma', N'Su', 5234567894, N'Okul')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (20, N'Ömer', N'Midi', 5254567898, N'İş')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (22, N'Deniz', N'Yıldız', 5934567892, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (23, N'Ela', N'Cag', 5234567882, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (24, N'Çağrı', N'Elma', 5234567891, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (25, N'Melisa', N'Sungur', 5234567894, N'Okul')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (26, N'Gözde', N'Yıldırım', 5254567898, N'İş')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (27, N'Zeynep', N'Keskin', 5934567893, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (28, N'Oğuz', N'Kekin', 5934567892, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (29, N'Esma', N'Soy', 5234567882, N'Aile')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (30, N'Melis', N'Atasoy', 5234567891, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (31, N'İlayda', N'Dağdelen', 5234567894, N'Okul')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (32, N'Sevim', N'Hayırlıoğlu', 5254567898, N'İş')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (33, N'Zeynep', N'Sude', 5934567893, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (34, N'Selin', N'Şekerci', 5934567892, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (35, N'Atakan', N'Delyan', 5234567882, N'Aile')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (36, N'İlkay', N'Soykan', 5234567891, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (37, N'Devin', N'Akın', 5234567894, N'Okul')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (38, N'Aslan', N'Soykan', 5254567898, N'İş')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (39, N'Zehra', N'Dursun', 5934567893, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (40, N'Kader', N'Aksoy', 5934567892, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (1002, N'John', N'Doe', 5295687982, N'Arkadaş')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (1003, N'Kübra', N'Ak', 5455488845, N'Aile')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (1004, N'Hira', N'Gün', 5456454564, N'Ev')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (1005, N'Esra', N'Gül', 5345682684, N'Aile')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (1006, N'Eda', N'Menekse', 1234567890, N'Aile')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (1007, N'Perihan', N'Akpunar', 5533449988, N'Aile')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (1008, N'Zeliha', N'Gündoğdu', 5468975234, N'İş')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (1009, N'Hatice', N'Ersarı', 5963450985, N'Okul ')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (1012, N'Nur', N'Karahan', 1245564578, N'İş')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (1014, N'İnci', N'Yılmaz', 5456654544, N'Aile')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (1015, N'Esin', N'Isık', 5698754230, N'Aile')
INSERT [dbo].[TelRehber] ([tel_id], [ad], [soyad], [tel], [tur]) VALUES (1016, N'Helen', N'Su', 5566445500, N'Ev')
SET IDENTITY_INSERT [dbo].[TelRehber] OFF
GO
ALTER TABLE [dbo].[Favori]  WITH CHECK ADD  CONSTRAINT [FK__Favori__kisiID__59063A47] FOREIGN KEY([kisiID])
REFERENCES [dbo].[TelRehber] ([tel_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Favori] CHECK CONSTRAINT [FK__Favori__kisiID__59063A47]
GO
ALTER TABLE [dbo].[SonAramalar]  WITH CHECK ADD FOREIGN KEY([aramaID])
REFERENCES [dbo].[TelRehber] ([tel_id])
GO
USE [master]
GO
ALTER DATABASE [TelefonRehberi] SET  READ_WRITE 
GO
