--UC1 Create Database

create Database Address_Book;
use Address_Book;

--UC2 Create Table Address_Book

create Table Address_Book
(FirstName varchar(100), LastName varchar(100), Address varchar(300), 
City varchar(50), State varchar(30), ZipCode int, PhoneNumber bigint, EMailId varchar(50) )

--UC3 Insert New Contacts in Address_Book

insert into Address_Book values
('Parnika', 'Vishwakarma', 'Kengeri', 'Bangalore', 'Karnataka', 123456, 9876543212, 'parnika@gmail.com'),
('Sunil', 'Kumar', 'Malleshwaram', 'Mysore', 'Karnataka', 135798, 8765432123, 'Sunil09@gmail.com'),
('Bindhu', 'Shree', 'Hossur', 'Chennai', 'TamilNadu', 234567, 7654321234, 'Bin9876@gmail.com'),
('Sumit', 'Rao', 'Budhera', 'Gurgao', 'Haryana', 234123, 6543212345, 'sumit65@gmail.com'),
('Mansi', 'Adiga', 'Dasanpura', 'Trivendrum', 'Kerala', 211011, 9878987654, 'Mansi@gmail.com'),
('Anamika', 'Rathod', 'Samalkha', 'Panipat', 'Haryana', 212234, 9753124680, 'anamika@gmail.com')

--UC4 Edit Person Details using Name

update Address_Book set EMailId = 'Adiga12@gmail.com' where LastName = 'Adiga'

--UC5 Delete record using Name

delete from Address_Book where FirstName = 'Sumit'

--UC6 Revtive person details using state or city name 

select * from Address_Book where State = 'Karnataka'

--UC7 Size of Address Book

select Count(*) as Size_Of_Address_Book from Address_Book

--UC8 retrive data 

select * from Address_Book where state = 'Karnataka' Order By FirstName

--UC9 Ability to identify each Address Book with name and Type

alter table Address_Book add type varchar(15)
update Address_Book set type = 'Profession' where FirstName='Mansi'
update Address_Book set type = 'Friend' where FirstName='Parnika'
update Address_Book set type = 'Family' where FirstName='Sunil'
update Address_Book set type = 'Friend' where FirstName='Bindhu'
update Address_Book set type = 'Profession' where FirstName='Anamika'

select * from Address_Book;

--UC10 Ability to get number of contact persons i.e. count by type

select Count(FirstName) as type from Address_Book where FirstName = 'Mansi' or FirstName = 'Anamika' or type = 'Profession'
select Count(FirstName) as type from Address_Book where FirstName = 'Parnika' or FirstName = 'Bindhu' or type = 'Friend'
select Count(FirstName) as type from Address_Book where FirstName = 'Sunil' or type = 'Family'

--UC11 Ability to add person to both Friend and Family

INSERT INTO Address_Book(FirstName,LastName,Address,City,State,ZipCode,PhoneNumber,EMailId,type) VALUES ('Nitin','Rathod','Navi','Mumbai','Maharashtra',400011,'9632105478','nint@yahoo.com','Family');
INSERT INTO Address_Book(FirstName,LastName,Address,City,State,ZipCode,PhoneNumber,EMailId,type) VALUES ('Megha','Shree','VijayNagar','Bangalore','Karnataka',230011,'9872105478','meg@yahoo.com','Friend');

--UC13 Ensure all retrieve queries done especially in UC 6, UC 7, UC 8 and UC 10 are working with new table structure

select count('contacts.firstname') from 