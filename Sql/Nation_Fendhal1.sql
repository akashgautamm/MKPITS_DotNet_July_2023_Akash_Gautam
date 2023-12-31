CREATE TABLE TableNation(NationID int primary key,NationName varchar(500))
Insert into TableNation values(1,'India')
Insert into TableNation values(2,'China')
Insert into TableNation values(3,'Span')
Insert into TableNation values(4,'Russia')
Insert into TableNation values(5,'Japan')


CREATE TABLE TableState (StateID int primary key,NationID int,StateName varchar(500),foreign key(NationID) references TableNation(NationID))
Insert into TableState values(101,1,'Maharashtra')
Insert into TableState values(102,1,'MP')
Insert into TableState values(103,2,'Chinese1')
Insert into TableState values(104,2,'Chinese2')
Insert into TableState values(105,3,'Spanish1')
Insert into TableState values(106,4,'Spanish2')
Insert into TableState values(107,5,'Japanish')



CREATE TABLE TableCity(CityID int primary key,StateID int,CityName varchar(500),foreign key (StateID) references TableState(StateID))
Insert into TableCity values(201,101,'Nagpur')
Insert into TableCity values(202,101,'Pune')
Insert into TableCity values(203,102,'Rewa')
Insert into TableCity values(204,102,'Indore')
Insert into TableCity values(205,103,'Chinese3')
Insert into TableCity values(206,104,'Chinese4')
Insert into TableCity values(207,105,'Spanish3')
Insert into TableCity values(208,106,'Russia2')
Insert into TableCity values(209,107,'Japanish2')



CREATE TABLE TableCourseRegDetail(CourseRegID int primary key, CategoryID int, FullName varchar(1500), GenderID int)
Insert into TableCourseRegDetail values(301,401,'Akash Gautam',11)
Insert into TableCourseRegDetail values(302,402,'Rahul Mishra',12)
Insert into TableCourseRegDetail values(303,403,'Yash Kumbhalkar',13)
Insert into TableCourseRegDetail values(304,404,'David Kothe',14)
Insert into TableCourseRegDetail values(305,405,'Ved Bagde',15)


CREATE TABLE TableRegAddress(RegAddressID int,CourseRegID int,NationID int, StateID int ,CityID int,foreign key(NationID) references TableNation(NationID),foreign key(StateID) references TableState(StateID),foreign key (CityID) references TableCity(CityID),foreign key (CourseRegID) references TableCourseRegDetail ( CourseRegID))
Insert into TableRegAddress values(501,301,1,101,201)
Insert into TableRegAddress values(502,302,2,103,205)
Insert into TableRegAddress values(503,303,3,105,207)
Insert into TableRegAddress values(504,304,4,106,208)
Insert into TableRegAddress values(505,305,5,107,209)




CREATE TABLE TableFeeDetail(FeeID int,CourseRegId int,TotalAmount Decimal(10,2),MinPer Decimal(10,2),PaidAmount Decimal(10,2),BalAmount Decimal(10,2),PaidDate date,foreign key (CourseRegID) references TableCourseRegDetail ( CourseRegID))
Insert into TableFeeDetail values (21,301,100,50,50,50,'2023-12-21')
Insert into TableFeeDetail values (22,302,100,50,60,40,'2023-12-22')
Insert into TableFeeDetail values (23,303,100,50,70,30,'2023-12-23')
Insert into TableFeeDetail values (24,304,100,50,80,20,'2023-12-24')
Insert into TableFeeDetail values (25,305,100,50,90,10,'2023-12-25')


select * from TableNation
select * from   TableState
select * from	 TableCity
select * from	 TableCourseRegDetail
select * from  TableRegAddress
select * from  TableFeeDetail
drop table TableFeeDetail