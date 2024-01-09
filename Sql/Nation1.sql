-------------Nation---------------------
CREATE TABLE TableNation(Nation_Id int primary key,
                         Nation_Name varchar(100))
Insert into TableNation values(1,'India')
Insert into TableNation values(2,'United Nation')
Insert into TableNation values(3,'Nepal')
Insert into TableNation values(4,'Srilanka')
select * from TableNation

-------------State-------------------
CREATE TABLE TableState(State_Id int primary key,
                        State_Name varchar(100),
						Nation_Id int,
						foreign key(Nation_Id) references TableNation(Nation_Id))
Insert into TableState values(101,'Andra Pradesh',1)
Insert into TableState values(102,'Punjab',1)
Insert into TableState values(103,'California',2)
Insert into TableState values(104,'Florida',2)
Insert into TableState values(105,'Koshi',3)
Insert into TableState values(106,'Bagmati',3)
Insert into TableState values(107,'Colombo',4)
Insert into TableState values(108,'Ratnapura',4)

------------------City------------------------
CREATE TABLE TableCity(City_Id int primary key,
                        City_Name varchar(100), 
						State_Id int,
						foreign key(State_Id) references TableState(State_Id))
Insert into TableCity values(201,'Vishakhapatnam',101)
Insert into TableCity values(202,'Vijayawada',101)
Insert into TableCity values(203,'Guntur',101)
Insert into TableCity values(204,'Amritsar',102)
Insert into TableCity values(205,'Jalandhar',102)
Insert into TableCity values(206,'Chandigarh',102)
Insert into TableCity values(207,'Los Angeles',103)
Insert into TableCity values(208,'San Jose',103)
Insert into TableCity values(209,'San Diego',103)
Insert into TableCity values(2010,'Jacksonville',104)
Insert into TableCity values(2011,'Miami',104)
Insert into TableCity values(2012,'Tampa',104)
Insert into TableCity values(2013,'Damak',105)
Insert into TableCity values(2014,'Dharan',105)
Insert into TableCity values(2015,'Biratnagar',105)
Insert into TableCity values(2016,'Banepa',106)
Insert into TableCity values


(2017,'Bharatpur',106)
Insert into TableCity values(2018,'Hetauda',106)
Insert into TableCity values(2019,'Grandpass',107)
Insert into TableCity values(2020,'Borella',107)
Insert into TableCity values(2021,'Pettah',107)
Insert into TableCity values(2022,'Balangoda',108)
Insert into TableCity values(2023,'Kolonna',108)
Insert into TableCity values(2024,'Panamure',108)

-----------------TableCourseRegDetail------------------------
CREATE TABLE TableCourseRegDetail(CourseRegId int identity primary key,
                                  CategoryId int,
								  FullName varchar(100),
								  GenderId int)
drop table TableCourseRegDetail
select * from  TableCourseRegDetail

------------------------TableRegAddress-------------------------
CREATE TABLE TableRegAddress(RegAddressId int identity,
                              CourseRegId int ,
							  Nation_Id int,
							  State_Id int,
							  City_Id int,
							  foreign key(CourseRegId) references TableCourseRegDetail(CourseRegId),
							  foreign key(Nation_Id) references TableNation(Nation_Id),
							  foreign key(State_Id) references TableState(State_Id),
							  foreign key(City_Id) references TableCity(City_Id))
select * from TableRegAddress

---------------------------TableFeeDetail--------------------------
CREATE TABLE TableFeeDetail(FeeId int identity,
                            CourseRegId int,
							TotalAmount decimal,
							MiniPer decimal,
							PaidAmount decimal,
							BalAmount decimal,
							PaidDate DateTime,
							foreign key(CourseRegId) references TableCourseRegDetail(CourseRegId))


select * from  TableCourseRegDetail
select * from TableRegAddress
select * from TableFeeDetail



