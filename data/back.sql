USE [library]
GO
/****** Object:  UserDefinedFunction [dbo].[vague_search_book_by_code]    Script Date: 12/18/2013 14:17:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc back(
  @bkId int,
  @rdId int,
  @opId int
  )
AS
begin
	declare @is_borrowed int
	select @is_borrowed=COUNT(*) from TB_Borrow where IsHasReturn=0 and rdId=@rdId and bkId=@bkId
	if @is_borrowed=0
		return(0)
	else
		begin
			update TB_Book set bkStatus='ÔÚ¹Ý'
			update TB_Reader set rdHaveBorrowNum=rdHaveBorrowNum-1 where rdID=@rdId
			update TB_Borrow set IsHasReturn=1,OperatorRetId=@opId where rdId=@rdId and bkId=@bkId and IsHasReturn=0
			return(1)
		end		
end
