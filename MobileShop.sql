create database MobileShop

use MobileShop

create table Sanpham 
(
	idSP nvarchar (30) primary key,
	tenSP nvarchar (50),
	gia decimal,
	hangSX nvarchar (50)
)
go
insert into Sanpham(idSP, tenSP, gia, hangSX)
values
	('SP01',N'samsung A01',1000000,N'SS01'),
	('SP02',N'samsung A02',2000000,N'SS02'),
	('SP03',N'samsung A03',3000000,N'SS03')
	go

create table Khachhang
(
	idKH nvarchar (30) primary key,
	tenKH nvarchar (50),
	diachi nvarchar (50),
	sdt int
)
go
insert into Khachhang(idKH, tenKH, diachi, sdt)
values
	('KH01',N'aaaaa',N'Ha Nam',0123456789),
	('KH02',N'bbbbb',N'Ha Noi',0123456799),
	('KH03',N'ccccc',N'Nam Dinh',0123456999)
	go

create table Donhang
( idDH nvarchar (30) primary key,
  idSP nvarchar(30) foreign key references Sanpham(idSP),
  idKH nvarchar (30) foreign key references Khachhang(idKH),
  Soluong int,
  ngaymua date
)
go
insert into Donhang(idDH, idSP, idKH, Soluong, ngaymua)
values
	('DH01',N'SP01',N'KH01',1,'11-18-2024'),
	('DH02',N'SP02',N'KH02',2,'11-19-2024'),
	('DH03',N'SP03',N'KH03',3,'11-20-2024')
	go

create table Nguoidung
(
	idND nvarchar (30) primary key,
	tendangnhap nvarchar (50) NOT NULL,
	matkhau nvarchar (50) NOT NULL,
)
go
insert into Nguoidung(idND, tendangnhap, matkhau)
values
	('ND01',N'ddddd',N'142854'),
	('ND02',N'eeeee',N'142855'),
	('ND03',N'fffff',N'142856')
	go