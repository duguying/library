USE [library]
GO
/****** Object:  Table [dbo].[TB_ReaderType]    Script Date: 12/11/2013 22:22:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_ReaderType](
	[rdType] [smallint] IDENTITY(1,1) NOT NULL,
	[rdTypeName] [nvarchar](20) NOT NULL,
	[maxBorrowNum] [int] NOT NULL,
	[maxBorrowDay] [int] NOT NULL,
	[maxContinueTimes] [int] NOT NULL,
 CONSTRAINT [PK_TB_ReaderType] PRIMARY KEY CLUSTERED 
(
	[rdType] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者类型ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_ReaderType', @level2type=N'COLUMN',@level2name=N'rdType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者类型名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_ReaderType', @level2type=N'COLUMN',@level2name=N'rdTypeName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最大借书数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_ReaderType', @level2type=N'COLUMN',@level2name=N'maxBorrowNum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最大借阅天数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_ReaderType', @level2type=N'COLUMN',@level2name=N'maxBorrowDay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最大续借次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_ReaderType', @level2type=N'COLUMN',@level2name=N'maxContinueTimes'
GO
/****** Object:  Table [dbo].[TB_Reader]    Script Date: 12/11/2013 22:22:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Reader](
	[rdID] [int] IDENTITY(1,1) NOT NULL,
	[rdUsername] [nchar](10) NOT NULL,
	[rdPassword] [nchar](50) NOT NULL,
	[rdName] [nchar](10) NULL,
	[rdSex] [nchar](1) NULL,
	[rdType] [smallint] NULL,
	[rdDept] [nvarchar](20) NULL,
	[rdPhone] [nvarchar](25) NULL,
	[rdEmail] [nvarchar](25) NOT NULL,
	[rdDateReg] [datetime] NOT NULL,
	[rdPhoto] [image] NULL,
	[rdStatus] [nchar](2) NOT NULL,
	[rdHaveBorrowNum] [int] NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[rdID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者编号，借书证号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdUsername'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdPassword'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdSex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单位代码/单位名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdDept'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdPhone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者邮箱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdEmail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者注册时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdDateReg'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者照片' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdPhoto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'证件状态(正常/挂失/注销)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'已借书数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Reader', @level2type=N'COLUMN',@level2name=N'rdHaveBorrowNum'
GO
/****** Object:  Table [dbo].[TB_Borrow]    Script Date: 12/11/2013 22:22:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Borrow](
	[borrowId] [numeric](12, 0) IDENTITY(1,1) NOT NULL,
	[rdId] [int] NOT NULL,
	[bkId] [int] NOT NULL,
	[ldContinueTimes] [int] NOT NULL,
	[ldDateOut] [datetime] NOT NULL,
	[ldDateRetPlan] [datetime] NULL,
	[ldDateRetAct] [datetime] NULL,
	[ldOverDay] [int] NULL,
	[ldOverMoney] [money] NULL,
	[ldPunishMoney] [money] NULL,
	[IsHasReturn] [bit] NULL,
	[OperatorLendId] [int] NULL,
	[OperatorRetId] [int] NULL,
 CONSTRAINT [PK_lend] PRIMARY KEY CLUSTERED 
(
	[borrowId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借书事务编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'borrowId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'rdId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'bkId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'续借次数（第一次借时，记为0）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'ldContinueTimes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借书日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'ldDateOut'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应还日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'ldDateRetPlan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实际还书日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'ldDateRetAct'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'超期天数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'ldOverDay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'超期金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'ldOverMoney'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'罚款金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'ldPunishMoney'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否已经还书，缺省为0-未还' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'IsHasReturn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借书操作员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'OperatorLendId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'还书操作员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Borrow', @level2type=N'COLUMN',@level2name=N'OperatorRetId'
GO
/****** Object:  Table [dbo].[TB_Book]    Script Date: 12/11/2013 22:22:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Book](
	[bkId] [int] IDENTITY(1,1) NOT NULL,
	[bkCode] [nvarchar](50) NOT NULL,
	[bkName] [nvarchar](50) NOT NULL,
	[bkAuthor] [nvarchar](30) NULL,
	[bkPress] [nvarchar](50) NULL,
	[bkDatePress] [datetime] NULL,
	[bkISBN] [nvarchar](15) NULL,
	[bkCatalog] [nvarchar](30) NULL,
	[bkLanguage] [smallint] NULL,
	[bkPages] [int] NULL,
	[bkPrice] [money] NOT NULL,
	[bkDateIn] [datetime] NULL,
	[bkBrief] [text] NULL,
	[bkCover] [image] NULL,
	[bkStatus] [nchar](2) NULL,
 CONSTRAINT [PK_book] PRIMARY KEY CLUSTERED 
(
	[bkId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [book_code_unique] UNIQUE NONCLUSTERED 
(
	[bkCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'书籍ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'书名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'作者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkAuthor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出版社' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkPress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出版时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkDatePress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ISBN' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkISBN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分类' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkCatalog'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'书籍语种' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkLanguage'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'页数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkPages'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'价格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'入馆日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkDateIn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'简介' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkBrief'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'封面图片' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkCover'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'在馆状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Book', @level2type=N'COLUMN',@level2name=N'bkStatus'
GO
/****** Object:  Table [dbo].[TB_Admin]    Script Date: 12/11/2013 22:22:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Admin](
	[adminId] [int] IDENTITY(1,1) NOT NULL,
	[adminUsername] [nchar](20) NOT NULL,
	[adminPassword] [nchar](50) NOT NULL,
	[adminEmail] [nchar](50) NOT NULL,
	[adminLastLoginDate] [datetime] NOT NULL,
 CONSTRAINT [PK_admin] PRIMARY KEY CLUSTERED 
(
	[adminId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Admin', @level2type=N'COLUMN',@level2name=N'adminId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Admin', @level2type=N'COLUMN',@level2name=N'adminUsername'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Admin', @level2type=N'COLUMN',@level2name=N'adminPassword'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Admin', @level2type=N'COLUMN',@level2name=N'adminEmail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'管理员最后登录时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TB_Admin', @level2type=N'COLUMN',@level2name=N'adminLastLoginDate'
GO
/****** Object:  UserDefinedFunction [dbo].[vague_search_book_by_keyword]    Script Date: 12/11/2013 22:22:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[vague_search_book_by_keyword](
  @keyword nvarchar(50)
  )
  RETURNS TABLE
AS
		RETURN(
		select
		bkId,
		bkCode,
		bkName,
		bkAuthor,
		bkPress,
		bkDatePress,
		bkISBN,
		bkCatalog,
		bkLanguage,
		bkPages,
		bkPrice,
		bkDateIn,
		bkBrief,
		bkCover,
		bkStatus
		from  TB_Book where
		bkName like '%'+@keyword+'%' or
		bkAuthor like '%'+@keyword+'%' or
		bkPress like '%'+@keyword+'%' or
		bkISBN like '%'+@keyword+'%' or
		bkCatalog like '%'+@keyword+'%'
		)
GO
/****** Object:  UserDefinedFunction [dbo].[vague_search_book_by_condition]    Script Date: 12/11/2013 22:22:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[vague_search_book_by_condition](
  @bk_keyword nvarchar(50),
  @bk_code nvarchar(50),
  @bk_press nvarchar(50),
  @bk_catalog nvarchar(30),
  @bk_language smallint,
  @bk_page_from int,
  @bk_page_to int,
  @bk_price_from money,
  @bk_price_to money,
  @bk_status nchar(2)
  )
  RETURNS TABLE
AS
	RETURN(
		select
			*
		from  TB_Book where
			(bkName like '%'+@bk_keyword+'%' or
			bkAuthor like '%'+@bk_keyword+'%' or
			bkPress like '%'+@bk_keyword+'%' or
			bkISBN like '%'+@bk_keyword+'%' or
			bkCatalog like '%'+@bk_keyword+'%') and
			
			bkCode like '%'+@bk_code+'%' and
			bkPress like '%'+@bk_press+'%' and
			bkCatalog like '%'+@bk_catalog+'%' and
			bkLanguage = @bk_language and
			bkPages >= @bk_page_from and
			bkPages <= @bk_page_to and
			bkPrice >= @bk_price_from and
			bkPrice <= @bk_price_to and
			bkStatus = @bk_status
		)
GO
/****** Object:  UserDefinedFunction [dbo].[vague_search_book_by_code]    Script Date: 12/11/2013 22:22:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[vague_search_book_by_code](
  @bkCode nvarchar(50)
  )
  RETURNS TABLE
AS
		RETURN(
		select
		bkId,
		bkCode,
		bkName,
		bkAuthor,
		bkPress,
		bkDatePress,
		bkISBN,
		bkCatalog,
		bkLanguage,
		bkPages,
		bkPrice,
		bkDateIn,
		bkBrief,
		bkCover,
		bkStatus
		from  TB_Book where
		bkCode like '%'+@bkCode+'%'
		)
GO
