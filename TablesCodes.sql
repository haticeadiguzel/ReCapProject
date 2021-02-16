Create table Cars
(
	CarId int primary key identity (1,1),
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice decimal,
	Descriptions nvarchar(50),
	foreign key (BrandId) references Colors(ColorId),
	foreign key (ColorId) references Brands(BrandId),
)

create table Colors
(
	ColorId int primary key identity (1,1),
	ColorName nvarchar(10)
)

create table Brands
(
	BrandId int primary key identity (1,1),
	BrandName nvarchar(10)
)

Insert into Cars(BrandId, ColorId, ModelYear,DailyPrice, Descriptions)
values
	('1','4','2002','100','M3'),
	('2','2','2006','200','A180'),
	('3','3','2010','400','A1'),
	('4','1','2019','800','S')

insert into Brands(BrandName)
values
	('BMW'),
	('Mercedes'),
	('Audi'),
	('Tesla')

insert into Colors(ColorName)
values
	('Red'),
	('Black'),
	('Grey'),
	('white')

Select * from Cars
select * from Brands
select * from Colors