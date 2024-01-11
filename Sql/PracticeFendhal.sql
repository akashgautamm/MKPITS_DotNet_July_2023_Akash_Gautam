CREATE TABLE TableNation(NationId int primary key,
                        NationName varchar(200))
Insert into TableNation values(1,'India')
Insert into TableNation values(2,'Australia')
Insert into TableNation values(3,'Srilanka')

CREATE TABLE TableState(StateId int primary key,
                        NationId int,
						StateName varchar(200),
						foreign key (NationId) references TableNation(NationId))
Insert into TableState values(11,1,'Up')
Insert into TableState values(12,1,'Mp')
Insert into TableState values(13,2,'Melborn')
Insert into TableState values(14,2,'Sydney')
Insert into TableState values(15,3,'Colombo')
Insert into TableState values(16,3,'Trivanth')
drop table TableState




CREATE TABLE TableCity(CityId int primary key,
                      StateId int,
					  CityName varchar(200),
					  foreign key (StateId)  references TableState(StateId))
Insert into TableCity values(21,11,'Heyderabad')
Insert into TableCity values(22,12,'Rewa')
Insert into TableCity values(23,13,'Mel')
Insert into TableCity values(24,14,'Syd')
Insert into TableCity values(25,15,'Colo')
Insert into TableCity values(26,16,'Ajni')

drop table TableCity

Create Table TableCourseRegDetail(CourseRegId int identity primary key,
                                  CategoryId int,
								  FullName varchar(200),
								  GenderId int)
select * from TableCourseRegDetail
Create Table TableRegAddress(RegAddressId int identity,
                             CourseRegId int,
							 NationId int,
							 StateId int,
							 CityId int,
							 foreign key(CourseRegId) references TableCourseRegDetail(CourseRegId),
							 foreign key(NationId) references TableNation(NationId),
							 foreign key(StateId) references TableState(StateId),
							 foreign key(CityId) references TableCity(CityId))
select * from TableRegAddress
Create Table TableFeeDetail(FeeId int identity,
                            CourseRegId int,
							TotalAmount int,
							MiniPer decimal,
							PaidAmount decimal,
							BalAmount decimal,
							PaidDate datetime,
							foreign key(CourseRegId) references TableCourseRegDetail(CourseRegId));

drop table TableFeeDetail
select * from TableFeeDetail




















++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


