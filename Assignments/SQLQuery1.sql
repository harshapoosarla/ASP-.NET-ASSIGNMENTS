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