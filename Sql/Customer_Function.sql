create table Customer(id int primary key,name varchar(20),state varchar(20))
insert into Customer values(1,'Lucky','Maharashtra')
insert into Customer values(2,'Akash','Gujrat')
insert into Customer values(3,'Sujit','Rajasthan')
insert into Customer values(5,'Hemant','Kerla')
insert into Customer values(4,'Shardul','Kashmir')
insert into Customer values(6,'Bobby','Hyderabad')
insert into Customer values(7,'Yash','Mp')
insert into Customer values(8,'Chandu','Up')
insert into Customer values(9,'Rahul','Himachal')
insert into Customer values(10,'Virat','Jaipur')

select * from Customer order by name     /*sequence wise name in ascending order*/
select * from Customer order by name desc  /*Sequencw wise name in descending order */

select *from Customer order by id    /*sequenct wise id */
select *from Customer order by state /*sequence wise state name */

select * from Customer where id=1 /*only selected data shown*/
select * from Customer where id>1 and id<=5

select * from Customer where state='Mp'
select *from Customer where state='Maharashtra' order by name



