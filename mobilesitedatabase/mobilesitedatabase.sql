USE [MobileSiteDatabase]
GO
/****** Object:  Table [dbo].[ProductInformation]    Script Date: 10/2/2018 3:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductInformation](
	[ProductId] [uniqueidentifier] NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[SellingPrice] [decimal](18, 3) NULL,
	[MarketPrice] [decimal](18, 3) NULL,
	[Stock] [numeric](18, 0) NULL,
	[Description] [nvarchar](max) NULL,
	[DateOfInsert] [date] NULL,
	[Rating] [numeric](5, 0) NULL,
	[OperatingSystem] [nvarchar](50) NULL,
	[Color] [nvarchar](50) NULL,
	[IsAvailable] [bit] NULL,
	[FirstImage] [nvarchar](50) NULL,
	[SecondImage] [nvarchar](50) NULL,
	[ThirdImage] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProductInformation] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiteUser]    Script Date: 10/2/2018 3:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteUser](
	[UserId] [uniqueidentifier] NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Gender] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[ContactNumber] [numeric](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersBasket]    Script Date: 10/2/2018 3:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersBasket](
	[BasketId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[DateOfCreation] [datetime] NULL,
	[GrandTotal] [int] NULL,
 CONSTRAINT [PK_UsersBasket] PRIMARY KEY CLUSTERED 
(
	[BasketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersBasketItems]    Script Date: 10/2/2018 3:46:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersBasketItems](
	[ItemId] [uniqueidentifier] NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[Quantity] [int] NOT NULL,
	[BasketId] [uniqueidentifier] NULL,
	[Total] [int] NOT NULL,
	[DateOfCreation] [datetime] NOT NULL,
 CONSTRAINT [PK_UsersBasketItems] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ProductInformation] ([ProductId], [ProductName], [SellingPrice], [MarketPrice], [Stock], [Description], [DateOfInsert], [Rating], [OperatingSystem], [Color], [IsAvailable], [FirstImage], [SecondImage], [ThirdImage]) VALUES (N'494a1a9f-84f0-4483-83b3-0c81ba73da63', N'test-2', CAST(544.000 AS Decimal(18, 3)), CAST(444.000 AS Decimal(18, 3)), CAST(5 AS Numeric(18, 0)), N'c', CAST(N'2018-01-01' AS Date), CAST(1 AS Numeric(5, 0)), N'Windows', N'Black', 1, N'2 (1).jpg', N'3.jpg', N'3.jpg')
INSERT [dbo].[ProductInformation] ([ProductId], [ProductName], [SellingPrice], [MarketPrice], [Stock], [Description], [DateOfInsert], [Rating], [OperatingSystem], [Color], [IsAvailable], [FirstImage], [SecondImage], [ThirdImage]) VALUES (N'153c21d9-7b2a-4df8-b3df-0dacf4db880a', N'test-3', CAST(20555.000 AS Decimal(18, 3)), CAST(20555.000 AS Decimal(18, 3)), CAST(4 AS Numeric(18, 0)), N'sdfds', CAST(N'2018-01-01' AS Date), CAST(4 AS Numeric(5, 0)), N'Windows', N'Black', 1, N'3.jpg', N'3 (1).jpg', N'4 (1).jpg')
INSERT [dbo].[ProductInformation] ([ProductId], [ProductName], [SellingPrice], [MarketPrice], [Stock], [Description], [DateOfInsert], [Rating], [OperatingSystem], [Color], [IsAvailable], [FirstImage], [SecondImage], [ThirdImage]) VALUES (N'badf4aac-9d10-43e7-93c1-3e5a36cb2ca4', N'Redmi Note 5 Pro', CAST(25400.000 AS Decimal(18, 3)), CAST(26552.000 AS Decimal(18, 3)), CAST(54 AS Numeric(18, 0)), N'fu hdufhdfuigh dfughfduigh fudih guifdghdfiughdfiughsidufhgidfuhgfdiuviudfvhfu hgdfiuhfduivhvdfuihguidfhgdfghdfhaoei fpiuaweh gpiudf hgiudfh gdifuhg dfpihgidfhp s', CAST(N'2018-06-06' AS Date), CAST(4 AS Numeric(5, 0)), N'BlackberryOS', N'Black', 1, N'img-4.jpg', N'img-11.jpg', N'img-10.jpg')
INSERT [dbo].[ProductInformation] ([ProductId], [ProductName], [SellingPrice], [MarketPrice], [Stock], [Description], [DateOfInsert], [Rating], [OperatingSystem], [Color], [IsAvailable], [FirstImage], [SecondImage], [ThirdImage]) VALUES (N'e836e2ee-e0d7-476f-9199-52581e7ede42', N'Lava 6S', CAST(15000.000 AS Decimal(18, 3)), CAST(15215.000 AS Decimal(18, 3)), CAST(5 AS Numeric(18, 0)), N'sldkfjidfiuh ughreuig hug rgh reuigh iurg hrugh rg hg g rhgirueghierh gihg gh irghreigh ieurgh iugh uighiuerhgegehghfiuer h rhg e ghregh hg regheir h', CAST(N'2018-01-01' AS Date), CAST(4 AS Numeric(5, 0)), N'Android', N'Blue', 1, N'img-4.jpg', N'img-12.jpg', N'img-15.jpg')
INSERT [dbo].[ProductInformation] ([ProductId], [ProductName], [SellingPrice], [MarketPrice], [Stock], [Description], [DateOfInsert], [Rating], [OperatingSystem], [Color], [IsAvailable], [FirstImage], [SecondImage], [ThirdImage]) VALUES (N'415aa9c3-902c-408f-acaf-615faedabf5b', N'Samsung J7', CAST(25000.000 AS Decimal(18, 3)), CAST(25400.000 AS Decimal(18, 3)), CAST(45 AS Numeric(18, 0)), N'KDJsad fjgjfdighfdighfd gi fhg fdhgdfiughfdiughfdiug dfogh dfuighfduighfduighd fiug hdfiugh dfiughdfig hfduighdfiugdfhguidfhgiudfhgdfiughd fiugh dfiug dfuig hfdiug hfdiug dfg dfiug hdfuighdfuig fdg hdfiug hfdiug hdfuig dfg hdfuig hdfuig hdfiug dfguidfhguidfhgiudf ghdfuig hdfuig dfig dfuigh dfiug fdig  ig dfg hdfiug hfduig dfg  dfug hdfuig fdgiu fig fdigh dfiug hdfiuh dfius', CAST(N'2017-05-09' AS Date), CAST(4 AS Numeric(5, 0)), N'Android', N'Red', 1, N'img-2.png', N'img-8.png', N'img-13.png')
INSERT [dbo].[ProductInformation] ([ProductId], [ProductName], [SellingPrice], [MarketPrice], [Stock], [Description], [DateOfInsert], [Rating], [OperatingSystem], [Color], [IsAvailable], [FirstImage], [SecondImage], [ThirdImage]) VALUES (N'de250678-fd50-4083-bf16-67731c52a642', N'Redmi 3S', CAST(7000.000 AS Decimal(18, 3)), CAST(6500.000 AS Decimal(18, 3)), CAST(5 AS Numeric(18, 0)), N'dfkjuidfhudffhudigh duf dug dfgduig dg dg dug dugdufgdsuifhwifius dfh sdufhsduif sf  dshf uf hsdu fhdsuf hsudf s f fsuifh sdiufhaif hsf  fsdhf iusdfh uisfwe89f weifhdsiufhsiuf hewf ywe98we fhsidu', CAST(N'2018-05-07' AS Date), CAST(3 AS Numeric(5, 0)), N'Android', N'Blue', 1, N'img-3.jpg', N'img-14.jpg', N'img-10.jpg')
INSERT [dbo].[ProductInformation] ([ProductId], [ProductName], [SellingPrice], [MarketPrice], [Stock], [Description], [DateOfInsert], [Rating], [OperatingSystem], [Color], [IsAvailable], [FirstImage], [SecondImage], [ThirdImage]) VALUES (N'83747489-a9b4-4bbd-873d-a7cd4807103a', N'Samsung Edge 6', CAST(21000.000 AS Decimal(18, 3)), CAST(25100.000 AS Decimal(18, 3)), CAST(4 AS Numeric(18, 0)), N'dslkjfeo rierg highreiugh ruighreughioejhdio  hgdiog hdfig hfdig hdfigh diofg hdig hfdiugh dfiugh dfuig hdfiug hdfuig fduig hdiufg hduigh df giudfgh ufdihguidghiudh gdiugh dufi', CAST(N'2018-05-06' AS Date), CAST(1 AS Numeric(5, 0)), N'Android', N'Blue', 1, N'img-2.png', N'img-6.jpg', N'img-15.jpg')
INSERT [dbo].[ProductInformation] ([ProductId], [ProductName], [SellingPrice], [MarketPrice], [Stock], [Description], [DateOfInsert], [Rating], [OperatingSystem], [Color], [IsAvailable], [FirstImage], [SecondImage], [ThirdImage]) VALUES (N'dfafb85b-f2ff-4170-9918-c354618d1310', N'One Plus', CAST(25400.000 AS Decimal(18, 3)), CAST(15000.000 AS Decimal(18, 3)), CAST(5 AS Numeric(18, 0)), N'sdlkfjid jgdfiogjfdigfiogfdiog fdoihg fdgh dfgh dfigh dfsipohg ipruoehg 9ergh i erogj oajgoi[ajgioerhgoidfhgoidfhg idfohgoidf ghdfihg ifdhgoidfhg piodfh giodfhoifdhodfg hdfoi hofih ifodh', CAST(N'2018-01-01' AS Date), CAST(3 AS Numeric(5, 0)), N'Windows', N'White', 1, N'img-3.jpg', N'img-12.jpg', N'img-15.jpg')
INSERT [dbo].[ProductInformation] ([ProductId], [ProductName], [SellingPrice], [MarketPrice], [Stock], [Description], [DateOfInsert], [Rating], [OperatingSystem], [Color], [IsAvailable], [FirstImage], [SecondImage], [ThirdImage]) VALUES (N'a1df0791-22e4-4629-8222-e7a8f6237d8f', N'test1', CAST(879.000 AS Decimal(18, 3)), CAST(797.000 AS Decimal(18, 3)), CAST(4 AS Numeric(18, 0)), N'kj', CAST(N'2018-01-01' AS Date), CAST(4 AS Numeric(5, 0)), N'Windows', N'Black', 1, N'4 (1).jpg', N'3.jpg', N'3.jpg')
INSERT [dbo].[ProductInformation] ([ProductId], [ProductName], [SellingPrice], [MarketPrice], [Stock], [Description], [DateOfInsert], [Rating], [OperatingSystem], [Color], [IsAvailable], [FirstImage], [SecondImage], [ThirdImage]) VALUES (N'67219638-287e-40d0-90b5-f50917159e14', N'tEST-3', CAST(564.000 AS Decimal(18, 3)), CAST(6465.000 AS Decimal(18, 3)), CAST(4 AS Numeric(18, 0)), N'WDQW', CAST(N'2018-01-01' AS Date), CAST(4 AS Numeric(5, 0)), N'Windows', N'Black', 1, N'4 (1).jpg', N'2 (1).jpg', N'3.jpg')
INSERT [dbo].[ProductInformation] ([ProductId], [ProductName], [SellingPrice], [MarketPrice], [Stock], [Description], [DateOfInsert], [Rating], [OperatingSystem], [Color], [IsAvailable], [FirstImage], [SecondImage], [ThirdImage]) VALUES (N'19fefebf-be6c-4d18-878b-fd0fbbf9270c', N'Samsung Max', CAST(25499.000 AS Decimal(18, 3)), CAST(25444.000 AS Decimal(18, 3)), CAST(6 AS Numeric(18, 0)), N'dsfh sdfhdusfhdsuif hdufh udfghdfugh dfug fdughfduihgdfiughfdui ghfduihg dfiugh dfu ghdfigh dfui ghfdihg dfuig hdfi ghdfihg dfuigh dfiugh dfiugh iudfg fdgh fduigh fdiughdfiug hfdiugh dfiug hdfiughdfiughfdiuhg iudfgh idfuh giudfhg idfugh difugh fidug dfiugh iudfh giudfhg iudfgh iudf', CAST(N'2018-05-01' AS Date), CAST(4 AS Numeric(5, 0)), N'Android', N'Blue', 1, N'img-13.png', N'img-6.jpg', N'img-3.jpg')
INSERT [dbo].[SiteUser] ([UserId], [FirstName], [LastName], [Email], [Password], [Gender], [Country], [ContactNumber]) VALUES (N'6f228de2-ef18-48c8-aba0-ceb967884fd8', N'Kamran', N'Basit', N'kamranqdn@gmail.com', N'1234', N'Male', N'France', CAST(8090903494 AS Numeric(18, 0)))
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__SiteUser__A9D105349D3DEBAA]    Script Date: 10/2/2018 3:46:39 PM ******/
ALTER TABLE [dbo].[SiteUser] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ProcDeleteProduct]    Script Date: 10/2/2018 3:46:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcDeleteProduct](
@ProductId uniqueidentifier
)
As
delete  from ProductInformation where ProductId=@ProductId
GO
/****** Object:  StoredProcedure [dbo].[ProcGetLatestProducts]    Script Date: 10/2/2018 3:46:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcGetLatestProducts]



AS
begin
select top 4 
ProductId,ProductName,SellingPrice,OperatingSystem,SecondImage  from ProductInformation order by  DateOfInsert desc  
end
GO
/****** Object:  StoredProcedure [dbo].[ProcGetLoginCredentials]    Script Date: 10/2/2018 3:46:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[ProcGetLoginCredentials]
@Email nvarchar(50),
@Password nvarchar(50)

As
declare @isValid bit,@Message nvarchar(200),@userId uniqueidentifier
Begin
if exists(Select 1 from SiteUser where Email=@Email)
begin  
		if (exists(Select 1 from SiteUser where Email=@Email and Password=@Password))
		begin
			

			select @isValid=1,@Message='Login Successfull',@userId=UserId from SiteUser

		
			
		end

		else
		begin
			select @isValid=0,@Message='Your Password was incorrect'
		end
end		 
else

begin

select @isValid=0,@Message='Invalid Email' 
end
		select @isValid as IsValid,@Message as [Message],@userId as UserId
END
GO
/****** Object:  StoredProcedure [dbo].[ProcGetProductData]    Script Date: 10/2/2018 3:46:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcGetProductData]
As
begin
Select ProductId,ProductName, SellingPrice,MarketPrice,Stock,Description,DateOfInsert,Rating,OperatingSystem,Color,IsAvailable,FirstImage,SecondImage,ThirdImage from ProductInformation 
end
GO
/****** Object:  StoredProcedure [dbo].[ProcGetProductList]    Script Date: 10/2/2018 3:46:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcGetProductList]
as 
begin
select top 8 ProductName,SellingPrice,OperatingSystem,SecondImage from ProductInformation
end
GO
/****** Object:  StoredProcedure [dbo].[ProcGetProductListBulk]    Script Date: 10/2/2018 3:46:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcGetProductListBulk]
as 
begin
select top 12 ProductId, ProductName,SellingPrice,OperatingSystem,SecondImage,[Description] from ProductInformation
end
GO
/****** Object:  StoredProcedure [dbo].[ProcGetProductPageDetails]    Script Date: 10/2/2018 3:46:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcGetProductPageDetails](

@ProductId uniqueidentifier
)
as
begin
	select ProductId, ProductName,SellingPrice,Color,OperatingSystem,Rating,SecondImage,[Description]
	from ProductInformation 
	where ProductId=@ProductId
end
GO
/****** Object:  StoredProcedure [dbo].[ProcInsertBasketItems]    Script Date: 10/2/2018 3:46:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcInsertBasketItems](

@Email nvarchar(50),
@ProductId uniqueidentifier,
@Quantity int,
@UserId uniqueidentifier,
@Total int,
@BasketId uniqueidentifier,
@GrandTotal int

)
AS

	Declare @CartId uniqueidentifier
Begin
	If (Exists(Select 1 from UsersBasket where Email=@Email))
		Begin
			Select CartId=@BasketId from UsersBasket where Email=@Email

			Insert into UsersBasketItems(ItemId,ProductId,Quantity,BasketId,Total,DateOfCreation)
			values(newid(),@ProductId,@Quantity,@CartId,@Total,GETDATE())

			Select ProductName,SellingPrice,Quantity,SecondImage,Total 
			from ProductInformation  P left join UsersBasketItems U
			on P.ProductId=U.ProductId 
			End

	else

		Insert into UsersBasket(BasketId,UserId,Email,DateOfCreation,GrandTotal)
		values(newid(),@UserId,@Email,GETDATE(),@GrandTotal)

		Select ProductName,SellingPrice,Quantity,SecondImage,Total 
		from ProductInformation  P left join UsersBasketItems U
		on P.ProductId=U.ProductId 
End
		
		
GO
/****** Object:  StoredProcedure [dbo].[ProcInsertProducts]    Script Date: 10/2/2018 3:46:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProcInsertProducts](
@ProductId uniqueidentifier,
@ProductName nvarchar(50),
@SellingPrice decimal(18,3),
@MarketPrice decimal(18,3),
@Stock numeric(18,0),
@Description nvarchar(max),
@DateOfInsert date,
@Rating numeric(5,0),
@OperatingSystem nvarchar(50),
@Color nvarchar(50),
@IsAvailable bit,
@FirstImage nvarchar(50),
@SecondImage nvarchar(50),
@ThirdImage nvarchar(50)

)
AS
if exists(Select @ProductName from ProductInformation where ProductId=@ProductId)
begin
update ProductInformation
set ProductName=@ProductName ,
	SellingPrice=@SellingPrice,
	MarketPrice=@MarketPrice,
	Stock=@Stock,
	Description=@Description,
	DateOfInsert=@DateOfInsert,
	Rating=@Rating,
	OperatingSystem=@OperatingSystem,
	Color=@Color,
	 IsAvailable=@IsAvailable,
	FirstImage=@FirstImage,
	SecondImage=@SecondImage,
	ThirdImage=@ThirdImage where ProductId=@ProductId
end
else



begin
Insert into ProductInformation(ProductId,ProductName,SellingPrice,MarketPrice,Stock,Description,DateOfInsert,Rating,OperatingSystem,Color,IsAvailable,FirstImage,SecondImage,ThirdImage)
 values(newid(),@ProductName,@SellingPrice,@MarketPrice,@Stock,@Description,@DateOfInsert,@Rating,@OperatingSystem,@Color,@IsAvailable,@FirstImage,@SecondImage,@ThirdImage)
 end
GO
/****** Object:  StoredProcedure [dbo].[ProcInsertSiteUserCredentials]    Script Date: 10/2/2018 3:46:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProcInsertSiteUserCredentials](
@UserId uniqueidentifier,
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Email nvarchar(50) ,
@Password nvarchar(50),
@Gender nvarchar(50),
@Country nvarchar(50),
@ContactNumber numeric(18,0)



)

AS
declare @isValid bit,@Message nvarchar(200)
Begin

if (not exists(Select 1 from SiteUser where Email=@Email))
	begin
		Insert into SiteUser(UserId,FirstName,LastName,Email,Password,Gender,Country,ContactNumber)
		values(newid(),@FirstName,@LastName,@Email,@Password,@Gender,@Country,@ContactNumber)
	end
else
	begin
		select @isValid=1,@Message='This Email is already exists'
	end	
	
	select @isValid as isValid,@Message as [Message] 

END
GO
