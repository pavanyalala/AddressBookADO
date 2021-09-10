create database AddressBookADO

create table AddressBook
(
  FirstName varchar(20) not null,
  LastName varchar(20) not null,
  Address varchar(20) not null,
  City varchar(20) not null,
  State varchar(20) not null,
  Zip float not null,
  PhoneNumber float not null,
  Email varchar(50) not null
)

Insert into AddressBook(FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email)
values
('Bunny','ABC','Dammaiguda','Hyderabad','Telangana',5000,1111111111,'bunny@gmail.com'),
('Sunny','XYZ','Kothapet','Hyderabad','Telangana',6000,2222222222,'sunny@gmail.com'),
('Bunty','DEF','Nagole','Hyderabad','Telangana',7000,3333333333,'bunty@gmail.com')

select * from AddressBook