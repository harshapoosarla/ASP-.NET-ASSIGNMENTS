create database IndividualAuth

use IndividualAuth
drop database IndividualAuth


select * from AspNetRoles;
select * from AspNetUserClaims;
select * from AspNetUserLogins;
select * from AspNetUserRoles;
select * from AspNetUsers;


insert into AspNetRoles(Id,Name) values (1,'Products');
insert into AspNetRoles(Id,Name) values (2,'Orders');
insert into AspNetRoles(Id,Name) values (3,'Users');

insert into AspNetUserRoles(UserId,RoleId) values('0e0ce4a4-2dac-46cf-b393-1a183f279e06',1);
insert into AspNetUserRoles(UserId,RoleId) values('152d40ec-ed7d-4aa0-9b74-b4ef19db4782',2);
insert into AspNetUserRoles(UserId,RoleId) values('60894d11-6c04-4a74-8b9f-ea8e7c6289f4',3);








create table Products(Id int primary key identity(1,1),Name nvarchar(50),Price float,URL nvarchar(250),Description nvarchar(3000),Brand_Id int foreign key references Brand(Id))
create table Brand(Id int primary key identity(1,1),Name nvarchar(50))

select * from Products
select * from Brand

drop table Brand
drop table Products

insert into Brand(Name)values('Apple')
insert into Brand(Name)values('Samsung')
insert into Brand(Name)values('Moto')
insert into Brand(Name)values('OnePlus')

insert into Products(Name,Price,URL,Description,Brand_Id) values ('iPhone',85000,'Content/iphone.jpg','Meet the iPhone-X the device that is so smart that it responds to atap,your voice,and even a glance.It comes with 64GB ROM,5.8 inch Super Retina HD Display,All Screen OLED Multi-Touch Display',1)
insert into Products(Name,Price,URL,Description,Brand_Id) values ('Apple Watch',40000,'Content/watch.jpg','Watch Series 3 GPS-42mm Space Grey Aluminium Case with Black Sport Band',1)
insert into Products(Name,Price,URL,Description,Brand_Id) values ('Apple Airpods',12000,'Content/airpods.jpg','Wireless,Effortless,Magical.Airpods will forever change the way you use headphones.When ever you pull out of the case they instantly turn on connect to your phone.It comes with a Microphone with a Canalphone Design and is compatible with Mobile',1)
insert into Products(Name,Price,URL,Description,Brand_Id) values ('iPad Pro',90000,'Content/ipad.jpg','Whatever the job is the iPad is up for it.The iPad boasts incredible power and is delightfully simple to use.It comes with a 10.5 Retina for stunning detail and 64GB ROM,26.67 cm(10.5 inch)Quad HD Display,12 MP Primary Camera|7 MP Front',1)
insert into Products(Name,Price,URL,Description,Brand_Id) values ('one plus6',35000,'Content/oneplus6.jpg','6GB RAM,6.28 inch,2280 x 1080 pixels,Optic AMOLED,402 PPI',4)
insert into Products(Name,Price,URL,Description,Brand_Id) values ('samsung s7',52000,'Content/s7.jpg','6GB RAM,6 inch,2280 x 1080 pixels,Optic AMOLED,600 PPI',2)
insert into Products(Name,Price,URL,Description,Brand_Id) values ('samsung s8',35000,'Content/s8.jpg','6GB RAM,6.28 inch,2280 x 1080 pixels,Optic AMOLED,402 PPI',2)
insert into Products(Name,Price,URL,Description,Brand_Id) values ('iPhone 7plus',75000,'Content/iphone 7plus.jpg','Meet the iPhone-7plus the device that is so smart that it responds to atap,your voice,and even a glance.It comes with 64GB ROM,5.8 inch Super Retina HD Display,All Screen OLED Multi-Touch Display',1)
insert into Products(Name,Price,URL,Description,Brand_Id) values ('iPhone 8plus',80000,'Content/iphone 8plus.jpg','Meet the iPhone-X the device that is so smart that it responds to atap,your voice,and even a glance.It comes with 64GB ROM,5.8 inch Super Retina HD Display,All Screen OLED Multi-Touch Display',1)
insert into Products(Name,Price,URL,Description,Brand_Id) values ('moto g6',20000,'Content/moto g6.jpg','Meet the moto g6 the device that is so smart that it responds to a tap.It comes with 64GB ROM,5.8 inch Super Retina HD Display,All Screen OLED Multi-Touch Display',3)






drop table Products

select * from __MigrationHistory
select * from AspNetRoles
select * from AspNetUserClaims
select * from AspNetUserLogins
select * from AspNetUserRoles
insert into AspNetUserRoles(UserId,RoleId) values('eaa901c9-f04e-4d25-b9b4-f5f2e4346772',3)

alter table AspNetUserRoles drop column where RoleId=3
select * from AspNetUsers
select * from Products