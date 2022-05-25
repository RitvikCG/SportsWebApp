Create database Sports;

Create table sports_table(id int primary key identity(1,1) , sports_name VarChar(20) , sports_type VarChar(20) , max_members int NOT NULL);


insert into sports_table values('Cricket','Outdoor',11);
insert into sports_table values('Football','Outdoor',11);
insert into sports_table values('Chess','Indoor',1);
insert into sports_table values('Carrom Board','Indoor',1);
insert into sports_table values('BasketBall','Outdoor',5);
insert into sports_table values('TableTennis','Indoor',1);
insert into sports_table values('VolleyBall','Outdoor',6);