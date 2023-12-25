CREATE TABLE Employe(Id int ,Name varchar(20),Department varchar(20),City varchar(20),Salary bigint)
Insert into Employe values(1,'Akash','Manager','Nagpur',1000)
Insert into Employe values(2,'Piyush','Manager','Mumbai',2000)
Insert into Employe values(3,'Sarang','Account','Jaipur',3000)
Insert into Employe values(4,'David','Computer','Nashik',4000)
Insert into Employe values(5,'Lucky','Computer','Pune',5000)
select * from Employe
-------------Simple Table Show-------------- 
CREATE FUNCTION f1() returns table as return(select * from Employe)
Select * from f1()

---------------Scaler Function--------------
Create function f3(@Ename varchar(20),@EDepartment varchar(20),@Ecity varchar(20)) 
returns varchar(60) as begin return(select @Ename+''+@EDepartment+''+@Ecity)end
select dbo.f3(Name,Department,City)as 'Details' from Employe

Create Table Marks(Rno int, Mark1 int, Mark2 int, Mark3 int)
Insert into Marks values(1,80,80,80)
Insert into Marks values(2,70,70,70)
Insert into Marks values(3,90,90,90)
Insert into Marks values(4,60,60,60)
Insert into Marks values(5,50,50,50)
select * from Marks
-------------Marks Sum--------------
create function f6(@Mark1 int, @Mark2 int, @Mark3 int)
returns int as begin return(select @Mark1+@Mark2+@Mark3)end;
select dbo.f6(Mark1,Mark2,Mark3)as 'Total Marks' from Marks
------------------Percentage------------------
create function f8(@Mark1 int, @Mark2 int, @Mark3 int)
returns int as begin return(select (@Mark1+@Mark2+@Mark3)*0.3)end;
select dbo.f8 (Mark1,Mark2,Mark3)as 'Percentage' from Marks
