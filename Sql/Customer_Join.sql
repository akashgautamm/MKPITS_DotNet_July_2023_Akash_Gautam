create table Customer (Custid int,Custname varchar(20),Telno bigint)
insert into Customer values(201,'Akash',99897)
insert into Customer values(202,'Sanket',5557)
insert into Customer values(203,'Sarang',89755)
insert into Customer values(204,'Piyush',669897)
insert into Customer values(205,'Sujit',39897)
insert into Customer values(206,'Raj',857897)
insert into Customer values(207,'Ashwin',499897)
insert into Customer values(208,'Sahil',99897)
drop table Customer
select * from Customer

create table Orders(Orderid int ,Orderdate date,Custid int,Producctname varchar(20),Quantity int ,Rate int)
insert into Orders values(1,'2023-05-10',201,'Steel',20,100)
insert into Orders values(2,'2023-05-11',202,'Bronze',20,200)
insert into Orders values(3,'2023-05-12',203,'Gold',20,300)
insert into Orders values(4,'2023-05-13',204,'Iron',20,500)
insert into Orders values(5,'2023-05-14',205,'Steel',20,500)

select * from Orders
drop table Orders


/*-------INNER JOIN-----------*/ 
select Customer.Custid,Customer.Custname,Customer.Telno,Orders.Orderid,Orders.Orderdate,Orders.Producctname,Orders.Quantity,Orders.Rate
from Customer inner join Orders on Customer.Custid=Orders.Custid
select * from Customer inner join  Orders on Customer.Custid=Orders.Custid

/*------------OUTER JOIN----------------*/
select Customer.Custid,Customer.Custname,Customer.Telno,Orders.Orderid,Orders.Orderdate,Orders.Producctname,Orders.Quantity,Orders.Rate from Customer cross join Orders
select * from Customer cross join  Orders

/*-----------Right & Left outer join-------------*/ 
select * from Customer left outer join Orders on Customer.Custid=Orders.Custid
select * from Customer right outer join Orders on Customer.Custid=Orders.Custid
select * from Customer full outer join Orders on Customer.Custid=Orders.Custid

create table Person1(id int identity primary key, FirstName varchar(20) ,LastName varchar(20),City varchar(20))
insert into Person1 values('Amit','Kalwe','Nagpur')
insert into Person1 values('Anshul','koche','Amaravti')
insert into Person1 values('Sarang','Prajapati','Wardha')
insert into Person1 values('Akash','Gautam','Wardha')
insert into Person1 values('Yash','Mishra','Nagpur')
insert into Person1 values('Hemant','Pandey','Gondia')
select * from Person1
drop table Person1
/*---------------Self join----------------*/
select p1.FirstName ,p2.LastName,p2.City from Person1 p1,Person1 p2 where p1.id<>p2.id and p1.City=p2.City order by  p2.city