CREATE TABLE Product(Id int primary key,ProductName varchar(30),ListPrice dec(10,2))
Insert into Product values(1,'Mouse',100)
Insert into Product values(2,'Keyboard',200)
Insert into Product values(3,'Cpu',300)
Insert into Product values(4,'Monitor',400)
Insert into Product values(5,'Printer',500)
Insert into Product values(6,'Sandisk',600)
Insert into Product values(7,'Mouse',700)
Insert into Product values(8,'Electronic',800)
select * from Product
drop table Product
-------------Create Procedure-------------------
CREATE PROCEDURE Productsp
as begin select * from Product end;
Exec Productsp

-------------Find Procedure--------------------
CREATE PROCEDURE Productsp1
as begin select * from Product where Id=5 end;
Exec Productsp1

---------------Alter Procedure----------------

ALTER PROCEDURE Productsp
as begin insert into Product values (9,'Gadgets',900) select * from Product end;
 exec Productsp

 ---------------Drop procedure----------------
 drop Procedure Productsp

 ----------------Creating a stored procedure with one parameter-------------------
 -----------Price--------
 CREATE PROCEDURE  Productsp3(@minprice as decimal)
 as begin 
 select * from Product where ListPrice>@minprice order by ListPrice end;
 EXEC Productsp3 200
 ----------Id------------
 CREATE PROCEDURE Productsp4(@Pid as int)
 as begin
 select * from Product where Id>@Pid order by Id end;
 EXEC Productsp4 5
 --------Name---------
 CREATE PROCEDURE Productsp5 (@Pname as varchar(20))
 as begin
 Select * from Product where ProductName=@Pname end;
 EXEC Productsp5 'Mouse'

 -------stored proc with 2 parameters----------
 Create Procedure Productsp6(@Pname as Varchar(20),@Price as decimal)
 as begin select * from Product where ProductName=@Pname and ListPrice>@Price end;
 Exec Productsp6 'Mouse',100

 --------stored proc with 2 parameters---------
 create Procedure Productsp7 (@Min as decimal, @Max as decimal)
 as begin select * from Product where ListPrice>@Min and ListPrice<@Max order by ProductName end;
 Exec Productsp7 100,700


