CREATE TABLE Courses(

Id int not null primary key identity,
Title nvarchar(max) not null,
Teacher nvarchar(max) not null,
WorkLoad nvarchar(100) not null,
Description nvarchar(max) not null
);