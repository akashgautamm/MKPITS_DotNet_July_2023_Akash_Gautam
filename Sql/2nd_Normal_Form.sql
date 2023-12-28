------------------------------------------------------------------------
CREATE TABLE Teacher(Id int primary key, Name varchar(20),Age int)
Insert into Teacher values(1,'Amit',25)
Insert into Teacher values(2,'David',30)
Insert into Teacher values(3,'Lucky',35)
Insert into Teacher values(4,'Rohit',40)
Insert into Teacher values(5,'Shewag',45)
select * from Teacher
------------------------------------------------------------------------
CREATE TABLE Details(Id int, Name varchar(20),Subject varchar(20),foreign key (Id) references Teacher(Id))
Insert into Details values(1,'Amit','Java')
Insert into Details values(1,'Amit','C++')
Insert into Details values(2,'David','Php')
Insert into Details values(3,'Lucky','Python')
Insert into Details values(3,'Lucky','Sql')
Insert into Details values(4,'Rohit','Mysql')
Insert into Details values(5,'Shewag','Cprogram')

select * from Teacher
select * from Details



