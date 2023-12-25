CREATE TABLE Student(Id int , Name varchar(20),Marks int, Fees bigint)
Insert into Student values(1,'Akash',20,1000)
Insert into Student values(2,'Yash',30,2000)
Insert into Student values(3,'Sarang',40,3000)
Insert into Student values(4,'Sujit',50,4000)
Insert into Student values(5,'Piyush',60,5000)
Insert into Student values(6,'Piyush',60,5000)
Insert into Student values(7,'Akash',60,5000)

select * from Student
-----------Sum Query----------------
select* from Student select Id,sum(Fees) from Student
select sum(Fees) as"Total Salary" from Student
-----------Average Query------------
select avg (Marks) as "Average" from Student where Name='Akash'
select Name,avg(Marks) as "Average" from Student group by Name
-----------Count Query--------------
select count(Fees) as"Total" from Student
select count(Fees) as "Total" from Student where Name='Akash'
select Name ,count(Fees)as "Total" from Student group by Name


