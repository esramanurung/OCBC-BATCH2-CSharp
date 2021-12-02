create database bank;

use bank;

-- SOAL NOMOR 1

create table customers(
	customerNumber int not null identity primary key,
	customerName varchar(50) not null,
	contactLastName varchar(50) not null,
	contactFirstName varchar(50) not null,
	phone varchar(20) not null,
	addressLine1 varchar (100) not null,
	addressLine2 varchar (100) not null,
	city varchar (50) not null,
	state varchar (50) not null,
	postalCode int  not null,
	country varchar (50) not null,
	salesRepEmployeeNumber int  not null,
	creditLimit decimal not null,
);
--update
alter table customers alter column country varchar(50) not null
--menghapus
alter table customers drop column country  
--menambah
alter table customers add country varchar(50) not null

-- Menghapus tabel customers
drop table customers;

--Menghapus data
delete from customers 

truncate table customers;
set identity_insert dbo.customers on;

insert into customers(customerNumber,customerName,contactLastName,contactFirstName,phone,addressLine1,addressLine2,city,state,
postalCode,country,salesRepEmployeeNumber,creditLimit)
values
(1,'Abrar Fadhlan',' Fadhlan','Devi','081232132137','Jl. Ahmad Yani','Jl. Stasiun Wonokromo','Gayungan','Surabaya Selatan', 20,'Indonesia', 2, 150000),
(2,'Pramudya Abrar','Pramudya','Abrar','08213123224','Jl. Mastrip','Jl. Gunungsari','KarangPilang','Jawa Barat', 20312,'Indonesia', 3, 350000),
(3,'Alvan Zafar','Alvan','Zafar','089253523622','Jl. Joyoboyo','Jl. Menganti','Dukuh Pakis','Jawa Timur', 20313,'Indonesia', 3, 650000),
(4,'Alvan Pramana','Alvan ','Pramana','081525362362','Jl. Hayam Wuruk','Jl. Gajah Mada','Wiyung','Sumatera Barat', 20314,'Indonesia', 7, 450000),
(5,'Chairil Atha','Chairil','Atha','08253636373','Jl. Adityawarman','	Jl. Ciliwung','Jambangan','Surabaya Selatan', 20311,'Indonesia', 4, 950000),
(6,'Rizky Atha','Rizky','Atha','089635435463','Jl. Kutai','Jl. Indragiri','Sawahan','Surabaya Selatan', 20311,'Indonesia', 6, 250000),
(7,'Daffa Axel','Daffa','Axel','085232732737','Jl. Pulo Wonokromo','Jl. Pagesangan','Bandung','Jawa Barat', 20317,'Indonesia', 4, 650000),
(8,'Varen Azka','Varen','Azka','081734343628','Jl. Jambangan','Jl. Karah','Polonia','Medan', 20318,'Indonesia', 7, 250000),
(9,'Fakhri Azka','Fakhri','Azka','081229936372','Jl. Karah Agung','Jl. Karah Agung','Bandung','Jawa Barat', 20312,'Indonesia', 6, 150000),
(10,'Barraq Isyraf ','Barraq','Isyraf','081666373838','Jl. Gayung Kebonsari','	Jl. Gayungan PTT','Bandung','Jawa Barat', 20312,'Indonesia', 10, 550000);


select * from customers


-- SOAL  NOMOR 2

create table products(
	productCode char (20) primary key not null,
	productName varchar (100) not null,
	productLine int not null,
	productScale int not null,
	productVendor varchar (50) not null,
	productDescription varchar (250) not null,
	quantityInStock int not null,
	buyPrice money not null,
	MSRP money not null,
	constraint fk_productLine foreign key (productLine) references productlines (productLine)
);
 drop table products
insert products values
('A001','Innova', 1, 2,'Toyota','Mobil', 12, 50000000,45000000),
('A002','Vellfire', 2, 5,'Toyota','Mobil', 5, 60000000,55000000),
('A003','voxy', 3, 3,'Toyota','Mobil', 4, 700000000,65000000),
('A004','Sienta', 4, 6,'Toyota','Mobil', 12, 80000000,70000000),
('A005','Alphard', 5, 2,'Toyota','Mobil', 89, 90000000,80000000),
('A006','Calya', 6, 8,'Toyota','Mobil', 34, 10000000,9500000),
('A007','Avanza', 7, 9,'Toyota','Mobil', 55, 11000000,10000000),
('A008','Fortuner', 8, 5,'Toyota','Mobil', 19, 12000000,11000000),
('A009','Land Cruiser', 9, 3,'Toyota','Mobil',45, 13000000,12500000),
('A010','C-HR', 10, 5,'Toyota','Mobil', 19, 14000000,13000000);

alter table products add constraint fk_product_line foreign key (productLine) references productlines (productLine)
alter table alter column productVendo varchar(50) not null
--Menghapus semua data
delete from products


select * from products
select * from productlines
--SOAL NOMOR 3

create table productlines(
	productLine int primary key not null,
	textDescription varchar (150) not null,
	htmlDescription varchar (100) not null,
	[image] varchar (255)
);

alter table productlines alter column image varchar (255)

insert productlines values
(1,'Ivory Snow','Page1.html','image1.png'),
(2,'Dreft','Page2.html','image2.png'),
(3,'Tide','Page3.html','image3.png'),
(4,'Cheer','Page4.html','image4.png'),
(5,'Dash','Page5.html','image5.png'),
(6,'Bold','Page6.html','image6.png'),
(7,'Gain','Page7.html','image7.png'),
(8,'Era','Page8.html','image8.png'),
(9,'Dash','Page9.html','image9.png'),
(10,'Tide','Page10.html','image10.png');


select * from productlines
-- SOAL NOMOR 4
create table orders(
	orderNumber int primary key not null,
	orderDate date not null,
	requiredDate date not null,
	shippedDate date not null,
	status varchar (50) not null,
	comments varchar (100) not null,
	customerNumber int not null
	constraint fk_customer_number foreign key (customerNumber) references customers (customerNumber),
);
alter table orders alter column status varchar (50)

insert orders values
(1,'2019-01-01','2019-01-05','2019-01-03','Delivered','Good',11),
(2,'2019-01-02','2019-01-06','2019-01-04','Sorting','Good',12),
(3,'2019-01-03','2019-01-07','2019-01-05','Delivered','Good',13),
(4,'2019-01-04','2019-01-08','2019-01-06','Delivered','Good',14),
(5,'2019-01-05','2019-01-09','2019-01-07','Delivered','Good',15),
(6,'2019-01-06','2019-01-10','2019-01-08','Delivered','Good',16),
(7,'2019-01-07','2019-01-11','2019-01-09','Sorting','Good',17),
(8,'2020-06-08','2019-01-12','2019-01-10','Sorting','Good',18),
(9,'2019-01-09','2019-01-13','2019-01-11','Delivered','Good',19),
(10,'2019-01-10','2019-01-14','2019-01-12','Sorting','Good',20);


select * from orders
-- SOAL NOMOR 5
create table orderdetails(
	orderNumber int not null,
	productCode char(20) not null,
	quantityOrdered int not null,
	priceEach money not null,
	orderLineNumber int not null
	constraint fk_order_number foreign key (orderNumber) references orders (orderNumber),
	constraint fk_product_code foreign key (productCode) references products (productCode)
)

insert orderdetails values
(1,'A001',10,250.000,23),
(2,'A002',15,154.000,9),
(3,'A003',57,250.000,21),
(4,'A004',38,157.000,6),
(5,'A005',18,170.000,12),
(6,'A006',32,350.000,17),
(7,'A007',42,259.000,22),
(8,'A008',53,557.000,4),
(9,'A009',23,650.000,5),
(10,'A010',24,350.000,2);

select * from orderdetails
--SOAL NOMOR 6

create table payments(
	customerNumber int  not null,
	checkNumber int primary key not null,
	paymentDate date not null,
	amount int not null

	constraint fk_payment_customer_number foreign key (customerNumber) references customers (customerNumber) ,
);

insert payments values
(1,1,'2019-02-01',100000),
(2,2,'2019-02-02',110000),
(3,3,'2019-02-03',120000),
(4,4,'2019-02-04',130000),
(5,5,'2019-02-05',140000),
(6,6,'2019-02-06',150000),
(7,7,'2019-02-07',160000),
(8,8,'2019-02-08',170000),
(9,9,'2019-02-09',180000),
(10,10,'2019-02-10',190000);

select * from payments

--SOAL NOMOR 7--
create table employees(
	employeeNumber int primary key not null,
	lastName varchar (50) not null,
	firstName varchar(50) not null,
	extension varchar(50) not null,
	email varchar(50) not null,
	officeCode char(50) not null,
	reportsTo int  null,
	jobTitle varchar(50) null

	constraint fk_office_code foreign key (officeCode) references offices (officeCode),
	constraint fk_reports_to foreign key (reportsTo) references employees (employeeNumber)
);

alter table employees alter column reportsTo int null

select * from dbo.offices

insert employees values
(1,'Gibran','Esfand','Sarjana','gibran@gmail.com','A01', 5,'Manager'),
(2,'Esfand','Kafi','Magister','esfand@gmail.com','A02', 10,'Staff'),
(3,'Rafa','Fathan','Magister' ,'rafa@gmail.com','A03', 1,'Branch Manager'),
(4,'Faiz','Nawfal ','Magister','faiz@gmail.com','A04', 9,'HRD'),
(5,'Dzuhairi','Ibrahim','Magister','dzuhairi@gmail.com','A05', null,'Head Manager'),
(6,'Zuhair','Fahri','Magister','zuhair@gmail.com','A06', 1,'IT Head'),
(7,'Haris','Raka','Sarjana','haris@gmail.com','A07', 6,'IT Support'),
(8,'Bobby','Kaivan','Diploma','bobby@gmail.com','A08', 10,'Staff'),
(9,'Rizky','Azka','Sarjana','rizky@gmail.com','A09', 1,'Head HRD'),
(10,'Jefri','Karim','Magister','jefri@gmail.com','A10', 1,'Head Staff');

select * from employees


--SOAL NOMOR 8--
create table offices(
	officeCode char(50) primary key not null,
	city varchar (50) not null,
	phone varchar (20) not null,
	addressLine1 varchar (50) not null,
	addressLine2 varchar (50) not null,
	[state] varchar (50) not null,
	postalCode int not null,
	territory varchar (50) not null,

);

insert offices values
('A01','Jakarta','082246391','Jl. Ahmad Yani','Jl. Stasiun Wonokromo','Gayungan', 20141,'Jakarta'),
('A02','Bandung','082246392','Jl. Mastrip','Jl. Gunungsari','KarangPilang', 20142,'Jakarta'),
('A03','Medan','082246393','Jl. Joyoboyo','Jl. Menganti','Dukuh Pakis', 20143,'Jakarta'),
('A04','Bandung','082246394','Jl. Hayam Wuruk','Jl. Gajah Mada','Wiyung',20144, 'Jakarta'),
('A05','Medan','082246395','Jl. Adityawarman','Jl. Ciliwung','Jambangan',20145,'Jakarta'),
('A06','Riau','082246396','Jl. Kutai','Jl. Indragiri','Sawahan', 20146, 'Jakarta'),
('A07','Kalimantan','082246397','Jl. Pulo Wonokromo','Jl.Pagesangan','Sawahan',20147,'Jakarta'),
('A08','Jakarta','082246398','Jl.Opak','Jl.Waru','Jambang',20148,'Jakarta'),
('A09','Bandung','082246399','Jl. Jambangan','Jl. Karah','Polonia',20149,'Jakarta'),
('A10','Pontianak','082246310','Jl. Karah Agung','Jl. Karah Agung','Polonia',201410,'Jakarta');

 delete from offices where officeCode like 'SAR%'

 select * from offices
