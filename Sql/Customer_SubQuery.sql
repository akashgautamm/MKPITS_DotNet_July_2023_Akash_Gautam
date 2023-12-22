create table Customer(CustomerId int ,FirstName varchar(20),LastName varchar(20),State varchar(20), City varchar(20))
insert into Customer values(1,'Akash','Gautam','Maharashtra','Nagpur')
insert into Customer values(2,'Ankit','Yadav','Mp','Bhopal')
insert into Customer values(3,'Sujit','Singh','Maharashtra','Bhopal')
insert into Customer values(4,'Sarang','Prajapati','Maharashtra','Nagpur')
insert into Customer values(5,'Ajit','Singh','Maharashtra','Nagpur')
select * from Customer

create table Orders(OrderId int,CustomerId int,ProductName varchar(20),Quantity varchar(20))
insert into Orders values(1,1,'Mouse',2)
insert into Orders values(2,2,'Mouse',2)
insert into Orders values(3,3,'Mouse',2)
insert into Orders values(4,4,'Mouse',2)
insert into Orders values(5,5,'Mouse',2)
select * from Orders

/*------------------SubQuery-----------------*/

select  OrderId,CustomerId,ProductName,Quantity
from Orders where CustomerId in(select CustomerId from Customer where City='Nagpur')


/*----------------SubQuery2---------------*/
select * from Orders  where CustomerId in(select CustomerId from Customer where City='Bhopal'