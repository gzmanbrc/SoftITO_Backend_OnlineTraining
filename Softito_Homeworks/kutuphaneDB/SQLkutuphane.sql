--create database Kutuphane

--use Kutuphane


create table Uye(
Id int not null,
ad varchar(35) not null,
soyad varchar(35) not null,
dogum_yili int,
telefon varchar(10) ,
primary key(Id)
);

create table Kategori(
Id int not null,
tur varchar(35) not null,
primary key(Id)
);

create table Yazar(
Id int not null,
ad varchar(35) not null,
soyad varchar(35) not null,
dogum_yili int,
uyruk varchar(10) ,
primary key(Id)
);

create table Kitap(
Id int not null,
isim varchar(35) not null,
yazarId int ,
yil int,
kategoriId int,
stok int,
primary key(Id),
foreign key (kategoriId) references Kategori(Id),
foreign key (yazarId) references Yazar(Id),
);

create table Odunc_kitap(
UyeId int not null,
KitapId int not null,
alisDate Date, 
iadeDate Date,
foreign key (uyeId) references Uye(Id),
foreign key (kitapId) references kitap(Id)
);

create table Personel(
Id int not null,
isim varchar(35) not null,
gorev varchar(20) not null,
primary key(Id)
);