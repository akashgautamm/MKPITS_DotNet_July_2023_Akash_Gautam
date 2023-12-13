create table Employe (id int,first varchar(20),last varchar(20),city varchar(20),state varchar(20))
insert into Employe values(1,'Amit','Shah','Nagpur','Maha')
insert into Employe values(1,'Sarang','Prajapati','Nagpur','Maha')
insert into Employe values(1,'Rahul','Mishra','Raipur','Jaipur')
select city,COUNT(*) from Employe where state='Maha' group by city
