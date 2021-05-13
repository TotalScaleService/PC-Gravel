USE [master]
GO
/****** Object:  Database [IRS_Scale]    Script Date: 12/4/2020 12:01:52 PM ******/
CREATE DATABASE [IRS_Scale]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IRS_Scale', FILENAME = N'D:\SQL2017\MSSQL14.SQL2017\MSSQL\DATA\IRS_Scale.mdf' , SIZE = 15424KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IRS_Scale_log', FILENAME = N'D:\SQL2017\MSSQL14.SQL2017\MSSQL\DATA\IRS_Scale_1.ldf' , SIZE = 568896KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [IRS_Scale] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IRS_Scale].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [IRS_Scale] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IRS_Scale] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IRS_Scale] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IRS_Scale] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IRS_Scale] SET ARITHABORT OFF 
GO
ALTER DATABASE [IRS_Scale] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [IRS_Scale] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IRS_Scale] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IRS_Scale] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IRS_Scale] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IRS_Scale] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IRS_Scale] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IRS_Scale] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IRS_Scale] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IRS_Scale] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IRS_Scale] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IRS_Scale] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IRS_Scale] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IRS_Scale] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IRS_Scale] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IRS_Scale] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IRS_Scale] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IRS_Scale] SET RECOVERY FULL 
GO
ALTER DATABASE [IRS_Scale] SET  MULTI_USER 
GO
ALTER DATABASE [IRS_Scale] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IRS_Scale] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IRS_Scale] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IRS_Scale] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [IRS_Scale] SET DELAYED_DURABILITY = DISABLED 
GO
USE [IRS_Scale]
GO
/****** Object:  User [Test]    Script Date: 12/4/2020 12:01:52 PM ******/
CREATE USER [Test] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [pocket]    Script Date: 12/4/2020 12:01:52 PM ******/
CREATE USER [pocket] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/4/2020 12:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Account_Name] [varchar](50) NOT NULL,
	[Phone] [varchar](20) NULL,
	[Address] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[Zip] [varchar](10) NULL,
	[Terms] [varchar](20) NULL,
	[Taxable] [bit] NULL,
	[Show_Price] [bit] NULL,
	[Default_Hauler] [varchar](50) NULL,
	[Show_Price_On_Ticket] [bit] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Account_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountProducts]    Script Date: 12/4/2020 12:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountProducts](
	[Product_Name] [varchar](50) NOT NULL,
	[Account_Name] [varchar](50) NOT NULL,
	[Price] [money] NULL,
	[Delivery_Rate] [money] NULL,
	[Flat_Rate] [bit] NULL,
 CONSTRAINT [PK_AccountProducts] PRIMARY KEY CLUSTERED 
(
	[Product_Name] ASC,
	[Account_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hauler]    Script Date: 12/4/2020 12:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hauler](
	[Hauler_Name] [varchar](50) NOT NULL,
	[Same_As_Sold_To] [bit] NOT NULL,
	[Default_Account] [varchar](50) NULL,
	[Show_Price_On_Ticket] [bit] NULL,
 CONSTRAINT [PK_Hauler] PRIMARY KEY CLUSTERED 
(
	[Hauler_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 12/4/2020 12:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[Account_Name] [varchar](50) NOT NULL,
	[Job_Name] [varchar](50) NOT NULL,
	[Description] [varchar](100) NULL,
	[Address] [varchar](100) NULL,
	[Job_Number] [varchar](100) NULL,
	[Job_Key] [varchar](100) NULL,
	[Show_Price] [bit] NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[Account_Name] ASC,
	[Job_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job_Products]    Script Date: 12/4/2020 12:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job_Products](
	[Product_Name] [varchar](50) NOT NULL,
	[Account_Name] [varchar](50) NOT NULL,
	[Job_Name] [varchar](50) NOT NULL,
	[Price] [money] NULL,
	[Delivery_Rate] [money] NULL,
	[Flat_Rate] [bit] NULL,
	[Product_Number] [varchar](100) NULL,
 CONSTRAINT [PK_Job_Products] PRIMARY KEY CLUSTERED 
(
	[Product_Name] ASC,
	[Account_Name] ASC,
	[Job_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/4/2020 12:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Product_Name] [varchar](50) NOT NULL,
	[Unit_Of_Measure] [varchar](50) NOT NULL,
	[Taxable] [bit] NOT NULL,
	[Price_Per_UOM] [money] NOT NULL,
	[Tons_Per_Yard] [decimal](18, 6) NULL,
	[Use_Scale] [bit] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Product_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Setup]    Script Date: 12/4/2020 12:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Setup](
	[Company_Name] [varchar](50) NOT NULL,
	[Header1] [varchar](100) NULL,
	[Header2] [varchar](100) NULL,
	[Header3] [varchar](100) NULL,
	[Tax_Rate] [decimal](6, 3) NOT NULL,
	[Simulate_Scale] [bit] NOT NULL,
	[Default_Hauler] [varchar](100) NULL,
	[Comm_Port] [varchar](50) NULL,
	[Print_To_Screen] [bit] NULL,
	[Show_Price_By_Default] [bit] NULL,
	[Pit_Name] [varchar](100) NULL,
	[Show_SplitWeigh_Button] [bit] NULL,
	[Station_Number] [decimal](2, 0) NULL,
	[Show_State_Ticket_Button] [bit] NULL,
	[Report_Printer] [varchar](200) NULL,
	[Ticket_Printer] [varchar](200) NULL,
	[Ticket_Number] [bigint] NULL,
	[Ticket_Copies_Per_Page] [int] NULL,
	[Ticket_Copies] [int] NULL,
	[Ticket_Paper] [varchar](100) NULL,
	[Ticket_Width] [int] NULL,
	[Ticket_Height] [int] NULL,
	[Ticket_Raw_Kind] [int] NULL,
 CONSTRAINT [PK_Setup] PRIMARY KEY CLUSTERED 
(
	[Company_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[States]    Script Date: 12/4/2020 12:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[State] [varchar](50) NOT NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[State] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 12/4/2020 12:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[Ticket] [int] NOT NULL,
	[Date_Out] [datetime] NOT NULL,
	[Product_Name] [varchar](50) NULL,
	[Product_Number] [varchar](50) NULL,
	[Account_Name] [varchar](50) NULL,
	[Hauler_Name] [varchar](50) NULL,
	[Truck_Id] [varchar](50) NULL,
	[Job_Name] [varchar](50) NULL,
	[Job_Number] [varchar](50) NULL,
	[Job_Description] [varchar](100) NULL,
	[Job_Address] [varchar](100) NULL,
	[Job_Key] [varchar](100) NULL,
	[Gross] [int] NULL,
	[Tare] [int] NULL,
	[Unit_Of_Measure] [varchar](50) NULL,
	[Quantity] [decimal](18, 3) NULL,
	[Yards_Conversion] [decimal](18, 6) NULL,
	[Price_Per_UOM] [money] NULL,
	[Tax_Rate] [decimal](4, 4) NULL,
	[Comment] [varchar](100) NULL,
	[Scale_Used] [bit] NULL,
	[Delivery_Rate] [money] NULL,
	[Delivery_Flat_Rate] [bit] NULL,
	[Taxable] [bit] NULL,
	[Void] [bit] NULL,
	[Show_Pricing] [bit] NULL,
	[Show_Price_On_Ticket] [bit] NULL,
	[Driver_Name] [varchar](50) NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Ticket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trucks]    Script Date: 12/4/2020 12:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trucks](
	[Truck_Id] [varchar](50) NOT NULL,
	[Hauler_Name] [varchar](50) NOT NULL,
	[Account_Name] [varchar](50) NULL,
	[Job_Name] [varchar](50) NULL,
	[Product_Name] [varchar](50) NULL,
	[Tare_Weight] [decimal](10, 2) NULL,
	[On_Hold] [bit] NULL,
	[Hold_Date] [datetime] NULL,
	[Comment] [varchar](50) NULL,
	[Driver_Name] [varchar](50) NULL,
 CONSTRAINT [PK_Trucks] PRIMARY KEY CLUSTERED 
(
	[Truck_Id] ASC,
	[Hauler_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zip_Codes]    Script Date: 12/4/2020 12:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zip_Codes](
	[Zip] [varchar](50) NOT NULL,
	[City] [varchar](100) NOT NULL,
	[State] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Zip_Codes] PRIMARY KEY CLUSTERED 
(
	[Zip] ASC,
	[City] ASC,
	[State] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Job]    Script Date: 12/4/2020 12:01:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_Job] ON [dbo].[Job]
(
	[Account_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Transactions] ADD  CONSTRAINT [DF_Transactions_Date_Out]  DEFAULT (getdate()) FOR [Date_Out]
GO
ALTER TABLE [dbo].[Transactions] ADD  CONSTRAINT [DF_Transactions_Gross]  DEFAULT ((0)) FOR [Gross]
GO
ALTER TABLE [dbo].[Transactions] ADD  CONSTRAINT [DF_Transactions_Tare]  DEFAULT ((0)) FOR [Tare]
GO
ALTER TABLE [dbo].[Transactions] ADD  CONSTRAINT [DF_Transactions_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Transactions] ADD  CONSTRAINT [DF_Transactions_Yards_Conversion]  DEFAULT ((0)) FOR [Yards_Conversion]
GO
ALTER TABLE [dbo].[Transactions] ADD  CONSTRAINT [DF_Transactions_Price_Per_UOM]  DEFAULT ((0)) FOR [Price_Per_UOM]
GO
ALTER TABLE [dbo].[Transactions] ADD  CONSTRAINT [DF_Transactions_Tax]  DEFAULT ((0)) FOR [Tax_Rate]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_States] FOREIGN KEY([State])
REFERENCES [dbo].[States] ([State])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_States]
GO
ALTER TABLE [dbo].[AccountProducts]  WITH CHECK ADD  CONSTRAINT [FK_AccountProducts_Account1] FOREIGN KEY([Account_Name])
REFERENCES [dbo].[Account] ([Account_Name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AccountProducts] CHECK CONSTRAINT [FK_AccountProducts_Account1]
GO
ALTER TABLE [dbo].[AccountProducts]  WITH CHECK ADD  CONSTRAINT [FK_AccountProducts_Product1] FOREIGN KEY([Product_Name])
REFERENCES [dbo].[Product] ([Product_Name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AccountProducts] CHECK CONSTRAINT [FK_AccountProducts_Product1]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [FK_Job_Account1] FOREIGN KEY([Account_Name])
REFERENCES [dbo].[Account] ([Account_Name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [FK_Job_Account1]
GO
ALTER TABLE [dbo].[Job_Products]  WITH CHECK ADD  CONSTRAINT [FK_Job_Products_Job] FOREIGN KEY([Account_Name], [Job_Name])
REFERENCES [dbo].[Job] ([Account_Name], [Job_Name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Job_Products] CHECK CONSTRAINT [FK_Job_Products_Job]
GO
ALTER TABLE [dbo].[Job_Products]  WITH CHECK ADD  CONSTRAINT [FK_Job_Products_Product] FOREIGN KEY([Product_Name])
REFERENCES [dbo].[Product] ([Product_Name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Job_Products] CHECK CONSTRAINT [FK_Job_Products_Product]
GO
ALTER TABLE [dbo].[Trucks]  WITH CHECK ADD  CONSTRAINT [FK_Trucks_Account] FOREIGN KEY([Account_Name])
REFERENCES [dbo].[Account] ([Account_Name])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Trucks] CHECK CONSTRAINT [FK_Trucks_Account]
GO
ALTER TABLE [dbo].[Trucks]  WITH CHECK ADD  CONSTRAINT [FK_Trucks_Hauler] FOREIGN KEY([Hauler_Name])
REFERENCES [dbo].[Hauler] ([Hauler_Name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Trucks] CHECK CONSTRAINT [FK_Trucks_Hauler]
GO
ALTER TABLE [dbo].[Trucks]  WITH CHECK ADD  CONSTRAINT [FK_Trucks_Product1] FOREIGN KEY([Product_Name])
REFERENCES [dbo].[Product] ([Product_Name])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Trucks] CHECK CONSTRAINT [FK_Trucks_Product1]
GO
ALTER TABLE [dbo].[Zip_Codes]  WITH CHECK ADD  CONSTRAINT [FK_Zip_Codes_States] FOREIGN KEY([State])
REFERENCES [dbo].[States] ([State])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Zip_Codes] CHECK CONSTRAINT [FK_Zip_Codes_States]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Either tons Yards Or Count' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Product', @level2type=N'COLUMN',@level2name=N'Price_Per_UOM'
GO
USE [master]
GO
ALTER DATABASE [IRS_Scale] SET  READ_WRITE 
GO
