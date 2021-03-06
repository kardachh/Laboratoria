USE [master]
GO
/****** Object:  Database [Laboratoriya]    Script Date: 20.06.2022 19:26:57 ******/
CREATE DATABASE [Laboratoriya]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'labDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\labDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'labDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\labDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Laboratoriya] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Laboratoriya].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Laboratoriya] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Laboratoriya] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Laboratoriya] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Laboratoriya] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Laboratoriya] SET ARITHABORT OFF 
GO
ALTER DATABASE [Laboratoriya] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Laboratoriya] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Laboratoriya] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Laboratoriya] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Laboratoriya] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Laboratoriya] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Laboratoriya] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Laboratoriya] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Laboratoriya] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Laboratoriya] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Laboratoriya] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Laboratoriya] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Laboratoriya] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Laboratoriya] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Laboratoriya] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Laboratoriya] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Laboratoriya] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Laboratoriya] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Laboratoriya] SET  MULTI_USER 
GO
ALTER DATABASE [Laboratoriya] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Laboratoriya] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Laboratoriya] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Laboratoriya] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Laboratoriya] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Laboratoriya] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Laboratoriya] SET QUERY_STORE = OFF
GO
USE [Laboratoriya]
GO
/****** Object:  Table [dbo].[order]    Script Date: 20.06.2022 19:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date_start] [date] NOT NULL,
	[code] [varchar](14) NOT NULL,
	[date_end] [date] NOT NULL,
	[id_laborant] [int] NOT NULL,
	[id_service] [int] NOT NULL,
	[id_patient] [int] NOT NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient]    Script Date: 20.06.2022 19:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient](
	[id] [int] IDENTITY(51,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[surname] [nvarchar](255) NOT NULL,
	[login] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[date] [date] NOT NULL,
	[pasport] [nvarchar](255) NOT NULL,
	[phone_number] [nvarchar](255) NOT NULL,
	[email] [nvarchar](255) NOT NULL,
	[insurance_policy] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_patients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[service]    Script Date: 20.06.2022 19:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[service](
	[Code] [int] NOT NULL,
	[Service] [varchar](255) NOT NULL,
	[Price] [float] NOT NULL,
	[Deadline] [int] NOT NULL,
 CONSTRAINT [PK_services] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[typeUser]    Script Date: 20.06.2022 19:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[typeUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_typeUser] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 20.06.2022 19:26:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(101,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[surname] [varchar](50) NOT NULL,
	[login] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[id_type] [int] NOT NULL,
	[image] [varchar](max) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[patient] ON 

INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (1, N'Ashley', N'Blowin', N' ablowin1e', N' aQygVtMjN', CAST(N'2005-03-18' AS Date), N'3302282847', N'79091019392', N'trrrt@ggg.com', N'56568678436')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (2, N'Vale', N'Goroni', N' vgoroni1f', N' bWr0QU', CAST(N'2000-10-10' AS Date), N'3303525233', N'79092029392', N'qcvv@bv.ru', N'66768584679')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (3, N'Suki', N'Grafom', N' sgrafom1g', N' JcNcVDAouYzA', CAST(N'2001-12-16' AS Date), N'3302282847', N'79092029392', N'qwer@qwer.com', N'56456463278')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (4, N'Justis', N'Gianneschi', N' jgianneschi1h', N' oieX5u2sUfpD', CAST(N'1987-09-15' AS Date), N'3303 545433', N'+7 (790) 940-49-39', N'qed@sdgf.com', N'34363574743')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (5, N'Emilie', N'Collett', N' ecollett1i', N' Y0uMyKB0W', CAST(N'2000-02-11' AS Date), N'3303555533550', N'79095059392', N'trrrt@ggg.com', N'24565756336')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (6, N'Byrom', N'Terrell', N' bterrell1j', N' hswseW', CAST(N'1999-05-15' AS Date), N'3302282847', N'79096069392', N'qcvv@bv.ru', N'56568678436')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (7, N'Daphne', N'Bifield', N' dbifield1k', N' oYAQ4URihIA', CAST(N'2005-03-18' AS Date), N'3303575733', N'79097079392', N'qwer@qwer.com', N'66768584679')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (8, N'Blanca', N'Staig', N' bstaig1l', N' MygqEtjMtUbC', CAST(N'2000-10-10' AS Date), N'3302282847', N'79098089392', N'qed@sdgf.com', N'56456463278')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (9, N'Adriaens', N'Kennsley', N' akennsley1m', N' CTUdBfJsy6qF', CAST(N'2001-12-16' AS Date), N'3303595933', N'79099099392', N'trrrt@ggg.com', N'34363574743')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (10, N'Emlyn', N'Bartak', N' ebartak1n', N' y2t4H1', CAST(N'1987-09-15' AS Date), N'3303606033600', N'79091001093', N'qcvv@bv.ru', N'24565756336')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (11, N'Victoria', N'Willshire', N' vwillshire1o', N' VFSLc2t', CAST(N'2000-02-11' AS Date), N'3303616133', N'79091019392', N'qwer@qwer.com', N'56568678436')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (12, N'Egon', N'Savin', N' esavin1p', N' axnJY9s', CAST(N'1999-05-15' AS Date), N'3303626233', N'79092029392', N'qed@sdgf.com', N'66768584679')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (13, N'Phillie', N'Elsom', N' pelsom1q', N' OXzMECG', CAST(N'2005-03-18' AS Date), N'3302282847', N'79092029392', N'trrrt@ggg.com', N'56456463278')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (14, N'Adan', N'Semaine', N' asemaine1r', N' MdJRkHor5SP', CAST(N'2000-10-10' AS Date), N'3303646433', N'79094049392', N'qcvv@bv.ru', N'34363574743')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (15, N'Constantino', N'Northrop', N' cnorthrop1s', N' UIwCvTA7MRS0', CAST(N'2001-12-16' AS Date), N'3303656533650', N'79095059392', N'qwer@qwer.com', N'24565756336')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (16, N'Rodie', N'Easson', N' reasson1t', N' 2J0jgg9RWlXs', CAST(N'1987-09-15' AS Date), N'3303666633660', N'79096069392', N'qed@sdgf.com', N'56568678436')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (17, N'Alida', N'Boleyn', N' aboleyn1u', N' 2q2mQdDRmtr', CAST(N'2000-02-11' AS Date), N'3303676733670', N'79097079392', N'trrrt@ggg.com', N'66768584679')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (18, N'Hill', N'Scholfield', N' hscholfield1v', N' 1Pbs2K6qXYB', CAST(N'1999-05-15' AS Date), N'3303686833680', N'79098089392', N'qcvv@bv.ru', N'56456463278')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (19, N'Cordell', N'Cowpe', N' ccowpe1w', N' VHr417Ft0', CAST(N'2005-03-18' AS Date), N'3303696933690', N'79099099392', N'qwer@qwer.com', N'34363574743')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (20, N'Alexandro', N'Eldon', N' aeldon1x', N' rrywOQRmFKyh', CAST(N'2000-10-10' AS Date), N'3302282847', N'79091001093', N'qed@sdgf.com', N'24565756336')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (21, N'Kayle', N'Collin', N' kcollin1y', N' Q0ZV21vew0', CAST(N'2001-12-16' AS Date), N'3303717133710', N'79091019392', N'trrrt@ggg.com', N'56568678436')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (22, N'Inesita', N'Larkins', N' ilarkins1z', N' DEFNpHtU', CAST(N'1987-09-15' AS Date), N'3302282847', N'79092029392', N'qcvv@bv.ru', N'66768584679')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (23, N'Waylin', N'Lound', N' wlound20', N' a2G4Ihh2o', CAST(N'2000-02-11' AS Date), N'3303727233720', N'79092029392', N'qwer@qwer.com', N'56456463278')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (24, N'Mechelle', N'Gillogley', N' mgillogley21', N' EjUHfCUFqF', CAST(N'1999-05-15' AS Date), N'3302282847', N'79094049392', N'qed@sdgf.com', N'34363574743')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (25, N'Donal', N'Muccino', N' dmuccino22', N' E4okVgx', CAST(N'2005-03-18' AS Date), N'3303757533', N'79095059392', N'trrrt@ggg.com', N'24565756336')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (26, N'Joye', N'Leadbetter', N' jleadbetter22', N' ZNsaKdgb', CAST(N'2000-10-10' AS Date), N'3302282847', N'79096069392', N'qcvv@bv.ru', N'56568678436')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (27, N'Gianina', N'Trump', N' gtrump24', N' 6XXY7IS26Ci', CAST(N'2001-12-16' AS Date), N'3303777733770', N'79097079392', N'qwer@qwer.com', N'66768584679')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (28, N'Read', N'LeEstut', N' rleestut25', N' zq2C4rUR', CAST(N'1987-09-15' AS Date), N'3303787833780', N'79098089392', N'qed@sdgf.com', N'56456463278')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (29, N'Jill', N'Anscott', N' janscott26', N' 5maCRrCZLu', CAST(N'2000-02-11' AS Date), N'3302282847', N'79099099392', N'trrrt@ggg.com', N'34363574743')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (30, N'Bud', N'Douch', N' bdouch27', N' KAkwrli', CAST(N'1999-05-15' AS Date), N'3302282847', N'79091001093', N'qcvv@bv.ru', N'24565756336')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (31, N'Cicily', N'Ossenna', N' cossenna28', N' vfKJkCeohOzZ', CAST(N'2005-03-18' AS Date), N'3302282847', N'79091019392', N'qwer@qwer.com', N'56568678436')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (32, N'Hew', N'Izzat', N' hizzat29', N' Uifdtu', CAST(N'2000-10-10' AS Date), N'3302282847', N'79092029392', N'qed@sdgf.com', N'66768584679')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (33, N'Eddie', N'Gimeno', N' egimeno2a', N' oF1hbmKlZ', CAST(N'2001-12-16' AS Date), N'3303828233', N'79092029392', N'trrrt@ggg.com', N'56456463278')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (34, N'Sybyl', N'Fierro', N' sfierro2b', N' VjUrQ2', CAST(N'1987-09-15' AS Date), N'3302282847', N'79094049392', N'qcvv@bv.ru', N'34363574743')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (35, N'Nicol', N'Troup', N' ntroup2c', N' KmDDYf1Pu', CAST(N'2000-02-11' AS Date), N'3303858533', N'79095059392', N'qwer@qwer.com', N'24565756336')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (36, N'Bondy', N'Pattenden', N' bpattenden2d', N' IOUkHpOn', CAST(N'1999-05-15' AS Date), N'3302282847', N'79096069392', N'qed@sdgf.com', N'56568678436')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (37, N'Angus', N'Cockman', N' acockman2e', N' fDKhK7OK', CAST(N'2005-03-18' AS Date), N'3303878733', N'79097079392', N'trrrt@ggg.com', N'66768584679')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (38, N'Mord', N'Hanscome', N' mhanscome2f', N' xBHzpa7eP0u', CAST(N'2000-10-10' AS Date), N'3303888833880', N'79098089392', N'qcvv@bv.ru', N'56456463278')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (39, N'Susy', N'Leblanc', N' sleblanc2g', N' T2et1U5M', CAST(N'2001-12-16' AS Date), N'3303898933890', N'79099099392', N'qwer@qwer.com', N'34363574743')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (40, N'Gerard', N'Ciccoloi', N' gciccoloi2h', N' w4dZ2hxiCiAg', CAST(N'1987-09-15' AS Date), N'3303909033900', N'79091001093', N'qed@sdgf.com', N'24565756336')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (41, N'Seamus', N'Sayburn', N' ssayburn2i', N' 1hTM7EVKaS', CAST(N'2000-02-11' AS Date), N'3303919133910', N'79091019392', N'trrrt@ggg.com', N'56568678436')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (42, N'Washington', N'Gentiry', N' wgentiry2j', N' z2X9UH5', CAST(N'1999-05-15' AS Date), N'3303929233920', N'79092029392', N'qcvv@bv.ru', N'66768584679')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (43, N'Rebekkah', N'Westall', N' rwestall2k', N' xLgunbO9x6', CAST(N'2005-03-18' AS Date), N'3303929233920', N'79092029392', N'qwer@qwer.com', N'56456463278')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (44, N'Court', N'Kulic', N' ckulic2l', N' FLHYRN', CAST(N'2000-10-10' AS Date), N'3302 289999', N'+7 (790) 940-49-39', N'qed@sdgf.com', N'34363574743')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (45, N'Lorilee', N'Roux', N' lroux2m', N' 98cCxHeeK21', CAST(N'2001-12-16' AS Date), N'3302282847', N'79095059392', N'trrrt@ggg.com', N'24565756336')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (46, N'Modestine', N'Rolinson', N' mrolinson2n', N' faGzyW8hEca', CAST(N'1987-09-15' AS Date), N'3303969633', N'79096069392', N'qcvv@bv.ru', N'56568678436')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (47, N'Shelbi', N'Ellgood', N' sellgood2o', N' 2do5MME', CAST(N'2000-02-11' AS Date), N'3303979733970', N'79097079392', N'qwer@qwer.com', N'66768584679')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (48, N'Barbabra', N'Retchless', N' bretchless2p', N' WraGihh', CAST(N'1999-05-15' AS Date), N'3302282847', N'79098089392', N'qed@sdgf.com', N'56456463278')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (49, N'Robinetta', N'Jerzak', N' rjerzak2q', N' hAp8jki', CAST(N'2005-03-18' AS Date), N'3303999933', N'79099099392', N'trrrt@ggg.com', N'34363574743')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (50, N'Vance', N'Boots', N' vboots2r', N' bgJfSDEVEQm6', CAST(N'2000-10-10' AS Date), N'3302282847', N'79091001093', N'qcvv@bv.ru', N'24565756336')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (1052, N'Angus', N'Cockman', N' acockman2e', N' fDKhK7OK', CAST(N'2005-03-18' AS Date), N'3303 878733', N'+7 (790) 970-79-39', N'trrrt@ggg.com', N'66768584679')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (1055, N'123', N'123', N'12312', N'123', CAST(N'2022-06-17' AS Date), N'1123 12', N'+7 (123) 321-12-31', N'123', N'123')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (1056, N'123', N'123', N'123', N'23', CAST(N'2022-06-17' AS Date), N'1231 231231', N'+7 (123) 123-12-31', N'sasdfasdf', N'asdf')
INSERT [dbo].[patient] ([id], [name], [surname], [login], [password], [date], [pasport], [phone_number], [email], [insurance_policy]) VALUES (1057, N'123', N'123', N'123', N'23', CAST(N'2022-06-17' AS Date), N'1231 231255', N'+7 (123) 123-12-31', N'sasdfasdf', N'asdf')
SET IDENTITY_INSERT [dbo].[patient] OFF
GO
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (176, N'Билирубин общий', 102.85, 1)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (229, N'СПИД', 341.78, 2)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (258, N'Креатинин', 143.22, 2)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (287, N'Волчаночный антикоагулянт', 290.11, 1)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (311, N'Амилаза', 361.88, 2)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (323, N'Глюкоза', 447.65, 1)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (346, N'Общий белок', 396.03, 2)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (415, N'Кальций общий', 419.9, 2)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (501, N'Гепатит В', 176.83, 2)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (543, N'Гепатит С', 289.99, 2)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (548, N'Альбумин', 234.09, 2)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (557, N'ВИЧ', 490.77, 2)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (619, N'TSH', 262.71, 2)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (659, N'Сифилис RPR', 443.66, 2)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (797, N'АТ и АГ к ВИЧ 1/2', 370.62, 2)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (836, N'Железо', 105.32, 1)
INSERT [dbo].[service] ([Code], [Service], [Price], [Deadline]) VALUES (855, N'Ковид IgM', 209.78, 2)
GO
SET IDENTITY_INSERT [dbo].[typeUser] ON 

INSERT [dbo].[typeUser] ([id], [name]) VALUES (1, N'Администратор')
INSERT [dbo].[typeUser] ([id], [name]) VALUES (2, N'Лаборант')
SET IDENTITY_INSERT [dbo].[typeUser] OFF
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (1, N'Clareta', N'Hacking', N'admin', N'admin', 1, N'admin.png')
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (2, N'Northrop', N'Mably', N'lab1', N'lab1', 2, N'laborant_1.jpeg')
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (3, N'Fabian', N'Rolf', N'lab2', N'lab2', 2, N'laborant_2.png')
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (4, N'Lauree', N'Raden', N'lraden2', N'5Ydp2mz', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (5, N'Barby', N'Follos', N'bfollos4', N'ckmAJPQV', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (6, N'Mile', N'Enterle', N'menterle5', N'0PRom6i', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (7, N'Midge', N'Peaker', N'mpeaker6', N'0Tc5oRc', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (8, N'Manon', N'Robichon', N'mrobichon7', N'LEwEjMlmE5X', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (9, N'Stavro', N'Robken', N'srobken8', N'Cbmj2Yi', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (10, N'Bryan', N'Tidmas', N'btidmas9', N'dYDHbBQfK', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (11, N'Jeannette', N'Fussie', N'jfussiea', N'EGxXuLQ9', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (12, N'Stephen', N'Antonacci', N'santonaccib', N'YcXAhY2Pja', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (13, N'Niccolo', N'Bountiff', N'nbountiffc', N'5xfyjS9ZULGA', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (14, N'Clemente', N'Benjefield', N'cbenjefieldd', N'tQOsP0ei9TuD', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (15, N'Orlan', N'Corbyn', N'ocorbyne', N'bG1ZIzwIoU', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (16, N'Coreen', N'Stickins', N'cstickinsf', N'QRYADbgNj', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (17, N'Daveta', N'Clarage', N'dclarageg', N'Yp59ZIDnWe', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (18, N'Javier', N'McCawley', N'jmccawleyh', N'g58zLcmCYON', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (19, N'Daile', N'Band', N'dbandi', N'yFAaYuVW', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (20, N'Angil', N'Buttery', N'abutteryj', N'ttOFbWWGtD', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (21, N'Kyla', N'Kinman', N'kkinmank', N'qUr6fdWP6L5G', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (22, N'Selena', N'Skepper', N'sskepperl', N'jHYN0v2', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (23, N'Alyson', N'Yeoland', N'ayeolandm', N'QQezRBV9', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (24, N'Claudie', N'Speeding', N'cspeedingn', N'UCLYITfw2Vo', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (25, N'Alaric', N'Scarisbrick', N'ascarisbricko', N'fzBcv6GbyCp', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (26, N'Marie', N'Thurby', N'mthurbyp', N'wg0uIskqei', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (27, N'Cloe', N'Roxbrough', N'croxbroughq', N'67CVVym', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (28, N'Pegeen', N'McCotter', N'pmccotterr', N'QG5tdzRpGZJ2', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (29, N'Iggie', N'Calleja', N'icallejas', N'aeDvZk8o9', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (30, N'Nelle', N'Brosch', N'nbroscht', N'DmPJt2', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (31, N'Shae', N'Allsepp', N'sallseppu', N't0ko0854Cpvv', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (32, N'Eldridge', N'Abbatucci', N'eabbatucciv', N'gUtNdsDu', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (33, N'Skip', N'Garnham', N'sgarnhamw', N'eml6RqbK', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (34, N'Ric', N'Kitchenside', N'rkitchensidex', N'xaa7miQ7yB', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (35, N'Urbanus', N'Di', N'udiy', N'dHqu78cU6NOP', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (36, N'Monty', N'Beidebeke', N'mbeidebekez', N'F5T5spAU9A4O', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (37, N'Byrann', N'Savins', N'bsavins10', N'l6sYf29NLN', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (38, N'Sonnie', N'Riby', N'sriby11', N'Va24LYqFh', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (39, N'Sherill', N'Birney', N'sbirney12', N'Ggygo2ePsETs', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (40, N'Indira', N'Kleanthous', N'ikleanthous12', N'2H0GS7a', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (41, N'Maison', N'Skerme', N'mskerme14', N'wy1HWA', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (42, N'Hanan', N'Cahey', N'hcahey15', N'NSXcG9khd', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (43, N'Tore', N'Rusling', N'trusling16', N'abol9dYC8e', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (44, N'Jeddy', N'De', N'jde17', N'gK6Hsl8Q', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (45, N'Flossi', N'McLeoid', N'fmcleoid18', N'B9zr0N7cJw', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (46, N'Nikoletta', N'Megainey', N'nmegainey19', N'gph7QurFf', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (47, N'Adan', N'Bliven', N'abliven1a', N'vVxlf94KpeX', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (48, N'Mohandis', N'Rossoni', N'mrossoni1b', N'nLXj2lS', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (49, N'Nappie', N'Redington', N'nredington1c', N'DCbOb1SX', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (50, N'Lenka', N'Francie', N'lfrancie1d', N'DoGeHWuAAM', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (51, N'Ashley', N'Blowin', N'ablowin1e', N'aQygVtMjN', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (52, N'Vale', N'Goroni', N'vgoroni1f', N'bWr0QU', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (53, N'Suki', N'Grafom', N'sgrafom1g', N'JcNcVDAouYzA', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (54, N'Justis', N'Gianneschi', N'jgianneschi1h', N'oieX5u2sUfpD', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (55, N'Emilie', N'Collett', N'ecollett1i', N'Y0uMyKB0W', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (56, N'Byrom', N'Terrell', N'bterrell1j', N'hswseW', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (57, N'Daphne', N'Bifield', N'dbifield1k', N'oYAQ4URihIA', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (58, N'Blanca', N'Staig', N'bstaig1l', N'MygqEtjMtUbC', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (59, N'Adriaens', N'Kennsley', N'akennsley1m', N'CTUdBfJsy6qF', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (60, N'Emlyn', N'Bartak', N'ebartak1n', N'y2t4H1', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (61, N'Victoria', N'Willshire', N'vwillshire1o', N'VFSLc2t', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (62, N'Egon', N'Savin', N'esavin1p', N'axnJY9s', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (63, N'Phillie', N'Elsom', N'pelsom1q', N'OXzMECG', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (64, N'Adan', N'Semaine', N'asemaine1r', N'MdJRkHor5SP', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (65, N'Constantino', N'Northrop', N'cnorthrop1s', N'UIwCvTA7MRS0', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (66, N'Rodie', N'Easson', N'reasson1t', N'2J0jgg9RWlXs', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (67, N'Alida', N'Boleyn', N'aboleyn1u', N'2q2mQdDRmtr', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (68, N'Hill', N'Scholfield', N'hscholfield1v', N'1Pbs2K6qXYB', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (69, N'Cordell', N'Cowpe', N'ccowpe1w', N'VHr417Ft0', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (70, N'Alexandro', N'Eldon', N'aeldon1x', N'rrywOQRmFKyh', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (71, N'Kayle', N'Collin', N'kcollin1y', N'Q0ZV21vew0', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (72, N'Inesita', N'Larkins', N'ilarkins1z', N'DEFNpHtU', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (73, N'Waylin', N'Lound', N'wlound20', N'a2G4Ihh2o', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (74, N'Mechelle', N'Gillogley', N'mgillogley21', N'EjUHfCUFqF', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (75, N'Donal', N'Muccino', N'dmuccino22', N'E4okVgx', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (76, N'Joye', N'Leadbetter', N'jleadbetter22', N'ZNsaKdgb', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (77, N'Gianina', N'Trump', N'gtrump24', N'6XXY7IS26Ci', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (78, N'Read', N'LeEstut', N'rleestut25', N'zq2C4rUR', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (79, N'Jill', N'Anscott', N'janscott26', N'5maCRrCZLu', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (80, N'Bud', N'Douch', N'bdouch27', N'KAkwrli', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (81, N'Cicily', N'Ossenna', N'cossenna28', N'vfKJkCeohOzZ', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (82, N'Hew', N'Izzat', N'hizzat29', N'Uifdtu', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (83, N'Eddie', N'Gimeno', N'egimeno2a', N'oF1hbmKlZ', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (84, N'Sybyl', N'Fierro', N'sfierro2b', N'VjUrQ2', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (85, N'Nicol', N'Troup', N'ntroup2c', N'KmDDYf1Pu', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (86, N'Bondy', N'Pattenden', N'bpattenden2d', N'IOUkHpOn', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (87, N'Angus', N'Cockman', N'acockman2e', N'fDKhK7OK', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (88, N'Mord', N'Hanscome', N'mhanscome2f', N'xBHzpa7eP0u', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (89, N'Susy', N'Leblanc', N'sleblanc2g', N'T2et1U5M', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (90, N'Gerard', N'Ciccoloi', N'gciccoloi2h', N'w4dZ2hxiCiAg', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (91, N'Seamus', N'Sayburn', N'ssayburn2i', N'1hTM7EVKaS', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (92, N'Washington', N'Gentiry', N'wgentiry2j', N'z2X9UH5', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (93, N'Rebekkah', N'Westall', N'rwestall2k', N'xLgunbO9x6', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (94, N'Court', N'Kulic', N'ckulic2l', N'FLHYRN', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (95, N'Lorilee', N'Roux', N'lroux2m', N'98cCxHeeK21', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (96, N'Modestine', N'Rolinson', N'mrolinson2n', N'faGzyW8hEca', 1, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (97, N'Shelbi', N'Ellgood', N'sellgood2o', N'2do5MME', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (98, N'Barbabra', N'Retchless', N'bretchless2p', N'WraGihh', 2, NULL)
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (99, N'Robinetta', N'Jerzak', N'rjerzak2q', N'hAp8jki', 2, NULL)
GO
INSERT [dbo].[user] ([id], [name], [surname], [login], [password], [id_type], [image]) VALUES (100, N'Vance', N'Boots', N'vboots2r', N'bgJfSDEVEQm6', 2, NULL)
SET IDENTITY_INSERT [dbo].[user] OFF
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_patient] FOREIGN KEY([id_patient])
REFERENCES [dbo].[patient] ([id])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_patient]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_service] FOREIGN KEY([id_service])
REFERENCES [dbo].[service] ([Code])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_service]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_user] FOREIGN KEY([id_laborant])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_user]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [FK_user_typeUser] FOREIGN KEY([id_type])
REFERENCES [dbo].[typeUser] ([id])
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [FK_user_typeUser]
GO
USE [master]
GO
ALTER DATABASE [Laboratoriya] SET  READ_WRITE 
GO
