
/****** Object:  Database [QuanLyQuanAn]    Script Date: 05/13/2018 13:47:17 ******/
CREATE DATABASE [QuanLyQuanAn] 
go
GO
USE [QuanLyQuanAn]
GO
ALTER DATABASE [QuanLyQuanAn] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanAn].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanAn] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET ARITHABORT OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET AUTO_CLOSE ON
GO
ALTER DATABASE [QuanLyQuanAn] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyQuanAn] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyQuanAn] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QuanLyQuanAn] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET  DISABLE_BROKER
GO
ALTER DATABASE [QuanLyQuanAn] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QuanLyQuanAn] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QuanLyQuanAn] SET  READ_WRITE
GO
ALTER DATABASE [QuanLyQuanAn] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QuanLyQuanAn] SET  MULTI_USER
GO
ALTER DATABASE [QuanLyQuanAn] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QuanLyQuanAn] SET DB_CHAINING OFF
GO
USE [QuanLyQuanAn]
GO
/****** Object:  Table [dbo].[tablefood]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tablefood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tablefood] ON
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (1, N'Bàn0', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (2, N'Bàn1', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (3, N'Bàn2', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (4, N'Bàn3', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (5, N'Bàn4', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (6, N'Bàn5', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (7, N'Bàn6', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (8, N'Bàn7', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (9, N'Bàn8', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (10, N'Bàn9', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (11, N'Bàn10', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (12, N'Bàn11', N'CÓ NGƯỜI')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (13, N'Bàn12', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (14, N'Bàn13', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (15, N'Bàn14', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (16, N'Bàn15', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (17, N'Bàn16', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (18, N'Bàn17', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (19, N'Bàn18', N'CÓ NGƯỜI')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (20, N'Bàn19', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (21, N'Bàn20', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (22, N'Bàn21', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (23, N'Bàn22', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (24, N'Bàn23', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (25, N'Bàn24', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (26, N'Bàn25', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (27, N'Bàn26', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (28, N'Bàn27', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (29, N'Bàn28', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (30, N'Bàn29', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (31, N'Bàn30', N'TRỐNG')
INSERT [dbo].[tablefood] ([id], [name], [status]) VALUES (33, N'Bàn40', N'TRỐNG')
SET IDENTITY_INSERT [dbo].[tablefood] OFF
/****** Object:  Table [dbo].[Bill]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[discount] [int] NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bill] ON
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (329, CAST(0x383E0B00 AS Date), CAST(0x383E0B00 AS Date), 5, 1, 0, 20000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (330, CAST(0x383E0B00 AS Date), CAST(0x383E0B00 AS Date), 4, 1, 0, 30000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (331, CAST(0x383E0B00 AS Date), CAST(0x383E0B00 AS Date), 13, 1, 0, 10000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (332, CAST(0x383E0B00 AS Date), CAST(0x383E0B00 AS Date), 16, 1, 0, 110000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (334, CAST(0x393E0B00 AS Date), CAST(0x393E0B00 AS Date), 14, 1, 0, 700000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (335, CAST(0x393E0B00 AS Date), CAST(0x393E0B00 AS Date), 15, 1, 0, 40000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (336, CAST(0x393E0B00 AS Date), CAST(0x393E0B00 AS Date), 1, 1, 0, 1494000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (337, CAST(0x393E0B00 AS Date), CAST(0x393E0B00 AS Date), 16, 1, 0, 30000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (338, CAST(0x393E0B00 AS Date), CAST(0x393E0B00 AS Date), 16, 1, 0, 30000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (343, CAST(0x393E0B00 AS Date), NULL, 1, 1, 0, 50000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (344, CAST(0x393E0B00 AS Date), CAST(0x393E0B00 AS Date), 1, 1, 0, 30000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (345, CAST(0x393E0B00 AS Date), CAST(0x393E0B00 AS Date), 1, 1, 0, 30000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (346, CAST(0x393E0B00 AS Date), CAST(0x393E0B00 AS Date), 1, 1, 0, 60000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (347, CAST(0x393E0B00 AS Date), CAST(0x393E0B00 AS Date), 6, 1, 0, 40000)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (349, CAST(0x393E0B00 AS Date), CAST(0x393E0B00 AS Date), 12, 0, 0, NULL)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (353, CAST(0x393E0B00 AS Date), CAST(0x393E0B00 AS Date), 19, 0, 0, NULL)
SET IDENTITY_INSERT [dbo].[Bill] OFF
/****** Object:  Table [dbo].[BillInfo]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BillInfo] ON
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (484, 329, 1, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (485, 330, 1, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (486, 331, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (487, 332, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (488, 332, 3, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (489, 332, 4, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (492, 334, 4, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (493, 335, 1, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (494, 336, 1, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (495, 336, 3, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (496, 336, 4, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (497, 336, 8, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (498, 337, 1, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (499, 338, 1, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (500, 343, 1, 5)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (502, 344, 1, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (503, 345, 1, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (504, 346, 1, 6)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (505, 347, 1, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (510, 349, 2, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (514, 349, 1, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (515, 353, 1, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (516, 353, 10, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (517, 353, 11, 1)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
/****** Object:  StoredProcedure [dbo].[USP_Puttables]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Puttables]
@idTable1 int, @idTable2 int
AS

BEGIN

	declare @idFirsBill int
	declare @idSecondBill int
	declare @idFood int,@idFood1 int
	declare @count int
	declare @idbillinfo int
	
		select @idSecondBill = id  from dbo.Bill where idTable = @idTable2 and status = 0
		select @idFirsBill = id  from dbo.Bill where idTable = @idTable1 and status = 0
		select @idFood = idFood  from dbo.BillInfo where  idBill = @idFirsBill
		select @idFood1 = idFood  from dbo.BillInfo where  idBill = @idSecondBill
		select @count = count  from dbo.BillInfo where		idBill = @idFirsBill
		select @idbillinfo = id	from dbo.BillInfo  where idBill = @idSecondBill
		
end
		BEGIN

 DECLARE @isExitBillInfo int
 DECLARE @foodCount int = 1
 
 SELECT @isExitBillInfo = id, @foodCount = b.count 
 FROM dbo.BillInfo as b
  WHERE idBill = @idSecondBill AND idFood = @idFood 
  
 if(@isExitBillInfo > 0)
 BEGIN
  DECLARE @newCount int = @foodCount + @count
  if( @newCount > 0)
  begin
   UPDATE dbo.BillInfo SET count = @foodCount + @count where  id = @idbillinfo and @idFood = idFood
   
    end
  else
   DELETE dbo.BillInfo Where idBill = @idFirsBill and idFood = @idFood 
 END
 
 else
 BEGIN
  update dbo.BillInfo set idBill = @idSecondBill where idBill = @idFirsBill
  
 END
	delete dbo.BillInfo where idBill = @idFirsBill
	delete dbo.Bill where id = @idFirsBill
	update dbo.tablefood set status = N'TRỐNG' where id = @idTable1
	end
GO
/****** Object:  StoredProcedure [dbo].[USP_LayBanTrong]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_LayBanTrong]
  as select* from dbo.tablefood where status = N'TRỐNG'
GO
/****** Object:  StoredProcedure [dbo].[USP_LayBanCoNguoi]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_LayBanCoNguoi]
  as select* from dbo.tablefood where status = N'CÓ NGƯỜI'
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBillInfo]
@idBill int, @idFood int, @count int
AS

BEGIN

 DECLARE @isExitBillInfo int
 DECLARE @foodCount int = 1
 declare @idtable int
 
 select @idtable = idTable from dbo.Bill
 SELECT @isExitBillInfo = id, @foodCount = b.count 
 FROM dbo.BillInfo as b
  WHERE idBill = @idBill AND idFood = @idFood
  
 if(@isExitBillInfo > 0)
 BEGIN
  DECLARE @newCount int = @foodCount + @count
  if( @newCount > 0)
   UPDATE dbo.BillInfo SET count = @foodCount + @count where idFood = @idFood  and idBill = @idBill
  else
   DELETE dbo.BillInfo Where idBill = @idBill and idFood = @idFood 
 END
 
 else
 BEGIN
 
   INSERT INTO dbo.BillInfo
   (idBill,
   idFood,
   count)
   VALUES
   (@idBill,	
   @idFood,
   @count)
   END
 END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBill]
@idTable int
AS

BEGIN

 insert dbo.Bill
 (DateCheckIn,
 DateCheckOut,
 idTable,
 status,
 discount
 )
 values(GETDATE(),
		GETDATE(),
		@idTable,
		0,
		0)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Gettablelist]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Gettablelist]
  as select* from dbo.tablefood
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListByDate]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListByDate]
@checkIn date, @checkOut date
AS
BEGIN
	SELECT t.name, b.totalPrice, DateCheckIn, DateCheckOut, discount 
	from dbo.Bill AS b, dbo.tablefood AS t 
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1 AND t.id = b.idTable 
END
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteBillNull]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_DeleteBillNull]
@idTable1 int 
AS

BEGIN

	declare @idFirsBill int
	
		select @idFirsBill = id  from dbo.Bill where idTable = @idTable1 and status = 0
		

 

 BEGIN
 
  

		
	delete dbo.BillInfo where idBill = @idFirsBill
	delete dbo.Bill where id = @idFirsBill
	update dbo.tablefood set status = N'TRỐNG' where id = @idTable1
 	end
 	end
GO
/****** Object:  Table [dbo].[test]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[test](
	[name] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[test] ([name]) VALUES (N'khánh')
/****** Object:  Table [dbo].[Account]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'AD123', N'Alo', N'1A5hV7722Ik=', 0)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'AD123123', N'123', N'1A5hV7722Ik=', 0)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'AD12345', N'456', N'1A5hV7722Ik=', 0)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'US123', N'123', N'1A5hV7722Ik=', 1)
/****** Object:  StoredProcedure [dbo].[USP_SwitchTable]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_SwitchTable]
@idTable1 int, @idTable2 int
AS

BEGIN

	declare @idFirsBill int
	declare @idSecondBill int
	
	declare @finaltab1 int = 1
	declare @finaltab2 int = 1
	
		select @idSecondBill = id  from dbo.Bill where idTable = @idTable2 and status = 0
		select @idFirsBill = id  from dbo.Bill where idTable = @idTable1 and status = 0
	
	print @idFirsBill
	Print @idSecondBill
	print '------------'
	
	if(@idFirsBill IS NULL)
	begin
	print'000002'
		insert dbo.Bill
		( DateCheckIn,
		DateCheckOut,
		idTable,
		status,
		discount
		) 
		values (GETDATE() ,
		NULL , 
		@idTable1 ,
		0,
		0)
				select @idFirsBill = MAX(id) from dbo.Bill where idTable = @idTable1 and status = 0
				

	end
		select  @finaltab1 = COUNT(*) from dbo.BillInfo where idBill = @idFirsBill

print @idFirsBill
	Print @idSecondBill
	print '------------'

if(@idSecondBill IS NULL)
	begin
	print '00001'
		insert dbo.Bill
		( DateCheckIn ,
		DateCheckOut ,
		idTable ,
		status,
		discount
		) 
		values (GETDATE() ,
		NULL , 
		@idTable2 ,
		0,
		0)
		
		select @idSecondBill = MAX(id) from dbo.Bill where idTable = @idTable2 and status = 0
		
	end

				select  @finaltab2 = COUNT(*) from dbo.BillInfo where idBill = @idSecondBill

print @idFirsBill
	Print @idSecondBill
	print '------------'
	
	select id into IDBillInfoTable from dbo.BillInfo where idBill = @idSecondBill
	
	update dbo.BillInfo set idBill = @idSecondBill where idBill = @idFirsBill
	
		update dbo.BillInfo set idBill = @idFirsBill where id in(select *from IDBillInfoTable)
		
		
	drop table IDBillInfoTable
	
	if(@finaltab1 = 0)
	update dbo.tablefood set status = N'TRỐNG' where id = @idTable2
	if(@finaltab2 = 0)
	update dbo.tablefood set status = N'TRỐNG' where id = @idTable1
	
	delete dbo.BillInfo where idBill = @idFirsBill
	delete dbo.Bill where id = @idFirsBill
end
GO
/****** Object:  UserDefinedFunction [dbo].[GetUnsignString]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetUnsignString](@strInput NVARCHAR(4000)) 
RETURNS NVARCHAR(4000)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[FoodCategory] ON
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'Hải Sản')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'Món Nướng')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (3, N'Món Lẩu')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (4, N'Món Hấp')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (5, N'Thức Uống')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF
/****** Object:  Table [dbo].[Food]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Food] ON
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1, N'Sò', 1, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Bò Nướng', 2, 14000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Lẩu Trâu', 3, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Cá Cam Hấp', 4, 700000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'7 Up', 5, 7000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (8, N'Lipton', 5, 7000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (10, N'Lẩu cá kèo', 3, 70000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (11, N'Trà chanh', 5, 5000)
SET IDENTITY_INSERT [dbo].[Food] OFF
/****** Object:  StoredProcedure [dbo].[USP_GetNameFood]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetNameFood] 
@idTable int
as
begin

select f.name  from Bill AS b, BillInfo AS bi, Food AS f where bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable = @idTable
end
GO
/****** Object:  StoredProcedure [dbo].[USP_showPrice]    Script Date: 05/13/2018 13:47:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_showPrice]
  @foodname nvarchar (100)
  as
  begin
 
  select price from dbo.Food where name = @foodname
  end
GO
CREATE TABLE tblNhanVien
(
	MaNV NVARCHAR(100) primary key REFERENCES Account(UserName),
	TenNV NVARCHAR(50) NOT NULL,
	NgaySinh DATETIME NOT NULL,
	GioiTinh NVARCHAR(30) NOT NULL,
	TrinhDoHocVan NVARCHAR(30) NULL,
	ChucVu NVARCHAR(30) NOT NULL,
	SoCMND CHAR(11) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL
)

CREATE TABLE tblBangLuong
(
	STT INT IDENTITY PRIMARY KEY,
	Thang INT NOT NULL,
	MaNV NVARCHAR(100) not null  REFERENCES tblNhanVien(MaNV) ,
	TenNV NVARCHAR(50) NOT NULL,
	TongGioLam FLOAT NOT NULL,
	MucLuong MONEY NOT NULL,
	TienLuong MONEY NOT NULL
)
CREATE TABLE tblChamCongNV
(
	MaNV NVARCHAR(100)not null REFERENCES tblNhanVien(MaNV) ,
	TenNV NVARCHAR(50) NOT NULL,
	CaLam NVARCHAR(30) NOT NULL,
	Ngay DATETIME NOT NULL,
	SoGioLam FLOAT NOT NULL
)
ALTER TABLE [dbo].[tblChamCongNV]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[Account] ([UserName])
go
/****** Object:  Default [DF__tablefood__name__014935CB]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[tablefood] ADD  DEFAULT (N'CHƯA CÓ TÊN') FOR [name]
GO
/****** Object:  Default [DF__tablefood__statu__023D5A04]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[tablefood] ADD  DEFAULT (N'TRỐNG') FOR [status]
GO
/****** Object:  Default [DF__Bill__DateCheckI__1920BF5C]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
/****** Object:  Default [DF__BillInfo__count__1ED998B2]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
/****** Object:  Default [DF__Account__Display__07020F21]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'HIEP') FOR [DisplayName]
GO
/****** Object:  Default [DF__Account__PassWor__07F6335A]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [PassWord]
GO
/****** Object:  Default [DF__Account__Type__08EA5793]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
/****** Object:  Default [DF__FoodCatego__name__0DAF0CB0]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'CHƯA ĐẶT TÊN') FOR [name]
GO
/****** Object:  Default [DF__Food__name__1273C1CD]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'Chưa Đạt Tên') FOR [name]
GO
/****** Object:  Default [DF__Food__price__1367E606]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[Food] ADD  DEFAULT ((0)) FOR [price]
GO
/****** Object:  ForeignKey [FK__Bill__idTable__1A14E395]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[tablefood] ([id])
GO
/****** Object:  ForeignKey [FK__BillInfo__idBill__1FCDBCEB]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
/****** Object:  ForeignKey [FK__BillInfo__idFood__20C1E124]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
/****** Object:  ForeignKey [FK__Food__idCategory__145C0A3F]    Script Date: 05/13/2018 13:47:18 ******/
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
