-- to create a database obkect
create database my_database;

-- create a database table
use db_college;
create table tbl_students 
(
  roll int primary key identity(1,1),
  sname varchar(50) not null,
  saddress varchar(50) not null,
  sage int not null,
  sdob date not null
);

-- to insert data into database table
use db_college;
insert into tbl_students (sname,saddress,sage,sdob) values ('ram', 'pokhara', 22, '1992-12-12');

-- to disolay all the data from the databse table
use db_college; 
select * from tbl_students;

-- to insert data into database table (method two)
use db_college;
insert into tbl_students values ('sita', 'kathmandu', 24, '2003-2-24');

-- to insert data into database table (method three)
use db_college;
insert into tbl_students values 
('rita', 'kathmandu', 24, '2003-2-24'),
('mina', 'sanga', 20, '2013-2-24'),
('badal', 'khotang', 19, '2013-2-24'),
('sabin', 'jhapa', 17, '2033-2-24'),
('sujan', 'mustang', 12, '2005-2-24')
;
