create table StudentInformation
(
studentid int primary key identity(1,1),
Name nvarchar(500) unique not null,
DOB datetime2 not null,
Course nvarchar(500) not null,
Email nvarchar(500) not null,
Mobilenumber bigint 
)

select * from StudentInformation

create or alter procedure GetStudentInformation
as
begin
select * from StudentInformation
end

exec GetStudentInformation

create or alter procedure GetStudentInformationById (@id int )
as
begin
select * from StudentInformation
where studentid=@id

end

exec GetStudentInformationById 1

create or alter procedure insertStudentInformation (@Name nvarchar(500), @DOB datetime2,@cource nvarchar(500),@emaiid nvarchar(500), @Mobilenumber bigint)
   as 
   begin

   insert into StudentInformation (Name,DOB,Course,Email,Mobilenumber) values (@Name,@DOB,@cource,@emaiid,@Mobilenumber)
   end

   exec insertStudentInformation 'hari','08-08-2002','BE-EIE','haridurgesh@gmail.com',8925520077

create or alter procedure UpdateStudentInformation (@Name nvarchar(500), @DOB datetime2,@cource nvarchar(500),@emaiid nvarchar(500), @Mobilenumber bigint ,@id int)
   as
   begin
    update StudentInformation set Name=@Name,DOB=@DOB,Course=@cource,Email=@emaiid,Mobilenumber=@Mobilenumber
	where studentid=@id
	end
	exec UpdateStudentInformation 'siva','08-08-2002','BE-EIE','haridurgesh@gmail.com',8925520077,1

create or alter procedure DeleteStudentInformation (@id int)
	as
	begin
	 delete from StudentInformation where studentid =@id

 end

 exec DeleteStudentInformation  1

 create table coursename
 (
 courseid int primary key identity(1,1),
 course nvarchar(500) not null
	)

create or alter procedure GETcoursename
as
begin

	select * from coursename
	end

	exec GETcoursename


create or alter procedure GETcoursenameByid (@id int)
as
begin

	select * from coursename
	where courseid=@id
	end

	exec GETcoursenameByid 1



	create or alter procedure insertcoursename (@course nvarchar(500))
	as
	begin
	insert into coursename (course) values (@course)
	end

	exec insertcoursename 'BE-CSE'

	create or alter procedure updatecoursename (@course nvarchar(500),@id int)
	as
	begin
	update  coursename set course =@course
	where courseid=@id
	end

	exec updatecoursename 'BE-CSE',4

	create procedure Deletecoursename (@id int)
	as
	begin
	 delete from coursename where courseid =@id

 end

 exec Deletecoursename  1





