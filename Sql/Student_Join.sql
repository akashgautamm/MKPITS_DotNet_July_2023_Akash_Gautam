CREATE TABLE Student (Anmissio_No int ,Firstname varchar(20),Lastname varchar(20),Age int,City varchar(20))
insert into Student values(101,'Akash','Gautam',20,'Nagpur')
insert into Student values(102,'Yash','Kumbhalkar',19,'Bhandara')
insert into Student values(103,'Sahil','Kalwe',21,'Gondia')
insert into Student values(104,'David','Kothe',20,'Gondia')
insert into Student values(105,'Sarang','Prajapati',21,'Wadha')
insert into Student values(106,'Sujit','Mishra',19,'Wardha')
insert into Student values(107,'Chandu','Ghosh',20,'Jalna')
insert into Student values(108,'Sanket','Manwatkar',21,'Nagpur')
select * from Student
drop table Student

CREATE TABLE Fees(Admission_No int,Course varchar(20),Amount_Paid bigint)
insert into Fees values(101,'Java',20000)
insert into Fees values(102,'Dotnet',10000)
insert into Fees values(103,'Sql',20000)
insert into Fees values(104,'Java',40000)
insert into Fees values(105,'Python',30000)
insert into Fees values(106,'Java',20000)
insert into Fees values(107,'Dotnet',10000)
insert into Fees values(108,'Sql',20000)
insert into Fees values(109,'Java',40000)
insert into Fees values(1010,'Python',30000)
select * from Fees
drop table Fees


select Student.Anmissio_No,Student.Firstname,Student.Lastname,Student.Age,Student.City,Fees.Course,Fees.Amount_Paid from Student
inner join Fees on Student.Anmissio_No=Fees.Admission_No

/*------------OUTER JOIN----------------*/
select * from Student cross join Fees

/*-----------Right & Left outer join-------------*/ 
select * from Student left outer join Fees on Student.Anmissio_No=Fees.Admission_No
select * from Student right outer join Fees on Student.Anmissio_No=Fees.Admission_No








