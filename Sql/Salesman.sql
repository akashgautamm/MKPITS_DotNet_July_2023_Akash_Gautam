/*-------------Q1--------------------*/
create table Salesman(Id int , Name varchar(20), City varchar(20),Commission float)
insert into Salesman values(5001,'James Hoog','New York',0.15),
(5002,'Nail Knite','Paris',0.13),
(5003,'Pit Alex','London',0.11),
(5004,'Nail Knite','Paris',0.13),
(5005,'Pit Alex','London',0.11),
(5006,'Nail Knite','Paris',0.13)
select*from Salesman

/*------------------Q2----------------*/
create table Salesman1(Id int , Name varchar(20), City varchar(20),Commission float)
insert into Salesman1 values(5001,'James Hoog','New York',0.15),
(5002,'Nail Knite','Paris',0.13),
(5003,'Pit Alex','London',0.11),
(5004,'Nail Knite','Paris',0.13),
(5005,'Pit Alex','London',0.11),
(5006,'Nail Knite','Paris',0.13)
select Name ,Commission from Salesman1

/*Write a query to display the columns in a specific order like order date, salesman id, order number
and purchase amount from for all the orders.*/
create table Salesman2(Order_No int,Purchase_Amt bigint,Order_Date date,Customer_Id int,Salesman_Id int)












