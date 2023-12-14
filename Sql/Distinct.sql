create table Mkpits (id int, marks int,fees bigint,attendance int)
insert into Mkpits values(1,80,12000,80)
insert into Mkpits values(2,50,10000,70)
insert into Mkpits values(3,70,15000,90)
insert into Mkpits values(4,40,18000,85)
insert into Mkpits values(5,60,17550,83)
insert into Mkpits values(6,80,12500,80)
insert into Mkpits values(7,56,10010,64)
insert into Mkpits values(8,78,15050,91)
insert into Mkpits values(9,49,18950,79)
insert into Mkpits values(10,68,17550,33)

select TOP 5 marks from Mkpits 
select Top 3 fees from Mkpits order by fees Desc
select Top 20 percent attendance from Mkpits 
