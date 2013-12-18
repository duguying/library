USE [library]
GO
/****** Object:  UserDefinedFunction [dbo].[vague_search_book_by_code]    Script Date: 12/18/2013 14:17:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc renew(
  @bkId int,
  @rdId int,
  @opId int
  )
AS
begin
	
	declare @is_borrowed int
	declare @can_continue_time int
	declare @has_continue_time int
	declare @can_borrow_day int
	
	select @is_borrowed=COUNT(*) from TB_Borrow where IsHasReturn=0 and rdId=@rdId and bkId=@bkId
	select @can_continue_time=maxContinueTimes,@has_continue_time=rdHaveBorrowNum,@can_borrow_day=maxBorrowDay 
		from TB_Reader,TB_ReaderType where TB_Reader.rdType=TB_ReaderType.rdType and TB_Reader.rdID=@rdId
		
	if @is_borrowed=0 and @can_continue_time<@has_continue_time
		return(0)
	else
		begin
			update TB_Borrow 
				set ldDateOut=GETDATE(),ldContinueTimes=ldContinueTimes+1,ldDateRetPlan=DATEADD(DAY,+@can_borrow_day,Getdate()) 
				where rdId=@rdId and bkId=@bkId and IsHasReturn=0
			return(1)
		end		
end
