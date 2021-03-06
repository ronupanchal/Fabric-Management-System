USE [master]
GO
/****** Object:  Database [db_fabric]    Script Date: 22-04-2020 16:53:31 ******/
CREATE DATABASE [db_fabric]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_fabric', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_fabric.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_fabric_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_fabric_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_fabric] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_fabric].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_fabric] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_fabric] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_fabric] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_fabric] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_fabric] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_fabric] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_fabric] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_fabric] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_fabric] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_fabric] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_fabric] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_fabric] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_fabric] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_fabric] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_fabric] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_fabric] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_fabric] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_fabric] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_fabric] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_fabric] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_fabric] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_fabric] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_fabric] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_fabric] SET  MULTI_USER 
GO
ALTER DATABASE [db_fabric] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_fabric] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_fabric] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_fabric] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_fabric] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_fabric] SET QUERY_STORE = OFF
GO
USE [db_fabric]
GO
/****** Object:  Table [dbo].[tbl_billing]    Script Date: 22-04-2020 16:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_billing](
	[billno] [int] NULL,
	[bdate] [nvarchar](50) NULL,
	[cname] [nvarchar](50) NULL,
	[rawdetail] [nvarchar](50) NULL,
	[discount] [nvarchar](50) NULL,
	[transportdetail] [nvarchar](50) NULL,
	[total] [numeric](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_customer_detail]    Script Date: 22-04-2020 16:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_customer_detail](
	[custid] [int] NOT NULL,
	[custname] [nvarchar](50) NULL,
	[cemail] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_customer_detail] PRIMARY KEY CLUSTERED 
(
	[custid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_processing_cost]    Script Date: 22-04-2020 16:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_processing_cost](
	[finishgoodcode] [int] NULL,
	[finishgood] [nvarchar](50) NULL,
	[procost] [int] NULL,
	[finishgoodweight] [int] NULL,
	[proid] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_processing_detail]    Script Date: 22-04-2020 16:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_processing_detail](
	[proid] [int] NOT NULL,
	[prodate] [nvarchar](50) NULL,
	[proraw] [nvarchar](50) NULL,
	[promachine] [nvarchar](50) NULL,
	[procode] [nvarchar](50) NULL,
	[rawweight] [int] NULL,
 CONSTRAINT [PK_tbl_processing_detail] PRIMARY KEY CLUSTERED 
(
	[proid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_product_detail]    Script Date: 22-04-2020 16:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_product_detail](
	[pid] [int] NOT NULL,
	[pcost] [int] NULL,
	[pstock] [nvarchar](50) NULL,
	[stockweight] [nvarchar](50) NULL,
	[productionmachine] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_product_detail] PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_purchase_detail]    Script Date: 22-04-2020 16:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_purchase_detail](
	[rowcode] [int] NOT NULL,
	[rowname] [nvarchar](50) NULL,
	[category] [nvarchar](50) NULL,
	[purdate] [nvarchar](50) NULL,
	[amount] [int] NULL,
	[weight] [int] NULL,
 CONSTRAINT [PK_tbl_purchase_detail] PRIMARY KEY CLUSTERED 
(
	[rowcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_sales_detail]    Script Date: 22-04-2020 16:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_sales_detail](
	[salesno] [int] NOT NULL,
	[salesdate] [nvarchar](50) NULL,
	[raw] [nvarchar](50) NULL,
	[rawweight] [nvarchar](50) NULL,
	[amount] [int] NULL,
 CONSTRAINT [PK_tbl_sales_detail] PRIMARY KEY CLUSTERED 
(
	[salesno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_supplier_detail]    Script Date: 22-04-2020 16:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_supplier_detail](
	[scode] [int] NOT NULL,
	[sname] [nvarchar](50) NULL,
	[sphoneno] [nvarchar](50) NULL,
	[semail] [nvarchar](50) NULL,
	[raw] [nvarchar](50) NULL,
	[rawamt] [int] NULL,
	[rawcode] [int] NULL,
 CONSTRAINT [PK_tbl_supplier_detail] PRIMARY KEY CLUSTERED 
(
	[scode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_transport]    Script Date: 22-04-2020 16:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_transport](
	[transportid] [int] NOT NULL,
	[transportcost] [nvarchar](50) NOT NULL,
	[transportdistance] [int] NULL,
	[transportmode] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_transport] PRIMARY KEY CLUSTERED 
(
	[transportid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_warehouse]    Script Date: 22-04-2020 16:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_warehouse](
	[wid] [int] NOT NULL,
	[wname] [nvarchar](50) NULL,
	[managername] [nvarchar](50) NULL,
	[rent] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[wstock] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_warehouse] PRIMARY KEY CLUSTERED 
(
	[wid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [db_fabric] SET  READ_WRITE 
GO
