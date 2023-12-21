/*-------------------Delete Query-------------------*/
Create table Products1 (Id int identity primary key, Name varchar(20),Price int)
insert into Products1 values('Mouse',100)
insert into Products1 values('Cpu',200)
insert into Products1 values('Keyboard',300)
insert into Products1 values('Monitor',400)
insert into Products1 values('Laptop',500)
select * from Products1
delete from Products1 where Name='Keyboard'
sp_help Products1
delete from Products1
/*-----------------Truncate-------------------*/
truncate table Products1  /*truncate are showing delete id numbers are showing in starting 1 */

/*---------Alter-----------*/
Alter table Products1 add Quantity int
/*---------Column data type change-----------*/
Alter table Products1 alter column Quantity dec(10,2)	
/*---------Delte Column-----------*/

Alter table Products1 drop column Quantity

EXEC sp_rename 'Products1.Name','Firstname','Column'