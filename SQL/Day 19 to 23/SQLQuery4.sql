alter procedure InsertHostelStudent
	@StudentId int,
	@RoomNo int
as
begin
	declare @count int;

	select @count = count(*)
	from [dbo].[Hostel];

	if @count < 5
	begin
		insert into [dbo].[Hostel](StudentId, RoomNo)
		values (@StudentId,@RoomNo);
	end
end

exec InsertHostelStudent 1,5

select * from [dbo].[Hostel]

alter procedure AddStudent
	@StudentId int,
	@RoomNo int
as
begin
	insert into [dbo].[Hostel] (StudentId, RoomNo)
	values (@StudentId, @RoomNo)
end

alter table [dbo].[Hostel] add constraint c1
	check (RoomNo > 100)


exec AddStudent 8, 106

select DATEADD (year, 1, getdate()) as warrantyDate
select DATEDIFF (MONTH, '2025/11/21', '2026/1/28') as diff

create proc students_born_in 
	@input int
as begin
	select Name from CollegeMaster
	where month(month) = @input;
end;

exec students_born_in 8;

select * from [dbo].[CollegeMaster]
