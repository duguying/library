USE [library]
GO
/****** Object:  UserDefinedFunction [dbo].[vague_search_book_by_code]    Script Date: 12/18/2013 14:17:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc borrow(
  @bkId int,
  @rdId int,
  @opId int
  )
AS
begin
	declare @book_is_in int
	declare @reader_have_borrow int
	declare @reader_can_borrow int
	declare @can_borrow_day int
	
	set @book_is_in=(select count(*) from TB_Book where bkId=@bkId and bkStatus='ÔÚ¹Ý')
	
	select @reader_have_borrow=rdHaveBorrowNum,@reader_can_borrow=maxBorrowNum,@can_borrow_day=maxBorrowDay 
		from TB_Reader,TB_ReaderType where TB_Reader.rdType=TB_ReaderType.rdType and rdID=@rdId
	
	if @reader_have_borrow<@reader_can_borrow and @book_is_in!=0
		begin
			insert into TB_Borrow(rdId,bkId,ldContinueTimes,ldDateOut,ldDateRetPlan,IsHasReturn,OperatorLendId) 
							values(@rdId,@bkId,0,Getdate(),DATEADD(DAY,+@can_borrow_day,Getdate()),0,@opId)
			update TB_Reader set rdHaveBorrowNum=rdHaveBorrowNum+1 where rdID=@rdId
			update TB_Book set bkStatus='½è³ö' where bkId=@bkId
			return(1)
		end
	else
		return(0)
		
end

exec borrow 5,73,1