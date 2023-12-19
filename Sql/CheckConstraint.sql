Create table Product (Product_Id int identity primary key,Produt_Name varchar(20),Unit_Price dec(20,2) check(Unit_Price>0))
insert into Product values('Akash',10)
insert into Product values('Ajay',20)
select * from Product
delete from Product where Product_Id=1

Create table Product1 (Product_Id int identity primary key,Produt_Name varchar(20),Unit_Price dec(20,00)CONSTRAINT price  check(Unit_Price>0))
insert into Product1 values('Akash',10)
insert into Product1 values('Ajay',20)
select * from Product1

Create table Product2(Product_Id int identity primary key, Product_Name varchar(50),Unit_Price int ,check(Unit_Price>0),Discount dec(20,2),check(Discount>0),check (Discount>Unit_Price))
insert into Product2 values('Mouse',10,15)
insert into Product2 values('Keyword',10,15)
select*from Product2
drop table Product2
/*-----Using And -----*/
Create table Product3(Product_Id int identity primary key, Product_Name varchar(50),Unit_Price dec(20,2),Discount dec(20,2),Check(Unit_Price>0 and Discount>0 and Discount>Unit_Price))
insert into Product3 values('CPU',10,15)
insert into Product3 values('Monitor',10,15)
select*from Product3
/*----------Using Constraint---------*/
Create table Product4(Product_Id int identity primary key, Product_Name varchar(50),Unit_Price dec(20,2),Discount dec(20,2),Check(Unit_Price>0 and Discount>0),Constraint price1 check(Discount>Unit_Price))
insert into Product4 values('CPU',10,15,20)
insert into Product4 values('Monitor',10,15,20)
select * from Product4
sp_help Product4
Alter table Product4 add money int
Alter table Product4 add constraint ip check (money>discount)
Alter table Product4 drop constraint money
drop table Product4