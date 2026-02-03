

alter procedure dbo.GetStudentByDept
	@dept NVARCHAR(10), --Input parameter
	@StudentCount INT OUTPUT --Output parameter
AS
BEGIN
	select @StudentCount = count(*) from [dbo].[CollegeMaster] where [Department]=@dept
END;
-----
declare @scount int
exec [dbo].[GetStudentByDept]
@dept = 'CSE',
@StudentCount = @scount output

select @scount