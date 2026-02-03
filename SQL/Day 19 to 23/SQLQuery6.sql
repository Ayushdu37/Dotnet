select * from [dbo].[CollegeMaster]
where Id between 5 and 10
union all
select * from [dbo].[CollegeMaster]
where Id between 5 and 10

----------------------------------

select * from [dbo].[CollegeMaster]
where Id between 5 and 10
union 
select * from [dbo].[CollegeMaster]
where Id between 5 and 10

-----------------------------------

create table CommonHostel(
	Id int IDENTITY(1,1) NOT NULL,
	RoomNo int NOT NULL,
	StudentId int NOT NULL
);

create table PunjabSport(
	Id int primary key identity(1,1) not null,
	Name varchar(50) not null,
	SportsName varchar(50) not null,
);

insert UpSport(Name, SportsName)
values('Mari', 'cricket'),
('Mr.A', 'football'),
('Mr.B', 'cricket')

insert PunjabSport(Name, SportsName)
values('Mari', 'cricket'),
('Mr.Y', 'cricket'),
('Mr.Z', 'Basketball')

select * from UpSport
union 
select * from PunjabSport;