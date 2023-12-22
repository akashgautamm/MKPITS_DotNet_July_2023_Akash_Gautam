
CREATE TABLE Student(Rno int,Name varchar(20), Email varchar(20),City varchar(20),CourseId int)
Insert into Student values(1,'Akash','akash@123','Nagpur',1)
Insert into Student values(2,'Sarang','sarang@123','Amravti',2)
Insert into Student values(3,'David','david@123','Amravti',3)
Insert into Student values(4,'Sujit','sujit@123','Nagpur',4)
Insert into Student values(5,'Payuu','payu@123','Wardha',5)
Insert into Student values(6,'Praku','praku@123','Wardha',6)
Select * from Student

CREATE TABLE Fees(FeesId int ,Rno int,FeesDate date,Amount int ,CourseId int)
Insert into Fees values(1,1,'2023-12-15',1000,1)
Insert into Fees values(2,2,'2023-10-16',2000,2)
Insert into Fees values(3,3,'2023-11-17',3000,3)
Insert into Fees values(4,4,'2023-09-15',4000,4)
Insert into Fees values(5,5,'2023-11-18',5000,5)
Insert into Fees values(6,6,'2023-12-19',6000,6)
Select * from Fees
------------------------------SubQuery-------------------------------------------
select FeesId,Rno,FeesDate,Amount,CourseId
from Fees where CourseId in(select CourseId from Student where City='Nagpur')
select FeesId,Rno,FeesDate,Amount,CourseId
from Fees where CourseId in(select CourseId from Student where City='Amravti')
select FeesId,Rno,FeesDate,Amount,CourseId
from Fees where CourseId in(select CourseId from Student where City='Wardha')



CREATE TABLE Courses(CourseId int,CourseName varchar(20),Fees int,Duration int)
Insert into Courses Values(1,'Java',1000,2)
Insert into Courses Values(2,'Java',2000,2)
Insert into Courses Values(3,'Php',3000,2)
Insert into Courses Values(4,'Php',4000,2)
Insert into Courses Values(5,'Java',5000,2)
Insert into Courses Values(6,'Java',6000,2)
select * from Courses


select Rno,Name,Email,City,CourseId from Student Where CourseId in(Select CourseId from Courses where CourseName='Java')
select Rno,Name,Email,City,CourseId from Student Where CourseId in(Select CourseId from Courses where CourseName='Php')


