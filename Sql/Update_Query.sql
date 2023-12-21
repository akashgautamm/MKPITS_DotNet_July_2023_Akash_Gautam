/*---------------------Update Query-------------------*/
CREATE TABLE Products (Id int identity primary key,Name varchar(20), Price int)
insert into Products values('Mouse',200)
insert into Products values('Keyboard',300)
insert into Products values('Cpu',400)
insert into Products values('Monitor',500)
select * from Products
update Products set Price=600 where Name='Mouse'
update Products set price =1000 where Name='Cpu' and Price=400
