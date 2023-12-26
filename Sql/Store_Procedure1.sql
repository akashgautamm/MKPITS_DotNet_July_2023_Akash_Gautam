Create table Employe(Id int primary key,Departmentid int ,Name varchar(20),Departmentname varchar(20),Salary bigint) 
insert into Employe values(1,1,'Akash','Manager',1000)
insert into Employe values(2,2,'Sujit','Clerk',2000)
insert into Employe values(3,3,'Sarang','Manager',3000)
insert into Employe values(4,4,'David','Clerk',4000)
insert into Employe values(5,5,'Lucky','Peon',5000)
drop table Employe
--------------------------Count Employe------------------------------
create procedure p5 as begin select count(*) as "Total" from Employe end;
exec p5
-------------------------Single Parameter-------------------------------
create procedure p8 (@id int)as begin select * from Employe where Id=@id end;
exec p8 2
------------------------Maximum Salary---------------------------------
create procedure p11 (@salary bigint)as begin select * from Employe where Salary>@salary end;
exec p11 2000
------------------------Average Salary---------------------------------
create procedure p12 as begin select avg(Salary)as"Average" from Employe end;
Exec p12



	
