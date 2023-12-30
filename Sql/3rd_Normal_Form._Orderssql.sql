CREATE TABLE Orders (Orderid int primary key,Productid int,Rate int,Quantity int)
Insert into Orders values(1,11,200,2)
Insert into Orders values(2,12,300,3)
Insert into Orders values(3,13,400,2)



CREATE TABLE Customers(Custid int primary key,City varchar(50),State varchar(50),Orderid int,Orderdate date,foreign key (Orderid) references Orders(Orderid))
Insert into Customers values(101,'Nagpur','Maharashtra',1,'2023-12-21')
Insert into Customers values(102,'Pune','Maharashtra',1,'2023-12-21')
Insert into Customers values(103,'Surat','Gujrat',2,'2023-12-22')
Insert into Customers values(104,'Indore','MP',3,'2023-12-23')
Insert into Customers values(105,'Bhopal','MP',3,'2023-12-23')





CREATE TABLE Deliver(Custid int,Cityid int primary key,Orderid int,Orderdate date,foreign key(Orderid)references Orders(Orderid),foreign key(Custid)references Customers(Custid))
Insert into Deliver values(101,201,1,'2023-12-21')
Insert into Deliver values(102,202,1,'2023-12-22')
Insert into Deliver values(103,203,2,'2023-12-23')
Insert into Deliver values(104,204,3,'2023-12-24')
Insert into Deliver values(105,205,3,'2023-12-25')


CREATE TABLE Citys(Cityid int,Cityname varchar(20),Stateid int primary key)
Insert into Citys values(201,'Nagpur',301)
Insert into Citys values(202,'Hyderabad',302)
Insert into Citys values(203,'Kashmir',303)
Insert into Citys values(204,'Surat',304)
Insert into Citys values(205,'Indor',305)



CREATE TABLE States(Stateid int,Statename varchar(50),foreign key(Stateid)references Citys(Stateid))
Insert into States values(301,'Maharashtra')
Insert into States values(302,'UP')
Insert into States values(303,'Jammu')
Insert into States values(304,'Gujrat')
Insert into States values(305,'MP')


select * from Orders
select * from Customers
select * from Deliver
select * from Citys
select * from States