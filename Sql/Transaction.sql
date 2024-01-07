CREATE TABLE Product (Id int primary key, Name varchar(20),Quantity int,Price int)
insert into Product values(1,'Mouse',2,200)
insert into Product values(2,'Keyboard',2,300)
insert into Product values(3,'Cpu',3,400)
insert into Product values(4,'Monitor',4,500)
select * from Product

begin transaction

insert into Product values(5,'Computer',1,100)
update Product set price=400 where Id=2
rollback transaction
commit transaction